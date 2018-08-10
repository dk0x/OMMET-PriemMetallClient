using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevNet;
using System.IO.Ports;
using LiteDB;

namespace PriemMetalClient
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			ConfigManager.Load();
			VesManager.SetWorkMethod(ConfigManager.Parameters.VesWorkMethod, true);
			BaseRecord.SetListViewDefaultColumns<PSADocument>(PSAList);
			RefreshPSAList();
		}
		private int counter = 0;
		private void VesUpdateTimer_Tick(object sender, EventArgs e)
		{
			Random rnd = new Random();
			VesManager.VesDataManager.AddData(new VesData
			{
				Timestamp = DateTime.Now,
				Value = Convert.ToDecimal(rnd.Next(2000, 2500) / 1000m)
			});

			counter++;
			this.Text = counter.ToString();
			VesMainText.Text = "Нет данных";
			var r = VesManager.Report;
			if (r != null)
			{
				VesMainText.Text = r.AverageValue.ToString("N3");
				VesDeviationText.Text = r.Deviation.ToString("N3");
				VesCountText.Text = r.ReadoutCount.ToString();
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			ConfigManager.Save();
			DataBase.DB.Dispose();
		}

		private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ПараметрыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new ConfigForm())
				f.ShowDialog(this);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

			
		}

		private void Button1_Click(object sender, EventArgs e)
        {
			
		}

		private void ToolStripButton1_Click(object sender, EventArgs e)
		{
			VesManager.SetWorkMethod(ConfigManager.Parameters.VesWorkMethod, true);
		}

		private void НовыйДокументToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new DocumentForm())
				f.ShowDialog();
		}

		private void ЗакупочныеЦеныНаМеталлоломToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordBookForm<MetallPrice>())
				f.ShowDialogNormal(this);
		}

		private void Button1_Click_1(object sender, EventArgs e)
		{
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			
		}

		private void КонтрагентыФизическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordBookForm<ContragentFizLico>())
				f.ShowDialogNormal(this);
		}

		private void КонтрагентыЮридическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordBookForm<ContragentUrLico>())
				f.ShowDialogNormal(this);
		}

		public void RefreshPSAList()
		{
			PSAList.Items.Clear();
			IEnumerable<PSADocument> col = null;

			col = DataBase.PSADocumentCollection.FindAll();

			foreach (var el in col)
				BaseRecord.UpsertListViewItem<PSADocument>(PSAList, el);
			//List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			//List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			if (PSAList.Columns.Count > 0) PSAList.Columns[0].Width = 0;
		}

		private void NewPSADocumentBtn_Click(object sender, EventArgs e)
		{
			using (var f = new PSADocumentForm()) // создадим форму
			{
				f.ShowDialogWithCreateNewDocument(this); // откровем форму с автосозданием документа
				RefreshPSAList(); // обновим список
			}
		}

		private void EditPSADocumentBtn_Click(object sender, EventArgs e)
		{
			if (PSAList.SelectedItems.Count > 0)
			{
				//ListViewItem<PSADocument> item = PSAList.SelectedItems[0];
				using (var f = new PSADocumentForm()) // создадим форму
				{
					f.ShowDialogForEditDocument((PSAList.SelectedItems[0] as ListViewItem<PSADocument>)?.Record, this); // откровем форму с автосозданием документа
					RefreshPSAList(); // обновим список
				}
			}
		}

		private void DeletePSADocumentBtn_Click(object sender, EventArgs e)
		{
			if (PSAList.SelectedItems.Count > 0)
			{
				var item = PSAList.SelectedItems[0];
				DataBase.DB.GetCollection<PSADocument>().Delete((item as ListViewItem<PSADocument>).Record.Guid);
				PSAList.Items.Remove(item);
			}
		}
	}
}
