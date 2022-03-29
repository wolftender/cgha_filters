using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cg_proj_1.Filters {
	public enum ColorChannel {
		Red = 0, Green = 1, Blue = 2
	}

	public partial class ChannelSelectionForm : Form {
		private ColorChannel selectedChannel;

		public ColorChannel SelectedChannel {
			get { return selectedChannel; }
		}

		public ChannelSelectionForm (ColorChannel defaultChannel) {
			InitializeComponent ();

			selectedChannel = defaultChannel;

			radioRed.Checked = (selectedChannel == ColorChannel.Red);
			radioBlue.Checked = (selectedChannel == ColorChannel.Blue);
			radioGreen.Checked = (selectedChannel == ColorChannel.Green);
		}

		private void buttonApply_Click (object sender, EventArgs e) {
			if (radioRed.Checked) {
				selectedChannel = ColorChannel.Red;
			} else if (radioGreen.Checked) {
				selectedChannel = ColorChannel.Green;
			} else {
				selectedChannel = ColorChannel.Blue;
			}

			DialogResult = DialogResult.OK;
			Close ();
		}
	}
}
