using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public partial class BaseRecordSelectUserControl<TRecord> : UserControl where TRecord : BaseRecord
	{
		public delegate void RecordSelectHandler(object sender, TRecord record);
		public event RecordSelectHandler RecordSelect;
		public TRecord Record { get; private set; } = null;

		public BaseRecordSelectUserControl()
		{
			InitializeComponent();
			label.Text = RecordInfoAttribute.GetClassRecordInfo<TRecord>()?.Text ?? typeof(TRecord).Name;
			var col = DataBase.DB.GetCollection<TRecord>().FindAll().OrderBy(x => x.ToString()).ToList();
			comboBox.Items.AddRange(col.ToArray());
		}

		public void SetRecord(TRecord r)
		{
			if (r == null) return;
			Record = r;
			if (comboBox.SelectedItem != r) comboBox.SelectedItem = r.ComboboxListUpsert<TRecord>(comboBox);
			RecordSelect?.Invoke(this, r);
		}

		private void SelectBtn_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordBookForm<TRecord>())
			{
				var r = f.ShowDialogSelect(this.ParentForm);
				if (r != null)
				{
					Record = r;
					comboBox.SelectedItem = r.ComboboxListUpsert<TRecord>(comboBox);
					RecordSelect?.Invoke(this, r);
				}
			}
		}

		private void SelectBtn_Resize(object sender, EventArgs e)
		{
			if (SelectBtn.Width != SelectBtn.Height)
				SelectBtn.Width = SelectBtn.Height;
		}

		private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var r = comboBox.SelectedItem as TRecord;
			if (r != null)
			{
				Record = r;
				RecordSelect?.Invoke(this, r);
			}
		}
	}
}
