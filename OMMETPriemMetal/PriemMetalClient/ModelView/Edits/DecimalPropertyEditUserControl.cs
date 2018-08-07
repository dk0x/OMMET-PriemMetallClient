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
	public partial class DecimalPropertyEditUserControl : BasePropertyEditUserControl
	{
		public DecimalPropertyEditUserControl()
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
			var ri = RecordInfoAttribute.GetPropertyRecordInfo(prop);
			if (ri != null)
			{
				label.Text = ri.Text ?? "";
				numericUpDown.DecimalPlaces = ri.DecimalDigits;
				vesButton.Visible = ri.VesValueInsertButton;
			}

		}

		public override void SetValue(object value)
		{
			base.SetValue(value);
			numericUpDown.Value = (decimal)value;
		}
		//public override object GetValue() => numericUpDown.Value;

		private void NumericUpDown_ValueChanged(object sender, EventArgs e)
		{
			base.SetValue(numericUpDown.Value);
		}

		private void VesButton_Click(object sender, EventArgs e)
		{
			numericUpDown.Value = VesManager.Report.AverageValue;
		}
	}
}
