// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
using System.Data;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Beans!");
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            float r1 = Input.GetMouseX();
            if (r1 < 0)
            {
                r1 = 0;
                ;
            }
            Window.ClearBackground(Color.OffWhite);
            Draw.FillColor = Color.Red;
            DrawBean(100, 40, 30);
            Draw.FillColor = Color.Blue;
            DrawBean(Input.GetMouseX(), Input.GetMouseY(), 30);
            Draw.FillColor = Color.Yellow;
            DrawBean(Input.GetMouseX()-50, Input.GetMouseY(), 30);
            Draw.FillColor = Color.Green;
            DrawBean(Window.Width - Input.GetMouseX(), Window.Height-Input.GetMouseY(), 30);
            Draw.FillColor = Color.Black;
            DrawBean(Input.GetMouseY(), Input.GetMouseX(), 30);
            Draw.FillColor = Color.Cyan;
            DrawBean(400, 400, r1);

        }
        void DrawBean(float x, float y,float r)
        {
            // Bean Capsule
            Draw.Capsule(x, y, x, y+30,r);
            // Bean Eye
            Draw.FillColor = Color.OffWhite;
            Draw.Circle(x, y, r / 2);
            // Bean Cornea
            Draw.FillColor = Color.Black;
            Draw.Circle(x, y, r / 4);
        }
    }

} 
