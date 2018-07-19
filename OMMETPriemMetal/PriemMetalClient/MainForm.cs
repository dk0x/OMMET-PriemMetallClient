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
			VesManager.SetWorkMethod(ConfigManager.configParams.VesWorkMethod, true);
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
			Label l = new Label();
			l.TextAlign = ContentAlignment.MiddleCenter;
			l.Dock = DockStyle.Top;
			l.Text = form.Text;
		}

		private void MainForm_MdiChildActivate(object sender, EventArgs e)
		{

		}


		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
			//menuStrip1.MdiWindowListItem
		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			VesManager.SetWorkMethod(ConfigManager.configParams.VesWorkMethod, true);
		}

		private void новыйДокументToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DocumentForm docForm = new DocumentForm();
			//docForm.MdiParent = this;
			docForm.Show();
		}

		BuyPriceMetallBookForm buyPriceMetallBookForm = null;
		private void закупочныеЦеныНаМеталлоломToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (buyPriceMetallBookForm != null)
			{
				buyPriceMetallBookForm.Focus();
				return;
			}
			buyPriceMetallBookForm = new BuyPriceMetallBookForm();
			buyPriceMetallBookForm.Owner = this;
			buyPriceMetallBookForm.FormClosed += BuyPriceMetallBookForm_FormClosed;
			buyPriceMetallBookForm.Show();
		}

		private void BuyPriceMetallBookForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			buyPriceMetallBookForm = null;
		}
	}
}
