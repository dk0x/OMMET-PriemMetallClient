using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PriemMetalClient
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
	public class TextAttribute : System.Attribute
	{
		public string Text { get; }
		public TextAttribute(string text)
		{
			Text = text;
		}
		public static string GetPropertyTextAttribute(PropertyInfo propInfo)
		{
			object[] attrs = propInfo.GetCustomAttributes(false);
			TextAttribute ta = (TextAttribute)attrs.Single(x => x.GetType() == typeof(TextAttribute));
			if (ta != null)
				return ta.Text;
			return propInfo.Name;
		}
	}
	public class BaseRecord
	{
		[Text("Номер записи")]
		public int Id { get; set; } = 0;
		[Text("Уникальный идентификатор")]
		public Guid Guid { get; set; } = Guid.NewGuid();
	}
}
