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
	public partial class DateTimePropertyEditUserControl : BasePropertyEditUserControl
	{
		public DateTimePropertyEditUserControl()
		{
			InitializeComponent();
		}
		public override void SetRecord(BaseRecord record)
		{
			base.SetRecord(record);
		}

		public override void SetProperty(PropertyInfo prop)
		{
			base.SetProperty(prop);
			label.Text = RecordInfoAttribute.GetPropertyRecordInfo(prop)?.Text ?? "";
		}

		public override void SetValue(object value)
		{
			base.SetValue(value);
			dateTimePicker.Value = (DateTime)value;
		}

		private void dateTimePicker_ValueChanged(object sender, EventArgs e)
		{
			base.SetValue(dateTimePicker.Value);
		}
	}
}
