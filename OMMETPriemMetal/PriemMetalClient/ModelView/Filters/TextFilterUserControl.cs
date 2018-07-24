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
	public partial class TextFilterUserControl<RecordType> : BaseFilterUserControl where RecordType : BaseRecord
	{
		public PropertyInfo Property { get; set; } = null;
		public TextFilterUserControl()
		{
			InitializeComponent();
		}

		public bool SetProperty(PropertyInfo prop)
		{
			if (prop == null) return false;
			if (prop.PropertyType != typeof(string)) return false;
			Property = prop;
			GroupBox.Text = TextAttribute.GetPropertyTextAttribute(prop);
			LoadStrings(prop);
			return true;
		}

		public override Query GetQueryFilter()
		{
			if (string.IsNullOrWhiteSpace(ComboBox.Text)) return Query.All();
			return Query.Contains(Property.Name, ComboBox.Text);
		}

		public void LoadStrings(PropertyInfo prop)
		{
			ComboBox.Items.Clear();
			var col = DataBase.DB.GetCollection<RecordType>().FindAll();
			foreach (var el in col)
			{
				string s = (string)prop.GetValue(el, null);
				if (!ComboBox.Items.Contains(s)) ComboBox.Items.Add(s);
			}
		}
	}
}
