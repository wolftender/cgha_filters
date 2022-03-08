using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cg_proj_1 {
	interface IImageFilter {
		string Name { get; }
		byte [] apply (byte [] bitmap);
	}

	interface IEditableFilter {
		void edit (MainWindow mainWindow);
	}
}
