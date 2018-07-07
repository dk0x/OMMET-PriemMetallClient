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
		public string ComPort = "COM1";
		public int BaudRate = 9600;
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
				using (var sr = new StreamReader(@"config.xml"))
				{
					XmlSerializer xs = new XmlSerializer(typeof(ConfigParams));
					configParams = (ConfigParams)xs.Deserialize(sr);
					sr.Close();
				}
			}
		}
	}
}
