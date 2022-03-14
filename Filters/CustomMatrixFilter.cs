using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cg_proj_1.Filters {
	class CustomMatrixFilter : ConvolutionalFilter, IEditableFilter {
		public CustomMatrixFilter () : base (3, 3, new Point (1, 1), 
			new float [] { 
				1.0f, 1.0f, 1.0f,
				1.0f, 1.0f, 1.0f,
				1.0f, 1.0f, 1.0f
			}) { }

		public override string Name => "Custom (Convolutional)";

		public void edit (MainWindow mainWindow) {
			FilterEditorForm filterEditor = new FilterEditorForm (Width, Height, Anchor, Coefficients);
			filterEditor.ShowDialog ();

			create (filterEditor.MatrixWidth, filterEditor.MatrixHeight, filterEditor.Pivot, filterEditor.MatrixValues);
		}
	}
}
