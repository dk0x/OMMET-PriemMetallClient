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
	public partial class BaseRecordEditForm<RecordType> : Form where RecordType : BaseRecord
	{
		public BaseRecordEditUserControl<RecordType> EditUserControl = null;
		public delegate void FormClosedSaveHandler(object sender, RecordType r);
		public event FormClosedSaveHandler FormClosedSave;
		public RecordType Record { get => EditUserControl?.Record; set => SetRecord(value); }
		public BaseRecordEditForm()
		{
			InitializeComponent();
			this.Text = $"Редактирование записи: {RecordInfoAttribute.GetClassRecordInfo<RecordType>().Text ?? ""}";
			EditUserControl = new BaseRecordEditUserControl<RecordType>
			{
				Parent = this,
				Dock = DockStyle.Top
			};
			AutoSize = true;
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
