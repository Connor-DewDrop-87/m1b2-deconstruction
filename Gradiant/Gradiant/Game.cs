// Include the namespaces (code libraries) you need below.
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
        int r = 0;
        int b = 0;
        int g = 0;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Gradiant");
            Window.SetSize(255,255);
            Window.ClearBackground(Color.OffWhite);

        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            for (int i = 0; i < 254; i++)
            {
                
                Color gradiant = new Color(r+i, g+i, b+i);
                Draw.FillColor = gradiant;
                Draw.Rectangle(0, 0, 1, 255);
                

            }
        }
    }

}
