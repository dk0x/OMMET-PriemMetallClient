using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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

		public static void Save()
		{
			if (File.Exists(@"config.xml"))
				File.Delete(@"config.xml");
			XmlSerializer xs = new XmlSerializer(typeof(ConfigParams));
			TextWriter tw = new StreamWriter(@"config.xml");
			xs.Serialize(tw, configParams);
			tw.Close();
		}

		public static void Load()
		{
			if (File.Exists(@"config.xml"))
			{
				StreamReader sr = new StreamReader(@"config.xml");
				XmlSerializer xs = new XmlSerializer(typeof(ConfigParams));
				configParams = (ConfigParams)xs.Deserialize(sr);
				sr.Close();
			}
		}
	}
}
