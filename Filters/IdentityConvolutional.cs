using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cg_proj_1.Filters {
	class IdentityConvolutional : ConvolutionalFilter {
		public override string Name => "Identity (Convolution)";
		public IdentityConvolutional () : base (3, 3, new Point (1, 1),
			new float [] {
				0.0f, 0.0f, 0.0f,
				0.0f, 1.0f, 0.0f,
				0.0f, 0.0f, 0.0f
			}) { }
	}
}
