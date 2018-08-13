using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace PriemMetalClient
{
	public class BasePropertyEditUserControl: UserControl
	{
		public BaseRecord Record { get; set; } = default(BaseRecord);
		public PropertyInfo Property { get; private set; } = null;
		public RecordInfoAttribute PropertyRecordInfo { get; private set; } = null;
		public object Value { get => GetValue(); set => SetValue(value); }
		public virtual void Set(BaseRecord record, PropertyInfo prop)
		{
			SetProperty(prop);
			SetRecord(record);
		}

		public virtual void SetRecord(BaseRecord record)
		{
			Record = record;
			SetValue(GetValue());
		}

		public virtual void SetProperty(PropertyInfo prop)
		{
			Property = prop;
			PropertyRecordInfo = RecordInfoAttribute.GetPropertyRecordInfo(prop);
		}

		public virtual void SetValue(object value)
		{
			if (Record != null)	Property?.SetValue(Record, value, null);
		}

		public virtual object GetValue()
		{
			if (Record == null) return null;
			return Property?.GetValue(Record, null);
		}
	}
}
