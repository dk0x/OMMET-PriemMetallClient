namespace PriemMetalClient
{
	partial class TextFilterUserControl<RecordType>
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
			this.GroupBox = new System.Windows.Forms.GroupBox();
			this.ComboBox = new System.Windows.Forms.ComboBox();
			this.GroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// GroupBox
			// 
			this.GroupBox.AutoSize = true;
			this.GroupBox.Controls.Add(this.ComboBox);
			this.GroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.GroupBox.Location = new System.Drawing.Point(0, 0);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Size = new System.Drawing.Size(200, 40);
			this.GroupBox.TabIndex = 0;
			this.GroupBox.TabStop = false;
			this.GroupBox.Text = "Text";
			// 
			// ComboBox
			// 
			this.ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ComboBox.FormattingEnabled = true;
			this.ComboBox.Location = new System.Drawing.Point(3, 16);
			this.ComboBox.Name = "ComboBox";
			this.ComboBox.Size = new System.Drawing.Size(194, 21);
			this.ComboBox.Sorted = true;
			this.ComboBox.TabIndex = 0;
			// 
			// TextFilterViewControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GroupBox);
			this.Name = "TextFilterViewControl";
			this.Size = new System.Drawing.Size(200, 44);
			this.GroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox;
		private System.Windows.Forms.ComboBox ComboBox;
	}
}
