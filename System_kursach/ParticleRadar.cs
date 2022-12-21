using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;

using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace System_kursach
{
	internal class ParticleRadar : BaseObject
	{
		public static new float x;
		public static new float y;
		public static new float r = 50;
		public static int particleCount = 0;
		private static new Color color = Color.Red;

		public static void particleInside(List<Particle> particle, Graphics g)
		{
			
			for (int i = 0; i < particle.Count; i++)
			{
				float length = (float)Math.Sqrt((x - particle[i].X) * (x - particle[i].X) + (y - particle[i].Y) * (y - particle[i].Y));
				if (length <= r)
				{
					particleCount++;
					particle[i].Draw( g);
					particle[i].kill();
				}
			}
		}

		public static new Matrix GetTransform()
		{
			Matrix matrix = new Matrix();
			matrix.Translate(x, y);
			return matrix;
		}

		public static void Render(Graphics g)
		{
			g.Transform = GetTransform();

			g.DrawEllipse(new Pen(Color.FromArgb(255, color), 2), -r, -r, r * 2, r * 2);
			g.DrawString(
				particleCount.ToString(),
				new Font("Verdana", 16),
				new SolidBrush(Color.Black),
				-16, -16
			);
		}
	}
}
