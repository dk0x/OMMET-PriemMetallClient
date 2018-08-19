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
	public partial class NumericInputDialogForm : Form
	{
		public decimal Result { get => numericUpDown.Value; }
		public NumericInputDialogForm()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(string infoMsg, int DecimalPlaces = 0, IWin32Window owner = null)
		{
			label.Text = infoMsg;
			numericUpDown.DecimalPlaces = DecimalPlaces;
			numericUpDown.Increment = 1.0m / Convert.ToDecimal(Math.Pow(10, DecimalPlaces));
			numericUpDown.Focus();
			return this.ShowDialog(owner);
		}

		private void OkBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void CancelBtn_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
