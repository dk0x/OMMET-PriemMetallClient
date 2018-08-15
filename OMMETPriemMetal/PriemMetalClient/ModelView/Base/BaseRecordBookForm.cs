using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public partial class BaseRecordBookForm<TRecord> : Form where TRecord : BaseRecord
	{
		//public delegate void FormClosedSelectHandler(object sender, TRecord record);
		//public event FormClosedSelectHandler FormClosedSelect;
		//public List<string> Columns = new List<string>();
		//public List<BaseFilterUserControl> Filters = new List<BaseFilterUserControl>();

		//private BaseRecordEditForm<TRecord> editForm_edit = null;
		//private BaseRecordEditForm<TRecord> editForm_new = null;

		public BaseRecordBookForm()
		{
			InitializeComponent();
			this.Text = $"Справочник: {RecordInfoAttribute.GetClassRecordInfo<TRecord>().Text ?? ""}";
			BaseRecord.SetListViewDefaultColumns<TRecord>(List);
			RefreshList();
			List_SelectedIndexChanged(List, new EventArgs());
			MakeFilters();
		}

		public void MakeFilters()
		{
			FilterFlowPanel.Controls.Clear();
			var props = typeof(TRecord).GetProperties();
			foreach (var p in props)
			{
				var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(p);
				if (propInfo == null) continue;
				if (propInfo.TableNoFilter) continue; 
				Type t = p.PropertyType;
				if (t == typeof(string))
				{
					TextPropertyFilterUserControl<TRecord> f = new TextPropertyFilterUserControl<TRecord>();
					if (f.SetProperty(p))
					{
						f.Parent = FilterFlowPanel;
						f.EnterKeyPress += F_EnterKeyPress;
					}
				}
				else
				if (new[] { typeof(int), typeof(decimal), typeof(float), typeof(double) }.Contains(t))
				{
					NumericFilterUserControl<TRecord> f = new NumericFilterUserControl<TRecord>();
					if (f.SetProperty(p))
					{
						f.Parent = FilterFlowPanel;
						f.EnterKeyPress += F_EnterKeyPress;
					}
				}
			}
			FilterGroupBox.Visible = FilterFlowPanel.HasChildren;
		}

		private void F_EnterKeyPress(object sender)
		{
			RefreshList(true);
		}

		public TRecord ShowDialogSelect(Form owner)
		{
			if (ShowDialog(owner) == DialogResult.OK)
				return List.SelectedItems.Count > 0 ? (List.SelectedItems[0] as DBListViewItem)?.Record as TRecord : null;
			return null;
		}

		public void ShowNormal(Form owner)
		{
			BottomButtons.Items.Remove(SelectBtn);
			//SelectBtn.Visible = false;
			Show(owner);
		}

		public DialogResult ShowDialogNormal(Form owner)
		{
			BottomButtons.Items.Remove(SelectBtn);
			//SelectBtn.Visible = false;
			return ShowDialog(owner);
		}

		/*public DBColumnHeader OrderColumn = null;
		public bool OrderAsc = true;
		private void List_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column <= 0 ) return;
			OrderAsc = !OrderAsc;
			OrderColumn = (List.Columns[e.Column] as DBColumnHeader);
			RefreshList();
		}*/

		public void RefreshList(bool filter = false)
		{

			List.Items.Clear();
			IEnumerable<TRecord> col = null;
			List<Query> qq = new List<Query>();
			if (filter)
			{
				foreach (BasePropertyFilterUserControl f in FilterFlowPanel.Controls)
				{
					Query q = f.GetQueryFilter();
					if (q != null) qq.Add(q);
				}
			}
			if (qq.Count == 0) col = DataBase.DB.GetCollection<TRecord>().FindAll();
			if (qq.Count == 1) col = DataBase.DB.GetCollection<TRecord>().Find(qq[0]);
			if (qq.Count >= 2) col = DataBase.DB.GetCollection<TRecord>().Find(Query.And(qq.ToArray()));

			if (OrderColumn != null)
			{
				col = col.OrderBy(x => OrderColumn.PropertyInfo.GetValue(x, null));
			}
			else
			{
				col = col.OrderBy(x => x._Created);
			}
			List.BeginUpdate();
			foreach (var el in col)	el.UpsertListViewItem(List);
			List.EndUpdate();
			//List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			//List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			if (List.Columns.Count > 0) List.Columns[0].Width = 0;
		}

		private void List_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditBtn.Enabled = List.SelectedItems.Count > 0;
			DeleteBtn.Enabled = List.SelectedItems.Count > 0;
			SelectBtn.Enabled = List.SelectedItems.Count > 0;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			Close();
		}

		private void SelectBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedItems.Count > 0)
			{
				this.DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedItems.Count > 0)
			{
				DBListViewItem item = (DBListViewItem)List.SelectedItems[0];
				var selected = DataBase.DB.GetCollection<TRecord>().FindById(item.Record.Guid);
				if (selected != null)
				{
					using (var f = new BaseRecordEditForm<TRecord>())
					{
						f.SetRecord(selected);
						if (f.ShowDialog(this) == DialogResult.OK) RefreshList();
					}
				}
			}
		}

		private void Button1_Click(object sender, EventArgs e)
		{
		}

		private void Button3_Click(object sender, EventArgs e)
		{
		}

		private void List_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (SelectBtn.Visible)
			{
				SelectBtn_Click(SelectBtn, new EventArgs());
			}else
			{
				EditBtn_Click(SelectBtn, new EventArgs());
			}
		}

		private void NewBtn_Click_1(object sender, EventArgs e)
		{
			using (var f = new BaseRecordEditForm<TRecord>())
			{
				f.SetRecord(Activator.CreateInstance<TRecord>());
				if (f.ShowDialog(this) == DialogResult.OK) RefreshList();
			}
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedItems.Count > 0)
			{
				var item = (DBListViewItem)List.SelectedItems[0];
				item.Record.DBDelete();
				//DataBase.DB.GetCollection<TRecord>().Delete(item.Record.Guid);
				List.Items.Remove(item);
			}
		}

		private void Filter_Click(object sender, EventArgs e)
		{
			RefreshList(true);
		}

		private void Nofilter_Click(object sender, EventArgs e)
		{
			foreach (BasePropertyFilterUserControl f in FilterFlowPanel.Controls)
				f.Reset();
			RefreshList(false);
		}

		public DBColumnHeader OrderColumn = null;

		private void List_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column >= 0)
			{
				if (OrderColumn == List.Columns[e.Column])
				{
					OrderColumn.Text = OrderColumn.InfoAttribute.Text;
					OrderColumn = null;
				}
				else
				{
					if (OrderColumn != null) OrderColumn.Text = OrderColumn.InfoAttribute.Text;
					OrderColumn = List.Columns[e.Column] as DBColumnHeader;
					OrderColumn.Text = $"* {OrderColumn.InfoAttribute.Text}";
				}
				RefreshList();
			}
			
		}
	}
}

