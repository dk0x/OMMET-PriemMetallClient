using System.Windows.Forms;

namespace PriemMetalClient
{
	partial class PSADocumentForm
	{
		private StatusStrip statusStrip1;
		private FlowLayoutPanel flowLayoutPanel1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.FizLiceSelect = new System.Windows.Forms.RadioButton();
			this.UrLizoSelect = new System.Windows.Forms.RadioButton();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.otdelenieRecordSelectUserControl1 = new PriemMetalClient.OtdelenieRecordSelectUserControl();
			this.transportRecordSelectUserControl1 = new PriemMetalClient.TransportRecordSelectUserControl();
			this.contragentFizLicoRecordSelectUserControl1 = new PriemMetalClient.ContragentFizLicoRecordSelectUserControl();
			this.contragentUrLicoRecordSelectUserControl1 = new PriemMetalClient.ContragentUrLicoRecordSelectUserControl();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.List = new System.Windows.Forms.ListView();
			this.MainBtnPanel = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.NewBtn = new System.Windows.Forms.ToolStripButton();
			this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
			this.EditBtn = new System.Windows.Forms.ToolStripButton();
			this.SelectBtn = new System.Windows.Forms.ToolStripButton();
			this.CloseBtn = new System.Windows.Forms.ToolStripButton();
			this.flowLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.flowLayoutPanel5.SuspendLayout();
			this.MainBtnPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 466);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(742, 22);
			this.statusStrip1.TabIndex = 0;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.textBox1);
			this.flowLayoutPanel1.Controls.Add(this.label2);
			this.flowLayoutPanel1.Controls.Add(this.dateTimePicker1);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(742, 36);
			this.flowLayoutPanel1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(138, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Приемо-сдаточный акт №";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(152, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 9;
			this.textBox1.Text = "000789";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(258, 8);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "от";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
			this.dateTimePicker1.Enabled = false;
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(282, 8);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
			this.dateTimePicker1.TabIndex = 11;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.AutoSize = true;
			this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 36);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(742, 0);
			this.flowLayoutPanel3.TabIndex = 3;
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.AutoSize = true;
			this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 36);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(742, 0);
			this.flowLayoutPanel4.TabIndex = 4;
			// 
			// FizLiceSelect
			// 
			this.FizLiceSelect.Location = new System.Drawing.Point(4, 51);
			this.FizLiceSelect.Name = "FizLiceSelect";
			this.FizLiceSelect.Size = new System.Drawing.Size(194, 18);
			this.FizLiceSelect.TabIndex = 2;
			this.FizLiceSelect.TabStop = true;
			this.FizLiceSelect.Text = "Физицеское лицо";
			this.FizLiceSelect.UseVisualStyleBackColor = true;
			this.FizLiceSelect.CheckedChanged += new System.EventHandler(this.LizoSelect_CheckedChanged);
			// 
			// UrLizoSelect
			// 
			this.UrLizoSelect.Location = new System.Drawing.Point(205, 51);
			this.UrLizoSelect.Name = "UrLizoSelect";
			this.UrLizoSelect.Size = new System.Drawing.Size(194, 18);
			this.UrLizoSelect.TabIndex = 3;
			this.UrLizoSelect.TabStop = true;
			this.UrLizoSelect.Text = "Юридическое лицо";
			this.UrLizoSelect.UseVisualStyleBackColor = true;
			this.UrLizoSelect.CheckedChanged += new System.EventHandler(this.LizoSelect_CheckedChanged);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 36);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(742, 0);
			this.flowLayoutPanel2.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230F));
			this.tableLayoutPanel2.Controls.Add(this.FizLiceSelect, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.otdelenieRecordSelectUserControl1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.UrLizoSelect, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.transportRecordSelectUserControl1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.contragentFizLicoRecordSelectUserControl1, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.contragentUrLicoRecordSelectUserControl1, 1, 2);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(433, 120);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// otdelenieRecordSelectUserControl1
			// 
			this.otdelenieRecordSelectUserControl1.Location = new System.Drawing.Point(4, 4);
			this.otdelenieRecordSelectUserControl1.Multilane = false;
			this.otdelenieRecordSelectUserControl1.Name = "otdelenieRecordSelectUserControl1";
			this.otdelenieRecordSelectUserControl1.Size = new System.Drawing.Size(194, 40);
			this.otdelenieRecordSelectUserControl1.TabIndex = 0;
			// 
			// transportRecordSelectUserControl1
			// 
			this.transportRecordSelectUserControl1.Location = new System.Drawing.Point(205, 4);
			this.transportRecordSelectUserControl1.Multilane = false;
			this.transportRecordSelectUserControl1.Name = "transportRecordSelectUserControl1";
			this.transportRecordSelectUserControl1.Size = new System.Drawing.Size(194, 40);
			this.transportRecordSelectUserControl1.TabIndex = 1;
			// 
			// contragentFizLicoRecordSelectUserControl1
			// 
			this.contragentFizLicoRecordSelectUserControl1.Enabled = false;
			this.contragentFizLicoRecordSelectUserControl1.Location = new System.Drawing.Point(4, 76);
			this.contragentFizLicoRecordSelectUserControl1.Multilane = false;
			this.contragentFizLicoRecordSelectUserControl1.Name = "contragentFizLicoRecordSelectUserControl1";
			this.contragentFizLicoRecordSelectUserControl1.Size = new System.Drawing.Size(194, 40);
			this.contragentFizLicoRecordSelectUserControl1.TabIndex = 0;
			// 
			// contragentUrLicoRecordSelectUserControl1
			// 
			this.contragentUrLicoRecordSelectUserControl1.Enabled = false;
			this.contragentUrLicoRecordSelectUserControl1.Location = new System.Drawing.Point(205, 76);
			this.contragentUrLicoRecordSelectUserControl1.Multilane = false;
			this.contragentUrLicoRecordSelectUserControl1.Name = "contragentUrLicoRecordSelectUserControl1";
			this.contragentUrLicoRecordSelectUserControl1.Size = new System.Drawing.Size(194, 40);
			this.contragentUrLicoRecordSelectUserControl1.TabIndex = 4;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
			this.tableLayoutPanel1.Controls.Add(this.textBox5, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.textBox4, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.checkBox1, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(442, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(283, 133);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(130, 31);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(119, 20);
			this.textBox5.TabIndex = 11;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(130, 4);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(119, 20);
			this.textBox4.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 6);
			this.label7.Margin = new System.Windows.Forms.Padding(5);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(86, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Описание лома";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 33);
			this.label8.Margin = new System.Windows.Forms.Padding(5);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(63, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Основание";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(4, 112);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(100, 17);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Цена без НДС";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 87);
			this.label6.Margin = new System.Windows.Forms.Padding(5);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(103, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Всего Сумма (руб.)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 60);
			this.label5.Margin = new System.Windows.Forms.Padding(5);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(87, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Всего Нетто (т.)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// numericUpDown2
			// 
			this.numericUpDown2.BackColor = System.Drawing.SystemColors.Window;
			this.numericUpDown2.DecimalPlaces = 2;
			this.numericUpDown2.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numericUpDown2.Location = new System.Drawing.Point(130, 85);
			this.numericUpDown2.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.ReadOnly = true;
			this.numericUpDown2.Size = new System.Drawing.Size(119, 20);
			this.numericUpDown2.TabIndex = 12;
			this.numericUpDown2.ThousandsSeparator = true;
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.SystemColors.Window;
			this.numericUpDown1.DecimalPlaces = 3;
			this.numericUpDown1.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.numericUpDown1.Location = new System.Drawing.Point(130, 58);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.ReadOnly = true;
			this.numericUpDown1.Size = new System.Drawing.Size(119, 20);
			this.numericUpDown1.TabIndex = 11;
			this.numericUpDown1.ThousandsSeparator = true;
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.AutoSize = true;
			this.flowLayoutPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.flowLayoutPanel5.Controls.Add(this.tableLayoutPanel2);
			this.flowLayoutPanel5.Controls.Add(this.tableLayoutPanel1);
			this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 36);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(742, 141);
			this.flowLayoutPanel5.TabIndex = 9;
			// 
			// List
			// 
			this.List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.List.FullRowSelect = true;
			this.List.GridLines = true;
			this.List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.List.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
			this.List.Location = new System.Drawing.Point(0, 231);
			this.List.MultiSelect = false;
			this.List.Name = "List";
			this.List.Size = new System.Drawing.Size(742, 235);
			this.List.TabIndex = 22;
			this.List.UseCompatibleStateImageBehavior = false;
			this.List.View = System.Windows.Forms.View.Details;
			// 
			// MainBtnPanel
			// 
			this.MainBtnPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.MainBtnPanel.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.MainBtnPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.NewBtn,
            this.DeleteBtn,
            this.EditBtn,
            this.SelectBtn,
            this.CloseBtn});
			this.MainBtnPanel.Location = new System.Drawing.Point(0, 177);
			this.MainBtnPanel.Name = "MainBtnPanel";
			this.MainBtnPanel.Size = new System.Drawing.Size(742, 54);
			this.MainBtnPanel.TabIndex = 23;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 54);
			// 
			// NewBtn
			// 
			this.NewBtn.Image = global::PriemMetalClient.Properties.Resources._173077___plus1;
			this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewBtn.Name = "NewBtn";
			this.NewBtn.Size = new System.Drawing.Size(63, 51);
			this.NewBtn.Text = "Добавить";
			this.NewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Image = global::PriemMetalClient.Properties.Resources._173055___minus;
			this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(55, 51);
			this.DeleteBtn.Text = "Удалить";
			this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// EditBtn
			// 
			this.EditBtn.Image = global::PriemMetalClient.Properties.Resources._173002___edit;
			this.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(91, 51);
			this.EditBtn.Text = "Редактировать";
			this.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// SelectBtn
			// 
			this.SelectBtn.Image = global::PriemMetalClient.Properties.Resources._173061___ok;
			this.SelectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SelectBtn.Name = "SelectBtn";
			this.SelectBtn.Size = new System.Drawing.Size(58, 51);
			this.SelectBtn.Text = "Выбрать";
			this.SelectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// CloseBtn
			// 
			this.CloseBtn.Image = global::PriemMetalClient.Properties.Resources._173050___logout;
			this.CloseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(57, 51);
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// PSADocumentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 488);
			this.Controls.Add(this.List);
			this.Controls.Add(this.MainBtnPanel);
			this.Controls.Add(this.flowLayoutPanel5);
			this.Controls.Add(this.flowLayoutPanel4);
			this.Controls.Add(this.flowLayoutPanel3);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "PSADocumentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PSADocumentForm";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.flowLayoutPanel5.ResumeLayout(false);
			this.flowLayoutPanel5.PerformLayout();
			this.MainBtnPanel.ResumeLayout(false);
			this.MainBtnPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private FlowLayoutPanel flowLayoutPanel3;
		private FlowLayoutPanel flowLayoutPanel4;
		private ContragentFizLicoRecordSelectUserControl contragentFizLicoRecordSelectUserControl1;
		private FlowLayoutPanel flowLayoutPanel2;
		private OtdelenieRecordSelectUserControl otdelenieRecordSelectUserControl1;
		private TransportRecordSelectUserControl transportRecordSelectUserControl1;
		private RadioButton FizLiceSelect;
		private RadioButton UrLizoSelect;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private TextBox textBox1;
		private Label label2;
		private DateTimePicker dateTimePicker1;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label6;
		private Label label5;
		private NumericUpDown numericUpDown1;
		private NumericUpDown numericUpDown2;
		private CheckBox checkBox1;
		private ContragentUrLicoRecordSelectUserControl contragentUrLicoRecordSelectUserControl1;
		private FlowLayoutPanel flowLayoutPanel5;
		private Label label7;
		private TextBox textBox4;
		private Label label8;
		private TextBox textBox5;
		public ListView List;
		private ToolStrip MainBtnPanel;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton NewBtn;
		private ToolStripButton DeleteBtn;
		private ToolStripButton EditBtn;
		private ToolStripButton SelectBtn;
		private ToolStripButton CloseBtn;
	}
}