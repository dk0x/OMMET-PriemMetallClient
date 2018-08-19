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
	public partial class VesDialogForm : Form
	{
		public VesDataReport Result { get; private set; } = default(VesDataReport);
		public VesDialogForm()
		{
			InitializeComponent();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			Result = VesManager.Report;
			if (Result == null) return;
			Result.Stable = true;
			textBox1.Text = Result.LastValue.ToString("N3") + " тонн";
			textBox2.Text = Result.AverageValue.ToString("N3") + " тонн";
			textBox3.Text = Result.Deviation.ToString("N3") + " тонн";
			textBox4.Text = Result.ReadoutCount.ToString("N") + " раз";
			textBox5.Text = Result.Stable ? "ДА" : "НЕТ";
			textBox2.BackColor = Result.Stable ? Color.MediumSpringGreen : Color.MediumVioletRed;
			textBox5.BackColor = Result.Stable ? Color.MediumSpringGreen : Color.MediumVioletRed;
		}

		public new DialogResult ShowDialog(IWin32Window owner)
		{
			timer.Enabled = true;
			return base.ShowDialog(owner);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Result == null)
			{
				label5.Text = "Данных с весов нет!";
			} else if (!Result.Stable)
			{
				label5.Text = "Весы не стабилизированны!";
			} else
			{
				DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
