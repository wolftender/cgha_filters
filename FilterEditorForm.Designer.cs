
namespace cg_proj_1 {
	partial class FilterEditorForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBoxMatrixOptions = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.numericPivotY = new System.Windows.Forms.NumericUpDown();
			this.numericPivotX = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.numericHeight = new System.Windows.Forms.NumericUpDown();
			this.numericWidth = new System.Windows.Forms.NumericUpDown();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonAccept = new System.Windows.Forms.Button();
			this.dataGridFilter = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBoxMatrixOptions.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericPivotY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPivotX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWidth)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridFilter)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.dataGridFilter, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(703, 443);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.groupBoxMatrixOptions, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(506, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 437);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// groupBoxMatrixOptions
			// 
			this.groupBoxMatrixOptions.Controls.Add(this.label4);
			this.groupBoxMatrixOptions.Controls.Add(this.label3);
			this.groupBoxMatrixOptions.Controls.Add(this.numericPivotY);
			this.groupBoxMatrixOptions.Controls.Add(this.numericPivotX);
			this.groupBoxMatrixOptions.Controls.Add(this.label2);
			this.groupBoxMatrixOptions.Controls.Add(this.label1);
			this.groupBoxMatrixOptions.Controls.Add(this.numericHeight);
			this.groupBoxMatrixOptions.Controls.Add(this.numericWidth);
			this.groupBoxMatrixOptions.Location = new System.Drawing.Point(3, 3);
			this.groupBoxMatrixOptions.Name = "groupBoxMatrixOptions";
			this.groupBoxMatrixOptions.Size = new System.Drawing.Size(188, 331);
			this.groupBoxMatrixOptions.TabIndex = 0;
			this.groupBoxMatrixOptions.TabStop = false;
			this.groupBoxMatrixOptions.Text = "Filter Options";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 138);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(44, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Pivot Y";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Pivot X";
			// 
			// numericPivotY
			// 
			this.numericPivotY.Location = new System.Drawing.Point(70, 135);
			this.numericPivotY.Name = "numericPivotY";
			this.numericPivotY.Size = new System.Drawing.Size(108, 23);
			this.numericPivotY.TabIndex = 5;
			this.numericPivotY.ValueChanged += new System.EventHandler(this.numericPivotY_ValueChanged);
			// 
			// numericPivotX
			// 
			this.numericPivotX.Location = new System.Drawing.Point(70, 105);
			this.numericPivotX.Name = "numericPivotX";
			this.numericPivotX.Size = new System.Drawing.Size(108, 23);
			this.numericPivotX.TabIndex = 4;
			this.numericPivotX.ValueChanged += new System.EventHandler(this.numericPivotX_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(43, 15);
			this.label2.TabIndex = 3;
			this.label2.Text = "Height";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(39, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Width";
			// 
			// numericHeight
			// 
			this.numericHeight.Location = new System.Drawing.Point(70, 61);
			this.numericHeight.Name = "numericHeight";
			this.numericHeight.Size = new System.Drawing.Size(108, 23);
			this.numericHeight.TabIndex = 1;
			this.numericHeight.ValueChanged += new System.EventHandler(this.numericHeight_ValueChanged);
			// 
			// numericWidth
			// 
			this.numericWidth.Location = new System.Drawing.Point(70, 31);
			this.numericWidth.Name = "numericWidth";
			this.numericWidth.Size = new System.Drawing.Size(108, 23);
			this.numericWidth.TabIndex = 0;
			this.numericWidth.ValueChanged += new System.EventHandler(this.numericWidth_ValueChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.buttonAccept);
			this.panel1.Location = new System.Drawing.Point(3, 340);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(188, 94);
			this.panel1.TabIndex = 1;
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(3, 32);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(182, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// buttonAccept
			// 
			this.buttonAccept.Location = new System.Drawing.Point(3, 3);
			this.buttonAccept.Name = "buttonAccept";
			this.buttonAccept.Size = new System.Drawing.Size(182, 23);
			this.buttonAccept.TabIndex = 0;
			this.buttonAccept.Text = "Apply";
			this.buttonAccept.UseVisualStyleBackColor = true;
			this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
			// 
			// dataGridFilter
			// 
			this.dataGridFilter.AllowUserToAddRows = false;
			this.dataGridFilter.AllowUserToDeleteRows = false;
			this.dataGridFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridFilter.ColumnHeadersVisible = false;
			this.dataGridFilter.Location = new System.Drawing.Point(3, 3);
			this.dataGridFilter.Name = "dataGridFilter";
			this.dataGridFilter.RowHeadersVisible = false;
			this.dataGridFilter.RowTemplate.Height = 25;
			this.dataGridFilter.Size = new System.Drawing.Size(497, 434);
			this.dataGridFilter.TabIndex = 1;
			this.dataGridFilter.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridFilter_CellValueChanged);
			// 
			// FilterEditorForm
			// 
			this.AcceptButton = this.buttonAccept;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(727, 467);
			this.Controls.Add(this.tableLayoutPanel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FilterEditorForm";
			this.Text = "Convolutional Filter Editor";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBoxMatrixOptions.ResumeLayout(false);
			this.groupBoxMatrixOptions.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericPivotY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericPivotX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericWidth)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridFilter)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBoxMatrixOptions;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonAccept;
		private System.Windows.Forms.DataGridView dataGridFilter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericHeight;
		private System.Windows.Forms.NumericUpDown numericWidth;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown numericPivotY;
		private System.Windows.Forms.NumericUpDown numericPivotX;
	}
}