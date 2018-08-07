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
	public partial class BaseRecordEditForm<TRecord> : Form where TRecord : BaseRecord
	{
		public BaseRecordEditUserControl<TRecord> EditUserControl = null;
		public delegate void FormClosedSaveHandler(object sender);
		public event FormClosedSaveHandler FormClosedSave;
		public TRecord Record { get => EditUserControl?.Record; set => SetRecord(value); }
		public BaseRecordEditForm()
		{
			InitializeComponent();
			this.Text = $"Редактирование записи: {RecordInfoAttribute.GetClassRecordInfo<TRecord>().Text ?? ""}";
			EditUserControl = new BaseRecordEditUserControl<TRecord>
			{
				Parent = this,
				Dock = DockStyle.Top
			};
			AutoSize = true;
		}

		public void SetRecord(TRecord r)
		{
			EditUserControl.SetRecord(r);
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			DataBase.DB.GetCollection<TRecord>().Upsert(Record);
			FormClosedSave?.Invoke(this);
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
