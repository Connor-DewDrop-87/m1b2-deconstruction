﻿// CHALLENGE: Toggle the square's color between two colors (eg. red and green)
//            when the player either hits spacebar or does a left mouse click.

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

public class Game
{
    public void Setup()
    {
        Window.SetTitle("Toggle Color");
        Window.SetSize(400, 400);
    }

    public void Update()
    {
        // Reset screen
        Window.ClearBackground(Color.OffWhite);

        // Set fill color
        if (Input.IsKeyboardKeyPressed(KeyboardInput.Space)) 
        {
            Draw.FillColor = Color.Red;
            ;
        }
        if (Input.IsMouseButtonPressed(MouseInput.Left))
        {
            Draw.FillColor = Color.Green;
            ;
        }

        //Draw square using above color
        Draw.Square(100, 100, 200);
    }
}
