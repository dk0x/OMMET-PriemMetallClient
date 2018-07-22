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
			this.SelectBtn = new System.Windows.Forms.Button();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.NewBtn = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 445);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(627, 22);
			this.statusStrip1.TabIndex = 5;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoSize = true;
			this.flowLayoutPanel1.Controls.Add(this.SelectBtn);
			this.flowLayoutPanel1.Controls.Add(this.CloseBtn);
			this.flowLayoutPanel1.Controls.Add(this.SaveBtn);
			this.flowLayoutPanel1.Controls.Add(this.EditBtn);
			this.flowLayoutPanel1.Controls.Add(this.NewBtn);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 416);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(627, 29);
			this.flowLayoutPanel1.TabIndex = 11;
			// 
			// SelectBtn
			// 
			this.SelectBtn.AutoSize = true;
			this.SelectBtn.Location = new System.Drawing.Point(530, 3);
			this.SelectBtn.Name = "SelectBtn";
			this.SelectBtn.Size = new System.Drawing.Size(94, 23);
			this.SelectBtn.TabIndex = 1;
			this.SelectBtn.Text = "Выбрать";
			this.SelectBtn.UseVisualStyleBackColor = true;
			// 
			// CloseBtn
			// 
			this.CloseBtn.AutoSize = true;
			this.CloseBtn.Location = new System.Drawing.Point(430, 3);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(94, 23);
			this.CloseBtn.TabIndex = 3;
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.UseVisualStyleBackColor = true;
			// 
			// SaveBtn
			// 
			this.SaveBtn.AutoSize = true;
			this.SaveBtn.Location = new System.Drawing.Point(330, 3);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(94, 23);
			this.SaveBtn.TabIndex = 2;
			this.SaveBtn.Text = "Сохранить";
			this.SaveBtn.UseVisualStyleBackColor = true;
			// 
			// EditBtn
			// 
			this.EditBtn.AutoSize = true;
			this.EditBtn.Location = new System.Drawing.Point(230, 3);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(94, 23);
			this.EditBtn.TabIndex = 0;
			this.EditBtn.Text = "Редактировать";
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// NewBtn
			// 
			this.NewBtn.AutoSize = true;
			this.NewBtn.Location = new System.Drawing.Point(130, 3);
			this.NewBtn.Name = "NewBtn";
			this.NewBtn.Size = new System.Drawing.Size(94, 23);
			this.NewBtn.TabIndex = 4;
			this.NewBtn.Text = "Новая запись";
			this.NewBtn.UseVisualStyleBackColor = true;
			this.NewBtn.Click += new System.EventHandler(this.button5_Click);
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
			this.listView1.Size = new System.Drawing.Size(627, 416);
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
			this.ClientSize = new System.Drawing.Size(627, 467);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.statusStrip1);
			this.MinimizeBox = false;
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
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button SelectBtn;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.Button CloseBtn;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader category;
		private System.Windows.Forms.ColumnHeader price;
		private System.Windows.Forms.Button NewBtn;
	}
}