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
					if (ComPort.IsOpen) ComPort.Close();
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
		public static class ComPortCommands
		{
			public static byte[] Continuous_transfer_of_value_by_mask = { 0x2b, 0x03 }; // '+', PMASK 0x03
		}
		public static VesData GetDataFromComport()
        {
			if ((DateTime.Now - Data_.Timestamp).TotalMilliseconds <= 1000) return Data_;
			if (ComPort != null)
			{
				SendCommandToComport(ComPortCommands.Continuous_transfer_of_value_by_mask);
				/*byte[] arr = { 0xff, 0x7f, 0x20, 0x56, 0x10, 0x00, 0x09, 0x03 };
				ComPort.Write(arr, 0, 8);
				byte[] arr2 = { 0xff, 0x7f, 0x20, 0x2e, 0x7f, 0xf1, 0x03 };*/
				//ComPort.Write(arr2, 0, 7);

				return Data_;
			}
			return null;
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
			byte[] COM = ETHCheck(cmd); // cmd
			byte[] DATA = ETHCheck(data); // DATA
			byte[] CRC = ETHCheck(CalculateCRC(SOH, ADDR_TO, ADDR_FROM, COM, DATA));
			byte[] ETX = { 0x03 };
			
		}

		public static byte[] ETHCheck(byte b)
		{
			return ETHCheck(new byte[]{ b });
		}
		public static byte[] ETHCheck(byte[] arr)
		{
			List<byte> old_arr = new List<byte>(arr);
			List<byte> new_arr = new List<byte>();
			foreach(byte b in old_arr)
			{
				byte[] add = { };
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
			{
				crc = Convert.ToByte(crc ^ arr[i]);
			}
			return crc;
		}

		private static void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
			if (ComPort != null)
			{
				string data = ComPort.ReadExisting();
				byte[] arr = Encoding.ASCII.GetBytes(data);

			}
        }
    }
}
