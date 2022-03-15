using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class GammaCorrection : IImageFilter {
		public string Name => "Gamma Correct.";

		private float gamma;

		public float Gamma {
			get { return gamma; }
			set { gamma = value; }
		}

		public GammaCorrection () {
			gamma = 0.75f;
		}

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			int filtered;

			for (int i = 0; i < bitmap.Length; ++i) {
				filtered = (int) Math.Round (Math.Pow (bitmap [i] / 255.0f, 1.0f / gamma) * 255);
				bitmap [i] = (byte) Math.Min (255, Math.Max (0, filtered));
			}

			return bitmap;
		}
	}
}
