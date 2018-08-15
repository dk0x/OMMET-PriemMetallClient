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
	public partial class InputDialogForm : Form
	{
		public string ResultText { get => textBox.Text; }
		public InputDialogForm()
		{
			InitializeComponent();
		}

		public DialogResult ShowDialog(string infoMsg, IWin32Window owner = null)
		{
			label.Text = infoMsg;
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
