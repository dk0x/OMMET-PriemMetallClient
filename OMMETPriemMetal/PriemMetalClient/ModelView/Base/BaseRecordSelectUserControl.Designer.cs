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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label = new System.Windows.Forms.Label();
			this.SelectBtn = new System.Windows.Forms.Button();
			this.textBox = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label);
			this.panel1.Controls.Add(this.SelectBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(236, 22);
			this.panel1.TabIndex = 2;
			// 
			// label
			// 
			this.label.AutoEllipsis = true;
			this.label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(161, 22);
			this.label.TabIndex = 3;
			this.label.Text = "label1";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SelectBtn
			// 
			this.SelectBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.SelectBtn.Location = new System.Drawing.Point(161, 0);
			this.SelectBtn.Name = "SelectBtn";
			this.SelectBtn.Size = new System.Drawing.Size(75, 22);
			this.SelectBtn.TabIndex = 2;
			this.SelectBtn.Text = "Выбрать...";
			this.SelectBtn.UseVisualStyleBackColor = true;
			this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
			// 
			// textBox
			// 
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Location = new System.Drawing.Point(0, 22);
			this.textBox.Multiline = true;
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox.Size = new System.Drawing.Size(236, 51);
			this.textBox.TabIndex = 3;
			// 
			// BaseRecordSelectUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.panel1);
			this.Name = "BaseRecordSelectUserControl";
			this.Size = new System.Drawing.Size(236, 73);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Button SelectBtn;
		private System.Windows.Forms.TextBox textBox;
	}
}
