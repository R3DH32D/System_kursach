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
    public class Emitter
    {
        public float GravitationX = 0;
        public float GravitationY = 1;
        public static List<Particle> particles = new List<Particle>();
        
        public int MousePositionX;
        public int MousePositionY;
        public List<IImpactPoint> impactPoints = new List<IImpactPoint>();
        public  int ParticlesCount = 200;
        public float X; 
        public float Y; 
        public int Direction = 0; 
        public int Spreading = 0;
        public int speed = 1;
        public int RadiusMin = 2; 
        public int RadiusMax = 10;
        public int Life = 20;

        public float Radius = 10;


        public int ParticlesPerTick = 1;

        public Color ColorFrom = Color.White; 
        public Color ColorTo = Color.FromArgb(0, Color.Black);
        

        public virtual Particle CreateParticle()
        {
            var particle = new ParticleColorful();
            particle.FromColor = ColorFrom;
            particle.ToColor = ColorTo;

            return particle;
        }

        public void UpdateState()
        {
            int particlesToCreate = ParticlesPerTick;
            
                foreach (var particle in particles)
                {
                    particle.Life -= 1;
                    if (particle.Life < 0)
                    {

                        ResetParticle(particle);

                        if (particlesToCreate > 0)
                        {

                            particlesToCreate -= 1;
                            ResetParticle(particle);
                        }
                    }
                    else
                    {
                        particle.X += particle.SpeedX;
                        particle.Y += particle.SpeedY;

                        foreach (var point in impactPoints)
                        {
                            point.ImpactParticle(particle);
                        }

                        particle.SpeedX += GravitationX;
                        particle.SpeedY += GravitationY;


                    }
                }
                for (var i = 0; i < 10; ++i)
                {
                    if (particles.Count < ParticlesCount)
                    {

                        var particle = CreateParticle();
                        ResetParticle(particle);
                        particles.Add(particle);
                    }
                    else { break; }
                }
                while (particlesToCreate >= 1)
                {
                    particlesToCreate -= 1;
                    var particle = CreateParticle();
                    ResetParticle(particle);
                    particles.Add(particle);
                }
            }
        
        public void Render(Graphics g)
        {
            
            foreach (var particle in particles)
            {
                particle.Draw(g);
            }
            foreach (var point in impactPoints) 
            {
                
                point.Render(g);
            }
        }
        
            
        
        public virtual void ResetParticle(Particle particle)
        {
            particle.Life = Life;

            particle.X = X;
            particle.Y = Y;

            var direction = Direction
                + (double)Particle.rand.Next(Spreading)
                - Spreading / 2;

            particle.speed = speed;

            particle.SpeedX = (float)(Math.Cos(direction / 180 * Math.PI) * speed);
            particle.SpeedY = -(float)(Math.Sin(direction / 180 * Math.PI) * speed);

            particle.Radius = Particle.rand.Next(RadiusMin, RadiusMax);
        }

    }
    public class TopEmitter : Emitter
    {
        public int Width; 

        public override void ResetParticle(Particle particle)
        {
            base.ResetParticle(particle);

            
            particle.X = Particle.rand.Next(Width); 
            particle.Y = 0;  

            particle.SpeedY = 1; 
            particle.SpeedX = Particle.rand.Next(-2, 2); 
        }
    }
}
