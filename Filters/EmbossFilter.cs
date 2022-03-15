using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class EmbossFilter : ConvolutionalFilter {
		public override string Name => "Emboss";

		public EmbossFilter () : base (3, 3, new System.Drawing.Point (1, 1), new float [] {
			-1f, -1f, 0f,
			-1f, 1f, 1f,
			0f, 1f, 1f
		}) { }
	}
}
