using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PriemMetalClient
{
	public enum StringCase
	{
		None, UpperCase, LowerCase
	}
	public enum DateTimeFormat
	{
		Full, ShortDate, FullDate, ShortTime, FullTime, Format
	}
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
	public class RecordInfoAttribute : System.Attribute
	{
		public string Text { get; set; } = null;
		public bool TableNoFilter { get; set; } = false;
		public bool TableNoColumn { get; set; } = false;
		public bool TextMultilane { get; set; } = false;
		public bool VesValueInsertButton { get; set; } = false;
		public decimal MinValue { get; set; } = decimal.MinValue;
		public decimal MaxValue { get; set; } = decimal.MaxValue;
		public int DecimalDigits { get; set; } = 0;

		public DateTimeFormat DateTimeFormat { get; set; } = DateTimeFormat.Full;
		public string StringFormat { get; set; } = null;
		public StringCase StringCase { get; set; } = StringCase.None;
		public RecordInfoAttribute(string text)
		{
			Text = text;
		}
		public static RecordInfoAttribute GetPropertyRecordInfo(PropertyInfo propInfo)
		{
			object[] attrs = propInfo.GetCustomAttributes(false);
			return attrs.FirstOrDefault(x => x.GetType() == typeof(RecordInfoAttribute)) as RecordInfoAttribute;
		}
		public static RecordInfoAttribute GetClassRecordInfo<T>()
		{
			object[] attrs = typeof(T).GetCustomAttributes(false);
			return attrs.FirstOrDefault(x => x.GetType() == typeof(RecordInfoAttribute)) as RecordInfoAttribute;
		}
		public static RecordInfoAttribute GetClassRecordInfo(Type t)
		{
			object[] attrs = t.GetCustomAttributes(false);
			return attrs.FirstOrDefault(x => x.GetType() == typeof(RecordInfoAttribute)) as RecordInfoAttribute;
		}

		public static string ToStringBasedOnRecordInfo(object value, PropertyInfo propertyInfo)
		{
			if (value == null) return "";
			RecordInfoAttribute infoAttribute = RecordInfoAttribute.GetPropertyRecordInfo(propertyInfo);
			string result = value.ToString();
			if (propertyInfo.PropertyType == typeof(decimal))
			{
				decimal v = Convert.ToDecimal(value);
				result = string.IsNullOrWhiteSpace(infoAttribute.StringFormat) ? v.ToString() : v.ToString(infoAttribute.StringFormat);
			}
			else
			if (propertyInfo.PropertyType == typeof(DateTime))
			{
				DateTime v = Convert.ToDateTime(value);
				switch (infoAttribute.DateTimeFormat)
				{
					case DateTimeFormat.FullDate: result = v.ToLongDateString(); break;
					case DateTimeFormat.FullTime: result = v.ToLongTimeString(); break;
					case DateTimeFormat.ShortDate: result = v.ToShortDateString(); break;
					case DateTimeFormat.ShortTime: result = v.ToShortTimeString(); break;
					case DateTimeFormat.Format:
						result = string.IsNullOrWhiteSpace(infoAttribute.StringFormat) ? v.ToString() : v.ToString(infoAttribute.StringFormat);
						break;
				}
			}
			else
			if (propertyInfo.PropertyType == typeof(bool))
			{
				bool v = Convert.ToBoolean(value);
				result = v ? "Да" : "Нет";
			}

			switch (infoAttribute.StringCase)
			{
				case StringCase.LowerCase: result = result.ToLowerInvariant(); break;
				case StringCase.UpperCase: result = result.ToUpperInvariant(); break;
			}

			return result;
		}

	}
}
