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
	public partial class PSADocumentForm : Form
	{
		public PSADocument PSADocument { get; private set; } = null;
		public PSADocumentForm()
		{
			InitializeComponent();
			//FizLiceSelect.Checked = true;
			BaseRecord.SetListViewDefaultColumns<PSADocumentMetall>(List);
		}

		public bool ShowDialog(PSADocument doc, Form owner = null)
		{
			if (doc == null)
			{
				Close();
				throw new Exception("PSADocument Record is Null");
			}
			SetRecord(doc);
			if (this.ShowDialog(owner) == DialogResult.OK)
			{
				SaveRecord();
				return true;
			}
			return false;
		}

		public void SetRecord(PSADocument doc)
		{
			PSADocument = doc;
			this.Text = $"ПСА-{doc.Nomer.ToString("D8")}";
			docno.Text = doc.Nomer.ToString("D8");
			docdata.Value = doc.Date;
			otdelenieRecordSelectUserControl1.SetRecord(doc.Otdelenie);
			transportRecordSelectUserControl1.SetRecord(doc.Transport);

			switch (doc.ContragentType)
			{
				case ContragentType.FizLico:
					FizLicoSelect.Checked = true;
					contragentFizLicoRecordSelectUserControl1.SetRecord(doc.ContragentFizLico);
					break;
				case ContragentType.UrLico:
					UrLizoSelect.Checked = true;
					contragentUrLicoRecordSelectUserControl1.SetRecord(doc.ContragentUrLico);
					break;
			}
			opisanieLoma.Text = doc.OpisanieLoma;
			osnovanie.Text = doc.Osnovanie;
			nds.Checked = doc.Nds;
		}

		public PSADocument SaveRecord()
		{
			PSADocument doc = new PSADocument
			{
				ContragentFizLico = contragentFizLicoRecordSelectUserControl1.Record,
				ContragentType = FizLicoSelect.Checked ? ContragentType.FizLico :
					UrLizoSelect.Checked ? ContragentType.UrLico : ContragentType.UrLico,
				ContragentUrLico = contragentUrLicoRecordSelectUserControl1.Record,
				Nds = nds.Checked,
				Netto = netto.Value,
				OpisanieLoma = opisanieLoma.Text,
				Osnovanie = osnovanie.Text,
				Otdelenie = otdelenieRecordSelectUserControl1.Record,
				Summa = summa.Value,
				Transport = transportRecordSelectUserControl1.Record
			};
			DataBase.DB.GetCollection<PSADocument>().Upsert(doc);
			return doc;
		}

		private void LizoSelect_CheckedChanged(object sender, EventArgs e)
		{
			contragentFizLicoRecordSelectUserControl1.Enabled = FizLicoSelect.Checked;
			contragentUrLicoRecordSelectUserControl1.Enabled = UrLizoSelect.Checked;
			if (FizLicoSelect.Checked)
			{
				contragentUrLicoRecordSelectUserControl1.SetRecord(null);
			}
			if (UrLizoSelect.Checked)
			{
				contragentFizLicoRecordSelectUserControl1.SetRecord(null);
			}
		}		

		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			
		}

		private void NewBtn_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordEditForm<PSADocumentMetall>())
			{
				f.SetRecord(new PSADocumentMetall());
				f.ShowDialog(this);
			}
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}
	}
}
