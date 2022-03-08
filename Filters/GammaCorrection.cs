using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class GammaCorrection : IImageFilter {
		public string Name => "Gamma Correct.";

		public byte [] apply (byte [] bitmap) {
			throw new NotImplementedException ();
		}
	}
}
