using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class LaplacianFilter : ConvolutionalFilter {
		public override string Name => "Laplacian of Gaussian";

		public LaplacianFilter () : base (9, 9, new System.Drawing.Point (4, 4), new float [] {
			0.0f, 1.0f, 1.0f, 2.0f, 2.0f, 2.0f, 1.0f, 1.0f, 0.0f, 1.0f, 2.0f, 4.0f, 5.0f, 5.0f, 5.0f, 4.0f, 2.0f, 1.0f, 1.0f, 4.0f, 5.0f, 3.0f, 0.0f, 3.0f, 5.0f, 4.0f, 1.0f, 2.0f, 5.0f, 3.0f, -12.0f, -24.0f, -12.0f, 3.0f, 5.0f, 2.0f, 2.0f, 5.0f, 0.0f, -24.0f, -40.0f, -24.0f, 0.0f, 5.0f, 2.0f, 2.0f, 5.0f, 3.0f, -12.0f, -24.0f, -12.0f, 3.0f, 5.0f, 2.0f, 1.0f, 4.0f, 5.0f, 3.0f, 0.0f, 3.0f, 5.0f, 4.0f, 1.0f, 1.0f, 2.0f, 4.0f, 5.0f, 5.0f, 5.0f, 4.0f, 2.0f, 1.0f, 0.0f, 1.0f, 1.0f, 2.0f, 2.0f, 2.0f, 1.0f, 1.0f, 0.0f
		}) { }
	}
}
