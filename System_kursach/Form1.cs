using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_kursach
{
    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        Emitter emitter;

        GravityPoint point1; 
        GravityPoint point2; 
        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);
            this.emitter = new Emitter 
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Gold,
                ColorTo = Color.FromArgb(0, Color.Red),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
            };
            point1 = new GravityPoint
            {
                X = picDisplay.Width / 2 + 100,
                Y = picDisplay.Height / 2,
            };
            point2 = new GravityPoint
            {
                X = picDisplay.Width / 2 - 100,
                Y = picDisplay.Height / 2,
            };

            
            emitter.impactPoints.Add(point1);
            emitter.impactPoints.Add(point2);

           /* emitters.Add(this.emitter);
            emitter.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width/2+100 ,
                Y = picDisplay.Height / 2
            });
            emitter.impactPoints.Add(new GravityPoint
            {
                X = picDisplay.Width/2-100 ,
                Y = picDisplay.Height / 2
            }); 

            /*emitter = new TopEmitter
            {
                Width = picDisplay.Width,
                GravitationY = 0.25f
            };

            

            
            emitter.impactPoints.Add(new AntiGravityPoint
            {
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2
            });*/

            
           
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
            emitter.MousePositionX = e.X;
            emitter.MousePositionY = e.Y;
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
            point1.Power = tbGraviton.Value;
        }

        private void tbGraviton2_Scroll(object sender, EventArgs e)
        {
            lblGrav2.Text = $"{tbGraviton2.Value}";
            point2.Power = tbGraviton2.Value;
        }
    }
}
