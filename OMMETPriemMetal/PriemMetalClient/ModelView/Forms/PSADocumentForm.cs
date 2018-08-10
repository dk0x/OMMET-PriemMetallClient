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
			BaseRecord.SetListViewDefaultColumns<DocumentMetallVesPrice>(List);
		}

		public PSADocument ShowDialogWithCreateNewDocument(IWin32Window owner)
		{
			// создадим новый документ, присвоим номер и запишем в базу
			var col = DataBase.DB.GetCollection<PSADocument>().FindAll().ToList();
			int i = col.Count > 0 ? col.Max(x => x.Nomer) : 0;
			var doc = new PSADocument
			{
				Nomer = i + 1
			};
			DataBase.PSADocumentCollection.Upsert(doc);
			return ShowDialogForEditDocument(doc, owner); // откровем форму как диалог для редактирования
		}

		public PSADocument ShowDialogForEditDocument(PSADocument doc, IWin32Window owner)
		{
			if (doc == null) return null;
			SetDocument(doc); // заполним поля формы документом
			this.ShowDialog(owner); // покажем форму как диалог
			SaveDocument(); // сохраним документ
			return doc;
		}

		public void SetDocument(PSADocument doc)
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
			RefreshList();
			UpdatePriceVes();
		}

		public void RefreshList()
		{
			List.Items.Clear();
			foreach (var el in PSADocument.MetallVesPriceItems)
				BaseRecord.UpsertListViewItem<DocumentMetallVesPrice>(List, el);
		}

		public void SaveDocument()
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
			foreach(ListViewItem<DocumentMetallVesPrice> el in List.Items)
			{
				DataBase.DB.GetCollection<DocumentMetallVesPrice>().Upsert(el.Record);
			}
			DataBase.PSADocumentCollection.Upsert(PSADocument);
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

		public void UpdatePriceVes()
		{
			netto.Value = 0;
			summa.Value = 0;
			foreach(ListViewItem<DocumentMetallVesPrice> item in List.Items)
			{
				netto.Value += item.Record.Netto;
				summa.Value += item.Record.Summa;
			}
		}

		private void NewMetallVesPriceBtn_Click(object sender, EventArgs e)
		{
			using (var f = new DocumentMetallVesPriceForm())
			{
				var m = new DocumentMetallVesPrice()
				{
					OwnerDocumentGuid = PSADocument.Guid
				};
				DataBase.DB.GetCollection<DocumentMetallVesPrice>().Upsert(m);
				BaseRecord.UpsertListViewItem<DocumentMetallVesPrice>(List, m);
				f.ShowDialogForEditMetalVesPrice(m, this);
				BaseRecord.UpsertListViewItem<DocumentMetallVesPrice>(List, m);
				SaveDocument();
				UpdatePriceVes();
			}
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
		}

		private void DeleteMetallVesPriceBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedIndices.Count > 0)
			{
				var listViewItem = List.SelectedItems[0];
				DocumentMetallVesPrice metall = (listViewItem as ListViewItem<DocumentMetallVesPrice>)?.Record;
				if (metall != null) DataBase.DB.GetCollection<DocumentMetallVesPrice>().Delete(metall.Guid);
				UpdatePriceVes();
			}
		}

		private void EditMetallVesPriceBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedItems.Count > 0)
			{
				var listViewItem = List.SelectedItems[0];
				using (var f = new DocumentMetallVesPriceForm())
				{
					f.ShowDialogForEditMetalVesPrice((listViewItem as ListViewItem<DocumentMetallVesPrice>)?.Record, this);
					RefreshList();
					UpdatePriceVes();
				}
			}

		}
	}
}
