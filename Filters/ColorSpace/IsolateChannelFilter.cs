using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters.ColorSpace {
	public class IsolateChannelFilter : IImageFilter, IEditableFilter {
		private ColorChannel channel;

		public string Name {
			get {
				if (channel == ColorChannel.Red) return "Isolate Red";
				else if (channel == ColorChannel.Green) return "Isolate Green";
				else if (channel == ColorChannel.Blue) return "Isolate Blue";
				else return "Invalid filter";
			}
		}

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			int channels = stride / width;
			int padding = (4 - (width * channels % 4)) % 4;
			int scanlineWidth = width * channels + padding;

			// convert the pixels to floating point vectors
			int cx, cy, index;
			byte isolated;

			for (int i = 0; i < width * height; ++i) {
				cx = i % width;
				cy = i / width;

				index = cy * scanlineWidth + cx * channels;
				isolated = bitmap [index + (((int) channel) % 3)];

				bitmap [index + 0] = isolated;
				bitmap [index + 1] = isolated;
				bitmap [index + 2] = isolated;
			}

			return bitmap;
		}

		public void edit (MainWindow mainWindow) {
			ChannelSelectionForm form = new ChannelSelectionForm (ColorChannel.Red);
			form.ShowDialog (mainWindow);

			channel = form.SelectedChannel;
		}
	}
}
