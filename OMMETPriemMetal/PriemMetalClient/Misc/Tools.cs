using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public static class Tools
	{
		private static string _ExePath = "";
		public static string ExePath { get => GetExePath(); }
		public static string GetExePath()
		{
			if (_ExePath == "")
				_ExePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().
					GetName().CodeBase).Replace(@"file:\", "").Replace(@"file:", "");
			return _ExePath;
		}
		public static bool IsLinux { get => Environment.OSVersion.Platform == PlatformID.Unix; }
		public static string Path(string add)
		{
			add = ExePath + add;
			if (IsLinux)
				add = add.Replace(@"\", @"/");
			else
				add = add.Replace(@"/", @"\");
			string dir = System.IO.Path.GetDirectoryName(add);
			Directory.CreateDirectory(dir);
			return add;
		}

		public static bool OpenLink(string address)
		{
			try
			{
				int plat = (int)Environment.OSVersion.Platform;
				if ((plat != 4) && (plat != 128))
				{
					// Use Microsoft's way of opening sites
					Process.Start(address);
				}
				else
				{
					// We're on Unix, try gnome-open (used by GNOME), then open
					// (used my MacOS), then Firefox or Konqueror browsers (our last
					// hope).
					//string cmdline = String.Format("xdg-open {0} || gnome-open {0} || open {0} || " +
					//	"firefox {0} || mozilla-firefox {0} || konqueror {0}", address);
					string cmdline = String.Format("xdg-open {0}", address);
					Process proc = Process.Start(cmdline);

					// Sleep some time to wait for the shell to return in case of error
					System.Threading.Thread.Sleep(250);

					// If the exit code is zero or the process is still running then
					// appearently we have been successful.
					return (!proc.HasExited || proc.ExitCode == 0);
				}
			}
			catch (Exception e)
			{
				// We don't want any surprises
				return false;
			}
			return false;
		}
		public static PropertyInfo[] GetProperties<T>()
		{
			return typeof(T).GetProperties();
		}
		public static PropertyInfo[] GetProperties(object obj)
		{
			return obj.GetType().GetProperties();
		}
		public static PropertyInfo GetProperty<T>(string propName)
		{
			var props = GetProperties<T>();
			return props.FirstOrDefault(x => x.Name == propName);
		}

		public static void SetValueByPropertyName(object value, object obj, string propName)
		{
			obj.GetType().GetProperty(propName).SetValue(obj, value, null);
		}
		public static object GetValueByPropertyName(object obj, string propName)
		{
			return obj.GetType().GetProperty(propName).GetValue(obj, null);
		}

		public static T Clone<T, T2>(T2 source)
		{
			var serialized = JsonConvert.SerializeObject(source);
			return JsonConvert.DeserializeObject<T>(serialized);
		}
	}
}
