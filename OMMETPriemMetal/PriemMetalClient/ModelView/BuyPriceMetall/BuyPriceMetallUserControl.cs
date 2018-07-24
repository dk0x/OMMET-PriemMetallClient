using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public partial class BuyPriceMetallUserControl : UserControl
	{
		public BuyPriceMetall BuyPriceMetallRecord { get; set; } = null;
		private BuyPriceMetallBookForm BuyPriceMetallBookForm_select = null;
		public BuyPriceMetallUserControl()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (BuyPriceMetallBookForm_select != null)
			{
				BuyPriceMetallBookForm_select.Focus();
				return;
			}
			BuyPriceMetallBookForm_select = new BuyPriceMetallBookForm();
			BuyPriceMetallBookForm_select.FormClosedSelect += BuyPriceMetallBookForm_select_FormClosedSelect;
			BuyPriceMetallBookForm_select.ShowSelect(this.ParentForm);
		}

		public void LoadRecord(BuyPriceMetall r)
		{
			BuyPriceMetallRecord = r;
			cat.Text = r.Category;
			desc.Text = r.Description;
			price.Value = r.Price;
		}

		private void BuyPriceMetallBookForm_select_FormClosedSelect(object sender, BuyPriceMetall r)
		{
			if (r != null) LoadRecord(r);
			BuyPriceMetallBookForm_select.FormClosedSelect -= BuyPriceMetallBookForm_select_FormClosedSelect;
			BuyPriceMetallBookForm_select = null;
		}
	}
}
