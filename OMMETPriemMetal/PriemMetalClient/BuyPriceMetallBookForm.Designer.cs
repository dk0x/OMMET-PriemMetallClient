namespace PriemMetalClient
{
	partial class BuyPriceMetallBookForm
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
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.button5 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 430);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(728, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.button5);
			this.flowLayoutPanel1.Controls.Add(this.button1);
			this.flowLayoutPanel1.Controls.Add(this.button2);
			this.flowLayoutPanel1.Controls.Add(this.button3);
			this.flowLayoutPanel1.Controls.Add(this.button4);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 401);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(728, 29);
			this.flowLayoutPanel1.TabIndex = 11;
			// 
			// button5
			// 
			this.button5.AutoSize = true;
			this.button5.Location = new System.Drawing.Point(3, 3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(94, 23);
			this.button5.TabIndex = 4;
			this.button5.Text = "Новая запись";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(103, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Редактировать";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.AutoSize = true;
			this.button2.Location = new System.Drawing.Point(203, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(94, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "Выбрать";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.Location = new System.Drawing.Point(303, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(94, 23);
			this.button3.TabIndex = 2;
			this.button3.Text = "Сохранить";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.AutoSize = true;
			this.button4.Location = new System.Drawing.Point(403, 3);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(94, 23);
			this.button4.TabIndex = 3;
			this.button4.Text = "Закрыть";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.category,
            this.price});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.MultiSelect = false;
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(728, 401);
			this.listView1.TabIndex = 12;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// category
			// 
			this.category.Text = "Категория лома";
			this.category.Width = 189;
			// 
			// price
			// 
			this.price.Text = "Цена за 1 тонну, руб. (без НДС)";
			this.price.Width = 184;
			// 
			// BuyPriceMetallBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(728, 452);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "BuyPriceMetallBookForm";
			this.Text = "BuyPriceMetallBook";
			this.Load += new System.EventHandler(this.BuyPriceMetallBook_Load);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader category;
		private System.Windows.Forms.ColumnHeader price;
		private System.Windows.Forms.Button button5;
	}
}