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
		public bool Multilane
		{
			get => textBox.Multiline;
			set => textBox.Multiline = value;
		}

		public BaseRecordSelectUserControl()
		{
			InitializeComponent();
			label.Text = RecordInfoAttribute.GetClassRecordInfo<TRecord>()?.Text ?? typeof(TRecord).Name;
		}

		public void SetRecord(TRecord r)
		{
			if (r == null || r == Record) return;
			Record = r;
			UpdateText();
		}

		public void SetFormat(string s)
		{
			if (string.Equals(s, Format)) return;
			Format = s;
			UpdateText();
		}

		public void UpdateText()
		{
			textBox.Text = Record?.ToShortString() ?? "";
		}

		private void SelectBtn_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordBookForm<TRecord>())
				SetRecord(f.ShowDialogSelect(this.ParentForm));
		}
	}
}
