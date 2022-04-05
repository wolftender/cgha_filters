using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cg_proj_1 {
	[Flags]
	public enum DitherColorChannel {
		Red = 1 << 0,
		Green = 1 << 1,
		Blue = 1 << 2
	}

	public partial class AverageDitheringForm : Form {
		private DitherColorChannel channels;
		private int grayLevels;

		public DitherColorChannel Channels {
			get { return channels; }
		}

		public int GrayLevels {
			get { return grayLevels; }
		}

		public AverageDitheringForm (DitherColorChannel channels, int grayLevels = 4) {
			this.channels = channels;
			this.grayLevels = grayLevels;

			InitializeComponent ();

			checkBoxRed.Checked = channels.HasFlag (DitherColorChannel.Red);
			checkBoxGreen.Checked = channels.HasFlag (DitherColorChannel.Green);
			checkBoxBlue.Checked = channels.HasFlag (DitherColorChannel.Blue);
		}

		private void buttonApply_Click (object sender, EventArgs e) {
			channels = 0;

			if (checkBoxRed.Checked) channels |= DitherColorChannel.Red;
			if (checkBoxGreen.Checked) channels |= DitherColorChannel.Green;
			if (checkBoxBlue.Checked) channels |= DitherColorChannel.Blue;

			grayLevels = (int) Math.Min (255, Math.Max (2, numericGrayLevels.Value));

			DialogResult = DialogResult.OK;
			Close ();
		}
	}
}
