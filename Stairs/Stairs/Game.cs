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


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("StairCase");
            Window.SetSize(400, 400);
            Window.ClearBackground(Color.OffWhite);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            for (float index = 0; index < 10; index++)
            { 
                Draw.Rectangle(0+40*index, 60+40*index, 40, 400);

            }
        }
    }

}
