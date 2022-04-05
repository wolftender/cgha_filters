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

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			int channels = stride / width;
			int padding = (4 - (width * channels % 4)) % 4;
			int scanlineWidth = width * channels + padding;

			int cx, cy;
			double r, g, b;
			for (int i = 0; i < width * height; ++i) {
				cx = i % width;
				cy = i / width;

				r = (double) bitmap [cy * scanlineWidth + cx * channels + 0] / 255.0;
				g = (double) bitmap [cy * scanlineWidth + cx * channels + 1] / 255.0;
				b = (double) bitmap [cy * scanlineWidth + cx * channels + 2] / 255.0;

				if (colorChannels.HasFlag (DitherColorChannel.Red)) {
					r = Math.Round (r * (grayLevels - 1)) * (255.0 / (grayLevels - 1));
					bitmap [cy * scanlineWidth + cx * channels + 0] = (byte) Math.Max (0, Math.Min (255, r));
				}

				if (colorChannels.HasFlag (DitherColorChannel.Green)) {
					g = Math.Round (g * (grayLevels - 1)) * (255.0 / (grayLevels - 1));
					bitmap [cy * scanlineWidth + cx * channels + 1] = (byte) Math.Max (0, Math.Min (255, g));
				}

				if (colorChannels.HasFlag (DitherColorChannel.Blue)) {
					b = Math.Round (b * (grayLevels - 1)) * (255.0 / (grayLevels - 1));
					bitmap [cy * scanlineWidth + cx * channels + 2] = (byte) Math.Max (0, Math.Min (255, b));
				}
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
