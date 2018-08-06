using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using LiteDB;

namespace PriemMetalClient
{

	public class BaseRecord
	{
		//[Text("Уникальный идентификатор")]
		[LiteDB.BsonId]
		public Guid Guid { get; set; } = Guid.NewGuid();
		public DateTime _Created { get; set; } = DateTime.Now;

		public override string ToString()
		{
			string s = "";
			var props = this.GetType().GetProperties();
			foreach(var p in props)
			{
				var pinfo = RecordInfoAttribute.GetPropertyRecordInfo(p);
				if (pinfo?.Text != null)
				{
					s = s + pinfo.Text + ": ";
					if (p.PropertyType == typeof(DateTime))
					{
						if (pinfo.DatetimeDateOnly) s = s + ((DateTime)p.GetValue(this, null)).ToShortDateString();
						if (pinfo.DatetimeTimeOnly) s = s + ((DateTime)p.GetValue(this, null)).ToShortTimeString();
					} else
					{
						s = s + p.GetValue(this, null).ToString();
					}
					s = s + "; ";
				}
			}
			return s;
		}

		public virtual string ToShortString() => ToString();
	}
}
