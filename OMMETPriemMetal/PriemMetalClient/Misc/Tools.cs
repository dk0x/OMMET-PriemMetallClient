using System;
using System.Collections.Generic;
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
		public static string ExePath => GetExePath();
		public static string GetExePath()
		{
			if (_ExePath == "")
				_ExePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().
					GetName().CodeBase).Replace(@"file:\", "").Replace(@"file:", "");
			return _ExePath;
		}
		public static string Path(string add)
		{
			add = ExePath + add;
			if (Environment.OSVersion.Platform == PlatformID.Unix)
				add = add.Replace(@"\", @"/");
			else
				add = add.Replace(@"/", @"\");
			string dir = System.IO.Path.GetDirectoryName(add);
			Directory.CreateDirectory(dir);
			return add;
		}
		public static PropertyInfo[] GetProperties<T>()
		{
			return typeof(T).GetProperties();
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
	}
}
