using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class BrightnessCorrection : IImageFilter {
		public string Name => "Brightness Correct.";

		public Color [] apply (Color [] bitmap) {
			throw new NotImplementedException ();
		}
	}
}
