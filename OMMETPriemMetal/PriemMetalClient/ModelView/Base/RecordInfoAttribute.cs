using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PriemMetalClient
{
	[Flags]
	public enum RecordInfoFlags
	{
		NONE = 0,
		NOFILTER = 1,
		NOTABLECOLUMN = 2,
		TEXTMULTILANE = 4,
		DATEONLY = 8,
		TIMEONLY = 16
	}
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
	public class RecordInfoAttribute : System.Attribute
	{
		public string Text { get; set; } = null;
		public bool TableNoFilter { get; set; } = false;
		public bool TableNoColumn { get; set; } = false;
		public bool TextMultilane { get; set; } = false;
		public bool DatetimeDateOnly { get; set; } = false;
		public bool DatetimeTimeOnly { get; set; } = false;
		//public RecordInfoFlags Flags { get; }
		public RecordInfoAttribute(string text) //, RecordInfoFlags flags = RecordInfoFlags.NONE)
		{
			Text = text;
			//Flags = flags;
		}
		public static RecordInfoAttribute GetPropertyRecordInfo(PropertyInfo propInfo)
		{
			object[] attrs = propInfo.GetCustomAttributes(false);
			return (RecordInfoAttribute)attrs.FirstOrDefault(x => x.GetType() == typeof(RecordInfoAttribute));
		}
		public static RecordInfoAttribute GetClassRecordInfo<T>()
		{
			object[] attrs = typeof(T).GetCustomAttributes(false);
			return (RecordInfoAttribute)attrs.FirstOrDefault(x => x.GetType() == typeof(RecordInfoAttribute));
		}
		public static RecordInfoAttribute GetClassRecordInfo(Type t)
		{
			object[] attrs = t.GetCustomAttributes(false);
			return (RecordInfoAttribute)attrs.FirstOrDefault(x => x.GetType() == typeof(RecordInfoAttribute));
		}

	}
}
