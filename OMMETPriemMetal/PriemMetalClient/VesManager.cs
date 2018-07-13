using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using DevNet;

namespace PriemMetalClient
{
	public enum VesWorkMethod
	{
		DRIVER, COMPORT//, FILE
	}
	public class VesData
	{
		public bool Stable = false;
		public double Value = -1;
		public DateTime Timestamp = DateTime.MinValue;
	}
	public static class VesManager
	{
		private static dynamic DevNet = null;
		private static SerialPort ComPort_ = null;
		public static SerialPort ComPort { get {return GetComport(); } }
		private static VesData Data_ = new VesData();
		public static VesData Data { get { return GetData(); } }
		public static VesData GetData()
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
		}
		public static VesData GetDataFromDriver()
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
				Data_.Stable = true;
				Data_.Timestamp = DateTime.Now;

				return Data_;
			}
			catch
			{
				DevNet = null;
				Data_ = null;
				return null;
			}
		}
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
			if (ComPort_ != null)
			{
				try
				{
					if (ComPort_.IsOpen) ComPort_.Close();
					ComPort_ = null;
				} catch
				{
					ComPort_ = null;
				}
			}
			try
			{
				ComPort_ = new SerialPort(ConfigManager.configParams.ComPort,
					ConfigManager.configParams.BaudRate, Parity.None, 8, StopBits.One);
				ComPort_.DataReceived += ComPort_DataReceived;
				ComPort_.Open();
				return true;
			} catch
			{
				ComPort_ = null;
				return false;
			}
		}
		public static VesData GetDataFromComport()
        {
			if ((DateTime.Now - Data_.Timestamp).TotalMilliseconds <= 1000) return Data_;
			if (ComPort != null)
			{
				SendCommandToComport(ComPortCommands.Continuous_transfer_of_value_by_mask_mode);
				/*byte[] arr = { 0xff, 0x7f, 0x20, 0x56, 0x10, 0x00, 0x09, 0x03 };
				ComPort.Write(arr, 0, 8);
				byte[] arr2 = { 0xff, 0x7f, 0x20, 0x2e, 0x7f, 0xf1, 0x03 };*/
				//ComPort.Write(arr2, 0, 7);

				return Data_;
			}
			return null;
        }

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

		public static void ParseData(byte[] arr)
		{
			// 0xFF, 0x20, 0x22, 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
			List<byte> a = new List<byte>(arr);
			int i = 0;
			if (a[i] == 0xff)
			{
				i++;
				// 0x20, 0x22, 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
				byte to = a[i];
				byte from = a[i+1];
				i += 2;
				// 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
				byte com = a[i];
				i++;
				// 3.9.10.	0x2a ‘+’ Постоянная передача значений по маске
				// ПРИМЕЧАНИЕ 2: Пакет от прибора в режиме постоянной передачи имеет код команды ‘*’ (0x2A)
				if (com == 0x2a)
				{
					// 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
					byte pmask = a[i];
					i++;
					// 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
					byte[] acp_code = { a[i], a[i + 1], a[i + 2], a[i + 3] };
					Array.Reverse(acp_code);
					ulong acp_code_ulong = BitConverter.ToUInt32(acp_code, 0);
					i += 4;
					// 0x00, 0x00, 0x3F, 0x03
					byte[] brutto = { a[i], a[i + 1] };
					Array.Reverse(brutto);
					int brutto_int = BitConverter.ToInt16(brutto, 0);
					//i += 2;
					// 0x3F, 0x03
					//byte crc = a[i];
					//byte etx = a[i+1];
					//i += 2;
				}
			}
		}

		private static void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
			if (ComPort != null)
			{
				string data = ComPort.ReadExisting();
				byte[] arr = Encoding.ASCII.GetBytes(data);
				// 0xFF, 0x20, 0x22, 0x2A, 0x10, 0xFC, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
				arr = DLERemove(arr);
				// 0xFF, 0x20, 0x22, 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03
				ParseData(arr);
			}
        }
    }
}
