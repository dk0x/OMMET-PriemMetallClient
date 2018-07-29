using System.Windows.Forms;

namespace PriemMetalClient
{
	partial class TextPropertyEditUserControl
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
			this.TextBox = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// TextBox
			// 
			this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.TextBox.Location = new System.Drawing.Point(0, 13);
			this.TextBox.Name = "TextBox";
			this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.TextBox.Size = new System.Drawing.Size(202, 20);
			this.TextBox.TabIndex = 0;
			this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
			// 
			// label
			// 
			this.label.AutoEllipsis = true;
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(202, 13);
			this.label.TabIndex = 1;
			this.label.Text = "label1";
			// 
			// TextPropertyEditUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TextBox);
			this.Controls.Add(this.label);
			this.Name = "TextPropertyEditUserControl";
			this.Size = new System.Drawing.Size(202, 62);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox TextBox;
		private Label label;
	}
}
