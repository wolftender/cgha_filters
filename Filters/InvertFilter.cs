using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class InvertFilter : IImageFilter {
		public string Name => "Invert Filter";

		public Color [] apply (Color [] bitmap) {
			Color [] filtered = new Color [bitmap.Length];

			unsafe {
				for (int i = 0; i < bitmap.Length; ++i) {
					filtered [i] = Color.FromArgb (255 - bitmap [i].R, 255 - bitmap [i].G, 255 - bitmap [i].B);
				}
			}

			return filtered;
		}
	}
}
