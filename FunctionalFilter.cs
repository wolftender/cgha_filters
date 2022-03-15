using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1 {
	abstract class FunctionalFilter : IImageFilter {
		private Func<byte, byte> function;

		public Func<byte, byte> Function {
			get { return function; }
		}

		public abstract string Name { get; }

		public FunctionalFilter () {
			create ((byte x) => x);
		}

		public FunctionalFilter (Func<byte, byte> function) {
			create (function);
		}

		protected void create (Func<byte, byte> function) {
			this.function = function;
		}

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			unsafe {
				for (int i = 0; i < bitmap.Length; ++i) {
					bitmap [i] = function (bitmap [i]);
				}
			}

			return bitmap;
		}
	}
}
