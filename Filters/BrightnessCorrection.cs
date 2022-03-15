using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cg_proj_1.Filters {
	class BrightnessCorrection : IImageFilter, IEditableFilter {
		public string Name => "Brightness Correct.";
		private int intercept;

		public byte [] apply (byte [] bitmap, int width, int height, int stride) {
			for (int i = 0; i < bitmap.Length; ++i) {
				bitmap [i] = (byte) Math.Min (255, Math.Max (0, bitmap [i] + intercept));
			}

			return bitmap;
		}

		public void edit (MainWindow mainWindow) {
			IntegerDialogForm dialogForm = new IntegerDialogForm ("Brightness Correction", "Intercept", 0, -127, 127);
			dialogForm.ShowDialog (mainWindow);

			intercept = dialogForm.InputNumber;
		}
	}
}
