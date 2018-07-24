using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using LiteDB;

namespace PriemMetalClient
{
	public partial class NumericFilterUserControl<RecordType> : BaseFilterUserControl where RecordType : BaseRecord
	{
		public PropertyInfo Property { get; set; } = null;
		public NumericFilterUserControl()
		{
			InitializeComponent();
			comboBox.SelectedIndex = 0;
		}

		public bool SetProperty(PropertyInfo prop)
		{
			if (prop == null) return false;
			if (!(new[] { typeof(int), typeof(decimal), typeof(float), typeof(double) }.Contains(prop.PropertyType))) return false;
			Property = prop;
			GroupBox.Text = TextAttribute.GetPropertyTextAttribute(prop);
			return true;
		}

		public override Query GetQueryFilter()
		{
			switch (comboBox.SelectedIndex)
			{
				case 0: return Query.GTE(Property.Name, value.Value);
				case 1: return Query.EQ(Property.Name, value.Value);
				case 2: return Query.LTE(Property.Name, value.Value);
			}
			return Query.All();
		}

	}
}
