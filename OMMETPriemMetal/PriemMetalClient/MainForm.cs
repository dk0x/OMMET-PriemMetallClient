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
		}
		private int counter = 0;
		private void VesUpdateTimer_Tick(object sender, EventArgs e)
		{
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
			//BuyPriceMetallBookForm f = new BuyPriceMetallBookForm();
			//f.ShowNormal(this);
			//BaseBookForm<BuyPriceMetall> testbook = new BaseBookForm<BuyPriceMetall>();
			//test testbook = new test();
			//testbook.SetDefaultColumns();
			//testbook.ShowNormal(this);

			/*BaseRecordEditUserControl<MetallPrice> f = new BaseRecordEditUserControl<MetallPrice>();
			f.SetRecord(new MetallPrice { Price = 100.25m, Category = "1212" });
			f.Parent = tabPage2;
			f.SelectBtnVisible = true;*/

			//DataBase.DB.GetCollection<PSADocument>().Delete(Query.All());

			PSADocument doc = new PSADocument()
			{
				Nomer = 77,
				OpisanieLoma = "asdasd",
				Date = DateTime.Now,
				ContragentType = ContragentType.FizLico,
				ContragentFizLico = DataBase.DB.GetCollection<ContragentFizLico>().FindOne(Query.All()),
				Metalls = new List<PSADocumentMetall>()
			};
			//DataBase.DB.GetCollection<PSADocumentMetall>().Upsert(new PSADocumentMetall() { Category = "111" });
			//doc.Metalls.Add(DataBase.DB.GetCollection<PSADocumentMetall>().FindOne(Query.All()));
			doc.Metalls.Add(new PSADocumentMetall() {
				Brutto = 1000,
				Category = "Category",
				Netto = 2000,
				Nomenklatura = "Nomenklatura",
				Price = 100,
				PSADocumentGuid = doc.Guid,
				Summa = 1111,
				Tara = 3000,
				Zasor = 5
			});
			var b = DataBase.DB.GetCollection<PSADocument>().
				Include(x => x.Metalls).Upsert(doc);
			
			//var r = DataBase.DB.GetCollection<PSADocument>().Include(x => x.ContragentFizLico).Include(x => x.Metalls).
			//	FindOne(x=>x.Nomer == 77);

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

		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			using (var f = new PSADocumentForm())
				f.ShowDialog(this);
		}
	}
}
