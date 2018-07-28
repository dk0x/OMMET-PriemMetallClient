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
			this.value = new System.Windows.Forms.NumericUpDown();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.label = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
			this.SuspendLayout();
			// 
			// value
			// 
			this.value.Dock = System.Windows.Forms.DockStyle.Left;
			this.value.Location = new System.Drawing.Point(100, 20);
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
			this.value.Size = new System.Drawing.Size(100, 20);
			this.value.TabIndex = 2;
			this.value.ValueChanged += new System.EventHandler(this.value_ValueChanged);
			this.value.KeyUp += new System.Windows.Forms.KeyEventHandler(this.value_KeyUp);
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
			this.comboBox.Location = new System.Drawing.Point(0, 20);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(100, 21);
			this.comboBox.TabIndex = 3;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			// 
			// label
			// 
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(200, 20);
			this.label.TabIndex = 5;
			this.label.Text = "text";
			this.label.UseVisualStyleBackColor = true;
			this.label.CheckedChanged += new System.EventHandler(this.label_CheckedChanged);
			// 
			// NumericFilterUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.value);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.label);
			this.Name = "NumericFilterUserControl";
			this.Size = new System.Drawing.Size(200, 42);
			((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.NumericUpDown value;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.CheckBox label;
	}
}
