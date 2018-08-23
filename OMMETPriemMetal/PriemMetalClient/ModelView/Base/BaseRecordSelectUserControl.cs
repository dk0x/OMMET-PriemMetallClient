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
	public partial class BaseRecordSelectUserControl<TRecord> : UserControl where TRecord : BaseRecord
	{
		public delegate void RecordSelectHandler(object sender, TRecord record);
		public event RecordSelectHandler RecordSelect;
		public TRecord Record { get; private set; } = null;

		public BaseRecordSelectUserControl()
		{
			InitializeComponent();
			label.Text = RecordInfoAttribute.GetClassRecordInfo<TRecord>()?.Text ?? typeof(TRecord).Name;
			//var col = DataBase.DB.GetCollection<TRecord>().FindAll().OrderBy(x => x.ToString()).ToList();
			//comboBox.Items.AddRange(col.ToArray());
			//comboBox.DataSource = DataBase.DB.GetCollection<TRecord>().FindAll().OrderBy(x => x.ToString()).ToList();
		}

		public void SetRecord(TRecord r)
		{
			Record = r;
			textBox1.Text = Record?.ToString() ?? "";
			//if (comboBox.SelectedItem != r) comboBox.SelectedItem = r.ComboboxListUpsert<TRecord>(comboBox);
			RecordSelect?.Invoke(this, r);
		}

		private void SelectBtn_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordBookForm<TRecord>())
			{
				var r = f.ShowDialogSelect(this.ParentForm);
				if (r != null)
				{
					Record = r;
					textBox1.Text = Record.ToString();
					RecordSelect?.Invoke(this, r);
				}
			}
		}

		private void SelectBtn_Resize(object sender, EventArgs e)
		{
			if (SelectBtn.Width != SelectBtn.Height)
				SelectBtn.Width = SelectBtn.Height;
		}

		/*private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var r = comboBox.SelectedItem as TRecord;
			if (r != null)
			{
				Record = r;
				RecordSelect?.Invoke(this, r);
			}
		}*/

		private void comboBox_TextUpdate(object sender, EventArgs e)
		{

		}

		private void comboBox_TextChanged(object sender, EventArgs e)
		{
		}

		private void comboBox_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void AddBtn_Resize(object sender, EventArgs e)
		{
			if (AddBtn.Width != AddBtn.Height)
				AddBtn.Width = AddBtn.Height;
		}

		private void AddBtn_Click(object sender, EventArgs e)
		{
			using (var f = new BaseRecordEditForm<TRecord>())
			{
				f.SetRecord(Activator.CreateInstance<TRecord>());
				if (f.ShowDialog(this) == DialogResult.OK)
				{
					SetRecord(f.Record);
				}
			}
		}

		private void ClearBtn_Resize(object sender, EventArgs e)
		{
			if (ClearBtn.Width != ClearBtn.Height)
				ClearBtn.Width = ClearBtn.Height;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			FilterList(textBox1.Text);
		}

		ListBox lb = null;
		public void ShowList(TextBox parent)
		{
			if (lb == null)
			{
				var f = parent.FindForm();
				var p = f.PointToClient(parent.Parent.PointToScreen(parent.Location));
				p.Y += parent.Height;
				lb = new ListBox
				{
					Parent = f,
					Location = p,
					Width = parent.Width,
					Height = 100,
					ScrollAlwaysVisible = true
				};
				f.Controls.SetChildIndex(lb, 0);
				lb.Visible = true;
				lb.Click += lb_Click;
				lb.KeyUp += textBox1_KeyUp;
			}
			FilterList(textBox1.Text);
		}

		private void lb_Click(object sender, EventArgs e)
		{
			if (lb?.SelectedItem != null)
			{
				SetRecord(lb.SelectedItem as TRecord);
				//textBox1.Text = Record?.ToString() ?? "";
				HideList();
			}
		}

		public void FilterList(string text)
		{
			if (lb == null) return;
			if (text.IsNullOrWhiteSpace()) text = "";
			text = text.Trim();
			lb.DataSource = DataBase.DB.GetCollection<TRecord>().
				Find(x => x.ToString().ToLowerInvariant().Contains(text.ToLowerInvariant())).
				OrderBy(x => x.ToString()).ToList();

		}

		public void HideList()
		{
			if (lb != null)
			{
				//lb.Parent = null;
				lb.Dispose();
				lb = null;
			}
			textBox1.Text = Record?.ToString() ?? "";
		}

		private void textBox1_MouseClick(object sender, MouseEventArgs e)
		{
			ShowList(textBox1);
			FilterList("");
			textBox1.SelectAll();
		}

		private void ClearBtn_Click(object sender, EventArgs e)
		{
			SetRecord(null);
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			if (textBox1.Focused || (lb?.Focused ?? false)) return;
			HideList();
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void textBox1_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) HideList();
			if (e.KeyCode == Keys.Enter)
			{
				SetRecord(lb?.SelectedItem as TRecord);
				HideList();
			}
			if (e.KeyCode == Keys.Down) lb?.Focus();
		}
	}
}
