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
		}

		private void VesUpdateTimer_Tick(object sender, EventArgs e)
		{
			VesMain.Text = "Нет данных";

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
            VesManager.GetDataFromComport();

        }
    }
}
