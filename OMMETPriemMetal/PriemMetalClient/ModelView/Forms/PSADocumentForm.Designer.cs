using System.Windows.Forms;

namespace PriemMetalClient
{
	partial class PSADocumentForm
	{
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.docdata = new System.Windows.Forms.DateTimePicker();
			this.FizLicoSelect = new System.Windows.Forms.RadioButton();
			this.UrLizoSelect = new System.Windows.Forms.RadioButton();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.osnovanie = new System.Windows.Forms.TextBox();
			this.opisanieLoma = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.nds = new System.Windows.Forms.CheckBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.summa = new System.Windows.Forms.NumericUpDown();
			this.netto = new System.Windows.Forms.NumericUpDown();
			this.List = new System.Windows.Forms.ListView();
			this.ListBtnPanel = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.NewMetallVesPriceBtn = new System.Windows.Forms.ToolStripButton();
			this.DeleteMetallVesPriceBtn = new System.Windows.Forms.ToolStripButton();
			this.EditMetallVesPriceBtn = new System.Windows.Forms.ToolStripButton();
			this.bottomBtnPanel = new System.Windows.Forms.ToolStrip();
			this.CloseBtn = new System.Windows.Forms.ToolStripButton();
			this.SignBtn = new System.Windows.Forms.ToolStripButton();
			this.EditBtn = new System.Windows.Forms.ToolStripButton();
			this.SaveBtn = new System.Windows.Forms.ToolStripButton();
			this.TopPanel = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.docno = new System.Windows.Forms.MaskedTextBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.HistoryList = new System.Windows.Forms.ListView();
			this.otdelenieRecordSelectUserControl1 = new PriemMetalClient.OtdelenieRecordSelectUserControl();
			this.transportRecordSelectUserControl1 = new PriemMetalClient.TransportRecordSelectUserControl();
			this.contragentFizLicoRecordSelectUserControl1 = new PriemMetalClient.ContragentFizLicoRecordSelectUserControl();
			this.contragentUrLicoRecordSelectUserControl1 = new PriemMetalClient.ContragentUrLicoRecordSelectUserControl();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.summa)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.netto)).BeginInit();
			this.ListBtnPanel.SuspendLayout();
			this.bottomBtnPanel.SuspendLayout();
			this.TopPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(189, 20);
			this.label1.TabIndex = 8;
			this.label1.Text = "Приемо-сдаточный акт №";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Location = new System.Drawing.Point(289, 0);
			this.label2.Margin = new System.Windows.Forms.Padding(3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(25, 20);
			this.label2.TabIndex = 10;
			this.label2.Text = "от";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// docdata
			// 
			this.docdata.Cursor = System.Windows.Forms.Cursors.Default;
			this.docdata.Dock = System.Windows.Forms.DockStyle.Left;
			this.docdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.docdata.Location = new System.Drawing.Point(314, 0);
			this.docdata.Name = "docdata";
			this.docdata.Size = new System.Drawing.Size(95, 20);
			this.docdata.TabIndex = 11;
			// 
			// FizLicoSelect
			// 
			this.FizLicoSelect.Location = new System.Drawing.Point(4, 51);
			this.FizLicoSelect.Name = "FizLicoSelect";
			this.FizLicoSelect.Size = new System.Drawing.Size(194, 18);
			this.FizLicoSelect.TabIndex = 2;
			this.FizLicoSelect.TabStop = true;
			this.FizLicoSelect.Text = "Физицеское лицо";
			this.FizLicoSelect.UseVisualStyleBackColor = true;
			this.FizLicoSelect.CheckedChanged += new System.EventHandler(this.LizoSelect_CheckedChanged);
			// 
			// UrLizoSelect
			// 
			this.UrLizoSelect.Location = new System.Drawing.Point(205, 51);
			this.UrLizoSelect.Name = "UrLizoSelect";
			this.UrLizoSelect.Size = new System.Drawing.Size(197, 18);
			this.UrLizoSelect.TabIndex = 3;
			this.UrLizoSelect.TabStop = true;
			this.UrLizoSelect.Text = "Юридическое лицо";
			this.UrLizoSelect.UseVisualStyleBackColor = true;
			this.UrLizoSelect.CheckedChanged += new System.EventHandler(this.LizoSelect_CheckedChanged);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 218F));
			this.tableLayoutPanel2.Controls.Add(this.FizLicoSelect, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.otdelenieRecordSelectUserControl1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.UrLizoSelect, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.transportRecordSelectUserControl1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.contragentFizLicoRecordSelectUserControl1, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.contragentUrLicoRecordSelectUserControl1, 1, 2);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 28);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 3;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(421, 120);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
			this.tableLayoutPanel1.Controls.Add(this.osnovanie, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.opisanieLoma, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.nds, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.summa, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.netto, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(457, 28);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(354, 133);
			this.tableLayoutPanel1.TabIndex = 8;
			// 
			// osnovanie
			// 
			this.osnovanie.Dock = System.Windows.Forms.DockStyle.Fill;
			this.osnovanie.Location = new System.Drawing.Point(130, 31);
			this.osnovanie.Name = "osnovanie";
			this.osnovanie.Size = new System.Drawing.Size(220, 20);
			this.osnovanie.TabIndex = 11;
			// 
			// opisanieLoma
			// 
			this.opisanieLoma.Dock = System.Windows.Forms.DockStyle.Fill;
			this.opisanieLoma.Location = new System.Drawing.Point(130, 4);
			this.opisanieLoma.Name = "opisanieLoma";
			this.opisanieLoma.Size = new System.Drawing.Size(220, 20);
			this.opisanieLoma.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(6, 6);
			this.label7.Margin = new System.Windows.Forms.Padding(5);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label7.Size = new System.Drawing.Size(115, 16);
			this.label7.TabIndex = 9;
			this.label7.Text = "Описание лома";
			this.label7.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(6, 33);
			this.label8.Margin = new System.Windows.Forms.Padding(5);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label8.Size = new System.Drawing.Size(115, 16);
			this.label8.TabIndex = 8;
			this.label8.Text = "Основание";
			this.label8.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// nds
			// 
			this.nds.AutoSize = true;
			this.nds.Dock = System.Windows.Forms.DockStyle.Fill;
			this.nds.Location = new System.Drawing.Point(4, 112);
			this.nds.Name = "nds";
			this.nds.Size = new System.Drawing.Size(119, 17);
			this.nds.TabIndex = 13;
			this.nds.Text = "Цена без НДС";
			this.nds.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(6, 87);
			this.label6.Margin = new System.Windows.Forms.Padding(5);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label6.Size = new System.Drawing.Size(115, 16);
			this.label6.TabIndex = 10;
			this.label6.Text = "Всего Сумма (руб.)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(6, 60);
			this.label5.Margin = new System.Windows.Forms.Padding(5);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label5.Size = new System.Drawing.Size(115, 16);
			this.label5.TabIndex = 9;
			this.label5.Text = "Всего Нетто (т.)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// summa
			// 
			this.summa.BackColor = System.Drawing.SystemColors.Window;
			this.summa.DecimalPlaces = 2;
			this.summa.Dock = System.Windows.Forms.DockStyle.Fill;
			this.summa.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.summa.Location = new System.Drawing.Point(130, 85);
			this.summa.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.summa.Name = "summa";
			this.summa.ReadOnly = true;
			this.summa.Size = new System.Drawing.Size(220, 20);
			this.summa.TabIndex = 12;
			this.summa.ThousandsSeparator = true;
			// 
			// netto
			// 
			this.netto.BackColor = System.Drawing.SystemColors.Window;
			this.netto.DecimalPlaces = 3;
			this.netto.Dock = System.Windows.Forms.DockStyle.Fill;
			this.netto.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.netto.Location = new System.Drawing.Point(130, 58);
			this.netto.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
			this.netto.Name = "netto";
			this.netto.ReadOnly = true;
			this.netto.Size = new System.Drawing.Size(220, 20);
			this.netto.TabIndex = 11;
			this.netto.ThousandsSeparator = true;
			// 
			// List
			// 
			this.List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.List.FullRowSelect = true;
			this.List.GridLines = true;
			this.List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.List.Location = new System.Drawing.Point(3, 213);
			this.List.MultiSelect = false;
			this.List.Name = "List";
			this.List.Size = new System.Drawing.Size(1124, 271);
			this.List.TabIndex = 22;
			this.List.UseCompatibleStateImageBehavior = false;
			this.List.View = System.Windows.Forms.View.Details;
			// 
			// ListBtnPanel
			// 
			this.ListBtnPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ListBtnPanel.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.ListBtnPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.NewMetallVesPriceBtn,
            this.DeleteMetallVesPriceBtn,
            this.EditMetallVesPriceBtn});
			this.ListBtnPanel.Location = new System.Drawing.Point(3, 167);
			this.ListBtnPanel.Name = "ListBtnPanel";
			this.ListBtnPanel.Size = new System.Drawing.Size(1124, 46);
			this.ListBtnPanel.TabIndex = 23;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
			// 
			// NewMetallVesPriceBtn
			// 
			this.NewMetallVesPriceBtn.Image = global::PriemMetalClient.Properties.Resources._173077___plus1;
			this.NewMetallVesPriceBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewMetallVesPriceBtn.Name = "NewMetallVesPriceBtn";
			this.NewMetallVesPriceBtn.Size = new System.Drawing.Size(63, 43);
			this.NewMetallVesPriceBtn.Text = "Добавить";
			this.NewMetallVesPriceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.NewMetallVesPriceBtn.Click += new System.EventHandler(this.NewMetallVesPriceBtn_Click);
			// 
			// DeleteMetallVesPriceBtn
			// 
			this.DeleteMetallVesPriceBtn.Image = global::PriemMetalClient.Properties.Resources._173055___minus;
			this.DeleteMetallVesPriceBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteMetallVesPriceBtn.Name = "DeleteMetallVesPriceBtn";
			this.DeleteMetallVesPriceBtn.Size = new System.Drawing.Size(170, 43);
			this.DeleteMetallVesPriceBtn.Text = "Пометить/снять на удаление";
			this.DeleteMetallVesPriceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.DeleteMetallVesPriceBtn.Click += new System.EventHandler(this.DeleteMetallVesPriceBtn_Click);
			// 
			// EditMetallVesPriceBtn
			// 
			this.EditMetallVesPriceBtn.Image = global::PriemMetalClient.Properties.Resources._173002___edit;
			this.EditMetallVesPriceBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditMetallVesPriceBtn.Name = "EditMetallVesPriceBtn";
			this.EditMetallVesPriceBtn.Size = new System.Drawing.Size(91, 43);
			this.EditMetallVesPriceBtn.Text = "Редактировать";
			this.EditMetallVesPriceBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.EditMetallVesPriceBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.EditMetallVesPriceBtn.Click += new System.EventHandler(this.EditMetallVesPriceBtn_Click);
			// 
			// bottomBtnPanel
			// 
			this.bottomBtnPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.bottomBtnPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.bottomBtnPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseBtn,
            this.SignBtn,
            this.EditBtn,
            this.SaveBtn});
			this.bottomBtnPanel.Location = new System.Drawing.Point(3, 484);
			this.bottomBtnPanel.Name = "bottomBtnPanel";
			this.bottomBtnPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.bottomBtnPanel.Size = new System.Drawing.Size(1124, 25);
			this.bottomBtnPanel.TabIndex = 24;
			// 
			// CloseBtn
			// 
			this.CloseBtn.Image = global::PriemMetalClient.Properties.Resources._173050___logout;
			this.CloseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(73, 22);
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// SignBtn
			// 
			this.SignBtn.Image = global::PriemMetalClient.Properties.Resources._173063___ok_sign;
			this.SignBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SignBtn.Name = "SignBtn";
			this.SignBtn.Size = new System.Drawing.Size(80, 22);
			this.SignBtn.Text = "Провести";
			this.SignBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.SignBtn.Click += new System.EventHandler(this.SignBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.Image = global::PriemMetalClient.Properties.Resources._173002___edit;
			this.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(107, 22);
			this.EditBtn.Text = "Редактировать";
			this.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// SaveBtn
			// 
			this.SaveBtn.Image = global::PriemMetalClient.Properties.Resources._173091___save;
			this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(85, 22);
			this.SaveBtn.Text = "Сохранить";
			this.SaveBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// TopPanel
			// 
			this.TopPanel.AutoSize = true;
			this.TopPanel.Controls.Add(this.panel2);
			this.TopPanel.Controls.Add(this.tableLayoutPanel1);
			this.TopPanel.Controls.Add(this.tableLayoutPanel2);
			this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.TopPanel.Location = new System.Drawing.Point(3, 3);
			this.TopPanel.Name = "TopPanel";
			this.TopPanel.Size = new System.Drawing.Size(1124, 164);
			this.TopPanel.TabIndex = 27;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.docdata);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.docno);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1124, 22);
			this.panel2.TabIndex = 28;
			// 
			// docno
			// 
			this.docno.Dock = System.Windows.Forms.DockStyle.Left;
			this.docno.Location = new System.Drawing.Point(189, 0);
			this.docno.Mask = "00000000";
			this.docno.Name = "docno";
			this.docno.Size = new System.Drawing.Size(100, 20);
			this.docno.TabIndex = 28;
			this.docno.Text = "00000000";
			this.docno.ValidatingType = typeof(int);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1138, 538);
			this.tabControl1.TabIndex = 28;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.List);
			this.tabPage1.Controls.Add(this.ListBtnPanel);
			this.tabPage1.Controls.Add(this.bottomBtnPanel);
			this.tabPage1.Controls.Add(this.TopPanel);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1130, 512);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Документ";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.HistoryList);
			this.tabPage2.Controls.Add(this.toolStrip2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1130, 512);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "История изменений";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// toolStrip2
			// 
			this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripButton1});
			this.toolStrip2.Location = new System.Drawing.Point(3, 3);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(1124, 46);
			this.toolStrip2.TabIndex = 24;
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 46);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = global::PriemMetalClient.Properties.Resources._173017___folder_open;
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(68, 43);
			this.toolStripButton1.Text = "Просмотр";
			this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
			// 
			// HistoryList
			// 
			this.HistoryList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HistoryList.FullRowSelect = true;
			this.HistoryList.GridLines = true;
			this.HistoryList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.HistoryList.Location = new System.Drawing.Point(3, 49);
			this.HistoryList.MultiSelect = false;
			this.HistoryList.Name = "HistoryList";
			this.HistoryList.Size = new System.Drawing.Size(1124, 460);
			this.HistoryList.TabIndex = 25;
			this.HistoryList.UseCompatibleStateImageBehavior = false;
			this.HistoryList.View = System.Windows.Forms.View.Details;
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
			this.transportRecordSelectUserControl1.Size = new System.Drawing.Size(197, 40);
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
			this.contragentUrLicoRecordSelectUserControl1.Size = new System.Drawing.Size(197, 40);
			this.contragentUrLicoRecordSelectUserControl1.TabIndex = 4;
			// 
			// PSADocumentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1138, 538);
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name = "PSADocumentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "PSADocumentForm";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PSADocumentForm_FormClosing);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.summa)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.netto)).EndInit();
			this.ListBtnPanel.ResumeLayout(false);
			this.ListBtnPanel.PerformLayout();
			this.bottomBtnPanel.ResumeLayout(false);
			this.bottomBtnPanel.PerformLayout();
			this.TopPanel.ResumeLayout(false);
			this.TopPanel.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private ContragentFizLicoRecordSelectUserControl contragentFizLicoRecordSelectUserControl1;
		private OtdelenieRecordSelectUserControl otdelenieRecordSelectUserControl1;
		private TransportRecordSelectUserControl transportRecordSelectUserControl1;
		private RadioButton FizLicoSelect;
		private RadioButton UrLizoSelect;
		private TableLayoutPanel tableLayoutPanel2;
		private Label label1;
		private Label label2;
		private DateTimePicker docdata;
		private TableLayoutPanel tableLayoutPanel1;
		private Label label6;
		private Label label5;
		private NumericUpDown netto;
		private NumericUpDown summa;
		private CheckBox nds;
		private ContragentUrLicoRecordSelectUserControl contragentUrLicoRecordSelectUserControl1;
		private Label label7;
		private TextBox opisanieLoma;
		private Label label8;
		private TextBox osnovanie;
		public ListView List;
		private ToolStrip ListBtnPanel;
		private ToolStripButton NewMetallVesPriceBtn;
		private ToolStripButton DeleteMetallVesPriceBtn;
		private ToolStrip bottomBtnPanel;
		private ToolStripButton SignBtn;
		private ToolStripButton CloseBtn;
		private Panel TopPanel;
		private Panel panel2;
		private ToolStripButton EditMetallVesPriceBtn;
		private ToolStripButton EditBtn;
		private MaskedTextBox docno;
		private ToolStripButton SaveBtn;
		private ToolStripSeparator toolStripSeparator1;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		public ListView HistoryList;
		private ToolStrip toolStrip2;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton toolStripButton1;
	}
}