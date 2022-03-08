using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cg_proj_1 {
	abstract class ConvolutionalFilter : IImageFilter {
		private float [] coefficients;
		private int width, height;

		public int Width {
			get { return width; }
		}

		public int Height {
			get { return height; }
		}

		public float [] Coefficients {
			get { return coefficients; }
			protected set {
				if (value.Length != width * height) {
					throw new ArgumentException ("convolutional filter requires " + width * height + " coefficients");
				}

				Array.Copy (value, coefficients, width * height);
			}
		}

		public abstract string Name { get; }

		public ConvolutionalFilter (int width, int height, float [] coefficients) {
			this.width = width;
			this.height = height;

			// with validation
			Coefficients = coefficients;
		}

		public Color [] apply (Color [] bitmap) {
			throw new NotImplementedException ();
		}
	}
}
