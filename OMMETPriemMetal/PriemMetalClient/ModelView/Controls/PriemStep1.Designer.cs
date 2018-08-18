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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.UrSelect = new System.Windows.Forms.RadioButton();
			this.FizSelect = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.contragentFizLicoRecordSelectUserControl1 = new PriemMetalClient.ContragentFizLicoRecordSelectUserControl();
			this.contragentUrLicoRecordSelectUserControl1 = new PriemMetalClient.ContragentUrLicoRecordSelectUserControl();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(333, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Приемо сдаточный акт № от 23132132132132";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Location = new System.Drawing.Point(0, 46);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(333, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Выбор контрагента:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.UrSelect);
			this.panel1.Controls.Add(this.FizSelect);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 69);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(333, 38);
			this.panel1.TabIndex = 4;
			// 
			// UrSelect
			// 
			this.UrSelect.AutoSize = true;
			this.UrSelect.Dock = System.Windows.Forms.DockStyle.Top;
			this.UrSelect.Location = new System.Drawing.Point(0, 17);
			this.UrSelect.Margin = new System.Windows.Forms.Padding(2);
			this.UrSelect.Name = "UrSelect";
			this.UrSelect.Size = new System.Drawing.Size(329, 17);
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
			this.FizSelect.Size = new System.Drawing.Size(329, 17);
			this.FizSelect.TabIndex = 0;
			this.FizSelect.TabStop = true;
			this.FizSelect.Text = "Физическое лицо";
			this.FizSelect.UseVisualStyleBackColor = true;
			this.FizSelect.CheckedChanged += new System.EventHandler(this.FizUrSelect_CheckedChanged);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 187);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(333, 25);
			this.panel2.TabIndex = 5;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Dock = System.Windows.Forms.DockStyle.Left;
			this.button2.Location = new System.Drawing.Point(0, 0);
			this.button2.Margin = new System.Windows.Forms.Padding(2);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 25);
			this.button2.TabIndex = 1;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Dock = System.Windows.Forms.DockStyle.Right;
			this.button1.Location = new System.Drawing.Point(280, 0);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(53, 25);
			this.button1.TabIndex = 0;
			this.button1.Text = "Далее";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// contragentFizLicoRecordSelectUserControl1
			// 
			this.contragentFizLicoRecordSelectUserControl1.AutoSize = true;
			this.contragentFizLicoRecordSelectUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.contragentFizLicoRecordSelectUserControl1.Location = new System.Drawing.Point(0, 107);
			this.contragentFizLicoRecordSelectUserControl1.MinimumSize = new System.Drawing.Size(100, 40);
			this.contragentFizLicoRecordSelectUserControl1.Multilane = false;
			this.contragentFizLicoRecordSelectUserControl1.Name = "contragentFizLicoRecordSelectUserControl1";
			this.contragentFizLicoRecordSelectUserControl1.Size = new System.Drawing.Size(333, 40);
			this.contragentFizLicoRecordSelectUserControl1.TabIndex = 6;
			// 
			// contragentUrLicoRecordSelectUserControl1
			// 
			this.contragentUrLicoRecordSelectUserControl1.AutoSize = true;
			this.contragentUrLicoRecordSelectUserControl1.Dock = System.Windows.Forms.DockStyle.Top;
			this.contragentUrLicoRecordSelectUserControl1.Location = new System.Drawing.Point(0, 147);
			this.contragentUrLicoRecordSelectUserControl1.MinimumSize = new System.Drawing.Size(100, 40);
			this.contragentUrLicoRecordSelectUserControl1.Multilane = false;
			this.contragentUrLicoRecordSelectUserControl1.Name = "contragentUrLicoRecordSelectUserControl1";
			this.contragentUrLicoRecordSelectUserControl1.Size = new System.Drawing.Size(333, 40);
			this.contragentUrLicoRecordSelectUserControl1.TabIndex = 7;
			// 
			// PriemStep1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.contragentUrLicoRecordSelectUserControl1);
			this.Controls.Add(this.contragentFizLicoRecordSelectUserControl1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.Name = "PriemStep1";
			this.Size = new System.Drawing.Size(333, 220);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton UrSelect;
		private System.Windows.Forms.RadioButton FizSelect;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private ContragentFizLicoRecordSelectUserControl contragentFizLicoRecordSelectUserControl1;
		private ContragentUrLicoRecordSelectUserControl contragentUrLicoRecordSelectUserControl1;
	}
}
