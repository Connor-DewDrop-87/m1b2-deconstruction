﻿// CHALLENGE: Update the code so that the shadows are drawn where the mouse
//            was on screen rather than exactly where the mouse is.
// Hint 1: Focus on one shadow. The logic can be applied to all afterwards.
// Hint 2: Consider how you can make the program remember last frame's mouse position.

// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D;

public class Game
{
    // Prepare custom colors to use.
    // A single value means intensity (black-and-white).
    Color black = new Color(0);
    Color shadow1 = new Color(70);
    Color shadow2 = new Color(140);
    Color shadow3 = new Color(210);

    public void Setup()
    {
        Window.SetTitle("Mouse Shadow");
        Window.SetSize(400, 400);
        // Run a little slower so we have more time to see the shadow
        Window.TargetFPS = 30;
        // Remove outlines
        Draw.LineColor = Color.Clear;
       
    }

    public void Update()
    {
        // Reset screen
        Window.ClearBackground(Color.OffWhite);

        // Get mouse position
        float mouseX = Input.GetMouseX();
        float mouseY = Input.GetMouseY();
        float mouseXs1 = mouseX;
        float mouseYs1 = mouseY;
        float mouseXs2 = mouseXs1;
        float mouseYs2 = mouseYs1;
        float mouseXs3 = mouseXs2;
        float mouseYs3 = mouseYs2;


        // Draw shadow 3
        Draw.FillColor = shadow3;
        Draw.Circle(mouseXs3, mouseYs3, 16);
        // Draw shadow 2
        Draw.FillColor = shadow2;
        Draw.Circle(mouseXs2, mouseYs2, 19);
        // Draw shadow 1
        Draw.FillColor = shadow1;
        Draw.Circle(mouseXs1, mouseYs1, 22);
        // Draw mouse
        Draw.FillColor = black;
        Draw.Circle(mouseX, mouseY, 25);

        

        

        
        

        
       

        
       
        

        
    }
}
