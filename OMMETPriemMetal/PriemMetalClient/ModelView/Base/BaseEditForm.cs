using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public partial class BaseEditForm<RecordType> : Form where RecordType : BaseRecord
	{
		public BaseRecordEditUserControl<RecordType> EditUserControl = null;
		public delegate void FormClosedSaveHandler(object sender, RecordType r);
		public event FormClosedSaveHandler FormClosedSave;
		public RecordType Record { get => EditUserControl.Record; set => SetRecord(value); }
		public BaseEditForm()
		{
			InitializeComponent();
			EditUserControl = new BaseRecordEditUserControl<RecordType>();
			EditUserControl.Parent = this;
		}

		public void SetRecord(RecordType r)
		{
			EditUserControl.SetRecord(r);
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			FormClosedSave?.Invoke(this, Record);
			Close();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
