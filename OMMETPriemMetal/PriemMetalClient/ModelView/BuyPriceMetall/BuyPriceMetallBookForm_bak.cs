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
	public partial class BuyPriceMetallBookForm_bak : Form
	{
		public delegate void FormClosedSelectHandler(object sender, BuyPriceMetall r);
		public event FormClosedSelectHandler FormClosedSelect;

		public BuyPriceMetallBookForm_bak()
		{
			InitializeComponent();
			RefreshList();
			listView1_SelectedIndexChanged(listView1, new EventArgs());
		}

		private void BuyPriceMetallBook_Load(object sender, EventArgs e)
		{

		}

		public void RefreshList()
		{
			listView1.Items.Clear();
			foreach (var el in DataBase.BuyPriceMetallTable.FindAll())
			{
				ListViewItemBaseRecord item = new ListViewItemBaseRecord();
				item.Record = el;
				item.Text = el.Category;
				item.SubItems.Add(el.Price.ToString());
				listView1.Items.Add(item);
			}

		}

		BuyPriceMetallEditForm buyPriceMetallEditForm_new = null;
		private void NewBtn_Click(object sender, EventArgs e)
		{
			if (buyPriceMetallEditForm_new != null)
			{
				buyPriceMetallEditForm_new.Focus();
				return;
			}
			buyPriceMetallEditForm_new = new BuyPriceMetallEditForm();
			buyPriceMetallEditForm_new.Owner = this;
			buyPriceMetallEditForm_new.FormClosed += BuyPriceMetallEditForm_new_FormClosed;
			buyPriceMetallEditForm_new.FormClosedSave += BuyPriceMetallEditForm_new_FormClosedSave;
			buyPriceMetallEditForm_new.LoadRecord(new BuyPriceMetall());
			buyPriceMetallEditForm_new.Show();
		}

		private void BuyPriceMetallEditForm_new_FormClosedSave(object sender, BuyPriceMetall r)
		{
			DataBase.BuyPriceMetallTable.Insert(r);
			RefreshList();
			buyPriceMetallEditForm_new.FormClosed -= BuyPriceMetallEditForm_new_FormClosed;
			buyPriceMetallEditForm_new.FormClosedSave -= BuyPriceMetallEditForm_new_FormClosedSave;
			buyPriceMetallEditForm_new = null;
		}

		private void BuyPriceMetallEditForm_new_FormClosed(object sender, FormClosedEventArgs e)
		{
			buyPriceMetallEditForm_new = null;
		}

		BuyPriceMetallEditForm buyPriceMetallEditForm_edit = null;
		private void EditBtn_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				ListViewItemBaseRecord item = (ListViewItemBaseRecord)listView1.SelectedItems[0];
				var selected = DataBase.BuyPriceMetallTable.FindOne(x => x.Guid == item.Record.Guid);
				if (selected != null)
				{
					if (buyPriceMetallEditForm_edit != null)
					{
						buyPriceMetallEditForm_edit.Focus();
						return;
					}
					buyPriceMetallEditForm_edit = new BuyPriceMetallEditForm();
					buyPriceMetallEditForm_edit.Owner = this;
					buyPriceMetallEditForm_edit.FormClosed += BuyPriceMetallEditForm_edit_FormClosed;
					buyPriceMetallEditForm_edit.FormClosedSave += BuyPriceMetallEditForm_edit_FormClosedSave;
					buyPriceMetallEditForm_edit.LoadRecord(selected);
					buyPriceMetallEditForm_edit.Show();
				}

			}
		}

		private void BuyPriceMetallEditForm_edit_FormClosedSave(object sender, BuyPriceMetall r)
		{
			DataBase.BuyPriceMetallTable.Upsert(r);
			RefreshList();
			buyPriceMetallEditForm_edit.FormClosed -= BuyPriceMetallEditForm_edit_FormClosed;
			buyPriceMetallEditForm_edit.FormClosedSave -= BuyPriceMetallEditForm_edit_FormClosedSave;
		}

		private void BuyPriceMetallEditForm_edit_FormClosed(object sender, FormClosedEventArgs e)
		{
			buyPriceMetallEditForm_edit = null;
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditBtn.Enabled = listView1.SelectedItems.Count > 0;
			DeleteBtn.Enabled = listView1.SelectedItems.Count > 0;
			SelectBtn.Enabled = listView1.SelectedItems.Count > 0;
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				ListViewItemBaseRecord item = (ListViewItemBaseRecord)listView1.SelectedItems[0];
				DataBase.BuyPriceMetallTable.Delete(item.Record.Id);
				listView1.Items.Remove(item);
			}
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			FormClosedSelect?.Invoke(this, null);
			Close();
		}

		private void SelectBtn_Click(object sender, EventArgs e)
		{
			if (listView1.SelectedItems.Count > 0)
			{
				ListViewItemBaseRecord item = (ListViewItemBaseRecord)listView1.SelectedItems[0];
				var selected = DataBase.BuyPriceMetallTable.FindOne(x => x.Guid == item.Record.Guid);
				if (selected != null)
				{
					FormClosedSelect?.Invoke(this, selected);
					Close();
				}
			}
		}

	}
}
