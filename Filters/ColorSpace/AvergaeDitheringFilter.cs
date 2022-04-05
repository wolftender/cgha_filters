using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters.ColorSpace {
	public class AvergaeDitheringFilter : IImageFilter, IEditableFilter {
		private DitherColorChannel colorChannels = 0;
		private int grayLevels = 4;

		public string Name => "Average dithering";

		public static void AverageDithering (ref double [] values, int numLevels) {
			double [] sums = new double [numLevels];
			int [] counts = new int [numLevels];
			int [] group = new int [values.Length];

			for (int i = 0; i < values.Length; ++i) {
				group [i] = (int) Math.Round ((values [i] / 255.0f) * (numLevels - 1));
				sums [group [i]] += values [i];
				counts [group [i]]++;
			}

			int g;
			for (int i = 0; i < values.Length; ++i) {
				g = group [i];
				values [i] = sums [g] / counts [g];
			}
		}

		private byte clampByte (double value) {
			return (byte) Math.Max (0, Math.Min (255, value));
		}

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			int channels = stride / width;
			int padding = (4 - (width * channels % 4)) % 4;
			int scanlineWidth = width * channels + padding;

			int cx, cy;
			double r, g, b;
			double [] R = new double [width * height];
			double [] G = new double [width * height];
			double [] B = new double [width * height];

			for (int i = 0; i < width * height; ++i) {
				cx = i % width;
				cy = i / width;

				r = (double) bitmap [cy * scanlineWidth + cx * channels + 0];
				g = (double) bitmap [cy * scanlineWidth + cx * channels + 1];
				b = (double) bitmap [cy * scanlineWidth + cx * channels + 2];

				R [cy * width + cx] = r;
				G [cy * width + cx] = g;
				B [cy * width + cx] = b;
			}

			if (colorChannels.HasFlag (DitherColorChannel.Red)) {
				AverageDithering (ref R, grayLevels);
			}

			if (colorChannels.HasFlag (DitherColorChannel.Green)) {
				AverageDithering (ref G, grayLevels);
			}

			if (colorChannels.HasFlag (DitherColorChannel.Blue)) {
				AverageDithering (ref B, grayLevels);
			}

			for (int i = 0; i < width * height; ++i) {
				cx = i % width;
				cy = i / width;

				bitmap [cy * scanlineWidth + cx * channels + 0] = clampByte (R[i]);
				bitmap [cy * scanlineWidth + cx * channels + 1] = clampByte (G[i]);
				bitmap [cy * scanlineWidth + cx * channels + 2] = clampByte (B[i]);
			}

			return bitmap;
		}

		public void edit (MainWindow mainWindow) {
			AverageDitheringForm form = new AverageDitheringForm (colorChannels, grayLevels);
			form.ShowDialog (mainWindow);

			colorChannels = form.Channels;
			grayLevels = form.GrayLevels;
		}
	}
}
