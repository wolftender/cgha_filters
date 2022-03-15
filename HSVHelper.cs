using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1 {
	struct HSVColor {
		private byte hue;
		private byte saturation;
		private byte value;

		public byte Hue {
			get { return hue; }
		}

		public byte Saturation {
			get { return saturation; }
		}

		public byte Value {
			get { return value; }
		}

		public HSVColor (byte h, byte s, byte v) {
			hue = h;
			saturation = s;
			value = v;
		}
	}

	static class HSVHelper {
		public static HSVColor rgbToHsv (byte r, byte g, byte b) {
			int M = Math.Max (r, Math.Max (g, b));
			int m = Math.Min (r, Math.Min (g, b));

			float Hp;
			if (M == m) {
				Hp = 0.0f;
			} else if (M == r) {
				Hp = ((float) (g - b)) / ((float) (M - m)) % 6.0f;
			} else if (M == g) {
				Hp = ((float) (b - r)) / ((float) (M - m)) + 2.0f;
			} else {
				Hp = ((float) (r - g)) / ((float) (M - m)) + 4.0f;
 			}

			byte h = (byte) Math.Min (255, Math.Floor (Hp / 6.0f * 255.0f));
			byte s = (byte) Math.Min (255, Math.Floor (((float) (M - m) / M) * 255.0f));
			byte v = (byte) Math.Min (255, M);

			HSVColor result = new HSVColor (h, s, v);
			return result;
		}
	}
}
