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
	public partial class IntegerDialogForm : Form {
		private int inputNumber;
		private int min, max;

		public int InputNumber {
			get { return inputNumber; }
		} 

		public IntegerDialogForm (string title, string prompt, int defaultValue, int min, int max) {
			InitializeComponent ();

			Text = title;
			label1.Text = prompt;

			numericInput.Minimum = min;
			numericInput.Maximum = max;
			numericInput.DecimalPlaces = 0;

			this.min = min;
			this.max = max;

			numericInput.Value = defaultValue;
		}

		private void buttonApply_Click (object sender, EventArgs e) {
			inputNumber = (int) numericInput.Value;

			if (inputNumber > min && inputNumber < max) {
				Close ();
				DialogResult = DialogResult.OK;
			}
		}
	}
}
