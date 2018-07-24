using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace PriemMetalClient
{
	public class ConfigParameters
	{
		public string ComPort = "-";
		public int BaudRate = 9600;
		public VesWorkMethod VesWorkMethod = VesWorkMethod.COMPORT;
		public string DataBasePath = @"/Data/database.db";
	}
	public static class ConfigManager
	{

		public static ConfigParameters Parameters = new ConfigParameters();
		private static string FileName = Tools.Path(@"/config.xml");

		public static bool Save()
		{
			TextWriter tw = null;
			try
			{
				if (File.Exists(FileName))
					File.Delete(FileName);
				tw = new StreamWriter(FileName);
				XmlSerializer xs = new XmlSerializer(typeof(ConfigParameters));
				xs.Serialize(tw, Parameters);
				tw.Close();
				return true;
			} catch
			{
				if (tw != null) tw.Close();
				MessageBox.Show("ERROR: SAVE CONFIG FAILED");
				return false;
			}
		}

		public static bool Load()
		{
			if (File.Exists(FileName))
			{
				StreamReader sr = null;
				try
				{
					sr = new StreamReader(FileName);
					XmlSerializer xs = new XmlSerializer(typeof(ConfigParameters));
					Parameters = (ConfigParameters)xs.Deserialize(sr);
					sr.Close();
					return true;
				} catch
				{
					if (sr != null) sr.Close();
					MessageBox.Show("ERROR: LOAD CONFIG FAILED. CONFIG RESET.");
					if (File.Exists(FileName))
						File.Delete(FileName);
					Parameters = new ConfigParameters();
					return false;
				}
			}
			return true;
		}
	}
}
