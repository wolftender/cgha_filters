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
	public partial class AddFilterForm : Form {
		public struct Selection {
			private int index;
			private string text;

			public int Index {
				get { return index; }
			}

			public string Text {
				get { return text; }
			}

			public Selection (int index, string text) {
				this.index = index;
				this.text = text;
			}
		}

		private Selection selection;

		public Selection SelectedFilter {
			get { return selection; }
		}

		public AddFilterForm (List <string> filterTemplates) {
			InitializeComponent ();

			foreach (string template in filterTemplates) {
				listViewTemplates.Items.Add (template);
			}
		}

		private void buttonAdd_Click (object sender, EventArgs e) {
			DialogResult = DialogResult.OK;
			Close ();
		}

		private void listViewTemplates_SelectedIndexChanged (object sender, EventArgs e) {
			if (listViewTemplates.SelectedItems.Count == 1) {
				buttonAdd.Enabled = true;

				ListViewItem item = listViewTemplates.SelectedItems [0];
				selection = new Selection (item.Index, item.Text);
			} else {
				buttonAdd.Enabled = false;
			}
		}
	}
}
