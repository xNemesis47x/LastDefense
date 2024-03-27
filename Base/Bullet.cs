using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class Bullet
    {

        static float posXb;
        static float posYb;
        static IntPtr image = Engine.LoadImage("assets/Balarda.png");

        public Bullet(float X,float Y) 
        {
            posXb = X;
            posYb = Y;
        }

        public void Render()
        {
            Engine.Draw(image, posXb, posYb, 95, 101);
        }

        public void Update()
        {
            posYb--;
        }
    }
}
