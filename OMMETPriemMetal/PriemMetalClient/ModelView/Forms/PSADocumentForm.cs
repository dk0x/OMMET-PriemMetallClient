﻿using System;
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
			this.DeleteMetallVesPriceBtn.Text = $"Пометить/снять{Environment.NewLine} на удаление";
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
			doc.DBUpsert();
			//DataBase.PSADocumentCollection.Upsert(doc);
			return ShowDialogForEditDocument(doc, owner); // откровем форму как диалог для редактирования
		}

		public PSADocument ShowDialogForEditDocument(PSADocument doc, IWin32Window owner)
		{
			if (doc == null) return null;
			SetDocument(doc); // заполним поля формы документом
			this.ShowDialog(owner); // покажем форму как диалог
			if (!PSADocument.Proveden) SaveDocument(); // сохраним документ
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
			nds.Checked = doc.BezNds;
			RefreshList();
			/*List.Items.Clear();
			var metalls = PSADocument.MetallVesPriceItems.OrderBy(x => x._Created);
			foreach (var el in metalls)
				el.UpsertListViewItem(List);*/
			UpdatePriceVes();
			SetProveden(doc.Proveden);
		}

		public void SetProveden(bool Proveden)
		{
			TopPanel.Enabled = !Proveden;
			ListBtnPanel.Enabled = !Proveden;
			List.Enabled = !Proveden;
			SignBtn.Visible = !Proveden;
			SaveBtn.Visible = !Proveden;
			EditBtn.Visible = Proveden;

		}

		public void RefreshList()
		{
			List.Items.Clear();
			foreach (var el in PSADocument.MetallVesPriceItems.OrderBy(x => x._Created))
				el.UpsertListViewItem(List);
		}

		public void SaveDocument()
		{
			if (PSADocument.Proveden)
			{
				//MessageBox.Show("Документ уже проведен. Войдите в режим редактирования.");
				return;
			}
			PSADocument.Nomer = Convert.ToInt32(docno.Text);
			PSADocument.ContragentFizLico = contragentFizLicoRecordSelectUserControl1.Record;
			PSADocument.ContragentType = FizLicoSelect.Checked ? ContragentType.FizLico :
				UrLizoSelect.Checked ? ContragentType.UrLico : ContragentType.UrLico;
			PSADocument.ContragentUrLico = contragentUrLicoRecordSelectUserControl1.Record;
			PSADocument.BezNds = nds.Checked;
			PSADocument.Netto = netto.Value;
			PSADocument.OpisanieLoma = opisanieLoma.Text;
			PSADocument.Osnovanie = osnovanie.Text;
			PSADocument.Otdelenie = otdelenieRecordSelectUserControl1.Record;
			PSADocument.Summa = summa.Value;
			PSADocument.Transport = transportRecordSelectUserControl1.Record;
			PSADocument.MetallVesPriceItems.Clear();
			foreach (DBListViewItem el in List.Items)
			{
				if (!el.Font.Strikeout)
				{
					el.Record.DBUpsert();
					el.Record.ListUpsert(PSADocument.MetallVesPriceItems);
				}
				else
				{
					el.Record.DBDelete();
				}
			}
			PSADocument.DBUpsert();
			RefreshList();
			UpdatePriceVes();
		}

		private void SignBtn_Click(object sender, EventArgs e)
		{
			SaveDocument();
			KassaTransaction kassa = new KassaTransaction
			{
				Osnovanie = Osnovanie.PSADocument,
				PSADocument = PSADocument,
				Debet = PSADocument.Summa
			};
			kassa.DBUpsert();
			PSADocument.Proveden = true;
			PSADocument.DBUpsert();
			SetProveden(true);
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
			foreach(DBListViewItem item in List.Items)
			{
				if (item.Font.Strikeout) continue;
				var r = item.Record as DocumentMetallVesPrice;
				netto.Value += r.Netto;
				summa.Value += r.Summa;
			}
		}

		private void NewMetallVesPriceBtn_Click(object sender, EventArgs e)
		{
			using (var f = new DocumentMetallVesPriceForm())
			{
				var m = f.ShowDialogForEditMetalVesPrice(new DocumentMetallVesPrice(), this);
				if (m != null)
				{
					m.UpsertListViewItem(List);
					//SaveDocument();
					UpdatePriceVes();
				}
			}
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
			Close();
		}

		private void DeleteMetallVesPriceBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedIndices.Count > 0)
			{
				var listViewItem = List.SelectedItems[0];
				DocumentMetallVesPrice m = (listViewItem as DBListViewItem)?.Record as DocumentMetallVesPrice;
				//if (m != null) m.DBDelete(); //DataBase.DB.GetCollection<DocumentMetallVesPrice>().Delete(metall.Guid);
				//List.Items.Remove(listViewItem);

				listViewItem.Font = listViewItem.Font.Strikeout ? 
					new Font(listViewItem.Font, FontStyle.Regular) : 
					new Font(listViewItem.Font, FontStyle.Strikeout);
				UpdatePriceVes();
			}
		}

		private void EditMetallVesPriceBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedItems.Count > 0)
			{
				var listViewItem = List.SelectedItems[0];
				DocumentMetallVesPrice m = (listViewItem as DBListViewItem)?.Record as DocumentMetallVesPrice;
				if (m != null)
				{
					using (var f = new DocumentMetallVesPriceForm())
					{
						m = f.ShowDialogForEditMetalVesPrice(m, this);
						if (m != null)
						{
							m.UpsertListViewItem(List);
							//SaveDocument();
							UpdatePriceVes();
						}
					}

				}
			}
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{

		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			SaveDocument();
		}
	}
}
