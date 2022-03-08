using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class BrightnessCorrection : IImageFilter {
		public string Name => "Brightness Correct.";

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			throw new NotImplementedException ();
		}
	}
}
