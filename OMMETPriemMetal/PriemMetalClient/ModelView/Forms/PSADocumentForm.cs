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
		public bool NewMode { get; private set; } = false;
		public PSADocumentForm()
		{
			InitializeComponent();
			//FizLiceSelect.Checked = true;
			BaseRecord.SetListViewDefaultColumns<PSADocumentMetall>(List);
		}

		public PSADocument ShowNewDialog(IWin32Window owner = null)
		{
			PSADocument = new PSADocument();
			PSADocument.Nomer = DataBase.PSADocumentCollection.Max(x => x.Nomer) + 1;
			DataBase.PSADocumentCollection.Upsert(PSADocument);
			NewMode = true;
			SetRecord(PSADocument);
			if (this.ShowDialog(owner) == DialogResult.OK)
			{
				SaveRecord();
				return PSADocument;
			}
			return null;
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
			List.Items.Clear();
			foreach (var el in doc.Metalls)
				BaseRecord.UpsertListViewItem<PSADocumentMetall>(List, el);
		}

		public PSADocument SaveRecord()
		{
			PSADocument.ContragentFizLico = contragentFizLicoRecordSelectUserControl1.Record;
			PSADocument.ContragentType = FizLicoSelect.Checked ? ContragentType.FizLico :
				UrLizoSelect.Checked ? ContragentType.UrLico : ContragentType.UrLico;
			PSADocument.ContragentUrLico = contragentUrLicoRecordSelectUserControl1.Record;
			PSADocument.Nds = nds.Checked;
			PSADocument.Netto = netto.Value;
			PSADocument.OpisanieLoma = opisanieLoma.Text;
			PSADocument.Osnovanie = osnovanie.Text;
			PSADocument.Otdelenie = otdelenieRecordSelectUserControl1.Record;
			PSADocument.Summa = summa.Value;
			PSADocument.Transport = transportRecordSelectUserControl1.Record;
			foreach(ListViewItem<PSADocumentMetall> el in List.Items)
			{
				DataBase.DB.GetCollection<PSADocumentMetall>().Upsert(el.Record);
			}
			return PSADocument;
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
			using (var f = new PSADocumentMetallForm())
			{
				if (NewMode)
				{
					var m = new PSADocumentMetall()
					{
						PSADocumentGuid = PSADocument.Guid
					};
					DataBase.DB.GetCollection<PSADocumentMetall>().Upsert(m);
					PSADocument.Metalls.Add(m);
					BaseRecord.UpsertListViewItem<PSADocumentMetall>(List, m);
					SaveRecord();
					f.SetRecord(m);
					var rec = f.ShowDialog(this);
					if (rec != null)
					{
						rec.PSADocumentGuid = PSADocument.Guid;
						BaseRecord.UpsertListViewItem<PSADocumentMetall>(List, rec);
						PSADocument.Metalls.Add(rec);
						//DataBase.DB.GetCollection<PSADocumentMetall>().Upsert(rec);
					}
				}
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

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedIndices.Count > 0)
			{
				PSADocumentMetall metall = (List.SelectedItems[0] as ListViewItem<PSADocumentMetall>).Record;

				PSADocument.Metalls.Remove(metall);
				//DataBase.DB.GetCollection<PSADocumentMetall>().Upsert(rec);

			}
		}
	}
}
