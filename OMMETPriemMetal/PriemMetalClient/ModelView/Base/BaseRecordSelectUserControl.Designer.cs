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
			this.label = new System.Windows.Forms.Label();
			this.SelectBtn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.AddBtn = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label
			// 
			this.label.AutoEllipsis = true;
			this.label.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label.Dock = System.Windows.Forms.DockStyle.Top;
			this.label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label.Location = new System.Drawing.Point(0, 0);
			this.label.Margin = new System.Windows.Forms.Padding(3);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(200, 20);
			this.label.TabIndex = 9;
			this.label.Text = "test test test test test test test test test ";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label.UseCompatibleTextRendering = true;
			// 
			// SelectBtn
			// 
			this.SelectBtn.BackgroundImage = global::PriemMetalClient.Properties.Resources._173095___search;
			this.SelectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.SelectBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.SelectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SelectBtn.Location = new System.Drawing.Point(178, 0);
			this.SelectBtn.Margin = new System.Windows.Forms.Padding(0);
			this.SelectBtn.Name = "SelectBtn";
			this.SelectBtn.Size = new System.Drawing.Size(22, 22);
			this.SelectBtn.TabIndex = 11;
			this.SelectBtn.Text = "...";
			this.SelectBtn.UseVisualStyleBackColor = false;
			this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
			this.SelectBtn.Resize += new System.EventHandler(this.SelectBtn_Resize);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.comboBox);
			this.panel1.Controls.Add(this.AddBtn);
			this.panel1.Controls.Add(this.SelectBtn);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 22);
			this.panel1.TabIndex = 12;
			// 
			// comboBox
			// 
			this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Location = new System.Drawing.Point(0, 0);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(156, 21);
			this.comboBox.TabIndex = 12;
			this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
			this.comboBox.TextUpdate += new System.EventHandler(this.comboBox_TextUpdate);
			this.comboBox.TextChanged += new System.EventHandler(this.comboBox_TextChanged);
			this.comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
			// 
			// AddBtn
			// 
			this.AddBtn.BackgroundImage = global::PriemMetalClient.Properties.Resources._173077___plus1;
			this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.AddBtn.Dock = System.Windows.Forms.DockStyle.Right;
			this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddBtn.Location = new System.Drawing.Point(156, 0);
			this.AddBtn.Margin = new System.Windows.Forms.Padding(0);
			this.AddBtn.Name = "AddBtn";
			this.AddBtn.Size = new System.Drawing.Size(22, 22);
			this.AddBtn.TabIndex = 13;
			this.AddBtn.Text = "...";
			this.AddBtn.UseVisualStyleBackColor = false;
			this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
			this.AddBtn.Resize += new System.EventHandler(this.AddBtn_Resize);
			// 
			// BaseRecordSelectUserControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label);
			this.MinimumSize = new System.Drawing.Size(100, 40);
			this.Name = "BaseRecordSelectUserControl";
			this.Size = new System.Drawing.Size(200, 42);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button SelectBtn;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.Button AddBtn;
	}
}
