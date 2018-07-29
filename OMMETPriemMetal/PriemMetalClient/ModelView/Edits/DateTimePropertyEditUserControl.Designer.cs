namespace PriemMetalClient
{
	partial class DateTimePropertyEditUserControl
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
			this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.AutoEllipsis = true;
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(200, 13);
			this.label.TabIndex = 3;
			this.label.Text = "label1";
			// 
			// dateTimePicker
			// 
			this.dateTimePicker.Dock = System.Windows.Forms.DockStyle.Top;
			this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker.Location = new System.Drawing.Point(0, 13);
			this.dateTimePicker.Name = "dateTimePicker";
			this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker.TabIndex = 4;
			this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
			// 
			// DateTimePropertyEditUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.dateTimePicker);
			this.Controls.Add(this.label);
			this.Name = "DateTimePropertyEditUserControl";
			this.Size = new System.Drawing.Size(200, 42);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label;
		private System.Windows.Forms.DateTimePicker dateTimePicker;
	}
}
