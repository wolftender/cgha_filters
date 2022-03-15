using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class ValueGrayscaleFilter: IImageFilter {
		public string Name => "Isolate HSV Value Value";

		public byte [] apply (byte [] bitmap, int imageWidth, int imageHeight, int stride) {
			int channels = stride / imageWidth;
			int padding = (4 - (imageWidth * channels % 4)) % 4;
			int scanlineWidth = imageWidth * channels + padding;

			int cx, cy, index;
			byte r, g, b, outColor;

			for (int i = 0; i < imageWidth * imageHeight; ++i) {
				cx = i % imageWidth;
				cy = i / imageWidth;

				index = cy * scanlineWidth + cx * channels;

				r = bitmap [index + 0];
				g = bitmap [index + 1];
				b = bitmap [index + 2];

				outColor = HSVHelper.rgbToHsv (r, g, b).Value;

				bitmap [index + 0] = bitmap [index + 1] = bitmap [index + 2] = outColor;
			}

			return bitmap;
		}
	}
}
