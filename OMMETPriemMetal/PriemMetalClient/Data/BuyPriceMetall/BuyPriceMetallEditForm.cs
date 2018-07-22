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
	public partial class BuyPriceMetallEditForm : Form
	{
		public delegate void FormClosedSaveHandler(object sender, BuyPriceMetall r);
		public event FormClosedSaveHandler FormClosedSave;
		public BuyPriceMetall record = null;
		public BuyPriceMetallEditForm()
		{
			InitializeComponent();
		}

		public void LoadRecord(BuyPriceMetall r)
		{
			record = r;
			cat.Text = r.Category;
			desc.Text = r.Description;
			price.Value = r.Price;
		}

		private void BuyPriceMetallEditForm_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			FormClosedSave?.Invoke(this, record);
			Close();
		}

		private void cat_TextChanged(object sender, EventArgs e)
		{
			record.Category = cat.Text;
		}

		private void desc_TextChanged(object sender, EventArgs e)
		{
			record.Description = desc.Text;
		}

		private void price_ValueChanged(object sender, EventArgs e)
		{
			record.Price = (int)price.Value;
		}
	}
}
