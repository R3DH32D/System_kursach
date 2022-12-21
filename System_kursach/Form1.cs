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
    public partial class Form1 : Form
    {
        public static List<Emitter> emitters = new List<Emitter>();
        
        Emitter emitter;
        
         
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            emitters.Add(emitter = new Emitter
            {
                Radius = 10,
                Direction = 0,
                Spreading = 10,
                speed=1,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            });
            
           


        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            emitter.UpdateState();
            using (var g = Graphics.FromImage(picDisplay.Image = Image.FromFile("C:\\wp.jpg")))
            {
                emitter.Render(g);
            }

            

            picDisplay.Invalidate();
        }
        
        private void picDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            MouseX = e.X;
            MouseY = e.Y;
        }

        private void tbDirection_Scroll(object sender, EventArgs e)
        {
            emitter.Direction = tbDirection.Value;
            lblDirection.Text = $"{tbDirection.Value}°";
        }

        private void tbSpreading_Scroll(object sender, EventArgs e)
        {
            emitter.Spreading = tbSpreading.Value;
            lblSpread.Text = $"{tbSpreading.Value}°";
        }

        private void tbGraviton_Scroll(object sender, EventArgs e)
        {
            lblGrav.Text = $"{tbGraviton.Value}";
            emitter.ParticlesPerTick = tbGraviton.Value;
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
            lblGrav2.Text = $"{tbGraviton2.Value}";
            emitter.Life = tbGraviton2.Value;
        }
        public float MouseX;
        public float MouseY;
        private void picDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            if (rbEmit.Checked)
            {
                saved = false;
                emitters.Add(emitter = new Emitter
                {
                    Life = tbGraviton2.Value,
                    Radius = 10,
                    Direction = tbDirection.Value,
                    Spreading = tbSpreading.Value,
                    speed = trackBar1.Value,
                    ColorFrom = Color.Gold,
                    ColorTo = Color.FromArgb(0, Color.Red),
                    ParticlesPerTick = tbGraviton.Value,
                    X = e.X,
                    Y = e.Y,
                });

            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            emitter.speed = trackBar1.Value;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        public static bool saved=false;
        private void picDisplay_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;
            if (RbRadar.Checked)
            {
                saved = true;
                ParticleRadar.x =MouseX ;
                ParticleRadar.y = MouseY;
                ParticleRadar.particleInside(Emitter.particles, g);
                ParticleRadar.Render(g);
            }
            particlecount.Text = "количество частиц" + Emitter.particles.Count;
        }

        private void picDisplay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
