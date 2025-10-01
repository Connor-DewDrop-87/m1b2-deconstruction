// Include the namespaces (code libraries) you need below.
using Raylib_cs;
using System;
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
        Color Nightsky = new Color("#0f052d");
        Color Blue = new Color("#203671");
        Color lightBlue = new Color("#36868f");
        Color Green = new Color("#5fc75d");

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetSize(400, 400);
            Window.SetTitle("Starry Night");
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            
            Window.ClearBackground(Nightsky);
            DrawRowOfClouds(Blue, 275, 25, 15, 33);
            DrawRowOfClouds(lightBlue, 325, 50, 7, 67);
            DrawRowOfClouds(Green, 400, 75, 5, 100);
            

        }
        void DrawRowOfClouds(Color cloudColor, int y, int r, int count, float space)
        {
            

            Draw.FillColor = cloudColor;
            Draw.LineSize = 0;

            for (int i = 0; i < count; i++)
            {

                Draw.Circle(space * i, y, r);
            }
        }
    }

}
