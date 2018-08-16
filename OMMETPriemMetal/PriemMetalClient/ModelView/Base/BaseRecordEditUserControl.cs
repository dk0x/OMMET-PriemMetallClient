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
			if (Record == record || record == null) return;
			Record = record;
			RenderUI(record);
		}

		public void RenderUI(RecordType record)
		{
			Controls.Clear();
			//this.AutoSize = true;
			int h = 0;
			SelectBtn = new Button
			{
				Text = "Выбрать...",
				Parent = this,
				Dock = DockStyle.Bottom,
				Visible = SelectBtnVisible
			};
			SelectBtn.Click += SelectBtn_Click;
			h += SelectBtn.Height;

			var props = Tools.GetProperties<RecordType>().Reverse();
			foreach(var p in props)
			{
				var ri = RecordInfoAttribute.GetPropertyRecordInfo(p);
				if (ri == null) continue;
				if (string.IsNullOrWhiteSpace(ri.Text)) continue;
				if (ri.ReadOnly) continue;
				if (p.PropertyType == typeof(string))
				{
					TextPropertyEditUserControl f = new TextPropertyEditUserControl
					{
						Dock = DockStyle.Top,
						Parent = this,
						//AutoSize = true
					};
					f.Set(record, p);
					h += f.Height;
				}
				else
				if (p.PropertyType == typeof(decimal))
				{
					NumericPropertyEditUserControl f = new NumericPropertyEditUserControl
					{
						Dock = DockStyle.Top,
						Parent = this,

						//AutoSize = true
					};
					f.numericUpDown.Maximum = ri.MaxVal;
					f.numericUpDown.Minimum = ri.MinVal;
					f.Set(record, p);
					h += f.Height;
				}
				else
				if (p.PropertyType == typeof(int))
				{
					NumericPropertyEditUserControl f = new NumericPropertyEditUserControl
					{
						Dock = DockStyle.Top,
						Parent = this,

						//AutoSize = true
					};
					f.numericUpDown.Maximum = ri.MaxVal;
					f.numericUpDown.Minimum = ri.MinVal;
					f.Set(record, p);
					h += f.Height;
				}
				else
				if (p.PropertyType == typeof(DateTime))
				{
					DateTimePropertyEditUserControl f = new DateTimePropertyEditUserControl
					{
						Dock = DockStyle.Top,
						Parent = this,
						//AutoSize = true
					};
					f.Set(record, p);
					h += f.Height;
				}
			}
			Label caption = new Label
			{
				Text = $"-- {RecordInfoAttribute.GetClassRecordInfo<RecordType>()?.Text ?? ""} --",
				Parent = this,
				AutoSize = false,
				Dock = DockStyle.Top
			};
			h += caption.Height;
			this.Height = h;
			this.Width = 200;
		}

		/*private BaseRecordBookForm<RecordType> selectForm = null;
		private void SelectBtn_Click(object sender, EventArgs e)
		{
			if (selectForm != null)
			{
				selectForm.Focus();
				return;
			}
			selectForm = new BaseRecordBookForm<RecordType>();
			selectForm.FormClosed += SelectForm_FormClosed;
			selectForm.FormClosedSelect += SelectForm_FormClosedSelect;
			selectForm.ShowSelect(this.ParentForm);

		}

		private void SelectForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			selectForm = null;
		}*/
		private void SelectBtn_Click(object sender, EventArgs e)
		{
			using (var selectForm = new BaseRecordBookForm<RecordType>())
			{
				//selectForm.FormClosedSelect += SelectForm_FormClosedSelect;
				SetRecord(selectForm.ShowDialogSelect(this.ParentForm));
			}
		}

		private void SelectForm_FormClosedSelect(object sender, RecordType record)
		{
			SetRecord(record);
		}

	}
}
