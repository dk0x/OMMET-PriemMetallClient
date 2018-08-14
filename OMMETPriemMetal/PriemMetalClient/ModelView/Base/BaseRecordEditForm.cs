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
		public TRecord Record { get => EditUserControl?.Record; set => SetRecord(value); }
		public BaseRecordEditForm()
		{
			InitializeComponent();
			this.Text = $"Редактирование записи: {RecordInfoAttribute.GetClassRecordInfo<TRecord>().Text ?? ""}";
		}

		public DialogResult ShowDialog(TRecord r, IWin32Window owner)
		{
			SetRecord(r);
			return ShowDialog(owner);
		}

		public void SetRecord(TRecord r)
		{
			if (EditUserControl != null)
			{
				this.Controls.Remove(EditUserControl);
				EditUserControl.Dispose();
				EditUserControl = null;
			}
			EditUserControl = new BaseRecordEditUserControl<TRecord>
			{
				Parent = this,
				Width = this.ClientSize.Width,
				Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right
			};

			EditUserControl.SetRecord(r);
			EditUserControl.Dock = DockStyle.Top;
			AutoSize = true;
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			Record.DBUpsert();
			//DataBase.DB.GetCollection<TRecord>().Upsert(Record);
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
