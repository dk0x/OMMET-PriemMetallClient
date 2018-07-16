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

		private void выходToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ConfigForm ConfigForm = new ConfigForm();
			ConfigForm.Show();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

        private void button1_Click(object sender, EventArgs e)
        {
			//VesManager.GetDataFromComport();
			//byte[] arr = { 0xff, 0x20, 0x22, 0x56, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xac, 0x03 };
			//byte[] arr = { 0xff, 0x20, 0x22, 0x56, 0x07, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
			//byte[] arr2 = { 0xff, 0x20, 0x22, 0x2e, 0x7f, 0x10, 0x00, 0x00, 0x01, 0x45, 0x13, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0xf5, 0x1c, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x75, 0x10, 0x00, 0x10, 0x00, 0x10, 0x00, 0x40, 0xc0, 0xc0, 0xdc, 0x03 };
			//byte[] arr2 = { 0xff, 0x20, 0x22, 0x2e, 0x7f, 0x10, 0x00, 0x00, 0x01, 0x45, 0x13, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x10, 0x00, 0xf5, 0x1c, 0x00, 0x00, 0x00, 0x00, 0x04, 0x00, 0x75, 0x10, 0x00, 0x10, 0x00, 0x10, 0x00, 0x40, 0xc0, 0xc0 };
			//byte[] arr3 = { 0xFF, 0x20, 0x22, 0x2A, 0x03, 0x00, 0x00, 0xD1, 0x0F, 0x00, 0x00, 0x3F, 0x03 };
			//arr2 = VesManager.ETXRemove(arr2);
			//textBox1.Text = VesManager.CalculateCRC(arr2, 0).ToString();
			//VesManager.ParseData(arr3);

		}

		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			VesManager.SetWorkMethod(ConfigManager.configParams.VesWorkMethod, true);
		}
	}
}
