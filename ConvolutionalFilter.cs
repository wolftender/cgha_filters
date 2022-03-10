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
		private Point anchor;

		public int Width {
			get { return width; }
		}

		public int Height {
			get { return height; }
		}

		public Point Anchor {
			get { return anchor; }
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

		public ConvolutionalFilter (int width, int height, Point anchor, float [] coefficients) {
			this.create (width, height, anchor, coefficients);
		}

		protected void create (int width, int height, Point anchor, float [] coefficients) {
			this.width = width;
			this.height = height;
			this.anchor = anchor;

			// with validation
			this.coefficients = new float [this.width * this.height];
			Coefficients = coefficients;
		}

		public byte [] apply (byte [] bitmap, int imageWidth, int imageHeight, int stride) {
			int channels = stride / imageWidth;
			float divisor = coefficients.Sum ();
			int padding = 4 - (imageWidth * channels % 4);

			byte [] output = new byte [bitmap.Length];

			unsafe {
				Parallel.For (0, channels, (int channel) => {
					int cx, cy, fx, fy, offsetX, offsetY;
					float sum;

					for (int i = 0; i < imageWidth * imageHeight; ++i) {
						cx = i % imageWidth;
						cy = i / imageWidth;

						// apply filter to fragment at (cx, cy)
						sum = 0.0f;

						for (int j = 0; j < width * height; ++j) {
							fx = j % width;
							fy = j / width;

							offsetX = fx - anchor.X;
							offsetY = fy - anchor.Y;

							fx = Math.Min (Math.Max (cx + offsetX, 0), imageWidth - 1);
							fy = Math.Min (Math.Max (cy + offsetY, 0), imageHeight - 1);

							sum += Coefficients [j] * ((float) bitmap [fy * (imageWidth * channels + padding) + fx * channels + channel] / 255.0f);
						}

						output [cy * (imageWidth * channels + padding) + cx * channels + channel] = (byte) Math.Round ((255 * sum) / divisor);
					}
				});
			}

			return output;
		}
	}
}
