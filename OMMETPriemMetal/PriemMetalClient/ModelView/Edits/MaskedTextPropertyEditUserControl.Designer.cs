using System.Windows.Forms;

namespace PriemMetalClient
{
	partial class MaskedTextPropertyEditUserControl
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
			this.label = new System.Windows.Forms.Label();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.SuspendLayout();
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
			// maskedTextBox
			// 
			this.maskedTextBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.maskedTextBox.Location = new System.Drawing.Point(0, 13);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(202, 20);
			this.maskedTextBox.TabIndex = 2;
			this.maskedTextBox.TextChanged += new System.EventHandler(this.maskedTextBox_TextChanged);
			// 
			// MaskedTextPropertyEditUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.maskedTextBox);
			this.Controls.Add(this.label);
			this.Name = "MaskedTextPropertyEditUserControl";
			this.Size = new System.Drawing.Size(202, 43);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label label;
		private MaskedTextBox maskedTextBox;
	}
}
