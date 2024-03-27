using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame
{
    internal class Player1
    {
        static public float posX;
        static public float posY;
        static private float speedX = 5;
        static private float speedY = 5;
        static IntPtr image = Engine.LoadImage("assets/player.png");

        public Player1(float X, float Y)
        {
            posX = X;
            posY = Y;
        }


        public void Update()
        {
            if (Engine.KeyPress(Engine.KEY_LEFT)) 
            {
                posX -= speedX;
            }

            if (Engine.KeyPress(Engine.KEY_RIGHT)) 
            { 
                 posX += speedX;
            }

            if (Engine.KeyPress(Engine.KEY_UP)) 
            { 
                posY -= speedY;
            }

            if (Engine.KeyPress(Engine.KEY_DOWN)) 
            { 
               posY += speedY;
            }

            if (Engine.KeyPress(Engine.KEY_ESP)) 
            {
                Shoot();
            }
        }

        public void Shoot()
        {
            Program.listB.Add(new Bullet(posX, posY));
        }

        public void Render()
        {
            Engine.Draw(image, posX, posY);
        }


    }
}
