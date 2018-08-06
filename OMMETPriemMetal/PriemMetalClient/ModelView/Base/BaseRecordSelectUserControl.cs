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
		//public delegate void CheckBoxCheckedChangedEventHandler(object sender);
		//public event CheckBoxCheckedChangedEventHandler CheckBoxCheckedChanged;
		public TRecord Record { get; private set; } = null;
		public string Format { get; private set; } = string.Empty;
		public bool Multilane
		{
			get => textBox.Multiline;
			set => textBox.Multiline = value;
		}

		/*public bool CheckBox
		{
			get => checkBox1.Visible;
			set => checkBox1.Visible = value;
		}

		public bool Checked
		{
			get => checkBox1.Checked;
			set => checkBox1.Checked = value;
		}*/

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
			textBox.Text = Record?.ToShortString() ?? "";
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

		/*private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			CheckBoxCheckedChanged?.Invoke(this);
		}*/
	}
}
