using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class ContrastEnhance : IImageFilter {
		public string Name => "Contrast Enhance";

		private float slope;

		public float Slope {
			get { return slope; }
			set { slope = value; }
		}

		public ContrastEnhance () {
			slope = 1.25f;
		}

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			int intercept = (int) ((1 - slope) * 127);
			int filtered;

			for (int i = 0; i < bitmap.Length; ++i) {
				filtered = (int) Math.Round (slope * bitmap [i]) + intercept;
				bitmap [i] = (byte) Math.Min (255, Math.Max (0, filtered));
			}

			return bitmap;
		}
	}
}
