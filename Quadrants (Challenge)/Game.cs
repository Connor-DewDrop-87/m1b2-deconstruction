﻿// CHALLENGE: Quadrants
// Only draw the colored squared when the mouse is inside that quadrant.
// Thus, only 1 color is draw on screen at one time.

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

public class Game
{
    public void Setup()
    {
        Window.SetTitle("Quadrants");
        Window.SetSize(400, 400);
    }

    public void Update()
    {
        // Clear screen
        Window.ClearBackground(Color.OffWhite);
        Input.GetMouseX();
        Input.GetMouseY();
        // Top-Left
        if (Input.GetMouseX() >= 200 || Input.GetMouseY() >= 200)
        {
            Draw.FillColor = Color.OffWhite;
            Draw.Square(0, 0, 200);
            ;
        }

        else

        {
            Draw.FillColor = Color.Red;
            Draw.Square(0, 0, 200);
            ;
        }

        // Top-Right
        if (Input.GetMouseX() <= 200 || Input.GetMouseY() >= 200)
        {
            Draw.FillColor = Color.OffWhite;
            Draw.Square(200, 0, 200);
            ;
        }
        else
        {
            Draw.FillColor = Color.Green;
            Draw.Square(200, 0, 200);
            ;
        }

        // Bottom-Left
        if (Input.GetMouseX() >= 200 || Input.GetMouseY() <= 200)
        {
            Draw.FillColor = Color.OffWhite;
            Draw.Square(0, 200, 200);
            ;
        }
        else
        {
            Draw.FillColor = Color.Yellow;
            Draw.Square(0, 200, 200);
            ;
        }



        // Bottom-Right
        if (Input.GetMouseX() <= 200 || Input.GetMouseY() <= 200)
        {
            Draw.FillColor = Color.OffWhite;
            Draw.Square(200, 200, 200);
            ;
        }
        else
        {
            Draw.FillColor = Color.Blue;
            Draw.Square(200, 200, 200);
            ;
        }

        // Draw lines to separate screen into quadrants
        Draw.LineSize = 2;
        Draw.LineSharp(Window.Width / 2, 0, Window.Width / 2, Window.Height);
        Draw.LineSharp(0, Window.Height / 2, Window.Width, Window.Height / 2);
        Draw.LineSize = 0;
    }
}
