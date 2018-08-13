namespace PriemMetalClient
{
	partial class NumericPropertyEditUserControl : BasePropertyEditUserControl
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
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.label = new System.Windows.Forms.Label();
			this.vesButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// numericUpDown
			// 
			this.numericUpDown.DecimalPlaces = 2;
			this.numericUpDown.Dock = System.Windows.Forms.DockStyle.Top;
			this.numericUpDown.Location = new System.Drawing.Point(0, 13);
			this.numericUpDown.Maximum = new decimal(new int[] {
			999999999,
			0,
			0,
			0});
			this.numericUpDown.Minimum = new decimal(new int[] {
			999999999,
			0,
			0,
			-2147483648});
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(133, 20);
			this.numericUpDown.TabIndex = 0;
			this.numericUpDown.ThousandsSeparator = true;
			this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown_ValueChanged);
			// 
			// label
			// 
			this.label.AutoEllipsis = true;
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(200, 13);
			this.label.TabIndex = 1;
			this.label.Text = "label1";
			// 
			// vesButton
			// 
			this.vesButton.Dock = System.Windows.Forms.DockStyle.Right;
			this.vesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.vesButton.Location = new System.Drawing.Point(133, 13);
			this.vesButton.Name = "vesButton";
			this.vesButton.Size = new System.Drawing.Size(67, 21);
			this.vesButton.TabIndex = 2;
			this.vesButton.Text = "С весов...";
			this.vesButton.UseVisualStyleBackColor = true;
			this.vesButton.Click += new System.EventHandler(this.VesButton_Click);
			// 
			// DecimalPropertyEditUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.vesButton);
			this.Controls.Add(this.label);
			this.Name = "DecimalPropertyEditUserControl";
			this.Size = new System.Drawing.Size(200, 34);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label;
		public System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.Button vesButton;
	}
}
