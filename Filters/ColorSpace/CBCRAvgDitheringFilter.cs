using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters.ColorSpace {
	public class CBCRAvgDitheringFilter : IImageFilter, IEditableFilter {
		public string Name => "CBCR Average Dither.";

		private int grayLevels = 4;

		private byte clampByte (double value) {
			return (byte) Math.Max (0, Math.Min (255, value));
		}

		private (double yp, double cb, double cr) toYpCbCr (double r, double g, double b) {
			double yp = 0.299 * r + 0.587 * g + 0.114 * b;
			double cb = 128.0 - 0.168 * r - 0.331 * g + 0.5 * b;
			double cr = 128.0 + 0.5 * r - 0.419 * g - 0.081 * b;

			return (yp, cb, cr);
		}

		private (byte r, byte g, byte b) toRGB (double yp, double cb, double cr) {
			double dr = yp + 1.402 * (cr - 128.0);
			double dg = yp - 0.334 * (cb - 128.0) - 0.714 * (cr - 128.0);
			double db = yp + 1.772 * (cb - 128.0);

			return (clampByte (dr), clampByte (dg), clampByte (db));
		}

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			int channels = stride / width;
			int padding = (4 - (width * channels % 4)) % 4;
			int scanlineWidth = width * channels + padding;

			int cx, cy;
			double r, g, b;
			(double yp, double cb, double cr) converted;
			(byte r, byte g, byte b) outColor;

			double [] YP = new double [width * height];
			double [] CB = new double [width * height];
			double [] CR = new double [width * height];

			for (int i = 0; i < width * height; ++i) {
				cx = i % width;
				cy = i / width;

				r = (double) bitmap [cy * scanlineWidth + cx * channels + 0];
				g = (double) bitmap [cy * scanlineWidth + cx * channels + 1];
				b = (double) bitmap [cy * scanlineWidth + cx * channels + 2];

				converted = toYpCbCr (r, g, b);

				YP [i] = converted.yp;
				CB [i] = converted.cb;
				CR [i] = converted.cr;
			}

			AvergaeDitheringFilter.AverageDithering (ref YP, grayLevels);
			AvergaeDitheringFilter.AverageDithering (ref CB, grayLevels);
			AvergaeDitheringFilter.AverageDithering (ref CR, grayLevels);

			for (int i = 0; i < width * height; ++i) {
				cx = i % width;
				cy = i / width;

				outColor = toRGB (YP [i], CB [i], CR [i]);

				bitmap [cy * scanlineWidth + cx * channels + 0] = outColor.r;
				bitmap [cy * scanlineWidth + cx * channels + 1] = outColor.g;
				bitmap [cy * scanlineWidth + cx * channels + 2] = outColor.b;
			}

			return bitmap;
		}

		public void edit (MainWindow mainWindow) {
			IntegerDialogForm editForm = new IntegerDialogForm ("Y'CbCr Dithering", "Gray levels: ", grayLevels, 2, 255);
			editForm.ShowDialog (mainWindow);

			grayLevels = editForm.InputNumber;
		}
	}
}
