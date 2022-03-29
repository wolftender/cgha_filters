
namespace cg_proj_1.Filters {
	partial class ChannelSelectionForm {
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
			this.groupBoxChannel = new System.Windows.Forms.GroupBox();
			this.radioBlue = new System.Windows.Forms.RadioButton();
			this.radioGreen = new System.Windows.Forms.RadioButton();
			this.radioRed = new System.Windows.Forms.RadioButton();
			this.buttonApply = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBoxChannel.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxChannel
			// 
			this.groupBoxChannel.Controls.Add(this.radioBlue);
			this.groupBoxChannel.Controls.Add(this.radioGreen);
			this.groupBoxChannel.Controls.Add(this.radioRed);
			this.groupBoxChannel.Location = new System.Drawing.Point(12, 36);
			this.groupBoxChannel.Name = "groupBoxChannel";
			this.groupBoxChannel.Size = new System.Drawing.Size(162, 115);
			this.groupBoxChannel.TabIndex = 0;
			this.groupBoxChannel.TabStop = false;
			this.groupBoxChannel.Text = "Color Channel";
			// 
			// radioBlue
			// 
			this.radioBlue.AutoSize = true;
			this.radioBlue.Location = new System.Drawing.Point(22, 78);
			this.radioBlue.Name = "radioBlue";
			this.radioBlue.Size = new System.Drawing.Size(48, 19);
			this.radioBlue.TabIndex = 2;
			this.radioBlue.TabStop = true;
			this.radioBlue.Text = "Blue";
			this.radioBlue.UseVisualStyleBackColor = true;
			// 
			// radioGreen
			// 
			this.radioGreen.AutoSize = true;
			this.radioGreen.Location = new System.Drawing.Point(22, 53);
			this.radioGreen.Name = "radioGreen";
			this.radioGreen.Size = new System.Drawing.Size(56, 19);
			this.radioGreen.TabIndex = 1;
			this.radioGreen.TabStop = true;
			this.radioGreen.Text = "Green";
			this.radioGreen.UseVisualStyleBackColor = true;
			// 
			// radioRed
			// 
			this.radioRed.AutoSize = true;
			this.radioRed.Location = new System.Drawing.Point(22, 28);
			this.radioRed.Name = "radioRed";
			this.radioRed.Size = new System.Drawing.Size(45, 19);
			this.radioRed.TabIndex = 0;
			this.radioRed.TabStop = true;
			this.radioRed.Text = "Red";
			this.radioRed.UseVisualStyleBackColor = true;
			// 
			// buttonApply
			// 
			this.buttonApply.Location = new System.Drawing.Point(99, 159);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 1;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(116, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select color channel:";
			// 
			// ChannelSelectionForm
			// 
			this.AcceptButton = this.buttonApply;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(186, 192);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonApply);
			this.Controls.Add(this.groupBoxChannel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ChannelSelectionForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Color Channel";
			this.TopMost = true;
			this.groupBoxChannel.ResumeLayout(false);
			this.groupBoxChannel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxChannel;
		private System.Windows.Forms.RadioButton radioBlue;
		private System.Windows.Forms.RadioButton radioGreen;
		private System.Windows.Forms.RadioButton radioRed;
		private System.Windows.Forms.Button buttonApply;
		private System.Windows.Forms.Label label1;
	}
}