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
			this.alarmLabel = new System.Windows.Forms.Label();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.NextBtn = new System.Windows.Forms.Button();
			this.Step1ContragentPanel = new System.Windows.Forms.Panel();
			this.Step2TransportPanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.Step3VesBruttoPanel = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.transportRecordSelectUserControl1 = new PriemMetalClient.TransportRecordSelectUserControl();
			this.contragentFizLicoRecordSelectUserControl1 = new PriemMetalClient.ContragentFizLicoRecordSelectUserControl();
			this.contragentUrLicoRecordSelectUserControl1 = new PriemMetalClient.ContragentUrLicoRecordSelectUserControl();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.Step1ContragentPanel.SuspendLayout();
			this.Step2TransportPanel.SuspendLayout();
			this.Step3VesBruttoPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// docNoLabel
			// 
			this.docNoLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.docNoLabel.Dock = System.Windows.Forms.DockStyle.Top;
			this.docNoLabel.Location = new System.Drawing.Point(0, 0);
			this.docNoLabel.Name = "docNoLabel";
			this.docNoLabel.Size = new System.Drawing.Size(444, 57);
			this.docNoLabel.TabIndex = 0;
			this.docNoLabel.Text = "Приемо сдаточный акт № от 23132132132132";
			this.docNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(442, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Выбор контрагента";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.UrSelect);
			this.panel1.Controls.Add(this.FizSelect);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 28);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(442, 44);
			this.panel1.TabIndex = 4;
			// 
			// UrSelect
			// 
			this.UrSelect.AutoSize = true;
			this.UrSelect.Dock = System.Windows.Forms.DockStyle.Top;
			this.UrSelect.Location = new System.Drawing.Point(0, 20);
			this.UrSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.UrSelect.Name = "UrSelect";
			this.UrSelect.Size = new System.Drawing.Size(438, 20);
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
			this.FizSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.FizSelect.Name = "FizSelect";
			this.FizSelect.Size = new System.Drawing.Size(438, 20);
			this.FizSelect.TabIndex = 0;
			this.FizSelect.TabStop = true;
			this.FizSelect.Text = "Физическое лицо";
			this.FizSelect.UseVisualStyleBackColor = true;
			this.FizSelect.CheckedChanged += new System.EventHandler(this.FizUrSelect_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.alarmLabel);
			this.panel2.Controls.Add(this.CancelBtn);
			this.panel2.Controls.Add(this.NextBtn);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 170);
			this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(442, 31);
			this.panel2.TabIndex = 5;
			// 
			// alarmLabel
			// 
			this.alarmLabel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.alarmLabel.ForeColor = System.Drawing.Color.Red;
			this.alarmLabel.Location = new System.Drawing.Point(75, 0);
			this.alarmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.alarmLabel.Name = "alarmLabel";
			this.alarmLabel.Size = new System.Drawing.Size(296, 31);
			this.alarmLabel.TabIndex = 2;
			this.alarmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// CancelBtn
			// 
			this.CancelBtn.AutoSize = true;
			this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Left;
			this.CancelBtn.Location = new System.Drawing.Point(0, 0);
			this.CancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(75, 31);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "Отмена";
			this.CancelBtn.UseVisualStyleBackColor = true;
			// 
			// NextBtn
			// 
			this.NextBtn.AutoSize = true;
			this.NextBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.NextBtn.Location = new System.Drawing.Point(371, 0);
			this.NextBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NextBtn.Name = "NextBtn";
			this.NextBtn.Size = new System.Drawing.Size(71, 31);
			this.NextBtn.TabIndex = 0;
			this.NextBtn.Text = "Далее";
			this.NextBtn.UseVisualStyleBackColor = true;
			this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
			// 
			// Step1ContragentPanel
			// 
			this.Step1ContragentPanel.AutoSize = true;
			this.Step1ContragentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Step1ContragentPanel.Controls.Add(this.panel2);
			this.Step1ContragentPanel.Controls.Add(this.contragentFizLicoRecordSelectUserControl1);
			this.Step1ContragentPanel.Controls.Add(this.contragentUrLicoRecordSelectUserControl1);
			this.Step1ContragentPanel.Controls.Add(this.panel1);
			this.Step1ContragentPanel.Controls.Add(this.label2);
			this.Step1ContragentPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step1ContragentPanel.Location = new System.Drawing.Point(0, 57);
			this.Step1ContragentPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Step1ContragentPanel.Name = "Step1ContragentPanel";
			this.Step1ContragentPanel.Size = new System.Drawing.Size(444, 203);
			this.Step1ContragentPanel.TabIndex = 8;
			// 
			// Step2TransportPanel
			// 
			this.Step2TransportPanel.AutoSize = true;
			this.Step2TransportPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Step2TransportPanel.Controls.Add(this.panel3);
			this.Step2TransportPanel.Controls.Add(this.transportRecordSelectUserControl1);
			this.Step2TransportPanel.Controls.Add(this.label1);
			this.Step2TransportPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step2TransportPanel.Location = new System.Drawing.Point(0, 260);
			this.Step2TransportPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Step2TransportPanel.Name = "Step2TransportPanel";
			this.Step2TransportPanel.Size = new System.Drawing.Size(444, 110);
			this.Step2TransportPanel.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(442, 28);
			this.label1.TabIndex = 2;
			this.label1.Text = "Выбор транспорта";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step3VesBruttoPanel
			// 
			this.Step3VesBruttoPanel.Controls.Add(this.label3);
			this.Step3VesBruttoPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.Step3VesBruttoPanel.Location = new System.Drawing.Point(0, 370);
			this.Step3VesBruttoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Step3VesBruttoPanel.Name = "Step3VesBruttoPanel";
			this.Step3VesBruttoPanel.Size = new System.Drawing.Size(444, 197);
			this.Step3VesBruttoPanel.TabIndex = 10;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(444, 28);
			this.label3.TabIndex = 3;
			this.label3.Text = "Взвешивание Брутто (до разгрузки металла)";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// transportRecordSelectUserControl1
			// 
			this.transportRecordSelectUserControl1.AutoSize = true;
			this.transportRecordSelectUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.transportRecordSelectUserControl1.Location = new System.Drawing.Point(0, 28);
			this.transportRecordSelectUserControl1.Margin = new System.Windows.Forms.Padding(4);
			this.transportRecordSelectUserControl1.MinimumSize = new System.Drawing.Size(133, 49);
			this.transportRecordSelectUserControl1.Name = "transportRecordSelectUserControl1";
			this.transportRecordSelectUserControl1.Size = new System.Drawing.Size(442, 49);
			this.transportRecordSelectUserControl1.TabIndex = 3;
			// 
			// contragentFizLicoRecordSelectUserControl1
			// 
			this.contragentFizLicoRecordSelectUserControl1.AutoSize = true;
			this.contragentFizLicoRecordSelectUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.contragentFizLicoRecordSelectUserControl1.Location = new System.Drawing.Point(0, 121);
			this.contragentFizLicoRecordSelectUserControl1.Margin = new System.Windows.Forms.Padding(4);
			this.contragentFizLicoRecordSelectUserControl1.MinimumSize = new System.Drawing.Size(133, 49);
			this.contragentFizLicoRecordSelectUserControl1.Name = "contragentFizLicoRecordSelectUserControl1";
			this.contragentFizLicoRecordSelectUserControl1.Size = new System.Drawing.Size(442, 49);
			this.contragentFizLicoRecordSelectUserControl1.TabIndex = 6;
			this.contragentFizLicoRecordSelectUserControl1.RecordSelect += new PriemMetalClient.BaseRecordSelectUserControl<PriemMetalClient.ContragentFizLico>.RecordSelectHandler(this.contragentFizLicoRecordSelectUserControl1_RecordSelect);
			// 
			// contragentUrLicoRecordSelectUserControl1
			// 
			this.contragentUrLicoRecordSelectUserControl1.AutoSize = true;
			this.contragentUrLicoRecordSelectUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.contragentUrLicoRecordSelectUserControl1.Location = new System.Drawing.Point(0, 72);
			this.contragentUrLicoRecordSelectUserControl1.Margin = new System.Windows.Forms.Padding(4);
			this.contragentUrLicoRecordSelectUserControl1.MinimumSize = new System.Drawing.Size(133, 49);
			this.contragentUrLicoRecordSelectUserControl1.Name = "contragentUrLicoRecordSelectUserControl1";
			this.contragentUrLicoRecordSelectUserControl1.Size = new System.Drawing.Size(442, 49);
			this.contragentUrLicoRecordSelectUserControl1.TabIndex = 7;
			this.contragentUrLicoRecordSelectUserControl1.RecordSelect += new PriemMetalClient.BaseRecordSelectUserControl<PriemMetalClient.ContragentUrLico>.RecordSelectHandler(this.contragentUrLicoRecordSelectUserControl1_RecordSelect);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 77);
			this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(442, 31);
			this.panel3.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(75, 0);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(296, 31);
			this.label4.TabIndex = 2;
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Dock = System.Windows.Forms.DockStyle.Left;
			this.button1.Location = new System.Drawing.Point(0, 0);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 31);
			this.button1.TabIndex = 1;
			this.button1.Text = "Назад";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Dock = System.Windows.Forms.DockStyle.Right;
			this.button2.Location = new System.Drawing.Point(371, 0);
			this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 31);
			this.button2.TabIndex = 0;
			this.button2.Text = "Далее";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// PriemStep1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.Controls.Add(this.Step3VesBruttoPanel);
			this.Controls.Add(this.Step2TransportPanel);
			this.Controls.Add(this.Step1ContragentPanel);
			this.Controls.Add(this.docNoLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "PriemStep1";
			this.Size = new System.Drawing.Size(444, 693);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.Step1ContragentPanel.ResumeLayout(false);
			this.Step1ContragentPanel.PerformLayout();
			this.Step2TransportPanel.ResumeLayout(false);
			this.Step2TransportPanel.PerformLayout();
			this.Step3VesBruttoPanel.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
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
		private System.Windows.Forms.Button NextBtn;
		private ContragentFizLicoRecordSelectUserControl contragentFizLicoRecordSelectUserControl1;
		private ContragentUrLicoRecordSelectUserControl contragentUrLicoRecordSelectUserControl1;
		private System.Windows.Forms.Label alarmLabel;
		private System.Windows.Forms.Panel Step1ContragentPanel;
		private System.Windows.Forms.Panel Step2TransportPanel;
		private TransportRecordSelectUserControl transportRecordSelectUserControl1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel Step3VesBruttoPanel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}
