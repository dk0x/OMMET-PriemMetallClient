using System.Windows.Forms;

namespace PriemMetalClient
{
	partial class BaseRecordBookForm<TRecord> : Form where TRecord : BaseRecord
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
			this.StatusStrip = new System.Windows.Forms.StatusStrip();
			this.FilterGroupBox = new System.Windows.Forms.GroupBox();
			this.FilterFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.button2 = new System.Windows.Forms.Button();
			this.MainBtnPanel = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.NewBtn = new System.Windows.Forms.ToolStripButton();
			this.DeleteBtn = new System.Windows.Forms.ToolStripButton();
			this.EditBtn = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.filter = new System.Windows.Forms.ToolStripButton();
			this.nofilter = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.List = new System.Windows.Forms.ListView();
			this.BottomButtons = new System.Windows.Forms.ToolStrip();
			this.SelectBtn = new System.Windows.Forms.ToolStripButton();
			this.CloseBtn = new System.Windows.Forms.ToolStripButton();
			this.FilterGroupBox.SuspendLayout();
			this.FilterFlowPanel.SuspendLayout();
			this.MainBtnPanel.SuspendLayout();
			this.BottomButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// BotButtonsPanel
			// 
			this.BotButtonsPanel.AutoSize = true;
			this.BotButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BotButtonsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.BotButtonsPanel.Location = new System.Drawing.Point(0, 423);
			this.BotButtonsPanel.Name = "BotButtonsPanel";
			this.BotButtonsPanel.Size = new System.Drawing.Size(773, 0);
			this.BotButtonsPanel.TabIndex = 14;
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
			this.FilterGroupBox.Controls.Add(this.FilterFlowPanel);
			this.FilterGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.FilterGroupBox.Location = new System.Drawing.Point(0, 0);
			this.FilterGroupBox.Name = "FilterGroupBox";
			this.FilterGroupBox.Size = new System.Drawing.Size(773, 48);
			this.FilterGroupBox.TabIndex = 16;
			this.FilterGroupBox.TabStop = false;
			this.FilterGroupBox.Text = "Фильтры";
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
			// MainBtnPanel
			// 
			this.MainBtnPanel.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.MainBtnPanel.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.MainBtnPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.NewBtn,
            this.DeleteBtn,
            this.EditBtn,
            this.toolStripSeparator3,
            this.filter,
            this.nofilter,
            this.toolStripSeparator4});
			this.MainBtnPanel.Location = new System.Drawing.Point(0, 48);
			this.MainBtnPanel.Name = "MainBtnPanel";
			this.MainBtnPanel.Size = new System.Drawing.Size(773, 46);
			this.MainBtnPanel.TabIndex = 22;
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
			// 
			// NewBtn
			// 
			this.NewBtn.Image = global::PriemMetalClient.Properties.Resources._173077___plus1;
			this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewBtn.Name = "NewBtn";
			this.NewBtn.Size = new System.Drawing.Size(63, 43);
			this.NewBtn.Text = "Добавить";
			this.NewBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click_1);
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.Image = global::PriemMetalClient.Properties.Resources._173055___minus;
			this.DeleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(55, 43);
			this.DeleteBtn.Text = "Удалить";
			this.DeleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.Image = global::PriemMetalClient.Properties.Resources._173002___edit;
			this.EditBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(91, 43);
			this.EditBtn.Text = "Редактировать";
			this.EditBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 46);
			// 
			// filter
			// 
			this.filter.Image = global::PriemMetalClient.Properties.Resources._173013___filter;
			this.filter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.filter.Name = "filter";
			this.filter.Size = new System.Drawing.Size(118, 43);
			this.filter.Text = "Применить фильтр";
			this.filter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.filter.Click += new System.EventHandler(this.Filter_Click);
			// 
			// nofilter
			// 
			this.nofilter.Image = global::PriemMetalClient.Properties.Resources._173013___nofilter;
			this.nofilter.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.nofilter.Name = "nofilter";
			this.nofilter.Size = new System.Drawing.Size(108, 43);
			this.nofilter.Text = "Сбросить фильтр";
			this.nofilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.nofilter.Click += new System.EventHandler(this.Nofilter_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 46);
			// 
			// List
			// 
			this.List.Dock = System.Windows.Forms.DockStyle.Fill;
			this.List.FullRowSelect = true;
			this.List.GridLines = true;
			this.List.Location = new System.Drawing.Point(0, 94);
			this.List.MultiSelect = false;
			this.List.Name = "List";
			this.List.Size = new System.Drawing.Size(773, 329);
			this.List.TabIndex = 23;
			this.List.UseCompatibleStateImageBehavior = false;
			this.List.View = System.Windows.Forms.View.Details;
			this.List.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.List_ColumnClick);
			this.List.SelectedIndexChanged += new System.EventHandler(this.List_SelectedIndexChanged);
			this.List.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.List_MouseDoubleClick);
			// 
			// BottomButtons
			// 
			this.BottomButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectBtn,
            this.CloseBtn});
			this.BottomButtons.Location = new System.Drawing.Point(0, 398);
			this.BottomButtons.Name = "BottomButtons";
			this.BottomButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.BottomButtons.Size = new System.Drawing.Size(773, 25);
			this.BottomButtons.TabIndex = 25;
			// 
			// SelectBtn
			// 
			this.SelectBtn.Image = global::PriemMetalClient.Properties.Resources._173061___ok;
			this.SelectBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.SelectBtn.Name = "SelectBtn";
			this.SelectBtn.Size = new System.Drawing.Size(74, 22);
			this.SelectBtn.Text = "Выбрать";
			this.SelectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.SelectBtn.Click += new System.EventHandler(this.SelectBtn_Click);
			// 
			// CloseBtn
			// 
			this.CloseBtn.Image = global::PriemMetalClient.Properties.Resources._173050___logout;
			this.CloseBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new System.Drawing.Size(73, 22);
			this.CloseBtn.Text = "Закрыть";
			this.CloseBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
			// 
			// BaseRecordBookForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(773, 445);
			this.Controls.Add(this.BottomButtons);
			this.Controls.Add(this.List);
			this.Controls.Add(this.MainBtnPanel);
			this.Controls.Add(this.FilterGroupBox);
			this.Controls.Add(this.BotButtonsPanel);
			this.Controls.Add(this.StatusStrip);
			this.Name = "BaseRecordBookForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "BaseBook";
			this.FilterGroupBox.ResumeLayout(false);
			this.FilterGroupBox.PerformLayout();
			this.FilterFlowPanel.ResumeLayout(false);
			this.MainBtnPanel.ResumeLayout(false);
			this.MainBtnPanel.PerformLayout();
			this.BottomButtons.ResumeLayout(false);
			this.BottomButtons.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		public System.Windows.Forms.FlowLayoutPanel BotButtonsPanel;
		public System.Windows.Forms.GroupBox FilterGroupBox;
		public System.Windows.Forms.StatusStrip StatusStrip;
		private FlowLayoutPanel FilterFlowPanel;
		private Button button2;
		private ToolStrip MainBtnPanel;
		private ToolStripButton NewBtn;
		private ToolStripButton DeleteBtn;
		private ToolStripButton EditBtn;
		public ListView List;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton filter;
		private ToolStripButton nofilter;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStrip BottomButtons;
		private ToolStripButton SelectBtn;
		private ToolStripButton CloseBtn;
	}
}