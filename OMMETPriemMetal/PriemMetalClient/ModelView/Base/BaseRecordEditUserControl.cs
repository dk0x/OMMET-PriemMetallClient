using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PriemMetalClient
{
	public class BaseRecordEditUserControl<RecordType> : UserControl where RecordType : BaseRecord
	{
		public RecordType Record { get; private set; }
		public Button SelectBtn { get; private set; } = null;
		private bool _SelectBtnVisible = false;
		public bool SelectBtnVisible { get => _SelectBtnVisible; set => SelectButtonVisible(value); }
		public BaseRecordEditUserControl()
		{
			
		}

		public void SelectButtonVisible(bool visible)
		{
			_SelectBtnVisible = visible;
			if (SelectBtn != null)
				SelectBtn.Visible = _SelectBtnVisible;
		}

		public void SetRecord(RecordType record)
		{
			Record = record;
			Render(record);
		}

		public void Render(RecordType record)
		{
			Controls.Clear();
			//this.AutoSize = true;
			int h = 0;
			SelectBtn = new Button();
			SelectBtn.Text = "Выбрать...";
			SelectBtn.Parent = this;
			SelectBtn.Dock = DockStyle.Bottom;
			SelectBtn.Visible = SelectBtnVisible;
			SelectBtn.Click += SelectBtn_Click;
			h += SelectBtn.Height;

			/*GroupBox gb = new GroupBox();
			gb.Parent = this;
			gb.AutoSize = true;
			gb.Dock = DockStyle.Top;
			gb.Text = TextAttribute.GetClassTextAttribute<RecordType>();*/
			var props = Tools.GetProperties<RecordType>().Reverse();
			foreach(var p in props)
			{
				if (p.PropertyType == typeof(string))
				{
					TextPropertyEditUserControl f = new TextPropertyEditUserControl();
					f.Dock = DockStyle.Top;
					//f.AutoSize = true;
					f.Set(record, p);
					f.Parent = this;
					h += f.Height;
				}
				else
				if (p.PropertyType == typeof(decimal))
				{
					DecimalPropertyEditUserControl f = new DecimalPropertyEditUserControl();
					f.Dock = DockStyle.Top;
					//f.AutoSize = true;
					f.Set(record, p);
					f.Parent = this;
					h += f.Height;
				}
			}
			Label caption = new Label();
			caption.Text = $"-- {TextAttribute.GetClassTextAttribute<RecordType>()} --";
			caption.Parent = this;
			caption.AutoSize = false;
			caption.Dock = DockStyle.Top;
			h += caption.Height;
			this.Height = h;
		}

		private BaseBookForm<RecordType> selectForm = null;
		private void SelectBtn_Click(object sender, EventArgs e)
		{
			if (selectForm != null)
			{
				selectForm.Focus();
				return;
			}
			selectForm = new BaseBookForm<RecordType>();
			selectForm.FormClosed += SelectForm_FormClosed;
			selectForm.FormClosedSelect += SelectForm_FormClosedSelect;
			selectForm.ShowSelect(this.ParentForm);

		}

		private void SelectForm_FormClosedSelect(object sender, RecordType record)
		{
			SetRecord(record);
			selectForm = null;
		}

		private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			selectForm = null;
		}
	}
}
