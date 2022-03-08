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
	public partial class MainWindow : Form {
		private abstract class FilterFactory {
			private string name;
			public string Name { get { return name; } }

			public FilterFactory (string name) {
				this.name = name;
			}
		}
		private class FilterFactory <T> : FilterFactory where T : IImageFilter, new () {
			public FilterFactory (string name) : base (name) { }

			public T construct (MainWindow mainWindow) {
				T filter = new T ();

				if (typeof (T).IsSubclassOf (typeof (IEditableFilter))) {
					(filter as IEditableFilter).edit (mainWindow);
				}

				return filter;
			}
		}

		private List<FilterFactory> filterFactories;
		private List<IImageFilter> imageFilters;

		// bitmaps to display
		private Bitmap bitmap;
		private Bitmap filteredBitmap;

		public Bitmap Bitmap {
			get { return bitmap; }
		}

		public Bitmap FilteredBitmap {
			get { return filteredBitmap; }
		}

		public MainWindow () {
			filterFactories = new List<FilterFactory> ();
			imageFilters = new List<IImageFilter> ();

			// register types of filters (hardcoded)
			// this may be done using metaprogramming later (maybe)


			// end of filter registration

			InitializeComponent ();
		}

		private void refreshView () {
			pictureBox1.Image = bitmap;
			pictureBox2.Image = filteredBitmap;
		}

		private void buttonAddFilter_Click (object sender, EventArgs e) {

		}

		private void buttonEditFilter_Click (object sender, EventArgs e) {

		}

		private void buttonDeleteFilter_Click (object sender, EventArgs e) {

		}

		private void loadImageToolStripMenuItem_Click (object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog ();
			
			if (openFileDialog.ShowDialog () == DialogResult.OK) {
				try {
					string filename = openFileDialog.FileName;

					// load bitmap from file
					bitmap = new Bitmap (Image.FromFile (filename));
					filteredBitmap = bitmap;

					refreshView ();
				} catch (Exception exception) {
					MessageBox.Show ("failed to open specified file, error:\n" + exception.Message, "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void saveImageToolStripMenuItem_Click (object sender, EventArgs e) {

		}

		private void exitToolStripMenuItem_Click (object sender, EventArgs e) {
			Close ();
		}

		private void deleteAllFiltersToolStripMenuItem_Click (object sender, EventArgs e) {

		}
	}
}
