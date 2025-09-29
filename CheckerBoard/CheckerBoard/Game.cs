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
            Window.SetSize(400, 400);
            Window.SetTitle("Checkers");
            Window.ClearBackground(Color.OffWhite);
            
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            for (int y = 0; y < 8; y++) 
            {
                int yremainder = y % 2;
                for (int x = 0; x < 8; x++)
                {
                    int xremainder = x % 2;
                    if (xremainder==0 ^ yremainder==1)
                    {
                        Draw.FillColor = Color.Black;
                        Draw.Square(0 + 50 * x, 0 + 50 * y, 50);
                        
                    }
                    if (xremainder == 1 ^ yremainder == 1)
                    {
                        Draw.FillColor = Color.White;
                        Draw.Square(0 + 50 * x, 0 + 50 * y, 50);
                        
                    }

                }
            }
        }
    }

}
