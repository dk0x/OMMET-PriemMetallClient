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
	public partial class BuyPriceMetallBookForm : Form
	{
		public BuyPriceMetallBookForm()
		{
			InitializeComponent();
		}

		private void BuyPriceMetallBook_Load(object sender, EventArgs e)
		{
			
		}
		BuyPriceMetallEditForm buyPriceMetallEditForm_new = null;
		private void button5_Click(object sender, EventArgs e)
		{
			if (buyPriceMetallEditForm_new != null)
			{
				buyPriceMetallEditForm_new.Focus();
				return;
			}
			buyPriceMetallEditForm_new = new BuyPriceMetallEditForm();
			buyPriceMetallEditForm_new.Owner = this;
			buyPriceMetallEditForm_new.FormClosed += BuyPriceMetallEditForm_new_FormClosed;
			buyPriceMetallEditForm_new.Show();
		}

		private void BuyPriceMetallEditForm_new_FormClosed(object sender, FormClosedEventArgs e)
		{
			buyPriceMetallEditForm_new = null;
		}
	}
}
