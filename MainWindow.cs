using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace cg_proj_1 {
	public partial class MainWindow : Form {
		private abstract class FilterFactory {
			private string name;
			public string Name { get { return name; } }

			public FilterFactory (string name) {
				this.name = name;
			}

			public abstract IImageFilter construct (MainWindow mainWindow);
		}
		private class FilterFactory <T> : FilterFactory where T : IImageFilter, new () {
			public FilterFactory (string name) : base (name) { }

			public override IImageFilter construct (MainWindow mainWindow) {
				T filter = new T ();

				if (filter is IEditableFilter) {
					(filter as IEditableFilter).edit (mainWindow);
				}

				return filter;
			}
		}

		private List<FilterFactory> filterFactories;
		private List<IImageFilter> imageFilters;
		private IImageFilter selectedFilter;
		private int selectedFilterIndex;

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

			filterFactories.Add (new FilterFactory<Filters.CustomMatrixFilter> ("Custom (Convolutional)"));
			filterFactories.Add (new FilterFactory<Filters.GrayscaleFilter> ("Grayscale"));
			filterFactories.Add (new FilterFactory<Filters.GaussianSmoothing> ("Gaussian Smoothing"));
			filterFactories.Add (new FilterFactory<Filters.SharpenFilter> ("Sharpen"));
			filterFactories.Add (new FilterFactory<Filters.InvertFilter> ("Invert"));
			filterFactories.Add (new FilterFactory<Filters.EdgeDetectionFilter> ("Edge Detection"));
			filterFactories.Add (new FilterFactory<Filters.EmbossFilter> ("Emboss"));
			filterFactories.Add (new FilterFactory<Filters.BrightnessCorrection> ("Brightness correction"));
			filterFactories.Add (new FilterFactory<Filters.ContrastEnhance> ("Contrast enhnancement"));
			filterFactories.Add (new FilterFactory<Filters.GammaCorrection> ("Gamma correction"));
			filterFactories.Add (new FilterFactory<Filters.SimpleBlur> ("Naive blur"));

			// end of filter registration

			InitializeComponent ();
		}

		private Bitmap filter (Bitmap bitmap) {
			BitmapData bitmapData = bitmap.LockBits (new Rectangle (0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);

			int size = bitmapData.Stride * bitmap.Height;
			byte [] pixels = new byte [size];

			Marshal.Copy (bitmapData.Scan0, pixels, 0, size);
			bitmap.UnlockBits (bitmapData);

			foreach (IImageFilter filter in imageFilters) {
				byte [] filteredPixels = filter.apply (pixels, bitmap.Width, bitmap.Height, bitmapData.Stride);
				Array.Copy (filteredPixels, pixels, size);
			}

			Bitmap output = new Bitmap (bitmap.Width, bitmap.Height, PixelFormat.Format24bppRgb);
			BitmapData outputData = output.LockBits (new Rectangle (0, 0, output.Width, output.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			Marshal.Copy (pixels, 0, outputData.Scan0, size);
			output.UnlockBits (outputData);

			return output;
		}

		private void refreshView () {
			pictureBoxRaw.Image = bitmap;

			// auto refresh
			if (bitmap != null) {
				filteredBitmap = filter (bitmap);
			}

			pictureBoxFiltered.Image = filteredBitmap;
		}

		private void refreshFilterList () {
			activeFiltersList.Items.Clear ();

			foreach (IImageFilter filter in imageFilters) {
				activeFiltersList.Items.Add (filter.Name);
			}
		}

		private void buttonAddFilter_Click (object sender, EventArgs e) {
			List<string> templates = new List<string> ();
			foreach (FilterFactory factory in filterFactories) {
				templates.Add (factory.Name);
			}

			AddFilterForm addFilterDialog = new AddFilterForm (templates);

			if (addFilterDialog.ShowDialog () == DialogResult.OK) {
				int filterTypeIndex = addFilterDialog.SelectedFilter.Index;

				// instantiate filter from factory
				IImageFilter newFilter = filterFactories [filterTypeIndex].construct (this);
				imageFilters.Add (newFilter);

				refreshFilterList ();
				refreshView ();
			}
		}

		private void buttonEditFilter_Click (object sender, EventArgs e) {
			if (selectedFilter != null) {
				if (selectedFilter is IEditableFilter) {
					(selectedFilter as IEditableFilter).edit (this);
					refreshView ();
				}
			}
		}

		private void buttonDeleteFilter_Click (object sender, EventArgs e) {
			if (selectedFilter != null) {
				imageFilters.Remove (selectedFilter);
				selectedFilter = null;

				refreshView ();
				refreshFilterList ();
			}
		}

		private void loadImageToolStripMenuItem_Click (object sender, EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog ();
			
			if (openFileDialog.ShowDialog () == DialogResult.OK) {
				try {
					string filename = openFileDialog.FileName;

					// load bitmap from file
					Image image = Image.FromFile (filename);

					bitmap = new Bitmap (image.Width, image.Height, PixelFormat.Format24bppRgb);
					Graphics ctx = Graphics.FromImage (bitmap);
					ctx.DrawImage (image, 0, 0);
					ctx.Dispose ();

					filteredBitmap = bitmap;
					image.Dispose ();

					refreshView ();
				} catch (Exception exception) {
					MessageBox.Show ("failed to open specified file, error:\n" + exception.Message, "file error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void saveImageToolStripMenuItem_Click (object sender, EventArgs e) {
			SaveFileDialog saveFileDialog = new SaveFileDialog ();
			saveFileDialog.DefaultExt = "png";

			if (saveFileDialog.ShowDialog () == DialogResult.OK) {
				try {
					if (filteredBitmap != null) {
						refreshView ();
						filteredBitmap.Save (saveFileDialog.FileName);
					} else {
						MessageBox.Show ("bitmap is null", "save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				} catch (Exception exception) {
					MessageBox.Show ("failed to save filtered image to file, error:\n" + exception.Message, "save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void exitToolStripMenuItem_Click (object sender, EventArgs e) {
			Close ();
		}

		private void deleteAllFiltersToolStripMenuItem_Click (object sender, EventArgs e) {
			if (MessageBox.Show ("Are you sure", "Are you sure that you want to delete all filters?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
				selectedFilter = null;
				imageFilters.Clear ();

				refreshView ();
				refreshFilterList ();
			}
		}

		private void activeFiltersList_SelectedIndexChanged (object sender, EventArgs e) {
			buttonDeleteFilter.Enabled = false;
			buttonEditFilter.Enabled = false;

			if (activeFiltersList.SelectedItems.Count == 1) {
				int index = activeFiltersList.SelectedItems [0].Index;
				
				if (imageFilters.Count > index) {
					IImageFilter filter = imageFilters [index];

					selectedFilter = filter;
					selectedFilterIndex = index;

					buttonDeleteFilter.Enabled = true;
					buttonEditFilter.Enabled = (filter is IEditableFilter);
					buttonCustom.Enabled = (filter is ConvolutionalFilter);
				}
			}
		}

		private void buttonCustom_Click (object sender, EventArgs e) {
			if (selectedFilter != null) {
				if (selectedFilter is ConvolutionalFilter) {
					Filters.CustomMatrixFilter newFilter = Filters.CustomMatrixFilter.From (selectedFilter as ConvolutionalFilter);
					imageFilters.Add (newFilter);

					refreshView ();
					refreshFilterList ();
				}
			}
		}
	}
}
