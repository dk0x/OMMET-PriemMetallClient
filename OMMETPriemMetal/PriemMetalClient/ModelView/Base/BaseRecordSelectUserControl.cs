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
		public TRecord Record { get; private set; } = null;
		public string Format { get; private set; } = string.Empty;

		public BaseRecordSelectUserControl()
		{
			InitializeComponent();
			label.Text = RecordInfoAttribute.GetClassRecordInfo<TRecord>().Text;
		}

		public void SetRecord(TRecord r)
		{
			Record = r;
			UpdateText();
		}

		public void SetFormat(string s)
		{
			Format = s;
			UpdateText();
		}

		public void UpdateText()
		{
			textBox.Text = Record.ToString();
		}

		BaseRecordBookForm<TRecord> recordBookForm = null;
		private void SelectBtn_Click(object sender, EventArgs e)
		{
			if (recordBookForm != null)
			{
				recordBookForm.Focus();
				return;
			}
			recordBookForm = new BaseRecordBookForm<TRecord>();
			recordBookForm.FormClosed += RecordBookForm_FormClosed;
			recordBookForm.FormClosedSelect += RecordBookForm_FormClosedSelect;
			recordBookForm.ShowSelect(this.ParentForm);
		}

		private void RecordBookForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			recordBookForm = null;
		}

		private void RecordBookForm_FormClosedSelect(object sender, TRecord record)
		{
			SetRecord(record);
		}
	}
}
