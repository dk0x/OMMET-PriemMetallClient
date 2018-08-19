namespace PriemMetalClient.ModelView.Controls
{
	partial class PriemStep1
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

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.docNoLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.UrSelect = new System.Windows.Forms.RadioButton();
			this.FizSelect = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.alarm1Label = new System.Windows.Forms.Label();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.Next1Btn = new System.Windows.Forms.Button();
			this.Step1ContragentPanel = new System.Windows.Forms.Panel();
			this.contragentFizLico = new PriemMetalClient.ContragentFizLicoRecordSelectUserControl();
			this.contragentUrLico = new PriemMetalClient.ContragentUrLicoRecordSelectUserControl();
			this.Step2TransportPanel = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.alarm2Label = new System.Windows.Forms.Label();
			this.Back2Btn = new System.Windows.Forms.Button();
			this.Next2Btn = new System.Windows.Forms.Button();
			this.transport = new PriemMetalClient.TransportRecordSelectUserControl();
			this.label1 = new System.Windows.Forms.Label();
			this.Step3VesBruttoPanel = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.alarm3Label = new System.Windows.Forms.Label();
			this.Back3Btn = new System.Windows.Forms.Button();
			this.Next3Btn = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.VesBruttoDialogBtn = new System.Windows.Forms.Button();
			this.VesBruttoCustomBtn = new System.Windows.Forms.Button();
			this.bruttoTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Step4MetallCatPanel = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.alarm4Label = new System.Windows.Forms.Label();
			this.Back4Btn = new System.Windows.Forms.Button();
			this.Next4Btn = new System.Windows.Forms.Button();
			this.metallCat = new PriemMetalClient.MetallPriceRecordSelectUserControl();
			this.label5 = new System.Windows.Forms.Label();
			this.Step5ZasorPanel = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.alarm5Label = new System.Windows.Forms.Label();
			this.Back5Btn = new System.Windows.Forms.Button();
			this.Next5Btn = new System.Windows.Forms.Button();
			this.zasor = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.Step6TaraPanel = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.alarm6Btn = new System.Windows.Forms.Label();
			this.Back6Btn = new System.Windows.Forms.Button();
			this.Next6Btn = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.VesTaraDialogBtn = new System.Windows.Forms.Button();
			this.VesTaraCustomBtn = new System.Windows.Forms.Button();
			this.taraTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.Step1ContragentPanel.SuspendLayout();
			this.Step2TransportPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.Step3VesBruttoPanel.SuspendLayout();
			this.panel4.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.Step4MetallCatPanel.SuspendLayout();
			this.panel6.SuspendLayout();
			this.Step5ZasorPanel.SuspendLayout();
			this.panel7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.zasor)).BeginInit();
			this.Step6TaraPanel.SuspendLayout();
			this.panel8.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// docNoLabel
			// 
			this.docNoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.docNoLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.docNoLabel.Location = new System.Drawing.Point(0, 0);
			this.docNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.docNoLabel.Name = "docNoLabel";
			this.docNoLabel.Size = new System.Drawing.Size(289, 46);
			this.docNoLabel.TabIndex = 0;
			this.docNoLabel.Text = "Приемо сдаточный акт № от 23132132132132";
			this.docNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(4, 4);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(279, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Шаг 1: Выбор контрагента";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.UrSelect);
			this.panel1.Controls.Add(this.FizSelect);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(4, 27);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(279, 38);
			this.panel1.TabIndex = 4;
			// 
			// UrSelect
			// 
			this.UrSelect.AutoSize = true;
			this.UrSelect.Dock = System.Windows.Forms.DockStyle.Top;
			this.UrSelect.Location = new System.Drawing.Point(0, 17);
			this.UrSelect.Margin = new System.Windows.Forms.Padding(2);
			this.UrSelect.Name = "UrSelect";
			this.UrSelect.Size = new System.Drawing.Size(275, 17);
			this.UrSelect.TabIndex = 1;
			this.UrSelect.TabStop = true;
			this.UrSelect.Text = "Юридическое лицо";
			this.UrSelect.UseVisualStyleBackColor = true;
			this.UrSelect.CheckedChanged += new System.EventHandler(this.FizUrSelect_CheckedChanged);
			// 
			// FizSelect
			// 
			this.FizSelect.AutoSize = true;
			this.FizSelect.Dock = System.Windows.Forms.DockStyle.Top;
			this.FizSelect.Location = new System.Drawing.Point(0, 0);
			this.FizSelect.Margin = new System.Windows.Forms.Padding(2);
			this.FizSelect.Name = "FizSelect";
			this.FizSelect.Size = new System.Drawing.Size(275, 17);
			this.FizSelect.TabIndex = 0;
			this.FizSelect.TabStop = true;
			this.FizSelect.Text = "Физическое лицо";
			this.FizSelect.UseVisualStyleBackColor = true;
			this.FizSelect.CheckedChanged += new System.EventHandler(this.FizUrSelect_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.alarm1Label);
			this.panel2.Controls.Add(this.CancelBtn);
			this.panel2.Controls.Add(this.Next1Btn);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(4, 149);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(279, 25);
			this.panel2.TabIndex = 5;
			// 
			// alarm1Label
			// 
			this.alarm1Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.alarm1Label.ForeColor = System.Drawing.Color.Red;
			this.alarm1Label.Location = new System.Drawing.Point(56, 0);
			this.alarm1Label.Name = "alarm1Label";
			this.alarm1Label.Size = new System.Drawing.Size(170, 25);
			this.alarm1Label.TabIndex = 2;
			this.alarm1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CancelBtn
			// 
			this.CancelBtn.AutoSize = true;
			this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.CancelBtn.Location = new System.Drawing.Point(0, 0);
			this.CancelBtn.Margin = new System.Windows.Forms.Padding(2);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(56, 25);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "Отмена";
			this.CancelBtn.UseVisualStyleBackColor = true;
			// 
			// Next1Btn
			// 
			this.Next1Btn.AutoSize = true;
			this.Next1Btn.Dock = System.Windows.Forms.DockStyle.Right;
			this.Next1Btn.Location = new System.Drawing.Point(226, 0);
			this.Next1Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Next1Btn.Name = "Next1Btn";
			this.Next1Btn.Size = new System.Drawing.Size(53, 25);
			this.Next1Btn.TabIndex = 0;
			this.Next1Btn.Text = "Далее";
			this.Next1Btn.UseVisualStyleBackColor = true;
			this.Next1Btn.Click += new System.EventHandler(this.Next1Btn_Click);
			// 
			// Step1ContragentPanel
			// 
			this.Step1ContragentPanel.AutoSize = true;
			this.Step1ContragentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Step1ContragentPanel.Controls.Add(this.panel2);
			this.Step1ContragentPanel.Controls.Add(this.contragentFizLico);
			this.Step1ContragentPanel.Controls.Add(this.contragentUrLico);
			this.Step1ContragentPanel.Controls.Add(this.panel1);
			this.Step1ContragentPanel.Controls.Add(this.label2);
			this.Step1ContragentPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step1ContragentPanel.Location = new System.Drawing.Point(0, 46);
			this.Step1ContragentPanel.Name = "Step1ContragentPanel";
			this.Step1ContragentPanel.Padding = new System.Windows.Forms.Padding(4);
			this.Step1ContragentPanel.Size = new System.Drawing.Size(289, 180);
			this.Step1ContragentPanel.TabIndex = 8;
			// 
			// contragentFizLico
			// 
			this.contragentFizLico.AutoSize = true;
			this.contragentFizLico.Dock = System.Windows.Forms.DockStyle.Top;
			this.contragentFizLico.Location = new System.Drawing.Point(4, 107);
			this.contragentFizLico.MinimumSize = new System.Drawing.Size(100, 40);
			this.contragentFizLico.Name = "contragentFizLico";
			this.contragentFizLico.Size = new System.Drawing.Size(279, 42);
			this.contragentFizLico.TabIndex = 6;
			this.contragentFizLico.RecordSelect += new PriemMetalClient.BaseRecordSelectUserControl<PriemMetalClient.ContragentFizLico>.RecordSelectHandler(this.contragentFizLico_RecordSelect);
			// 
			// contragentUrLico
			// 
			this.contragentUrLico.AutoSize = true;
			this.contragentUrLico.Dock = System.Windows.Forms.DockStyle.Top;
			this.contragentUrLico.Location = new System.Drawing.Point(4, 65);
			this.contragentUrLico.MinimumSize = new System.Drawing.Size(100, 40);
			this.contragentUrLico.Name = "contragentUrLico";
			this.contragentUrLico.Size = new System.Drawing.Size(279, 42);
			this.contragentUrLico.TabIndex = 7;
			this.contragentUrLico.RecordSelect += new PriemMetalClient.BaseRecordSelectUserControl<PriemMetalClient.ContragentUrLico>.RecordSelectHandler(this.contragentUrLico_RecordSelect);
			// 
			// Step2TransportPanel
			// 
			this.Step2TransportPanel.AutoSize = true;
			this.Step2TransportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Step2TransportPanel.Controls.Add(this.panel3);
			this.Step2TransportPanel.Controls.Add(this.transport);
			this.Step2TransportPanel.Controls.Add(this.label1);
			this.Step2TransportPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step2TransportPanel.Location = new System.Drawing.Point(0, 226);
			this.Step2TransportPanel.Name = "Step2TransportPanel";
			this.Step2TransportPanel.Padding = new System.Windows.Forms.Padding(4);
			this.Step2TransportPanel.Size = new System.Drawing.Size(289, 100);
			this.Step2TransportPanel.TabIndex = 9;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.alarm2Label);
			this.panel3.Controls.Add(this.Back2Btn);
			this.panel3.Controls.Add(this.Next2Btn);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(4, 69);
			this.panel3.Margin = new System.Windows.Forms.Padding(2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(279, 25);
			this.panel3.TabIndex = 6;
			// 
			// alarm2Label
			// 
			this.alarm2Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.alarm2Label.ForeColor = System.Drawing.Color.Red;
			this.alarm2Label.Location = new System.Drawing.Point(56, 0);
			this.alarm2Label.Name = "alarm2Label";
			this.alarm2Label.Size = new System.Drawing.Size(170, 25);
			this.alarm2Label.TabIndex = 2;
			this.alarm2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Back2Btn
			// 
			this.Back2Btn.AutoSize = true;
			this.Back2Btn.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back2Btn.Location = new System.Drawing.Point(0, 0);
			this.Back2Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Back2Btn.Name = "Back2Btn";
			this.Back2Btn.Size = new System.Drawing.Size(56, 25);
			this.Back2Btn.TabIndex = 1;
			this.Back2Btn.Text = "Назад";
			this.Back2Btn.UseVisualStyleBackColor = true;
			// 
			// Next2Btn
			// 
			this.Next2Btn.AutoSize = true;
			this.Next2Btn.Dock = System.Windows.Forms.DockStyle.Right;
			this.Next2Btn.Location = new System.Drawing.Point(226, 0);
			this.Next2Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Next2Btn.Name = "Next2Btn";
			this.Next2Btn.Size = new System.Drawing.Size(53, 25);
			this.Next2Btn.TabIndex = 0;
			this.Next2Btn.Text = "Далее";
			this.Next2Btn.UseVisualStyleBackColor = true;
			this.Next2Btn.Click += new System.EventHandler(this.Next2Btn_Click);
			// 
			// transport
			// 
			this.transport.AutoSize = true;
			this.transport.Dock = System.Windows.Forms.DockStyle.Top;
			this.transport.Location = new System.Drawing.Point(4, 27);
			this.transport.MinimumSize = new System.Drawing.Size(100, 40);
			this.transport.Name = "transport";
			this.transport.Size = new System.Drawing.Size(279, 42);
			this.transport.TabIndex = 3;
			this.transport.RecordSelect += new PriemMetalClient.BaseRecordSelectUserControl<PriemMetalClient.Transport>.RecordSelectHandler(this.transport_RecordSelect);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(279, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Шаг 2: Выбор транспорта";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step3VesBruttoPanel
			// 
			this.Step3VesBruttoPanel.AutoSize = true;
			this.Step3VesBruttoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Step3VesBruttoPanel.Controls.Add(this.panel4);
			this.Step3VesBruttoPanel.Controls.Add(this.tableLayoutPanel1);
			this.Step3VesBruttoPanel.Controls.Add(this.bruttoTextBox);
			this.Step3VesBruttoPanel.Controls.Add(this.label3);
			this.Step3VesBruttoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step3VesBruttoPanel.Location = new System.Drawing.Point(0, 326);
			this.Step3VesBruttoPanel.Name = "Step3VesBruttoPanel";
			this.Step3VesBruttoPanel.Padding = new System.Windows.Forms.Padding(4);
			this.Step3VesBruttoPanel.Size = new System.Drawing.Size(289, 119);
			this.Step3VesBruttoPanel.TabIndex = 10;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.alarm3Label);
			this.panel4.Controls.Add(this.Back3Btn);
			this.panel4.Controls.Add(this.Next3Btn);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(4, 88);
			this.panel4.Margin = new System.Windows.Forms.Padding(2);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(279, 25);
			this.panel4.TabIndex = 13;
			// 
			// alarm3Label
			// 
			this.alarm3Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.alarm3Label.ForeColor = System.Drawing.Color.Red;
			this.alarm3Label.Location = new System.Drawing.Point(56, 0);
			this.alarm3Label.Name = "alarm3Label";
			this.alarm3Label.Size = new System.Drawing.Size(170, 25);
			this.alarm3Label.TabIndex = 2;
			this.alarm3Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Back3Btn
			// 
			this.Back3Btn.AutoSize = true;
			this.Back3Btn.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back3Btn.Location = new System.Drawing.Point(0, 0);
			this.Back3Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Back3Btn.Name = "Back3Btn";
			this.Back3Btn.Size = new System.Drawing.Size(56, 25);
			this.Back3Btn.TabIndex = 1;
			this.Back3Btn.Text = "Назад";
			this.Back3Btn.UseVisualStyleBackColor = true;
			// 
			// Next3Btn
			// 
			this.Next3Btn.AutoSize = true;
			this.Next3Btn.Dock = System.Windows.Forms.DockStyle.Right;
			this.Next3Btn.Location = new System.Drawing.Point(226, 0);
			this.Next3Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Next3Btn.Name = "Next3Btn";
			this.Next3Btn.Size = new System.Drawing.Size(53, 25);
			this.Next3Btn.TabIndex = 0;
			this.Next3Btn.Text = "Далее";
			this.Next3Btn.UseVisualStyleBackColor = true;
			this.Next3Btn.Click += new System.EventHandler(this.Next3Btn_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.VesBruttoDialogBtn, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.VesBruttoCustomBtn, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 47);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(279, 41);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// VesBruttoDialogBtn
			// 
			this.VesBruttoDialogBtn.AutoSize = true;
			this.VesBruttoDialogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VesBruttoDialogBtn.Location = new System.Drawing.Point(2, 2);
			this.VesBruttoDialogBtn.Margin = new System.Windows.Forms.Padding(2);
			this.VesBruttoDialogBtn.Name = "VesBruttoDialogBtn";
			this.VesBruttoDialogBtn.Size = new System.Drawing.Size(135, 37);
			this.VesBruttoDialogBtn.TabIndex = 0;
			this.VesBruttoDialogBtn.Text = "Снаять показания \r\nс весов...";
			this.VesBruttoDialogBtn.UseVisualStyleBackColor = true;
			this.VesBruttoDialogBtn.Click += new System.EventHandler(this.VesBruttoDialogBtn_Click);
			// 
			// VesBruttoCustomBtn
			// 
			this.VesBruttoCustomBtn.AutoSize = true;
			this.VesBruttoCustomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VesBruttoCustomBtn.Location = new System.Drawing.Point(141, 2);
			this.VesBruttoCustomBtn.Margin = new System.Windows.Forms.Padding(2);
			this.VesBruttoCustomBtn.Name = "VesBruttoCustomBtn";
			this.VesBruttoCustomBtn.Size = new System.Drawing.Size(136, 37);
			this.VesBruttoCustomBtn.TabIndex = 1;
			this.VesBruttoCustomBtn.Text = "Ввести вручную...";
			this.VesBruttoCustomBtn.UseVisualStyleBackColor = true;
			this.VesBruttoCustomBtn.Click += new System.EventHandler(this.VesBruttoCustomBtn_Click);
			// 
			// bruttoTextBox
			// 
			this.bruttoTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.bruttoTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.bruttoTextBox.Location = new System.Drawing.Point(4, 27);
			this.bruttoTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.bruttoTextBox.Name = "bruttoTextBox";
			this.bruttoTextBox.ReadOnly = true;
			this.bruttoTextBox.Size = new System.Drawing.Size(279, 20);
			this.bruttoTextBox.TabIndex = 12;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(4, 4);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(279, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Шаг 3: Масса БРУТТО (до разгрузки транспорта)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step4MetallCatPanel
			// 
			this.Step4MetallCatPanel.AutoSize = true;
			this.Step4MetallCatPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Step4MetallCatPanel.Controls.Add(this.panel6);
			this.Step4MetallCatPanel.Controls.Add(this.metallCat);
			this.Step4MetallCatPanel.Controls.Add(this.label5);
			this.Step4MetallCatPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step4MetallCatPanel.Location = new System.Drawing.Point(0, 445);
			this.Step4MetallCatPanel.Name = "Step4MetallCatPanel";
			this.Step4MetallCatPanel.Padding = new System.Windows.Forms.Padding(4);
			this.Step4MetallCatPanel.Size = new System.Drawing.Size(289, 100);
			this.Step4MetallCatPanel.TabIndex = 11;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.alarm4Label);
			this.panel6.Controls.Add(this.Back4Btn);
			this.panel6.Controls.Add(this.Next4Btn);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(4, 69);
			this.panel6.Margin = new System.Windows.Forms.Padding(2);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(279, 25);
			this.panel6.TabIndex = 6;
			// 
			// alarm4Label
			// 
			this.alarm4Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.alarm4Label.ForeColor = System.Drawing.Color.Red;
			this.alarm4Label.Location = new System.Drawing.Point(56, 0);
			this.alarm4Label.Name = "alarm4Label";
			this.alarm4Label.Size = new System.Drawing.Size(170, 25);
			this.alarm4Label.TabIndex = 2;
			this.alarm4Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Back4Btn
			// 
			this.Back4Btn.AutoSize = true;
			this.Back4Btn.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back4Btn.Location = new System.Drawing.Point(0, 0);
			this.Back4Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Back4Btn.Name = "Back4Btn";
			this.Back4Btn.Size = new System.Drawing.Size(56, 25);
			this.Back4Btn.TabIndex = 1;
			this.Back4Btn.Text = "Назад";
			this.Back4Btn.UseVisualStyleBackColor = true;
			// 
			// Next4Btn
			// 
			this.Next4Btn.AutoSize = true;
			this.Next4Btn.Dock = System.Windows.Forms.DockStyle.Right;
			this.Next4Btn.Location = new System.Drawing.Point(226, 0);
			this.Next4Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Next4Btn.Name = "Next4Btn";
			this.Next4Btn.Size = new System.Drawing.Size(53, 25);
			this.Next4Btn.TabIndex = 0;
			this.Next4Btn.Text = "Далее";
			this.Next4Btn.UseVisualStyleBackColor = true;
			this.Next4Btn.Click += new System.EventHandler(this.Next4Btn_Click);
			// 
			// metallCat
			// 
			this.metallCat.AutoSize = true;
			this.metallCat.Dock = System.Windows.Forms.DockStyle.Top;
			this.metallCat.Location = new System.Drawing.Point(4, 27);
			this.metallCat.Margin = new System.Windows.Forms.Padding(2);
			this.metallCat.MinimumSize = new System.Drawing.Size(75, 32);
			this.metallCat.Name = "metallCat";
			this.metallCat.Size = new System.Drawing.Size(279, 42);
			this.metallCat.TabIndex = 7;
			this.metallCat.RecordSelect += new PriemMetalClient.BaseRecordSelectUserControl<PriemMetalClient.MetallPrice>.RecordSelectHandler(this.metallCat_RecordSelect);
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Top;
			this.label5.Location = new System.Drawing.Point(4, 4);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(279, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Шаг 4: Выбор категории металлолома";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step5ZasorPanel
			// 
			this.Step5ZasorPanel.AutoSize = true;
			this.Step5ZasorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Step5ZasorPanel.Controls.Add(this.panel7);
			this.Step5ZasorPanel.Controls.Add(this.zasor);
			this.Step5ZasorPanel.Controls.Add(this.label6);
			this.Step5ZasorPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step5ZasorPanel.Location = new System.Drawing.Point(0, 545);
			this.Step5ZasorPanel.Name = "Step5ZasorPanel";
			this.Step5ZasorPanel.Padding = new System.Windows.Forms.Padding(4);
			this.Step5ZasorPanel.Size = new System.Drawing.Size(289, 78);
			this.Step5ZasorPanel.TabIndex = 12;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.alarm5Label);
			this.panel7.Controls.Add(this.Back5Btn);
			this.panel7.Controls.Add(this.Next5Btn);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(4, 47);
			this.panel7.Margin = new System.Windows.Forms.Padding(2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(279, 25);
			this.panel7.TabIndex = 6;
			// 
			// alarm5Label
			// 
			this.alarm5Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.alarm5Label.ForeColor = System.Drawing.Color.Red;
			this.alarm5Label.Location = new System.Drawing.Point(56, 0);
			this.alarm5Label.Name = "alarm5Label";
			this.alarm5Label.Size = new System.Drawing.Size(170, 25);
			this.alarm5Label.TabIndex = 2;
			this.alarm5Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Back5Btn
			// 
			this.Back5Btn.AutoSize = true;
			this.Back5Btn.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back5Btn.Location = new System.Drawing.Point(0, 0);
			this.Back5Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Back5Btn.Name = "Back5Btn";
			this.Back5Btn.Size = new System.Drawing.Size(56, 25);
			this.Back5Btn.TabIndex = 1;
			this.Back5Btn.Text = "Назад";
			this.Back5Btn.UseVisualStyleBackColor = true;
			// 
			// Next5Btn
			// 
			this.Next5Btn.AutoSize = true;
			this.Next5Btn.Dock = System.Windows.Forms.DockStyle.Right;
			this.Next5Btn.Location = new System.Drawing.Point(226, 0);
			this.Next5Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Next5Btn.Name = "Next5Btn";
			this.Next5Btn.Size = new System.Drawing.Size(53, 25);
			this.Next5Btn.TabIndex = 0;
			this.Next5Btn.Text = "Далее";
			this.Next5Btn.UseVisualStyleBackColor = true;
			this.Next5Btn.Click += new System.EventHandler(this.Next5Btn_Click);
			// 
			// zasor
			// 
			this.zasor.Dock = System.Windows.Forms.DockStyle.Top;
			this.zasor.Location = new System.Drawing.Point(4, 27);
			this.zasor.Margin = new System.Windows.Forms.Padding(2);
			this.zasor.Name = "zasor";
			this.zasor.Size = new System.Drawing.Size(279, 20);
			this.zasor.TabIndex = 7;
			this.zasor.ThousandsSeparator = true;
			this.zasor.ValueChanged += new System.EventHandler(this.zasor_ValueChanged);
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Top;
			this.label6.Location = new System.Drawing.Point(4, 4);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(279, 23);
			this.label6.TabIndex = 2;
			this.label6.Text = "Шаг 5: Ввод процента засора металла (%)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step6TaraPanel
			// 
			this.Step6TaraPanel.AutoSize = true;
			this.Step6TaraPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Step6TaraPanel.Controls.Add(this.panel8);
			this.Step6TaraPanel.Controls.Add(this.tableLayoutPanel2);
			this.Step6TaraPanel.Controls.Add(this.taraTextBox);
			this.Step6TaraPanel.Controls.Add(this.label7);
			this.Step6TaraPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step6TaraPanel.Location = new System.Drawing.Point(0, 623);
			this.Step6TaraPanel.Name = "Step6TaraPanel";
			this.Step6TaraPanel.Padding = new System.Windows.Forms.Padding(4);
			this.Step6TaraPanel.Size = new System.Drawing.Size(289, 119);
			this.Step6TaraPanel.TabIndex = 13;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.alarm6Btn);
			this.panel8.Controls.Add(this.Back6Btn);
			this.panel8.Controls.Add(this.Next6Btn);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel8.Location = new System.Drawing.Point(4, 88);
			this.panel8.Margin = new System.Windows.Forms.Padding(2);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(279, 25);
			this.panel8.TabIndex = 6;
			// 
			// alarm6Btn
			// 
			this.alarm6Btn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.alarm6Btn.ForeColor = System.Drawing.Color.Red;
			this.alarm6Btn.Location = new System.Drawing.Point(56, 0);
			this.alarm6Btn.Name = "alarm6Btn";
			this.alarm6Btn.Size = new System.Drawing.Size(170, 25);
			this.alarm6Btn.TabIndex = 2;
			this.alarm6Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Back6Btn
			// 
			this.Back6Btn.AutoSize = true;
			this.Back6Btn.Dock = System.Windows.Forms.DockStyle.Left;
			this.Back6Btn.Location = new System.Drawing.Point(0, 0);
			this.Back6Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Back6Btn.Name = "Back6Btn";
			this.Back6Btn.Size = new System.Drawing.Size(56, 25);
			this.Back6Btn.TabIndex = 1;
			this.Back6Btn.Text = "Назад";
			this.Back6Btn.UseVisualStyleBackColor = true;
			// 
			// Next6Btn
			// 
			this.Next6Btn.AutoSize = true;
			this.Next6Btn.Dock = System.Windows.Forms.DockStyle.Right;
			this.Next6Btn.Location = new System.Drawing.Point(226, 0);
			this.Next6Btn.Margin = new System.Windows.Forms.Padding(2);
			this.Next6Btn.Name = "Next6Btn";
			this.Next6Btn.Size = new System.Drawing.Size(53, 25);
			this.Next6Btn.TabIndex = 0;
			this.Next6Btn.Text = "Далее";
			this.Next6Btn.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.VesTaraDialogBtn, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.VesTaraCustomBtn, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 47);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 41);
			this.tableLayoutPanel2.TabIndex = 13;
			// 
			// VesTaraDialogBtn
			// 
			this.VesTaraDialogBtn.AutoSize = true;
			this.VesTaraDialogBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VesTaraDialogBtn.Location = new System.Drawing.Point(2, 2);
			this.VesTaraDialogBtn.Margin = new System.Windows.Forms.Padding(2);
			this.VesTaraDialogBtn.Name = "VesTaraDialogBtn";
			this.VesTaraDialogBtn.Size = new System.Drawing.Size(135, 37);
			this.VesTaraDialogBtn.TabIndex = 0;
			this.VesTaraDialogBtn.Text = "Снаять показания \r\nс весов...";
			this.VesTaraDialogBtn.UseVisualStyleBackColor = true;
			this.VesTaraDialogBtn.Click += new System.EventHandler(this.VesTaraDialogBtn_Click);
			// 
			// VesTaraCustomBtn
			// 
			this.VesTaraCustomBtn.AutoSize = true;
			this.VesTaraCustomBtn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VesTaraCustomBtn.Location = new System.Drawing.Point(141, 2);
			this.VesTaraCustomBtn.Margin = new System.Windows.Forms.Padding(2);
			this.VesTaraCustomBtn.Name = "VesTaraCustomBtn";
			this.VesTaraCustomBtn.Size = new System.Drawing.Size(136, 37);
			this.VesTaraCustomBtn.TabIndex = 1;
			this.VesTaraCustomBtn.Text = "Ввести вручную...";
			this.VesTaraCustomBtn.UseVisualStyleBackColor = true;
			this.VesTaraCustomBtn.Click += new System.EventHandler(this.VesTaraCustomBtn_Click);
			// 
			// taraTextBox
			// 
			this.taraTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.taraTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.taraTextBox.Location = new System.Drawing.Point(4, 27);
			this.taraTextBox.Margin = new System.Windows.Forms.Padding(2);
			this.taraTextBox.Name = "taraTextBox";
			this.taraTextBox.ReadOnly = true;
			this.taraTextBox.Size = new System.Drawing.Size(279, 20);
			this.taraTextBox.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Top;
			this.label7.Location = new System.Drawing.Point(4, 4);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(279, 23);
			this.label7.TabIndex = 2;
			this.label7.Text = "Шаг 6: Масса ТАРЫ (после разгрузки транспорта)";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PriemStep1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.Step6TaraPanel);
			this.Controls.Add(this.Step5ZasorPanel);
			this.Controls.Add(this.Step4MetallCatPanel);
			this.Controls.Add(this.Step3VesBruttoPanel);
			this.Controls.Add(this.Step2TransportPanel);
			this.Controls.Add(this.Step1ContragentPanel);
			this.Controls.Add(this.docNoLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "PriemStep1";
			this.Size = new System.Drawing.Size(289, 986);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.Step1ContragentPanel.ResumeLayout(false);
			this.Step1ContragentPanel.PerformLayout();
			this.Step2TransportPanel.ResumeLayout(false);
			this.Step2TransportPanel.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.Step3VesBruttoPanel.ResumeLayout(false);
			this.Step3VesBruttoPanel.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.Step4MetallCatPanel.ResumeLayout(false);
			this.Step4MetallCatPanel.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.Step5ZasorPanel.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.zasor)).EndInit();
			this.Step6TaraPanel.ResumeLayout(false);
			this.Step6TaraPanel.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label docNoLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton UrSelect;
		private System.Windows.Forms.RadioButton FizSelect;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.Button Next1Btn;
		private ContragentFizLicoRecordSelectUserControl contragentFizLico;
		private ContragentUrLicoRecordSelectUserControl contragentUrLico;
		private System.Windows.Forms.Label alarm1Label;
		private System.Windows.Forms.Panel Step1ContragentPanel;
		private System.Windows.Forms.Panel Step2TransportPanel;
		private TransportRecordSelectUserControl transport;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel Step3VesBruttoPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label alarm2Label;
		private System.Windows.Forms.Button Back2Btn;
		private System.Windows.Forms.Button Next2Btn;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button VesBruttoDialogBtn;
		private System.Windows.Forms.Button VesBruttoCustomBtn;
		private System.Windows.Forms.TextBox bruttoTextBox;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Label alarm3Label;
		private System.Windows.Forms.Button Back3Btn;
		private System.Windows.Forms.Button Next3Btn;
		private System.Windows.Forms.Panel Step4MetallCatPanel;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label alarm4Label;
		private System.Windows.Forms.Button Back4Btn;
		private System.Windows.Forms.Button Next4Btn;
		private MetallPriceRecordSelectUserControl metallCat;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel Step5ZasorPanel;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label alarm5Label;
		private System.Windows.Forms.Button Back5Btn;
		private System.Windows.Forms.Button Next5Btn;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown zasor;
		private System.Windows.Forms.Panel Step6TaraPanel;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label alarm6Btn;
		private System.Windows.Forms.Button Back6Btn;
		private System.Windows.Forms.Button Next6Btn;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button VesTaraDialogBtn;
		private System.Windows.Forms.Button VesTaraCustomBtn;
		private System.Windows.Forms.TextBox taraTextBox;
	}
}
