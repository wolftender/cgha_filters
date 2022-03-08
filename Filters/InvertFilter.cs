using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class InvertFilter : IImageFilter {
		public string Name => "Invert Filter";

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			byte [] filtered = new byte [bitmap.Length];

			unsafe {
				for (int i = 0; i < bitmap.Length; ++i) {
					filtered [i] = (byte) (255 - bitmap [i]);
				}
			}

			return filtered;
		}
	}
}
