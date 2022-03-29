
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
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearAllFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutFilterEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBoxFiltered = new System.Windows.Forms.PictureBox();
			this.pictureBoxRaw = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.filtersGroupBox = new System.Windows.Forms.GroupBox();
			this.buttonCustom = new System.Windows.Forms.Button();
			this.activeFiltersList = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.buttonDeleteFilter = new System.Windows.Forms.Button();
			this.buttonEditFilter = new System.Windows.Forms.Button();
			this.buttonAddFilter = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiltered)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.filtersGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainStatusStrip
			// 
			this.mainStatusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mainStatusStrip.Location = new System.Drawing.Point(0, 1006);
			this.mainStatusStrip.Name = "mainStatusStrip";
			this.mainStatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
			this.mainStatusStrip.Size = new System.Drawing.Size(1333, 22);
			this.mainStatusStrip.TabIndex = 0;
			this.mainStatusStrip.Text = "statusStrip1";
			// 
			// menuStrip1
			// 
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			this.menuStrip1.Size = new System.Drawing.Size(1333, 30);
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
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadImageToolStripMenuItem
			// 
			this.loadImageToolStripMenuItem.Name = "loadImageToolStripMenuItem";
			this.loadImageToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
			this.loadImageToolStripMenuItem.Text = "Load Image";
			this.loadImageToolStripMenuItem.Click += new System.EventHandler(this.loadImageToolStripMenuItem_Click);
			// 
			// saveImageToolStripMenuItem
			// 
			this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
			this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
			this.saveImageToolStripMenuItem.Text = "Save Image";
			this.saveImageToolStripMenuItem.Click += new System.EventHandler(this.saveImageToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFilterToolStripMenuItem,
            this.loadFilterToolStripMenuItem,
            this.clearAllFiltersToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// addFilterToolStripMenuItem
			// 
			this.addFilterToolStripMenuItem.Name = "addFilterToolStripMenuItem";
			this.addFilterToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.addFilterToolStripMenuItem.Text = "Add Filter";
			this.addFilterToolStripMenuItem.Click += new System.EventHandler(this.addFilterToolStripMenuItem_Click);
			// 
			// loadFilterToolStripMenuItem
			// 
			this.loadFilterToolStripMenuItem.Name = "loadFilterToolStripMenuItem";
			this.loadFilterToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.loadFilterToolStripMenuItem.Text = "Load Filter";
			// 
			// clearAllFiltersToolStripMenuItem
			// 
			this.clearAllFiltersToolStripMenuItem.Name = "clearAllFiltersToolStripMenuItem";
			this.clearAllFiltersToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
			this.clearAllFiltersToolStripMenuItem.Text = "Clear All Filters";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutFilterEditorToolStripMenuItem});
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// aboutFilterEditorToolStripMenuItem
			// 
			this.aboutFilterEditorToolStripMenuItem.Name = "aboutFilterEditorToolStripMenuItem";
			this.aboutFilterEditorToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
			this.aboutFilterEditorToolStripMenuItem.Text = "About Filter Editor...";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 30);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(1333, 976);
			this.splitContainer1.SplitterDistance = 1084;
			this.splitContainer1.SplitterWidth = 5;
			this.splitContainer1.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.pictureBoxFiltered, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.pictureBoxRaw, 0, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(1084, 976);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// pictureBoxFiltered
			// 
			this.pictureBoxFiltered.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxFiltered.Location = new System.Drawing.Point(545, 4);
			this.pictureBoxFiltered.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBoxFiltered.Name = "pictureBoxFiltered";
			this.pictureBoxFiltered.Size = new System.Drawing.Size(536, 968);
			this.pictureBoxFiltered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxFiltered.TabIndex = 0;
			this.pictureBoxFiltered.TabStop = false;
			// 
			// pictureBoxRaw
			// 
			this.pictureBoxRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxRaw.Location = new System.Drawing.Point(3, 4);
			this.pictureBoxRaw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.pictureBoxRaw.Name = "pictureBoxRaw";
			this.pictureBoxRaw.Size = new System.Drawing.Size(536, 968);
			this.pictureBoxRaw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxRaw.TabIndex = 1;
			this.pictureBoxRaw.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.filtersGroupBox, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 976);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// filtersGroupBox
			// 
			this.filtersGroupBox.Controls.Add(this.buttonCustom);
			this.filtersGroupBox.Controls.Add(this.activeFiltersList);
			this.filtersGroupBox.Controls.Add(this.buttonDeleteFilter);
			this.filtersGroupBox.Controls.Add(this.buttonEditFilter);
			this.filtersGroupBox.Controls.Add(this.buttonAddFilter);
			this.filtersGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.filtersGroupBox.Location = new System.Drawing.Point(3, 4);
			this.filtersGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.filtersGroupBox.Name = "filtersGroupBox";
			this.filtersGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.filtersGroupBox.Size = new System.Drawing.Size(238, 344);
			this.filtersGroupBox.TabIndex = 0;
			this.filtersGroupBox.TabStop = false;
			this.filtersGroupBox.Text = "Filters";
			// 
			// buttonCustom
			// 
			this.buttonCustom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonCustom.Enabled = false;
			this.buttonCustom.Location = new System.Drawing.Point(3, 216);
			this.buttonCustom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonCustom.Name = "buttonCustom";
			this.buttonCustom.Size = new System.Drawing.Size(232, 31);
			this.buttonCustom.TabIndex = 5;
			this.buttonCustom.Text = "Make Custom";
			this.buttonCustom.UseVisualStyleBackColor = true;
			this.buttonCustom.Click += new System.EventHandler(this.buttonCustom_Click);
			// 
			// activeFiltersList
			// 
			this.activeFiltersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
			this.activeFiltersList.Dock = System.Windows.Forms.DockStyle.Top;
			this.activeFiltersList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.activeFiltersList.HideSelection = false;
			this.activeFiltersList.Location = new System.Drawing.Point(3, 24);
			this.activeFiltersList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.activeFiltersList.Name = "activeFiltersList";
			this.activeFiltersList.Size = new System.Drawing.Size(232, 184);
			this.activeFiltersList.TabIndex = 4;
			this.activeFiltersList.UseCompatibleStateImageBehavior = false;
			this.activeFiltersList.View = System.Windows.Forms.View.Details;
			this.activeFiltersList.SelectedIndexChanged += new System.EventHandler(this.activeFiltersList_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Filter Name";
			this.columnHeader1.Width = 160;
			// 
			// buttonDeleteFilter
			// 
			this.buttonDeleteFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonDeleteFilter.Enabled = false;
			this.buttonDeleteFilter.Location = new System.Drawing.Point(3, 247);
			this.buttonDeleteFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonDeleteFilter.Name = "buttonDeleteFilter";
			this.buttonDeleteFilter.Size = new System.Drawing.Size(232, 31);
			this.buttonDeleteFilter.TabIndex = 3;
			this.buttonDeleteFilter.Text = "Delete Filter";
			this.buttonDeleteFilter.UseVisualStyleBackColor = true;
			this.buttonDeleteFilter.Click += new System.EventHandler(this.buttonDeleteFilter_Click);
			// 
			// buttonEditFilter
			// 
			this.buttonEditFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonEditFilter.Enabled = false;
			this.buttonEditFilter.Location = new System.Drawing.Point(3, 278);
			this.buttonEditFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonEditFilter.Name = "buttonEditFilter";
			this.buttonEditFilter.Size = new System.Drawing.Size(232, 31);
			this.buttonEditFilter.TabIndex = 2;
			this.buttonEditFilter.Text = "Edit Filter";
			this.buttonEditFilter.UseVisualStyleBackColor = true;
			this.buttonEditFilter.Click += new System.EventHandler(this.buttonEditFilter_Click);
			// 
			// buttonAddFilter
			// 
			this.buttonAddFilter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.buttonAddFilter.Location = new System.Drawing.Point(3, 309);
			this.buttonAddFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.buttonAddFilter.Name = "buttonAddFilter";
			this.buttonAddFilter.Size = new System.Drawing.Size(232, 31);
			this.buttonAddFilter.TabIndex = 1;
			this.buttonAddFilter.Text = "Add Filter";
			this.buttonAddFilter.UseVisualStyleBackColor = true;
			this.buttonAddFilter.Click += new System.EventHandler(this.buttonAddFilter_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1333, 1028);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.mainStatusStrip);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "MainWindow";
			this.Text = "Filter Editor";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiltered)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxRaw)).EndInit();
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
		private System.Windows.Forms.PictureBox pictureBoxFiltered;
		private System.Windows.Forms.PictureBox pictureBoxRaw;
		private System.Windows.Forms.ListView activeFiltersList;
		private System.Windows.Forms.ToolStripMenuItem addFilterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFilterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearAllFiltersToolStripMenuItem;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button buttonCustom;
	}
}

