namespace PriemMetalClient
{
	partial class TextPropertyFilterUserControl<RecordType>
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
			this.ComboBox = new System.Windows.Forms.ComboBox();
			this.label = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// ComboBox
			// 
			this.ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.ComboBox.FormattingEnabled = true;
			this.ComboBox.Location = new System.Drawing.Point(0, 20);
			this.ComboBox.Name = "ComboBox";
			this.ComboBox.Size = new System.Drawing.Size(200, 21);
			this.ComboBox.Sorted = true;
			this.ComboBox.TabIndex = 2;
			this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.ComboBox_SelectedIndexChanged);
			this.ComboBox.TextUpdate += new System.EventHandler(this.ComboBox_TextUpdate);
			this.ComboBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBox_KeyUp);
			// 
			// label
			// 
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(200, 20);
			this.label.TabIndex = 4;
			this.label.Text = "text";
			this.label.UseVisualStyleBackColor = true;
			this.label.CheckedChanged += new System.EventHandler(this.label_CheckedChanged);
			// 
			// TextPropertyFilterUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ComboBox);
			this.Controls.Add(this.label);
			this.Name = "TextPropertyFilterUserControl";
			this.Size = new System.Drawing.Size(200, 42);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox ComboBox;
		private System.Windows.Forms.CheckBox label;
	}
}
