

using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using Tao.Sdl;

namespace MyGame
{

    class Program
    {

        static IntPtr image = Engine.LoadImage("assets/fondo.png");
        static public List<Player1> list = new List<Player1>();
        static public List<Bullet> listB = new List<Bullet>();

        static void Main(string[] args)
        {
            Engine.Initialize();

            list.Add(new Player1(100, 200));

            while (true)
            {
                Update();
                Render();
            }
        }

        public static void Render()
        {
            Engine.Clear();

            Engine.Draw(image, 0, 0);
            
            foreach (Player1 player in list)
            {
                player.Render();
            }

            foreach (Bullet b in listB)
            {
                b.Render();
            }

            Engine.Show();

            Sdl.SDL_Delay(20);
        }

        private static void Update()
        {
            foreach(Player1 player1 in list)
            {
                player1.Update();
            }

            foreach(Bullet b in listB)
            {
                b.Update();
            }

        }

    }

}
