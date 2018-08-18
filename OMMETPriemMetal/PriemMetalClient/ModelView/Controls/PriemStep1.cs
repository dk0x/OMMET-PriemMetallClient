using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient.ModelView.Controls
{
	public partial class PriemStep1 : UserControl
	{
		public PSADocument Document { get; private set; } = default(PSADocument);
		public PriemStep1()
		{
			InitializeComponent();
			FizSelect.Select();
		}

		public void SetDocument(PSADocument doc)
		{
			Document = doc;
		}

		private void FizUrSelect_CheckedChanged(object sender, EventArgs e)
		{
			contragentFizLicoRecordSelectUserControl1.Visible = FizSelect.Checked;
			contragentUrLicoRecordSelectUserControl1.Visible = UrSelect.Checked;
		}
	}
}
