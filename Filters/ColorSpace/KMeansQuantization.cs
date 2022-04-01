using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters.ColorSpace {
	public class KMeansQuantization : IImageFilter, IEditableFilter {
		// structure representing the float-based color vector
		private class ColorVector {
			public float R { get; set; }
			public float G { get; set; }
			public float B { get; set; }

			public byte RedByte {
				get { return (byte) Math.Max (0, Math.Min (255, R * 255)); }
			}

			public byte GreenByte {
				get { return (byte) Math.Max (0, Math.Min (255, G * 255)); }
			}

			public byte BlueByte {
				get { return (byte) Math.Max (0, Math.Min (255, B * 255)); }
			}

			public ColorVector (float r, float g, float b) {
				R = r;
				G = g;
				B = b;
			}

			public float distance (ColorVector a) {
				return distance (this, a);
			}

			public float distance (float r, float g, float b) {
				float dr = R - r;
				float dg = G - g;
				float db = B - b;

				return (float) Math.Sqrt (dr * dr + dg * dg + db * db);
			}

			public static float distance (ColorVector a, ColorVector b) {
				float dr = a.R - b.R;
				float dg = a.G - b.G;
				float db = a.B - b.B;

				return (float) Math.Sqrt (dr * dr + dg * dg + db * db);
			}
		};

		public string Name => "K-Means Quantization";

		private const int MAX_KMEANS_ITERATIONS = 30;
		private const float KMEANS_EPSILON = 0.02f;

		private int countColors = 30;

		private void chooseRandomCentroids (List<ColorVector> centroids, ref ColorVector [] vectors, int numCentroids) {
			// we select random centroids by performing following algorithm:
			//  1. list all indices for vectors (1, ..., n)
			//  2. shuffle all the indices
			//  3. select m first indices from the shuffled list
			//  4. return m vectors from the set that are labeled by the selected first m indices

			int [] indices = new int [vectors.Length];
			for (int i = 0; i < vectors.Length; ++i) indices [i] = i;

			// shuffle indices
			Random rng = new Random ();
			int swapIndex, tmp;
			for (int sourceIndex = indices.Length - 1; sourceIndex > 1; --sourceIndex) {
				swapIndex = rng.Next (sourceIndex);
				if (swapIndex != sourceIndex) {
					tmp = indices [swapIndex];
					indices [swapIndex] = indices [sourceIndex];
					indices [sourceIndex] = tmp;
				}
			}

			// clear the output buffer
			centroids.Clear ();

			// return the centroids
			for (int i = 0; i < numCentroids; ++i) {
				centroids.Add (vectors [indices [i]]);
			}
		}

		private (List<ColorVector>, int []) kmeans (ColorVector [] vectors, int numCentroids) {
			// performance measurements
			Stopwatch stopwatch = new Stopwatch ();

			List<ColorVector> centroids = new List<ColorVector> ();

			// choose initial centroids
			// this can be later replaced with k-means++!
			stopwatch.Start ();
			chooseRandomCentroids (centroids, ref vectors, numCentroids);
			stopwatch.Stop ();
			Debug.WriteLine ("[k-means] selected initial centroids in {0} ms", stopwatch.ElapsedMilliseconds);

			// this will be used for averages
			//  1. ColorVector holds the sum for all channels
			//  2. int holds the count of vectors
			(ColorVector, int) [] sums = new (ColorVector, int) [centroids.Count];
			for (int i = 0; i < centroids.Count; ++i) sums [i] = (new ColorVector (0.0f, 0.0f, 0.0f), 0);

			// this will be used to store relationships between vectors and centroids
			// if vectorCentroid[i] == k then vectors[i] belongs to centroids[k]
			int [] vectorCentroid = new int [vectors.Length];

			for (int iteration = 0; iteration < MAX_KMEANS_ITERATIONS; ++iteration) {
				stopwatch.Start ();

				// each iteration of the algorithm works as follows:
				//   1. for each vector in the set
				//      a) find centroid with smallest distance
				//      b) add this vector to the centroid
				//   2. compute average for each centroid
				//   3. use each average as new centroid

				// clear the data before iteration
				for (int i = 0; i < centroids.Count; ++i) {
					sums [i].Item1.R = sums [i].Item1.G = sums [i].Item1.B = 0.0f;
					sums [i].Item2 = 0;
				}

				// for each vector
				Parallel.For (0, vectors.Length, (int v) => {
					float minDistance = 10000.0f, distance;

					// select lowest distance centroid
					for (int c = 0; c < centroids.Count; ++c) {
						distance = ColorVector.distance (vectors [v], centroids [c]);
						if (distance < minDistance) {
							minDistance = distance;
							vectorCentroid [v] = c;
						}
					}
				});

				int ct;
				for (int v = 0; v < vectors.Length; ++v) {
					ct = vectorCentroid [v];

					// and compute the mean
					sums [ct].Item1.R += vectors [v].R;
					sums [ct].Item1.G += vectors [v].G;
					sums [ct].Item1.B += vectors [v].B;
					sums [ct].Item2++;
				}

				// compute new centroids
				float nr, ng, nb, difference, maxDifference = 0.0f;
				for (int i = 0; i < centroids.Count; ++i) {
					nr = sums [i].Item1.R / sums [i].Item2;
					ng = sums [i].Item1.G / sums [i].Item2;
					nb = sums [i].Item1.B / sums [i].Item2;

					difference = centroids [i].distance (nr, ng, nb);
					if (difference > maxDifference) maxDifference = difference;

					centroids [i].R = nr;
					centroids [i].G = ng;
					centroids [i].B = nb;
				}

				if (maxDifference < KMEANS_EPSILON) break;

				stopwatch.Stop ();
				Debug.WriteLine ("[k-means] executed {0}-th iteration in {1} ms", iteration, stopwatch.ElapsedMilliseconds);
			}

			return (centroids, vectorCentroid);
		}

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			int channels = stride / width;
			int padding = (4 - (width * channels % 4)) % 4;
			int scanlineWidth = width * channels + padding;

			byte [] output = new byte [bitmap.Length];
			ColorVector [] pixels = new ColorVector [width * height];

			// convert the pixels to floating point vectors
			int cx, cy;
			for (int i = 0; i < width * height; ++i) {
				cx = i % width;
				cy = i / width;

				ColorVector cv = new ColorVector (0.0f, 0.0f, 0.0f);
				cv.R = (float) bitmap [cy * scanlineWidth + cx * channels + 0] / 255.0f;
				cv.G = (float) bitmap [cy * scanlineWidth + cx * channels + 1] / 255.0f;
				cv.B = (float) bitmap [cy * scanlineWidth + cx * channels + 2] / 255.0f;

				pixels [i] = cv;
			}

			List<ColorVector> palette;
			int [] outPixels;

			(palette, outPixels) = kmeans (pixels, countColors);

			// output the pixels to the image
			for (int i = 0; i < width * height; ++i) {
				cx = i % width;
				cy = i / width;

				output [cy * scanlineWidth + cx * channels + 0] = palette [outPixels [i]].RedByte;
				output [cy * scanlineWidth + cx * channels + 1] = palette [outPixels [i]].GreenByte;
				output [cy * scanlineWidth + cx * channels + 2] = palette [outPixels [i]].BlueByte;
			}

			return output;
		}

		public void edit (MainWindow mainWindow) {
			IntegerDialogForm dialogForm = new IntegerDialogForm ("k-means", 
				"enter target color count", countColors, 2, 100);

			dialogForm.ShowDialog (mainWindow);

			countColors = Math.Max (2, Math.Min (100, dialogForm.InputNumber));
		}
	}
}
