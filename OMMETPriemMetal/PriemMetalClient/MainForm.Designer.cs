namespace PriemMetalClient
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.VesUpdateTimer = new System.Windows.Forms.Timer(this.components);
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.VesCountText = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
			this.VesDeviationText = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
			this.VesMainText = new System.Windows.Forms.ToolStripTextBox();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.PSAList = new System.Windows.Forms.ListView();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.NewPSADocumentBtn = new System.Windows.Forms.ToolStripButton();
			this.EditPSADocumentBtn = new System.Windows.Forms.ToolStripButton();
			this.DeletePSADocumentBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.новыйДокументToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.закупочныеЦеныНаМеталлоломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.контрагентыФизическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.контрагентыЮридическиеЛицаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.listView1 = new System.Windows.Forms.ListView();
			this.toolStrip3 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.финансыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.транзакцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.toolStrip2.SuspendLayout();
			this.tabPage5.SuspendLayout();
			this.toolStrip3.SuspendLayout();
			this.SuspendLayout();
			// 
			// VesUpdateTimer
			// 
			this.VesUpdateTimer.Enabled = true;
			this.VesUpdateTimer.Tick += new System.EventHandler(this.VesUpdateTimer_Tick);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.VesCountText,
            this.toolStripLabel3,
            this.VesDeviationText,
            this.toolStripLabel2,
            this.VesMainText,
            this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 445);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1036, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// VesCountText
			// 
			this.VesCountText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.VesCountText.Name = "VesCountText";
			this.VesCountText.ReadOnly = true;
			this.VesCountText.Size = new System.Drawing.Size(40, 25);
			this.VesCountText.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// toolStripLabel3
			// 
			this.toolStripLabel3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel3.Name = "toolStripLabel3";
			this.toolStripLabel3.Size = new System.Drawing.Size(120, 22);
			this.toolStripLabel3.Text = "Измерений за 10 сек";
			// 
			// VesDeviationText
			// 
			this.VesDeviationText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.VesDeviationText.Name = "VesDeviationText";
			this.VesDeviationText.ReadOnly = true;
			this.VesDeviationText.Size = new System.Drawing.Size(100, 25);
			this.VesDeviationText.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// toolStripLabel2
			// 
			this.toolStripLabel2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel2.Name = "toolStripLabel2";
			this.toolStripLabel2.Size = new System.Drawing.Size(133, 22);
			this.toolStripLabel2.Text = "Погрешность за 10 сек";
			// 
			// VesMainText
			// 
			this.VesMainText.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.VesMainText.BackColor = System.Drawing.Color.Green;
			this.VesMainText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.VesMainText.Name = "VesMainText";
			this.VesMainText.ReadOnly = true;
			this.VesMainText.Size = new System.Drawing.Size(100, 25);
			this.VesMainText.Text = "1000";
			this.VesMainText.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(156, 22);
			this.toolStripLabel1.Text = "Текущие показания весов: ";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 470);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1036, 22);
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.финансыToolStripMenuItem,
            this.сервисToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1036, 24);
			this.menuStrip1.TabIndex = 4;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйДокументToolStripMenuItem,
            this.toolStripMenuItem2,
            this.выходToolStripMenuItem});
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 6);
			// 
			// справочникиToolStripMenuItem
			// 
			this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закупочныеЦеныНаМеталлоломToolStripMenuItem,
            this.контрагентыФизическиеЛицаToolStripMenuItem,
            this.контрагентыЮридическиеЛицаToolStripMenuItem});
			this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
			this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
			this.справочникиToolStripMenuItem.Text = "Справочники";
			// 
			// сервисToolStripMenuItem
			// 
			this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem});
			this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
			this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.сервисToolStripMenuItem.Text = "Сервис";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 24);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1036, 421);
			this.tabControl1.TabIndex = 10;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.PSAList);
			this.tabPage1.Controls.Add(this.toolStrip2);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1028, 395);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Список документов";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// PSAList
			// 
			this.PSAList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PSAList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PSAList.FullRowSelect = true;
			this.PSAList.GridLines = true;
			this.PSAList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.PSAList.Location = new System.Drawing.Point(3, 57);
			this.PSAList.MultiSelect = false;
			this.PSAList.Name = "PSAList";
			this.PSAList.Size = new System.Drawing.Size(1022, 335);
			this.PSAList.TabIndex = 1;
			this.PSAList.UseCompatibleStateImageBehavior = false;
			this.PSAList.View = System.Windows.Forms.View.Details;
			// 
			// toolStrip2
			// 
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPSADocumentBtn,
            this.EditPSADocumentBtn,
            this.DeletePSADocumentBtn});
			this.toolStrip2.Location = new System.Drawing.Point(3, 3);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(1022, 54);
			this.toolStrip2.TabIndex = 0;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1028, 395);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1028, 395);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "new-file.png");
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// NewPSADocumentBtn
			// 
			this.NewPSADocumentBtn.Image = global::PriemMetalClient.Properties.Resources._173077___plus1;
			this.NewPSADocumentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewPSADocumentBtn.Name = "NewPSADocumentBtn";
			this.NewPSADocumentBtn.Size = new System.Drawing.Size(104, 51);
			this.NewPSADocumentBtn.Text = "Новый документ";
			this.NewPSADocumentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.NewPSADocumentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.NewPSADocumentBtn.Click += new System.EventHandler(this.NewPSADocumentBtn_Click);
			// 
			// EditPSADocumentBtn
			// 
			this.EditPSADocumentBtn.Image = global::PriemMetalClient.Properties.Resources._173002___edit;
			this.EditPSADocumentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditPSADocumentBtn.Name = "EditPSADocumentBtn";
			this.EditPSADocumentBtn.Size = new System.Drawing.Size(91, 51);
			this.EditPSADocumentBtn.Text = "Редактировать";
			this.EditPSADocumentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.EditPSADocumentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.EditPSADocumentBtn.Click += new System.EventHandler(this.EditPSADocumentBtn_Click);
			// 
			// DeletePSADocumentBtn
			// 
			this.DeletePSADocumentBtn.Image = global::PriemMetalClient.Properties.Resources._173055___minus;
			this.DeletePSADocumentBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeletePSADocumentBtn.Name = "DeletePSADocumentBtn";
			this.DeletePSADocumentBtn.Size = new System.Drawing.Size(55, 51);
			this.DeletePSADocumentBtn.Text = "Удалить";
			this.DeletePSADocumentBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.DeletePSADocumentBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.DeletePSADocumentBtn.Click += new System.EventHandler(this.DeletePSADocumentBtn_Click);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(120, 22);
			this.toolStripButton1.Text = "Перезагрузка порта";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1_Click);
			// 
			// новыйДокументToolStripMenuItem
			// 
			this.новыйДокументToolStripMenuItem.Image = global::PriemMetalClient.Properties.Resources._173002___edit;
			this.новыйДокументToolStripMenuItem.Name = "новыйДокументToolStripMenuItem";
			this.новыйДокументToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.новыйДокументToolStripMenuItem.Text = "Новый документ...";
			this.новыйДокументToolStripMenuItem.Click += new System.EventHandler(this.НовыйДокументToolStripMenuItem_Click);
			// 
			// выходToolStripMenuItem
			// 
			this.выходToolStripMenuItem.Image = global::PriemMetalClient.Properties.Resources._173050___logout;
			this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
			this.выходToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
			this.выходToolStripMenuItem.Text = "Выход";
			this.выходToolStripMenuItem.Click += new System.EventHandler(this.ВыходToolStripMenuItem_Click);
			// 
			// закупочныеЦеныНаМеталлоломToolStripMenuItem
			// 
			this.закупочныеЦеныНаМеталлоломToolStripMenuItem.Image = global::PriemMetalClient.Properties.Resources._173163___book;
			this.закупочныеЦеныНаМеталлоломToolStripMenuItem.Name = "закупочныеЦеныНаМеталлоломToolStripMenuItem";
			this.закупочныеЦеныНаМеталлоломToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.закупочныеЦеныНаМеталлоломToolStripMenuItem.Text = "Закупочные цены на металлолом";
			this.закупочныеЦеныНаМеталлоломToolStripMenuItem.Click += new System.EventHandler(this.ЗакупочныеЦеныНаМеталлоломToolStripMenuItem_Click);
			// 
			// контрагентыФизическиеЛицаToolStripMenuItem
			// 
			this.контрагентыФизическиеЛицаToolStripMenuItem.Image = global::PriemMetalClient.Properties.Resources._173163___book;
			this.контрагентыФизическиеЛицаToolStripMenuItem.Name = "контрагентыФизическиеЛицаToolStripMenuItem";
			this.контрагентыФизическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.контрагентыФизическиеЛицаToolStripMenuItem.Text = "Контрагенты: Физические лица";
			this.контрагентыФизическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.КонтрагентыФизическиеЛицаToolStripMenuItem_Click);
			// 
			// контрагентыЮридическиеЛицаToolStripMenuItem
			// 
			this.контрагентыЮридическиеЛицаToolStripMenuItem.Image = global::PriemMetalClient.Properties.Resources._173163___book;
			this.контрагентыЮридическиеЛицаToolStripMenuItem.Name = "контрагентыЮридическиеЛицаToolStripMenuItem";
			this.контрагентыЮридическиеЛицаToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
			this.контрагентыЮридическиеЛицаToolStripMenuItem.Text = "Контрагенты: Юридические лица";
			this.контрагентыЮридическиеЛицаToolStripMenuItem.Click += new System.EventHandler(this.КонтрагентыЮридическиеЛицаToolStripMenuItem_Click);
			// 
			// параметрыToolStripMenuItem
			// 
			this.параметрыToolStripMenuItem.Image = global::PriemMetalClient.Properties.Resources._173184___cog;
			this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
			this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.параметрыToolStripMenuItem.Text = "Параметры...";
			this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.ПараметрыToolStripMenuItem_Click);
			// 
			// tabPage4
			// 
			this.tabPage4.Location = new System.Drawing.Point(4, 22);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(1028, 395);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "tabPage4";
			this.tabPage4.UseVisualStyleBackColor = true;
			// 
			// tabPage5
			// 
			this.tabPage5.Controls.Add(this.listView1);
			this.tabPage5.Controls.Add(this.toolStrip3);
			this.tabPage5.Location = new System.Drawing.Point(4, 22);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage5.Size = new System.Drawing.Size(1028, 395);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "tabPage5";
			this.tabPage5.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(3, 57);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1022, 335);
			this.listView1.TabIndex = 3;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// toolStrip3
			// 
			this.toolStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
			this.toolStrip3.Location = new System.Drawing.Point(3, 3);
			this.toolStrip3.Name = "toolStrip3";
			this.toolStrip3.Size = new System.Drawing.Size(1022, 54);
			this.toolStrip3.TabIndex = 2;
			this.toolStrip3.Text = "toolStrip3";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.Image = global::PriemMetalClient.Properties.Resources._173077___plus1;
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(84, 51);
			this.toolStripButton2.Text = "Поступление";
			this.toolStripButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// финансыToolStripMenuItem
			// 
			this.финансыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.транзакцииToolStripMenuItem});
			this.финансыToolStripMenuItem.Name = "финансыToolStripMenuItem";
			this.финансыToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
			this.финансыToolStripMenuItem.Text = "Финансы";
			// 
			// транзакцииToolStripMenuItem
			// 
			this.транзакцииToolStripMenuItem.Name = "транзакцииToolStripMenuItem";
			this.транзакцииToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.транзакцииToolStripMenuItem.Text = "Транзакции";
			this.транзакцииToolStripMenuItem.Click += new System.EventHandler(this.транзакцииToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1036, 492);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.statusStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			this.toolStrip3.ResumeLayout(false);
			this.toolStrip3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Timer VesUpdateTimer;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripTextBox VesMainText;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
		private System.Windows.Forms.ToolStripTextBox VesCountText;
		private System.Windows.Forms.ToolStripLabel toolStripLabel3;
		private System.Windows.Forms.ToolStripTextBox VesDeviationText;
		private System.Windows.Forms.ToolStripLabel toolStripLabel2;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripMenuItem новыйДокументToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView PSAList;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton NewPSADocumentBtn;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem закупочныеЦеныНаМеталлоломToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem контрагентыФизическиеЛицаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem контрагентыЮридическиеЛицаToolStripMenuItem;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
		private System.Windows.Forms.ToolStripButton EditPSADocumentBtn;
		private System.Windows.Forms.ToolStripButton DeletePSADocumentBtn;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.ToolStripMenuItem финансыToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem транзакцииToolStripMenuItem;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ToolStrip toolStrip3;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
	}
}