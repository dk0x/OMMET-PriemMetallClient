namespace PriemMetalClient
{
	partial class NumericFilterUserControl<RecordType>
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
			this.value = new System.Windows.Forms.NumericUpDown();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.GroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupBox
			// 
			this.GroupBox.Controls.Add(this.value);
			this.GroupBox.Controls.Add(this.comboBox);
			this.GroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.GroupBox.Location = new System.Drawing.Point(0, 0);
			this.GroupBox.Name = "GroupBox";
			this.GroupBox.Size = new System.Drawing.Size(200, 44);
			this.GroupBox.TabIndex = 1;
			this.GroupBox.TabStop = false;
			this.GroupBox.Text = "Text";
			// 
			// value
			// 
			this.value.Dock = System.Windows.Forms.DockStyle.Left;
			this.value.Location = new System.Drawing.Point(93, 16);
			this.value.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.value.Minimum = new decimal(new int[] {
            999999999,
            0,
            0,
            -2147483648});
			this.value.Name = "value";
			this.value.Size = new System.Drawing.Size(94, 20);
			this.value.TabIndex = 0;
			// 
			// comboBox
			// 
			this.comboBox.Dock = System.Windows.Forms.DockStyle.Left;
			this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Items.AddRange(new object[] {
            "Больше чем",
            "Равно",
            "Меньше чем"});
			this.comboBox.Location = new System.Drawing.Point(3, 16);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(90, 21);
			this.comboBox.TabIndex = 1;
			// 
			// NumericFilterUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GroupBox);
			this.Name = "NumericFilterUserControl";
			this.Size = new System.Drawing.Size(200, 44);
			this.GroupBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GroupBox;
		private System.Windows.Forms.NumericUpDown value;
		private System.Windows.Forms.ComboBox comboBox;
	}
}
