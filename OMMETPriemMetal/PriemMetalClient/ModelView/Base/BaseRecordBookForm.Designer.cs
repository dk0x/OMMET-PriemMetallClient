using System.Windows.Forms;

namespace PriemMetalClient
{
	partial class BaseRecordBookForm<RecordType> : Form where RecordType : BaseRecord
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
			this.BotButtonsPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.CloseBtn = new System.Windows.Forms.Button();
			this.SelectBtn = new System.Windows.Forms.Button();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.NewBtn = new System.Windows.Forms.Button();
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.FilterGroupBox = new System.Windows.Forms.GroupBox();
			this.FilterButtonsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.FilterFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.List = new System.Windows.Forms.ListView();
			this.BotButtonsPanel.SuspendLayout();
			this.FilterGroupBox.SuspendLayout();
			this.FilterButtonsFlowPanel.SuspendLayout();
			this.FilterFlowPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// BotButtonsPanel
			// 
			this.BotButtonsPanel.AutoSize = true;
			this.BotButtonsPanel.Controls.Add(this.CloseBtn);
			this.BotButtonsPanel.Controls.Add(this.SelectBtn);
			this.BotButtonsPanel.Controls.Add(this.DeleteBtn);
			this.BotButtonsPanel.Controls.Add(this.EditBtn);
			this.BotButtonsPanel.Controls.Add(this.NewBtn);
			this.BotButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BotButtonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.BotButtonsPanel.Location = new System.Drawing.Point(0, 394);
			this.BotButtonsPanel.Name = "BotButtonsPanel";
			this.BotButtonsPanel.Size = new System.Drawing.Size(773, 29);
			this.BotButtonsPanel.TabIndex = 14;
			// 
			// CloseBtn
			// 
			this.CloseBtn.AutoSize = true;
			this.CloseBtn.Location = new System.Drawing.Point(676, 3);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(94, 23);
			this.CloseBtn.TabIndex = 3;
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.UseVisualStyleBackColor = true;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// SelectBtn
			// 
			this.SelectBtn.AutoSize = true;
			this.SelectBtn.Location = new System.Drawing.Point(576, 3);
			this.SelectBtn.Name = "SelectBtn";
			this.SelectBtn.Size = new System.Drawing.Size(94, 23);
			this.SelectBtn.TabIndex = 1;
			this.SelectBtn.Text = "Выбрать";
			this.SelectBtn.UseVisualStyleBackColor = true;
			this.SelectBtn.Visible = false;
			this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.AutoSize = true;
			this.DeleteBtn.Location = new System.Drawing.Point(476, 3);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(94, 23);
			this.DeleteBtn.TabIndex = 2;
			this.DeleteBtn.Text = "Удалить";
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.AutoSize = true;
			this.EditBtn.Location = new System.Drawing.Point(376, 3);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(94, 23);
			this.EditBtn.TabIndex = 0;
			this.EditBtn.Text = "Редактировать";
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// NewBtn
			// 
			this.NewBtn.AutoSize = true;
			this.NewBtn.Location = new System.Drawing.Point(276, 3);
			this.NewBtn.Name = "NewBtn";
			this.NewBtn.Size = new System.Drawing.Size(94, 23);
			this.NewBtn.TabIndex = 4;
			this.NewBtn.Text = "Новая запись";
			this.NewBtn.UseVisualStyleBackColor = true;
			this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
			// 
			// StatusStrip
			// 
			this.StatusStrip.Location = new System.Drawing.Point(0, 423);
			this.StatusStrip.Name = "StatusStrip";
			this.StatusStrip.Size = new System.Drawing.Size(773, 22);
			this.StatusStrip.TabIndex = 13;
			this.StatusStrip.Text = "StatusStrip";
			// 
			// FilterGroupBox
			// 
			this.FilterGroupBox.AutoSize = true;
			this.FilterGroupBox.Controls.Add(this.FilterButtonsFlowPanel);
			this.FilterGroupBox.Controls.Add(this.FilterFlowPanel);
			this.FilterGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.FilterGroupBox.Location = new System.Drawing.Point(0, 0);
			this.FilterGroupBox.Name = "FilterGroupBox";
			this.FilterGroupBox.Size = new System.Drawing.Size(773, 77);
			this.FilterGroupBox.TabIndex = 16;
			this.FilterGroupBox.TabStop = false;
			this.FilterGroupBox.Text = "Фильтры";
			// 
			// FilterButtonsFlowPanel
			// 
			this.FilterButtonsFlowPanel.AutoSize = true;
			this.FilterButtonsFlowPanel.Controls.Add(this.button1);
			this.FilterButtonsFlowPanel.Controls.Add(this.button3);
			this.FilterButtonsFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.FilterButtonsFlowPanel.Location = new System.Drawing.Point(3, 45);
			this.FilterButtonsFlowPanel.Name = "FilterButtonsFlowPanel";
			this.FilterButtonsFlowPanel.Size = new System.Drawing.Size(767, 29);
			this.FilterButtonsFlowPanel.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.AutoSize = true;
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(112, 23);
			this.button1.TabIndex = 0;
			this.button1.Text = "Привенить фильтр";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// button3
			// 
			this.button3.AutoSize = true;
			this.button3.Location = new System.Drawing.Point(121, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(112, 23);
			this.button3.TabIndex = 1;
			this.button3.Text = "Сбросить фильтр";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3_Click);
			// 
			// FilterFlowPanel
			// 
			this.FilterFlowPanel.AutoSize = true;
			this.FilterFlowPanel.Controls.Add(this.button2);
			this.FilterFlowPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.FilterFlowPanel.Location = new System.Drawing.Point(3, 16);
			this.FilterFlowPanel.Name = "FilterFlowPanel";
			this.FilterFlowPanel.Size = new System.Drawing.Size(767, 29);
			this.FilterFlowPanel.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 3);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// List
			// 
			this.List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.List.FullRowSelect = true;
			this.List.GridLines = true;
			this.List.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.List.Location = new System.Drawing.Point(0, 77);
			this.List.MultiSelect = false;
			this.List.Name = "List";
			this.List.Size = new System.Drawing.Size(773, 317);
			this.List.TabIndex = 17;
			this.List.UseCompatibleStateImageBehavior = false;
			this.List.View = System.Windows.Forms.View.Details;
			this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
			// 
			// BaseRecordBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 445);
			this.Controls.Add(this.List);
			this.Controls.Add(this.FilterGroupBox);
			this.Controls.Add(this.BotButtonsPanel);
			this.Controls.Add(this.StatusStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "BaseRecordBookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BaseBook";
			this.BotButtonsPanel.ResumeLayout(false);
			this.BotButtonsPanel.PerformLayout();
			this.FilterGroupBox.ResumeLayout(false);
			this.FilterGroupBox.PerformLayout();
			this.FilterButtonsFlowPanel.ResumeLayout(false);
			this.FilterButtonsFlowPanel.PerformLayout();
			this.FilterFlowPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.FlowLayoutPanel BotButtonsPanel;
		public System.Windows.Forms.Button CloseBtn;
		public System.Windows.Forms.Button SelectBtn;
		public System.Windows.Forms.Button DeleteBtn;
		public System.Windows.Forms.Button EditBtn;
		public System.Windows.Forms.Button NewBtn;
		public System.Windows.Forms.GroupBox FilterGroupBox;
		public System.Windows.Forms.ListView List;
		public System.Windows.Forms.StatusStrip StatusStrip;
		private FlowLayoutPanel FilterFlowPanel;
		private Button button1;
		private FlowLayoutPanel FilterButtonsFlowPanel;
		private Button button2;
		private Button button3;
	}
}