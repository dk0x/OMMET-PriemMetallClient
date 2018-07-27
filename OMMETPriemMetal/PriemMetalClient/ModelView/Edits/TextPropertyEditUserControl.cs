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
	partial class TextPropertyEditUserControl : BasePropertyEditUserControl
	{
		public TextPropertyEditUserControl()
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
			label.Text = TextAttribute.GetPropertyTextAttribute(prop);
		}

		public override void SetValue(object value)
		{
			base.SetValue(value);
			TextBox.Text = (string)value;
		}
		//public override object GetValue() => TextBox.Text;

		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			base.SetValue(TextBox.Text);
		}
	}
}
