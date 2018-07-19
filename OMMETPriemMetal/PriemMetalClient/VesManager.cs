using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using DevNet;

namespace PriemMetalClient
{
	public enum VesWorkMethod
	{
		DRIVER, COMPORT//, FILE
	}
	public class VesData
	{
		public double Value = -1;
		public DateTime Timestamp = DateTime.MinValue;
	}
	public class VesDataReport
	{
		public double AverageValue = -1;
		public int ReadoutCount = 0;
		public TimeSpan TimeRange = TimeSpan.Zero;
		public double Deviation = 0;
		public override string ToString() => "[V:" + AverageValue.ToString() + ",D:" + Deviation.ToString() + ",C:" + ReadoutCount.ToString() + "]";
	}
	public class VesDataManager
	{
		private Queue<VesData> DataFIFO = new Queue<VesData>(100);
		private bool LockThread = false;
		public VesData AddData(VesData data)
		{
			if (LockThread)
			{
				DateTime dt = DateTime.Now;

				while (LockThread)
				{
					System.Threading.Thread.Sleep(100);
					if ((dt - DateTime.Now).TotalSeconds >= 10)
						return data;
				};
			}
			if (DataFIFO.Count >= 100)
				DataFIFO.Dequeue();
			DataFIFO.Enqueue(data);
			return data;
		}
		public VesDataReport Report(TimeSpan TimeRange)
		{
			VesDataReport report = new VesDataReport();
			report.TimeRange = TimeRange;
			DateTime now = DateTime.Now;
			double sumAll = 0;
			int count = 0;
			double maxValue = double.MinValue;
			double minValue = double.MaxValue;
			LockThread = true;
			Queue<VesData> fifo_backup = new Queue<VesData>(DataFIFO);
			LockThread = false;
			var rnd = new Random();
			foreach (VesData data in fifo_backup)
			{
				//data.Value = rnd.Next(1000, 1100) / 10;
				if ((now - data.Timestamp) <= TimeRange)
				{
					sumAll += data.Value;
					count++;
					maxValue = Math.Max(maxValue, data.Value);
					minValue = Math.Min(minValue, data.Value);
				}
			}
			if (count > 0) report.AverageValue = sumAll / count;
			report.Deviation = (maxValue - minValue) / 2;
			report.ReadoutCount = count;
			return report;
		}
	}
	public static class VesManager
	{
		private static System.Timers.Timer Timer = null;
		private static VesWorkMethod VesWorkMethod_ = VesWorkMethod.COMPORT;
		public static VesWorkMethod VesWorkMethod { get => VesWorkMethod_; set { SetWorkMethod(value); } }
		public static VesDataManager VesDataManager = new VesDataManager();
		public static VesDataReport Report => ReportCustomTimeRange(new TimeSpan(0, 0, 10));
		public static VesDataReport ReportCustomTimeRange(TimeSpan TimeRange) => VesDataManager.Report(TimeRange);

		public static void SetWorkMethod(VesWorkMethod method, bool force = false)
		{
			if (!force)
				if (VesWorkMethod_ == method) return;
			switch (VesWorkMethod_)
			{
				case VesWorkMethod.COMPORT: CloseComport(); break;
				case VesWorkMethod.DRIVER: CloseDevNet(); break;
			}
			switch (method)
			{
				case VesWorkMethod.COMPORT: ReopenComport(); break;
				case VesWorkMethod.DRIVER: ReopenDevNet(); break;
			}
			VesWorkMethod_ = method;

		}
		/*public static VesDataReport GetData(VesWorkMethod VesWorkMethod)
		{
			if (ConfigManager.configParams.VesWorkMethod == VesWorkMethod.DRIVER)
			{
				return GetDataFromDriver();
			}
			if (ConfigManager.configParams.VesWorkMethod == VesWorkMethod.COMPORT)
			{
				return GetDataFromComport();
            }
            return null;
		}*/
		/*public static VesData GetDataFromDriver()
		{
			if (DevNet == null)
			{
				try
				{
					DevNet = Activator.CreateInstance(Type.GetTypeFromProgID("DevNet.Drv"), false);
				}
				catch
				{
					DevNet = null;
					Data_ = null;
					return null;
				}
			}
			try
			{
				double ves = 0;
				byte ErrState, Flags0, Flags1, DFlags, DState;
				DevNet.GetWeight(1, 0, out ves, out ErrState, out Flags0, out Flags1, out DFlags, out DState);
				Data_.Value = ves;
				Data_.Timestamp = DateTime.Now;

				return Data_;
			}
			catch
			{
				DevNet = null;
				Data_ = null;
				return null;
			}
		}*/
		#region DEVNET
		private static dynamic DevNet = null;
		public static bool ReopenDevNet()
		{
			CloseDevNet();
			try
			{
				DevNet = Activator.CreateInstance(Type.GetTypeFromProgID("DevNet.Drv"), false);
				Timer = new System.Timers.Timer(100);
				Timer.Elapsed += Timer_Elapsed;
				Timer.Start();
				return true;
			}
			catch
			{
				MessageBox.Show("ERROR: DRIVER MODE FAILED");
				CloseDevNet();
				return false;
			}
		}


		public static void CloseDevNet()
		{
			if (Timer != null)
			{
				Timer.Elapsed -= Timer_Elapsed;
				Timer.Stop();
				Timer = null;
			}
			DevNet = null;
		}
		#endregion
		#region COMPORT
		private static SerialPort ComPort_ = null;
		public static SerialPort ComPort { get { return GetComport(); } }
		public static SerialPort GetComport()
		{
			if (CheckComport()) return ComPort_;
			else if (ReopenComport()) return ComPort_;
			else return null;
		}
		public static bool CheckComport()
		{
			if (ComPort_ != null)
				if (ComPort_.PortName == ConfigManager.configParams.ComPort)
					if (ComPort_.BaudRate == ConfigManager.configParams.BaudRate)
						if (ComPort_.IsOpen)
							return true;
			return false;
		}
		public static bool ReopenComport()
		{
			CloseComport();
			try
			{
				if (ConfigManager.configParams.ComPort == "-") return false;
				ComPort_ = new SerialPort(ConfigManager.configParams.ComPort,
					ConfigManager.configParams.BaudRate, Parity.None, 8, StopBits.One);
				//ComPort_.DataReceived += ComPort_DataReceived;
				ComPort_.Open();
				SendCommandToComport(ComPortCommands.Continuous_transfer_of_value_by_mask_mode);
				Timer = new System.Timers.Timer(100);
				Timer.Elapsed += Timer_Elapsed;
				Timer.Start();
				return true;
			} catch
			{
				MessageBox.Show("ERROR: COMPORT MODE FAILED");
				CloseComport();
				return false;
			}
		}
		public static void CloseComport()
		{
			if (Timer != null)
			{
				Timer.Elapsed -= Timer_Elapsed;
				Timer.Stop();
				Timer = null;
			}
			if (ComPort_ != null)
			{
				try
				{
					ComPort_.DataReceived -= ComPort_DataReceived;
					if (ComPort_.IsOpen) ComPort_.Close();
					ComPort_ = null;
				}
				catch
				{
					ComPort_ = null;
				}
			}

		}
		private static List<byte> DataPacket = null;
		private static void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			/*var com = ComPort;
			if (com != null)
			{
				while (com.BytesToRead > 0)
				{
					byte b = (byte)com.ReadByte();
					if (b == 0xff)
						DataPacket = new List<byte>();
					if (DataPacket != null)
					{
						if (DataPacket.Count >= 128)
						{
							DataPacket = null;
						}
						else
						{
							DataPacket.Add(b);
							if (b == 0x03)
							{
								if (DataPacket[0] == 0xff && DataPacket[DataPacket.Count - 1] == 0x03)
								{
									ParseData(DataPacket.ToArray());
									DataPacket = null;
								}
							}
						}
					}
				}
				//string data = com.ReadExisting();
				//byte[] arr = Encoding.ASCII.GetBytes(data);
				// 0xFF, 0x20, 0x22, 0x2A, 0x10, 0xFC, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
				// 0xFF, 0x20, 0x22, 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
				//ParseData(arr);
			}*/
		}
		public static void ParseData(byte[] arr)
		{
			arr = DLERemove(arr);
			// [0xFF,] 0x20, 0x22, 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
			//List<byte> arr = new List<byte>(arr);
			int i = 0;
			if (arr[i] == 0xff)
			{
				i++;
				// [0x20,] [0x22,] 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
				byte to = arr[i];
				byte from = arr[i + 1];
				i += 2;
				// [0x2A,] 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
				byte com = arr[i];
				i++;
				// 3.9.10.	0x2a ‘+’ Постоянная передача значений по маске
				// ПРИМЕЧАНИЕ 2: Пакет от прибора в режиме постоянной передачи имеет код команды ‘*’ (0x2A)
				if (com == 0x2a)
				{
					// [0x03,] 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
					//byte pmask = a[i];
					i++;
					// [0x00, 0x00, 0xD1, 0x0F,] 0x00, 0x00, 0x3F, 0x03
					//byte[] acp_code = { a[i], a[i + 1], a[i + 2], a[i + 3] };
					//Array.Reverse(acp_code);
					//ulong acp_code_ulong = BitConverter.ToUInt32(acp_code, 0);
					i += 4;
					// [0x00, 0x00,] 0x3F, 0x03
					byte[] brutto = { arr[i], arr[i + 1] };
					Array.Reverse(brutto);
					int brutto_int = BitConverter.ToInt16(brutto, 0);
					VesData v = new VesData();
					v.Timestamp = DateTime.Now;
					v.Value = (double)brutto_int / 100;
					v.Value = Math.Round(v.Value, 2);
					VesDataManager.AddData(v);
					//i += 2;
					// [0x3F,] [0x03]
					//byte crc = a[i];
					//byte etx = a[i+1];
					//i += 2;
				}
			}
		}
		#endregion
		private static void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			if (VesWorkMethod == VesWorkMethod.DRIVER)
			{
				if (DevNet != null)
				{
					try
					{
						VesData data = new VesData();
						double ves = 0;
						byte ErrState, Flags0, Flags1, DFlags, DState;
						DevNet.GetWeight(1, 0, out ves, out ErrState, out Flags0, out Flags1, out DFlags, out DState);
						data.Value = ves;
						data.Timestamp = DateTime.Now;
						VesDataManager.AddData(data);
					}
					catch
					{
						ReopenDevNet();
					}
				}
			}
			else if (VesWorkMethod == VesWorkMethod.COMPORT)
			{
				var com = ComPort;
				if (com != null)
				{
					while (com.BytesToRead > 0)
					{
						byte b = (byte)com.ReadByte();
						if (b == 0xff)
							DataPacket = new List<byte>();
						if (DataPacket != null)
						{
							if (DataPacket.Count >= 128)
							{
								DataPacket = null;
							}
							else
							{
								DataPacket.Add(b);
								if (b == 0x03)
								{
									if (DataPacket[0] == 0xff && DataPacket[DataPacket.Count - 1] == 0x03)
									{
										ParseData(DataPacket.ToArray());
										DataPacket = null;
									}
								}
							}
						}
					}
					//string data = com.ReadExisting();
					//byte[] arr = Encoding.ASCII.GetBytes(data);
					// 0xFF, 0x20, 0x22, 0x2A, 0x10, 0xFC, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
					// 0xFF, 0x20, 0x22, 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
					//ParseData(arr);
				}
			}
		}

		/*public static VesData GetDataFromComport()
        {
			if ((DateTime.Now - Data_.Timestamp).TotalMilliseconds <= 1000) return Data_;
			if (ComPort != null)
			{
				SendCommandToComport(ComPortCommands.Continuous_transfer_of_value_by_mask_mode);
				//byte[] arr = { 0xff, 0x7f, 0x20, 0x56, 0x10, 0x00, 0x09, 0x03 };
				//ComPort.Write(arr, 0, 8);
				//byte[] arr2 = { 0xff, 0x7f, 0x20, 0x2e, 0x7f, 0xf1, 0x03 };
				//ComPort.Write(arr2, 0, 7);

				return Data_;
			}
			return null;
        }*/

		public static class ComPortCommands
		{
			public static byte[] Continuous_transfer_of_value_by_mask_mode = { 0x2b, 0x03 }; // '+', PMASK 0x03
		}
		public static void SendCommandToComport(byte[] cmd)
		{
			SendCommandToComport(cmd, new byte[] { });
		}
		public static void SendCommandToComport(byte[] cmd, byte[] data)
		{
			List<byte> arr = new List<byte>();
			byte[] SOH = { 0xff }; //SOH
			byte[] ADDR_TO = { 0x7f }; //ADDR_TO = 0x20(32) + 0x5f(95) = 0x7f(127)
			/* ЛЮБОЙ (как индивидуальный, требуется ответ от SLAVE-устройства любом случае).
			Адрес 95 позволяет вести обмен в соединении “точка-точка” с любым SLAVE-устройством, 
			не зная его адреса индивидуального адреса, однако если в сети несколько SLAVE-устройств, 
			возникнет конфликт на шине.*/
			byte[] ADDR_FROM = { 0x20 }; //ADDR_FROM = 0x20(32) (MASTER)
			byte[] COM = cmd; // cmd
			byte[] DATA = data; // DATA
			byte[] CRC = new byte[] { CalculateCRC(SOH, ADDR_TO, ADDR_FROM, COM, DATA) };
			byte[] ETX = { 0x03 };
			arr.AddRange(SOH);
			arr.AddRange(ADDR_TO);
			arr.AddRange(ADDR_FROM);
			arr.AddRange(DLECheck(COM));
			arr.AddRange(DLECheck(DATA));
			arr.AddRange(DLECheck(CRC));
			arr.AddRange(ETX);
			var com = ComPort;
			if (com != null)
			{
				var barr = arr.ToArray();
				com.Write(barr, 0, barr.Length);
			}
		}

		public static byte[] DLECheck(byte b)
		{
			return DLECheck(new byte[]{ b });
		}
		public static byte[] DLECheck(byte[] arr)
		{
			List<byte> old_arr = new List<byte>(arr);
			List<byte> new_arr = new List<byte>();
			foreach(byte b in old_arr)
			{
				if (b == 0xff )
					new_arr.AddRange(new byte[] { 0x10, 0x00 });
				else if (b == 0x03)
					new_arr.AddRange(new byte[] { 0x10, 0xfc });
				else if (b == 0x10)
					new_arr.AddRange(new byte[] { 0x10, 0xef });
				else new_arr.Add(b);
			}
			return new_arr.ToArray();
		}

		public static byte[] DLERemove(byte[] arr)
		{
			List<byte> old_arr = new List<byte>(arr);
			List<byte> new_arr = new List<byte>();
			for (int i = 0; i < arr.Length; i++)
			{
				byte b = arr[i];
				if (b == 0x10)
				{
					if (i + 1 >= arr.Length)
					{
						new_arr.Add(b);
						break;
					}
					byte b2 = arr[i + 1];
					if (b2 == 0x00)
					{
						new_arr.Add(0xff);
						i++;
						continue;
					}
					else if (b2 == 0xfc)
					{
						new_arr.Add(0x03);
						i++;
						continue;
					}
					else if (b2 == 0xef)
					{
						new_arr.Add(0x10);
						i++;
						continue;
					}
					else new_arr.Add(b);
				} else
				{
					new_arr.Add(b);
				}
			}
			return new_arr.ToArray();

		}

		public static byte CalculateCRC(byte[] SOH, byte[] ADDR_TO, byte[] ADDR_FROM, byte[] COM, byte[] DATA)
		{
			byte crc = CalculateCRC(SOH, 0);
			crc = CalculateCRC(ADDR_TO, crc);
			crc = CalculateCRC(ADDR_FROM, crc);
			crc = CalculateCRC(COM, crc);
			crc = CalculateCRC(DATA, crc);
			return crc;
		}
		public static byte CalculateCRC(byte[] arr, byte crc)
		{
			for(int i = 0; i < arr.Length; i++)
				crc = Convert.ToByte(crc ^ arr[i]);
			return crc;
		}




    }
}
