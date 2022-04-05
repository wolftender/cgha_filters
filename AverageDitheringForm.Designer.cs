
namespace cg_proj_1 {
	partial class AverageDitheringForm {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBoxRed = new System.Windows.Forms.CheckBox();
			this.checkBoxGreen = new System.Windows.Forms.CheckBox();
			this.checkBoxBlue = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.numericGrayLevels = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonApply = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericGrayLevels)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.checkBoxBlue);
			this.groupBox1.Controls.Add(this.checkBoxGreen);
			this.groupBox1.Controls.Add(this.checkBoxRed);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(222, 126);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Color channels";
			// 
			// checkBoxRed
			// 
			this.checkBoxRed.AutoSize = true;
			this.checkBoxRed.Location = new System.Drawing.Point(11, 41);
			this.checkBoxRed.Name = "checkBoxRed";
			this.checkBoxRed.Size = new System.Drawing.Size(46, 19);
			this.checkBoxRed.TabIndex = 0;
			this.checkBoxRed.Text = "Red";
			this.checkBoxRed.UseVisualStyleBackColor = true;
			// 
			// checkBoxGreen
			// 
			this.checkBoxGreen.AutoSize = true;
			this.checkBoxGreen.Location = new System.Drawing.Point(11, 66);
			this.checkBoxGreen.Name = "checkBoxGreen";
			this.checkBoxGreen.Size = new System.Drawing.Size(57, 19);
			this.checkBoxGreen.TabIndex = 1;
			this.checkBoxGreen.Text = "Green";
			this.checkBoxGreen.UseVisualStyleBackColor = true;
			// 
			// checkBoxBlue
			// 
			this.checkBoxBlue.AutoSize = true;
			this.checkBoxBlue.Location = new System.Drawing.Point(11, 91);
			this.checkBoxBlue.Name = "checkBoxBlue";
			this.checkBoxBlue.Size = new System.Drawing.Size(49, 19);
			this.checkBoxBlue.TabIndex = 2;
			this.checkBoxBlue.Text = "Blue";
			this.checkBoxBlue.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "Which color channels to dither";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.numericGrayLevels);
			this.groupBox2.Location = new System.Drawing.Point(12, 144);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(222, 63);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Gray levels";
			// 
			// numericGrayLevels
			// 
			this.numericGrayLevels.Location = new System.Drawing.Point(117, 20);
			this.numericGrayLevels.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.numericGrayLevels.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
			this.numericGrayLevels.Name = "numericGrayLevels";
			this.numericGrayLevels.Size = new System.Drawing.Size(94, 23);
			this.numericGrayLevels.TabIndex = 0;
			this.numericGrayLevels.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Gray level count";
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(159, 223);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 2;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// AverageDitheringForm
			// 
			this.AcceptButton = this.buttonApply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(246, 258);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AverageDitheringForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Average dithering";
			this.TopMost = true;
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericGrayLevels)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBoxBlue;
		private System.Windows.Forms.CheckBox checkBoxGreen;
		private System.Windows.Forms.CheckBox checkBoxRed;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown numericGrayLevels;
		private System.Windows.Forms.Button buttonApply;
	}
}