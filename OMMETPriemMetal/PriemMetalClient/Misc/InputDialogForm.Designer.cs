namespace PriemMetalClient
{
	partial class InputDialogForm
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
			this.CancelBtn = new System.Windows.Forms.Button();
			this.OkBtn = new System.Windows.Forms.Button();
			this.textBox = new System.Windows.Forms.TextBox();
			this.label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CancelBtn
			// 
			this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.CancelBtn.Location = new System.Drawing.Point(0, 64);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(284, 23);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "Отмена";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// OkBtn
			// 
			this.OkBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.OkBtn.Location = new System.Drawing.Point(0, 41);
			this.OkBtn.Name = "OkBtn";
			this.OkBtn.Size = new System.Drawing.Size(284, 23);
			this.OkBtn.TabIndex = 2;
			this.OkBtn.Text = "Подтвердить";
			this.OkBtn.UseVisualStyleBackColor = true;
			this.OkBtn.Click += new System.EventHandler(this.OkBtn_Click);
			// 
			// textBox
			// 
			this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox.Location = new System.Drawing.Point(0, 20);
			this.textBox.Name = "textBox";
			this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox.Size = new System.Drawing.Size(284, 20);
			this.textBox.TabIndex = 3;
			// 
			// label
			// 
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(284, 20);
			this.label.TabIndex = 4;
			this.label.Text = "TEXT TEXT";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// InputDialogForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 87);
			this.Controls.Add(this.textBox);
			this.Controls.Add(this.label);
			this.Controls.Add(this.OkBtn);
			this.Controls.Add(this.CancelBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "InputDialogForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.Button OkBtn;
		private System.Windows.Forms.TextBox textBox;
		private System.Windows.Forms.Label label;
	}
}