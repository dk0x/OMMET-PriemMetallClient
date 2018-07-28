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
	public partial class TextPropertyFilterUserControl<RecordType> : BasePropertyFilterUserControl where RecordType : BaseRecord
	{
		public TextPropertyFilterUserControl()
		{
			InitializeComponent();
			SupportTypes.AddRange(new[] { typeof(string) });
		}

		public override bool SetProperty(PropertyInfo prop)
		{
			if (base.SetProperty(prop) == false) return false;
			label.Text = TextAttribute.GetPropertyTextAttribute(prop);
			LoadStrings(prop);
			return true;
		}

		public override void Reset()
		{
			base.Reset();
			label.Checked = false;
			ComboBox.Text = string.Empty;
		}

		public override Query GetQueryFilter()
		{
			if (!label.Checked) return null;// Query.All();
			if (string.IsNullOrWhiteSpace(ComboBox.Text)) return null;// Query.All();
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

		private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			label.Checked = true;
			ApplyFilterEvent(this);
		}

		private void ComboBox_TextUpdate(object sender, EventArgs e)
		{
			label.Checked = true;
		}

		private void ComboBox_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) ApplyFilterEvent(this);

		}

		private void label_CheckedChanged(object sender, EventArgs e)
		{
			ApplyFilterEvent(this);
		}
	}
}
