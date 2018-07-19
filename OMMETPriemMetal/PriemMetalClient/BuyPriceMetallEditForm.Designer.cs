namespace PriemMetalClient
{
	partial class BuyPriceMetallEditForm
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
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.Controls.Add(this.button1);
			this.flowLayoutPanel2.Controls.Add(this.button2);
			this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 232);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(284, 29);
			this.flowLayoutPanel2.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(84, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Отмена";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.groupBox3);
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(284, 232);
			this.panel1.TabIndex = 2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(284, 77);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Категория лома";
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Location = new System.Drawing.Point(3, 16);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new System.Drawing.Size(278, 58);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "123123123\r\n12312\r\n123123\r\n123123123\r\n\r\n1231231";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.numericUpDown1);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox2.Location = new System.Drawing.Point(0, 77);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(284, 44);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Цена за 1 тонну, руб. (без НДС)";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Dock = System.Windows.Forms.DockStyle.Top;
			this.numericUpDown1.Location = new System.Drawing.Point(3, 16);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(278, 20);
			this.numericUpDown1.TabIndex = 0;
			this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericUpDown1.ThousandsSeparator = true;
			this.numericUpDown1.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.textBox2);
			this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox3.Location = new System.Drawing.Point(0, 121);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(284, 105);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Условия поставки";
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Location = new System.Drawing.Point(3, 16);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox2.Size = new System.Drawing.Size(278, 86);
			this.textBox2.TabIndex = 0;
			// 
			// BuyPriceMetallEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.flowLayoutPanel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "BuyPriceMetallEditForm";
			this.Text = "BuyPriceMetallEditForm";
			this.flowLayoutPanel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBox1;
	}
}