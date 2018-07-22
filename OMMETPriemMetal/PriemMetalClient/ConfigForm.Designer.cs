namespace PriemMetalClient
{
	partial class ConfigForm
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.ComportMethodRadioButton = new System.Windows.Forms.RadioButton();
			this.DriverMethodRadioButton = new System.Windows.Forms.RadioButton();
			this.ComPortGroupBox = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BaudRateComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.ComPortsComboBox = new System.Windows.Forms.ComboBox();
			this.flowLayoutPanel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.ComPortGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.SaveButton.Location = new System.Drawing.Point(0, 306);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(592, 23);
			this.SaveButton.TabIndex = 3;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CancelButton.Location = new System.Drawing.Point(0, 329);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(592, 23);
			this.CancelButton.TabIndex = 4;
			this.CancelButton.Text = "Отмена";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.groupBox2);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(592, 306);
			this.flowLayoutPanel1.TabIndex = 6;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.ComPortGroupBox);
			this.groupBox2.Controls.Add(this.ComportMethodRadioButton);
			this.groupBox2.Controls.Add(this.DriverMethodRadioButton);
			this.groupBox2.Location = new System.Drawing.Point(3, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(210, 133);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Режим работы с весами";
			// 
			// ComportMethodRadioButton
			// 
			this.ComportMethodRadioButton.AutoSize = true;
			this.ComportMethodRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.ComportMethodRadioButton.Location = new System.Drawing.Point(3, 33);
			this.ComportMethodRadioButton.Name = "ComportMethodRadioButton";
			this.ComportMethodRadioButton.Size = new System.Drawing.Size(204, 17);
			this.ComportMethodRadioButton.TabIndex = 1;
			this.ComportMethodRadioButton.TabStop = true;
			this.ComportMethodRadioButton.Text = "Напрямую с Com портом";
			this.ComportMethodRadioButton.UseVisualStyleBackColor = true;
			// 
			// DriverMethodRadioButton
			// 
			this.DriverMethodRadioButton.AutoSize = true;
			this.DriverMethodRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
			this.DriverMethodRadioButton.Location = new System.Drawing.Point(3, 16);
			this.DriverMethodRadioButton.Name = "DriverMethodRadioButton";
			this.DriverMethodRadioButton.Size = new System.Drawing.Size(204, 17);
			this.DriverMethodRadioButton.TabIndex = 0;
			this.DriverMethodRadioButton.TabStop = true;
			this.DriverMethodRadioButton.Text = "Драйвер (только Windows)";
			this.DriverMethodRadioButton.UseVisualStyleBackColor = true;
			// 
			// ComPortGroupBox
			// 
			this.ComPortGroupBox.AutoSize = true;
			this.ComPortGroupBox.Controls.Add(this.label2);
			this.ComPortGroupBox.Controls.Add(this.BaudRateComboBox);
			this.ComPortGroupBox.Controls.Add(this.label1);
			this.ComPortGroupBox.Controls.Add(this.ComPortsComboBox);
			this.ComPortGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ComPortGroupBox.Location = new System.Drawing.Point(3, 50);
			this.ComPortGroupBox.Name = "ComPortGroupBox";
			this.ComPortGroupBox.Size = new System.Drawing.Size(204, 80);
			this.ComPortGroupBox.TabIndex = 7;
			this.ComPortGroupBox.TabStop = false;
			this.ComPortGroupBox.Text = "Параметры Com порта";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 43);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label2.Size = new System.Drawing.Size(55, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Скорость";
			// 
			// BaudRateComboBox
			// 
			this.BaudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BaudRateComboBox.FormattingEnabled = true;
			this.BaudRateComboBox.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
			this.BaudRateComboBox.Location = new System.Drawing.Point(67, 40);
			this.BaudRateComboBox.Name = "BaudRateComboBox";
			this.BaudRateComboBox.Size = new System.Drawing.Size(127, 21);
			this.BaudRateComboBox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 22);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Номер";
			// 
			// ComPortsComboBox
			// 
			this.ComPortsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComPortsComboBox.FormattingEnabled = true;
			this.ComPortsComboBox.Location = new System.Drawing.Point(67, 19);
			this.ComPortsComboBox.Name = "ComPortsComboBox";
			this.ComPortsComboBox.Size = new System.Drawing.Size(127, 21);
			this.ComPortsComboBox.Sorted = true;
			this.ComPortsComboBox.TabIndex = 2;
			// 
			// ConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(592, 352);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CancelButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "ConfigForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Настройки";
			this.Load += new System.EventHandler(this.ConfigForm_Load);
			this.Shown += new System.EventHandler(this.ConfigForm_Shown);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ComPortGroupBox.ResumeLayout(false);
			this.ComPortGroupBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button CancelButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox ComPortGroupBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox BaudRateComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox ComPortsComboBox;
		private System.Windows.Forms.RadioButton ComportMethodRadioButton;
		private System.Windows.Forms.RadioButton DriverMethodRadioButton;
	}
}