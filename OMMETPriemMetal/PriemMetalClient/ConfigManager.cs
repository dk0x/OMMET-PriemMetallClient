using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PriemMetalClient
{
	public class ConfigParams
	{
		public string ComPort = "-";
		public int BaudRate = 9600;
		public VesWorkMethod VesWorkMethod = VesWorkMethod.COMPORT;
	}
	public static class ConfigManager
	{

		public static ConfigParams configParams = new ConfigParams();
		private static string FileName = @"./config.xml";

		public static void Save()
		{
			try
			{
				if (File.Exists(FileName))
					File.Delete(FileName);
				XmlSerializer xs = new XmlSerializer(typeof(ConfigParams));
				TextWriter tw = new StreamWriter(FileName);
				xs.Serialize(tw, configParams);
				tw.Close();
			} catch
			{
				MessageBox.Show("ERROR: SAVE CONFIG FAILED");
			}
		}

		public static void Load()
		{
			if (File.Exists(FileName))
			{
				try
				{
					StreamReader sr = new StreamReader(FileName);
					XmlSerializer xs = new XmlSerializer(typeof(ConfigParams));
					configParams = (ConfigParams)xs.Deserialize(sr);
					sr.Close();
				} catch
				{
					MessageBox.Show("ERROR: LOAD CONFIG FAILED");
					if (File.Exists(FileName))
						File.Delete(FileName);
					configParams = new ConfigParams();
				}
			}
		}
	}
}
