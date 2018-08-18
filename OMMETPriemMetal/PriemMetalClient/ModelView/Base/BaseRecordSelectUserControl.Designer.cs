namespace PriemMetalClient
{
	partial class BaseRecordSelectUserControl<TRecord>
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
			this.textBox = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.SelectBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox
			// 
			this.textBox.BackColor = System.Drawing.SystemColors.Window;
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Location = new System.Drawing.Point(0, 0);
			this.textBox.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.Size = new System.Drawing.Size(180, 20);
			this.textBox.TabIndex = 10;
			// 
			// label
			// 
			this.label.AutoEllipsis = true;
			this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Margin = new System.Windows.Forms.Padding(3);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(200, 20);
			this.label.TabIndex = 9;
			this.label.Text = "test test test test test test test test test ";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label.UseCompatibleTextRendering = true;
			// 
			// SelectBtn
			// 
			this.SelectBtn.BackgroundImage = global::PriemMetalClient.Properties.Resources._173095___search;
			this.SelectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SelectBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SelectBtn.Location = new System.Drawing.Point(180, 0);
			this.SelectBtn.Margin = new System.Windows.Forms.Padding(0);
			this.SelectBtn.Name = "SelectBtn";
			this.SelectBtn.Size = new System.Drawing.Size(20, 20);
			this.SelectBtn.TabIndex = 11;
			this.SelectBtn.Text = "...";
			this.SelectBtn.UseVisualStyleBackColor = false;
			this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
			this.SelectBtn.Resize += new System.EventHandler(this.SelectBtn_Resize);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.textBox);
			this.panel1.Controls.Add(this.SelectBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 20);
			this.panel1.TabIndex = 12;
			// 
			// BaseRecordSelectUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label);
			this.MinimumSize = new System.Drawing.Size(100, 40);
			this.Name = "BaseRecordSelectUserControl";
			this.Size = new System.Drawing.Size(200, 40);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button SelectBtn;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel panel1;
	}
}
