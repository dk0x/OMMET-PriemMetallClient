﻿using System;
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
		dynamic DevNet = null;
		public MainForm()
		{
			InitializeComponent();
			ConfigManager.Load();
			try
			{
				DevNet = Activator.CreateInstance(Type.GetTypeFromProgID("DevNet.Drv"), false);
			}
			catch
			{
				DevNet = null;
			}
		}

		private void VesUpdateTimer_Tick(object sender, EventArgs e)
		{
			VesMain.Text = "Нет данных";
			bool compete = false;
			if (DevNet != null)
			{
				try
				{
					double ves = 0;
					byte ErrState, Flags0, Flags1, DFlags, DState;
					DevNet.GetWeight(1, 0, out ves, out ErrState, out Flags0, out Flags1, out DFlags, out DState);
					VesMain.Text = ves.ToString();
					compete = true;
					return;
				}
				catch
				{

				}
				VesMain.Text = "Ошибка";
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
	}
}