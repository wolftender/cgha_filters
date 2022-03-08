using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cg_proj_1.Filters {
	class SimpleBlur : ConvolutionalFilter, IEditableFilter {
		public override string Name => "Naive Blur";

		public SimpleBlur () : base (3, 3, new Point (1, 1),
			new float [] {
				1.0f, 1.0f, 1.0f,
				1.0f, 1.0f, 1.0f,
				1.0f, 1.0f, 1.0f
			}) { }

		public void edit (MainWindow mainWindow) {
			IntegerDialogForm numberInput = new IntegerDialogForm ("Naive blur", "Enter matrix size", Width, 1, 13);
			
			if (numberInput.ShowDialog (mainWindow) == System.Windows.Forms.DialogResult.OK) {
				int size = numberInput.InputNumber;
				int anchor = size / 2;

				float [] coefficients = new float [size * size];
				Array.Fill (coefficients, 1.0f);

				create (size, size, new Point (anchor, anchor), coefficients);
			}
		}
	}
}
