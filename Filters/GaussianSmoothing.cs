using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cg_proj_1.Filters {
	class GaussianSmoothing : ConvolutionalFilter {
		public override string Name => "Gaussian Smoothing";

		public GaussianSmoothing () : base (5, 5, new Point (2, 2), 
			new float [] { 
				1f, 4f, 6f, 4f, 1f,
				4f, 16f, 24f, 16f, 4f,
				6f, 24f, 36f, 24f, 6f,
				4f, 16f, 24f, 16f, 4f,
				1f, 4f, 6f, 4f, 1f
			}
		) { }
	}
}
