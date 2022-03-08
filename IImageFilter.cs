using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cg_proj_1 {
	interface IImageFilter {
		string Name { get; }
		byte [] apply (byte [] bitmap, int width, int height, int stride);
	}

	interface IEditableFilter {
		void edit (MainWindow mainWindow);
	}
}
