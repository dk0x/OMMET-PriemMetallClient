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
		private ConfigForm ConfigForm = null;
		private List<Form> mdiForms = new List<Form>();
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
				VesMainText.Text = r.AverageValue.ToString();
				VesDeviationText.Text = r.Deviation.ToString();
				VesCountText.Text = r.ReadoutCount.ToString();
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			ConfigManager.Save();

		}

		public Form GetMdiFormByCaption(string text)
		{
			foreach(Form f in this.MdiChildren)
				if (text == f.Text) return f;
			return null;
		}

		private void AddMdiFormToPanel(Form form)
		{
			Label l = new Label
			{
				TextAlign = ContentAlignment.MiddleCenter,
				Dock = DockStyle.Top,
				Text = form.Text
			};
		}

		private void MainForm_MdiChildActivate(object sender, EventArgs e)
		{

		}


		private void ВыходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ПараметрыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ConfigForm != null)
			{
				if (ConfigForm.WindowState == FormWindowState.Minimized)
					ConfigForm.WindowState = FormWindowState.Normal;
				ConfigForm.Focus();
				return;
			}
			ConfigForm = new ConfigForm();
			ConfigForm.FormClosed += ConfigForm_FormClosed;
			ConfigForm.Owner = this;
			ConfigForm.Show();
		}

		private void ConfigForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			ConfigForm = null;
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
			DocumentForm docForm = new DocumentForm();
			
			docForm.Show();
		}

		BaseRecordBookForm<MetallPrice> metallPriceBookForm = null;
		private void ЗакупочныеЦеныНаМеталлоломToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (metallPriceBookForm != null)
			{
				metallPriceBookForm.Focus();
				return;
			}
			metallPriceBookForm = new BaseRecordBookForm<MetallPrice>();
			metallPriceBookForm.FormClosed += BuyPriceMetallBookForm_FormClosed;
			metallPriceBookForm.ShowNormal(this);
		}

		private void BuyPriceMetallBookForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			metallPriceBookForm = null;
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
				ContragentFizLico = DataBase.DB.GetCollection<ContragentFizLico>().FindOne(Query.All())
			};
			DataBase.DB.GetCollection<PSADocumentMetall>().Upsert(new PSADocumentMetall() { Category = "111" });
			doc.PSADocumentMetall.Add(DataBase.DB.GetCollection<PSADocumentMetall>().FindOne(Query.All()));
			doc.PSADocumentMetall.Add(new PSADocumentMetall());
			var b = DataBase.DB.GetCollection<PSADocument>().Upsert(doc);
			
			var r = DataBase.DB.GetCollection<PSADocument>().Include(x => x.ContragentFizLico).Include(x => x.PSADocumentMetall).
				FindOne(x=>x.Nomer == 77);

		}

		private void Button2_Click(object sender, EventArgs e)
		{
			
		}

		BaseRecordBookForm<ContragentFizLico> contragentFizLicoBookForm = null;
		private void КонтрагентыФизическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (contragentFizLicoBookForm != null)
			{
				contragentFizLicoBookForm.Focus();
				return;
			}
			contragentFizLicoBookForm = new BaseRecordBookForm<ContragentFizLico>();
			contragentFizLicoBookForm.FormClosed += ContragentFizLicoBookForm_FormClosed;
			contragentFizLicoBookForm.ShowNormal(this);

		}

		private void ContragentFizLicoBookForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			contragentFizLicoBookForm = null;
		}

		BaseRecordBookForm<ContragentUrLico> contragentUrLicoBookForm = null;
		private void КонтрагентыЮридическиеЛицаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (contragentUrLicoBookForm != null)
			{
				contragentUrLicoBookForm.Focus();
				return;
			}
			contragentUrLicoBookForm = new BaseRecordBookForm<ContragentUrLico>();
			contragentUrLicoBookForm.FormClosed += ContragentUrLicoBookForm_FormClosed;
			contragentUrLicoBookForm.ShowNormal(this);

		}

		private void ContragentUrLicoBookForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			contragentUrLicoBookForm = null;
		}

		private void ToolStripButton2_Click(object sender, EventArgs e)
		{
			PSADocumentForm f = new PSADocumentForm();
			f.Show();
		}
	}
}
