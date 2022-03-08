
namespace cg_proj_1 {
	partial class MainWindow {
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose ();
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.mainStatusStrip = new System.Windows.Forms.StatusStrip();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.autoRefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutFilterEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.filtersGroupBox = new System.Windows.Forms.GroupBox();
			this.activeFiltersList = new System.Windows.Forms.ListView();
			this.buttonDeleteFilter = new System.Windows.Forms.Button();
			this.buttonEditFilter = new System.Windows.Forms.Button();
			this.buttonAddFilter = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.filtersGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 749);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Size = new System.Drawing.Size(1166, 22);
			this.mainStatusStrip.TabIndex = 0;
			this.mainStatusStrip.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1166, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadImageToolStripMenuItem,
            this.saveImageToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadImageToolStripMenuItem
			// 
			this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
			this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.loadImageToolStripMenuItem.Text = "Load Image";
			this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
			// 
			// saveImageToolStripMenuItem
			// 
			this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
			this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.saveImageToolStripMenuItem.Text = "Save Image";
			this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshPreviewToolStripMenuItem,
            this.autoRefreshToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// refreshPreviewToolStripMenuItem
			// 
			this.refreshPreviewToolStripMenuItem.Name = "refreshPreviewToolStripMenuItem";
			this.refreshPreviewToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.refreshPreviewToolStripMenuItem.Text = "Refresh Preview";
			// 
			// autoRefreshToolStripMenuItem
			// 
			this.autoRefreshToolStripMenuItem.Name = "autoRefreshToolStripMenuItem";
			this.autoRefreshToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.autoRefreshToolStripMenuItem.Text = "Auto Refresh";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilterToolStripMenuItem,
            this.loadFilterToolStripMenuItem,
            this.clearAllFiltersToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addFilterToolStripMenuItem
			// 
			this.addFilterToolStripMenuItem.Name = "addFilterToolStripMenuItem";
			this.addFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.addFilterToolStripMenuItem.Text = "Add Filter";
			// 
			// loadFilterToolStripMenuItem
			// 
			this.loadFilterToolStripMenuItem.Name = "loadFilterToolStripMenuItem";
			this.loadFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.loadFilterToolStripMenuItem.Text = "Load Filter";
			// 
			// clearAllFiltersToolStripMenuItem
			// 
			this.clearAllFiltersToolStripMenuItem.Name = "clearAllFiltersToolStripMenuItem";
			this.clearAllFiltersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clearAllFiltersToolStripMenuItem.Text = "Clear All Filters";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFilterEditorToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aboutFilterEditorToolStripMenuItem
			// 
			this.aboutFilterEditorToolStripMenuItem.Name = "aboutFilterEditorToolStripMenuItem";
			this.aboutFilterEditorToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
			this.aboutFilterEditorToolStripMenuItem.Text = "About Filter Editor...";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(1166, 725);
			this.splitContainer1.SplitterDistance = 920;
			this.splitContainer1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.pictureBox2, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(920, 725);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.Location = new System.Drawing.Point(463, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(454, 719);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.Location = new System.Drawing.Point(3, 3);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(454, 719);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.filtersGroupBox, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 714F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(242, 725);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// filtersGroupBox
			// 
			this.filtersGroupBox.Controls.Add(this.activeFiltersList);
			this.filtersGroupBox.Controls.Add(this.buttonDeleteFilter);
			this.filtersGroupBox.Controls.Add(this.buttonEditFilter);
			this.filtersGroupBox.Controls.Add(this.buttonAddFilter);
			this.filtersGroupBox.Location = new System.Drawing.Point(3, 3);
			this.filtersGroupBox.Name = "filtersGroupBox";
			this.filtersGroupBox.Size = new System.Drawing.Size(236, 278);
			this.filtersGroupBox.TabIndex = 0;
			this.filtersGroupBox.TabStop = false;
			this.filtersGroupBox.Text = "Filters";
			// 
			// activeFiltersList
			// 
			this.activeFiltersList.HideSelection = false;
			this.activeFiltersList.Location = new System.Drawing.Point(6, 22);
			this.activeFiltersList.Name = "activeFiltersList";
			this.activeFiltersList.Size = new System.Drawing.Size(224, 139);
			this.activeFiltersList.TabIndex = 4;
			this.activeFiltersList.UseCompatibleStateImageBehavior = false;
			// 
			// buttonDeleteFilter
			// 
			this.buttonDeleteFilter.Location = new System.Drawing.Point(6, 225);
			this.buttonDeleteFilter.Name = "buttonDeleteFilter";
			this.buttonDeleteFilter.Size = new System.Drawing.Size(224, 23);
			this.buttonDeleteFilter.TabIndex = 3;
			this.buttonDeleteFilter.Text = "Delete Filter";
			this.buttonDeleteFilter.UseVisualStyleBackColor = true;
			this.buttonDeleteFilter.Click += new System.EventHandler(this.buttonDeleteFilter_Click);
			// 
			// buttonEditFilter
			// 
			this.buttonEditFilter.Enabled = false;
			this.buttonEditFilter.Location = new System.Drawing.Point(6, 196);
			this.buttonEditFilter.Name = "buttonEditFilter";
			this.buttonEditFilter.Size = new System.Drawing.Size(224, 23);
			this.buttonEditFilter.TabIndex = 2;
			this.buttonEditFilter.Text = "Edit Filter";
			this.buttonEditFilter.UseVisualStyleBackColor = true;
			this.buttonEditFilter.Click += new System.EventHandler(this.buttonEditFilter_Click);
			// 
			// buttonAddFilter
			// 
			this.buttonAddFilter.Location = new System.Drawing.Point(6, 167);
			this.buttonAddFilter.Name = "buttonAddFilter";
			this.buttonAddFilter.Size = new System.Drawing.Size(224, 23);
			this.buttonAddFilter.TabIndex = 1;
			this.buttonAddFilter.Text = "Add Filter";
			this.buttonAddFilter.UseVisualStyleBackColor = true;
			this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1166, 771);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.Text = "Filter Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.filtersGroupBox.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip mainStatusStrip;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox filtersGroupBox;
		private System.Windows.Forms.Button buttonDeleteFilter;
		private System.Windows.Forms.Button buttonEditFilter;
		private System.Windows.Forms.Button buttonAddFilter;
		private System.Windows.Forms.ToolStripMenuItem aboutFilterEditorToolStripMenuItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ListView activeFiltersList;
		private System.Windows.Forms.ToolStripMenuItem addFilterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFilterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearAllFiltersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshPreviewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem autoRefreshToolStripMenuItem;
	}
}

