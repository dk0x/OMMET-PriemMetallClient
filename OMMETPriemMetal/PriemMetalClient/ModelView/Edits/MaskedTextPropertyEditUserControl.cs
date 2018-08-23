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
	partial class MaskedTextPropertyEditUserControl : BasePropertyEditUserControl
	{
		public MaskedTextPropertyEditUserControl()
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
			var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(prop);
			if (propInfo != null)
			{
				label.Text = propInfo.Text ?? "";
				maskedTextBox.Mask = propInfo.TextMask ?? "";
			}
			ClientSize = new Size(ClientSize.Width, label.Height + maskedTextBox.Height);
		}

		public override void SetValue(object value)
		{
			base.SetValue(value);
			maskedTextBox.Text = (string)value;
		}
		//public override object GetValue() => TextBox.Text;

		private void maskedTextBox_TextChanged(object sender, EventArgs e)
		{
			base.SetValue(maskedTextBox.Text);
		}
	}
}
