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
	public partial class BaseRecordBookForm<RecordType> : Form where RecordType : BaseRecord
	{
		public delegate void FormClosedSelectHandler(object sender, RecordType record);
		public event FormClosedSelectHandler FormClosedSelect;
		public List<string> Columns = new List<string>();
		//public List<BaseFilterUserControl> Filters = new List<BaseFilterUserControl>();

		private BaseRecordEditForm<RecordType> editForm_edit = null;
		private BaseRecordEditForm<RecordType> editForm_new = null;

		public BaseRecordBookForm()
		{
			InitializeComponent();
			this.Text = $"Справочник: {RecordInfoAttribute.GetClassRecordInfo<RecordType>().Text ?? ""}";
			SetDefaultColumns();
			RefreshList();
			List_SelectedIndexChanged(List, new EventArgs());
			MakeFilters();
		}

		public void MakeFilters()
		{
			FilterFlowPanel.Controls.Clear();
			//Filters.Clear();
			var props = typeof(RecordType).GetProperties();
			foreach (var p in props)
			{
				var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(p);
				if (propInfo == null) continue;
				if (propInfo.TableNoFilter) continue; // Flags.HasFlag(RecordInfoFlags.NOFILTER)) continue;
				//string text = RecordInfoAttribute.GetPropertyRecordInfo(p);
				Type t = p.PropertyType;
				if (t == typeof(string))
				{
					TextPropertyFilterUserControl<RecordType> f = new TextPropertyFilterUserControl<RecordType>();
					if (f.SetProperty(p))
					{
						f.Parent = FilterFlowPanel;
						f.EnterKeyPress += F_EnterKeyPress;
					}
				}
				else
				if (new[] { typeof(int), typeof(decimal), typeof(float), typeof(double) }.Contains(t))
				{
					NumericFilterUserControl<RecordType> f = new NumericFilterUserControl<RecordType>();
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

		public void ShowSelect(Form owner)
		{
			Owner = owner;
			SelectBtn.Visible = true;
			Show();
		}
		public void ShowNormal(Form owner)
		{
			Owner = owner;
			SelectBtn.Visible = false;
			Show();
		}

		public void SetDefaultColumns()
		{
			List<string> NewColumns = new List<string>();
			var props = typeof(RecordType).GetProperties();
			foreach (var p in props)
			{
				var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(p);
				if (propInfo == null) continue;
				if (propInfo.TableNoColumn) continue; // Flags.HasFlag(RecordInfoFlags.NOTABLECOLUMN)) continue;
				NewColumns.Add(p.Name);
			}
			SetColumns(NewColumns);
		}

		public void SetColumns(List<string> newColumns)
		{
			Columns.Clear();
			List.Columns.Clear();
			List.Columns.Add("").Width = 0;

			var props = typeof(RecordType).GetProperties();

			foreach (var propName in newColumns)
			{
				var prop = props.FirstOrDefault(x => x.Name == propName);
				if (prop == null) continue;
				var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(prop);
				if (propInfo == null) continue;
				if (propInfo.TableNoColumn) continue; // Flags.HasFlag(RecordInfoFlags.NOTABLECOLUMN)) continue;
				if (string.IsNullOrWhiteSpace(propInfo.Text)) continue;
				Columns.Add(propName);
				List.Columns.Add(propInfo.Text);
			}
		}

		public void RefreshList(bool filter = false)
		{
			List.Items.Clear();
			IEnumerable<RecordType> col = null;
			if (filter)
			{
				List<Query> qq = new List<Query>();
				foreach (BasePropertyFilterUserControl f in FilterFlowPanel.Controls)
				{
					Query q = f.GetQueryFilter();
					if (q != null) qq.Add(q);
				}
				if (qq.Count == 0)
					col = DataBase.DB.GetCollection<RecordType>().FindAll();
				if (qq.Count == 1)
					col = DataBase.DB.GetCollection<RecordType>().Find(qq[0]);
				if (qq.Count >= 2)
					col = DataBase.DB.GetCollection<RecordType>().Find(Query.And(qq.ToArray()));
			}
			else
			{
				col = DataBase.DB.GetCollection<RecordType>().FindAll();
			}
			foreach (var el in col)
				AddLine(el);
			//List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
			List.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
		}

		public RecordType AddLine(RecordType record)
		{
			ListViewItem<RecordType> item = new ListViewItem<RecordType>();
			var props = typeof(RecordType).GetProperties();
			foreach (var c in Columns)
			{
				var prop = props.FirstOrDefault(x => x.Name == c);
				if (prop == null) continue;
				var value = prop.GetValue(record, null);
				string text = prop.GetValue(record, null).ToString();
				if (prop.PropertyType == typeof(DateTime))
				{
					var propInfo = RecordInfoAttribute.GetPropertyRecordInfo(prop);
					if (propInfo.DatetimeDateOnly) /*Flags.HasFlag(RecordInfoFlags.DATEONLY))*/ text = ((DateTime)value).ToShortDateString();
					if (propInfo.DatetimeTimeOnly) /*Flags.HasFlag(RecordInfoFlags.TIMEONLY))*/ text = ((DateTime)value).ToShortTimeString();
				}
				item.SubItems.Add(text);
			}
			item.Record = record;
			List.Items.Add(item);
			return record;
		}

		private void List_SelectedIndexChanged(object sender, EventArgs e)
		{
			EditBtn.Enabled = List.SelectedItems.Count > 0;
			DeleteBtn.Enabled = List.SelectedItems.Count > 0;
			SelectBtn.Enabled = List.SelectedItems.Count > 0;
		}

		private void CloseBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void SelectBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedItems.Count > 0)
			{
				var item = (ListViewItem<RecordType>)List.SelectedItems[0];
				var record = item.Record;
				//var selected = DataBase.BuyPriceMetallTable.FindOne(x => x.Guid == item.Guid);
				if (record != null)
				{
					FormClosedSelect?.Invoke(this, record);
					Close();
				}
			}
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedItems.Count > 0)
			{
				var item = (ListViewItem<RecordType>)List.SelectedItems[0];
				DataBase.DB.GetCollection<RecordType>().Delete(item.Record.Guid);
				List.Items.Remove(item);
			}
		}

		/*public virtual Form CreateNewForm()
		{
			return CreateEditForm(Activator.CreateInstance<RecordType>());
		}

		public virtual Form CreateEditForm(RecordType record)
		{
			return new BaseEditForm<RecordType>();
		}*/

		private void EditBtn_Click(object sender, EventArgs e)
		{
			if (List.SelectedItems.Count > 0)
			{
				ListViewItem<RecordType> item = (ListViewItem<RecordType>)List.SelectedItems[0];
				var selected = DataBase.DB.GetCollection<RecordType>().FindOne(x => x.Guid == item.Record.Guid);
				if (selected != null)
				{
					if (editForm_edit != null)
					{
						editForm_edit.Focus();
						editForm_edit.SetRecord(selected);
						return;
					}
					editForm_edit = new BaseRecordEditForm<RecordType>(); //CreateEditForm(selected);
					if (editForm_edit != null)
					{
						editForm_edit.Owner = this;
						editForm_edit.SetRecord(selected);
						editForm_edit.FormClosed += EditForm_edit_FormClosed;
						editForm_edit.FormClosedSave += EditForm_FormClosedSave;
						editForm_edit.Show();
					}
				}

			}
		}

		private void EditForm_edit_FormClosed(object sender, FormClosedEventArgs e)
		{
			editForm_edit = null;
		}

		protected void EditForm_FormClosedSave(object sender, RecordType r)
		{
			DataBase.DB.GetCollection<RecordType>().Upsert(r);
			RefreshList();
		}

		private void NewBtn_Click(object sender, EventArgs e)
		{
			if (editForm_new != null)
			{
				editForm_new.Focus();
				return;
			}
			editForm_new = new BaseRecordEditForm<RecordType>();// CreateNewForm();
			if (editForm_new != null)
			{
				editForm_new.SetRecord(Activator.CreateInstance<RecordType>());
				editForm_new.Owner = this;
				editForm_new.FormClosed += EditForm_new_FormClosed;
				editForm_new.FormClosedSave += EditForm_FormClosedSave;
				editForm_new.Show();
			}
		}

		private void EditForm_new_FormClosed(object sender, FormClosedEventArgs e)
		{
			editForm_new = null;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			RefreshList(true);
		}

		private void Button3_Click(object sender, EventArgs e)
		{
			foreach (BasePropertyFilterUserControl f in FilterFlowPanel.Controls)
				f.Reset();
			RefreshList(false);
		}
	}
}

