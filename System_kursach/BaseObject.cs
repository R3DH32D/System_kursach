using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace System_kursach
{
	internal abstract class BaseObject
	{
		public float x;
		public float y;
		public float r;
		public Color color;

		public Matrix GetTransform()
		{
			Matrix matrix = new Matrix();
			matrix.Translate(x, y);
			return matrix;
		}
	}
}


