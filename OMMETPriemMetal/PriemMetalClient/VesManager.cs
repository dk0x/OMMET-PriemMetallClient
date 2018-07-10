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
		DRIVER, COMPORT, FILE
	}
	public class VesData
	{
		public bool Stable = false;
		public double Value = 0;
	}
	public static class VesManager
	{
		public static VesWorkMethod VesWorkMethod = VesWorkMethod.COMPORT;
		private static dynamic DevNet = null;
		public static VesData Data { get { return GetData(); } }
		private static VesData data = new VesData();
		public static VesData GetData()
		{
			if (VesWorkMethod == VesWorkMethod.DRIVER)
			{
				data = GetDataFromDriver();
				if (data != null) return data;
				VesWorkMethod = VesWorkMethod.COMPORT;
			}
			if (VesWorkMethod == VesWorkMethod.COMPORT)
			{
                data = GetDataFromComport();
                if (data != null) return data;
            }
            return data;
		}
		public static VesData GetDataFromDriver()
		{
			VesData d = new VesData();
			if (DevNet == null)
			{
				try
				{
					DevNet = Activator.CreateInstance(Type.GetTypeFromProgID("DevNet.Drv"), false);
				}
				catch
				{
					DevNet = null;
					return null;
				}
			}
			try
			{
				double ves = 0;
				byte ErrState, Flags0, Flags1, DFlags, DState;
				DevNet.GetWeight(1, 0, out ves, out ErrState, out Flags0, out Flags1, out DFlags, out DState);
				d.Value = ves;
				d.Stable = true;
				return d;
			}
			catch
			{
				DevNet = null;
				return null;
			}

			
			return null;
		}
        public static FileStream file = null;
        public static SerialPort ComPort = null;
        public static VesData GetDataFromComport()
        {
            VesData d = new VesData();
            if (file==null)
            {
                file = File.OpenWrite("com.txt");

            }
            if (ComPort == null)
            {
                ComPort = new SerialPort(ConfigManager.configParams.ComPort,
                    ConfigManager.configParams.BaudRate, Parity.None, 8, StopBits.One);
                ComPort.DataReceived += ComPort_DataReceived;
                ComPort.Open();
            }
            byte[] arr = { 0xff, 0x7f, 0x20, 0x56, 0x10, 0x00, 0x09, 0x03 };
            //ComPort.Write(arr, 0, 8);
            byte[] arr2 = { 0xff, 0x7f, 0x20, 0x2e, 0x7f, 0xf1, 0x03 };
            //ComPort.Write(arr2, 0, 7);
            byte[] arr3 = { Convert.ToByte('+') };
            //ComPort.Write(arr3, 0, 1);
            byte[] arr4 = { Convert.ToByte('v') };
            ComPort.Write(arr4, 0, 1);

            return d;
        }

        private static void ComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
                string data = ComPort.ReadExisting();
            Console.WriteLine(data);
        }
    }
}
