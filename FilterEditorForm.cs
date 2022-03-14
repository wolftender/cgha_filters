using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cg_proj_1 {
	public partial class FilterEditorForm : Form {
		private float [] matrixValues;
		private int matrixWidth;
		private int matrixHeight;
		private int pivotX;
		private int pivotY;

		public float [] MatrixValues {
			get { return matrixValues; }
		}

		public int MatrixWidth {
			get { return matrixWidth; }
		}

		public int MatrixHeight {
			get { return matrixHeight; }
		}

		public Point Pivot {
			get { return new Point (pivotX, pivotY); }
		}

		public FilterEditorForm (int filterWidth, int filterHeight, Point pivot, float [] values) {
			matrixWidth = Math.Min (Math.Max (filterWidth, 1), 11);
			matrixHeight = Math.Min (Math.Max (filterHeight, 1), 11);

			InitializeComponent ();

			numericWidth.Value = filterWidth;
			numericHeight.Value = filterHeight;

			numericHeight.Minimum = 1;
			numericWidth.Minimum = 1;
			numericHeight.Maximum = 11;
			numericWidth.Maximum = 11;

			numericPivotX.Minimum = 0;
			numericPivotY.Minimum = 0;
			numericPivotX.Maximum = matrixWidth;
			numericPivotY.Maximum = matrixHeight;

			pivotX = Math.Min (Math.Max (pivot.X, 0), matrixWidth);
			pivotY = Math.Min (Math.Max (pivot.Y, 0), matrixHeight);

			numericPivotX.Value = pivotX;
			numericPivotY.Value = pivotY;

			matrixValues = values;
			refreshMatrix ();
		}

		private void refreshMatrix () {
			numericPivotX.Maximum = matrixWidth;
			numericPivotY.Maximum = matrixHeight;

			if (numericPivotX.Value > matrixWidth) {
				numericPivotX.Value = matrixWidth;
			}

			if (numericPivotY.Value > matrixHeight) {
				numericPivotY.Value = matrixHeight;
			}

			float [] newValues = new float [matrixWidth * matrixHeight];

			if (matrixValues != null) {
				for (int i = 0; i < newValues.Length && i < matrixValues.Length; ++i) {
					newValues [i] = matrixValues [i];
				}
			}

			matrixValues = newValues;

			// update the editor
			dataGridFilter.Rows.Clear ();
			dataGridFilter.Columns.Clear ();

			for (int i = 0; i < matrixWidth; ++i) {
				dataGridFilter.Columns.Add ("c" + i, "c" + i);
				dataGridFilter.Columns [i].DefaultCellStyle.Format = "N";
			}

			dataGridFilter.Rows.Add (matrixHeight);

			// set values to the matrix
			for (int col = 0; col < matrixWidth; ++col) {
				for (int row = 0; row < matrixHeight; ++row) {
					dataGridFilter [col, row].Value = matrixValues [row * matrixWidth + col];
				}
			}
		}

		private void numericWidth_ValueChanged (object sender, EventArgs e) {
			matrixWidth = (int) numericWidth.Value;
			matrixWidth = Math.Min (Math.Max (matrixWidth, 1), 11);

			refreshMatrix ();
		}

		private void numericHeight_ValueChanged (object sender, EventArgs e) {
			matrixHeight = (int) numericHeight.Value;
			matrixHeight = Math.Min (Math.Max (matrixHeight, 1), 11);

			refreshMatrix ();
		}

		private void dataGridFilter_CellValueChanged (object sender, DataGridViewCellEventArgs e) {
			int row = e.RowIndex;
			int col = e.ColumnIndex;

			try {
				float val = float.Parse (dataGridFilter [col, row].Value.ToString ());
				matrixValues [row * matrixWidth + col] = val;
			} catch {
				dataGridFilter [col, row].Value = matrixValues [row * matrixWidth + col];
			}			
		}

		private void numericPivotX_ValueChanged (object sender, EventArgs e) {
			pivotX = (int) Math.Min (Math.Max (numericPivotX.Value, 0), matrixWidth);
		}

		private void numericPivotY_ValueChanged (object sender, EventArgs e) {
			pivotY = (int) Math.Min (Math.Max (numericPivotY.Value, 0), matrixHeight);
		}
	}
}
