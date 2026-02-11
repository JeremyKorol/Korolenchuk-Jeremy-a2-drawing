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
            Window.SetTitle("The Button");
            Window.SetSize(400, 400);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.LightGray);
            Draw.FillColor = Color.DarkGray;
            Draw.LineColor = Color.Black;
            Draw.Square(50, 50, 300);

            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.Red;
                Draw.Ellipse(200, 200, 200, 150);

				//hand
				Draw.FillColor = Color.White;
				Draw.LineColor = Color.Black;
				//thumb
				Draw.Capsule(340, 340, 260, 340, 25);
				Draw.Capsule(260, 340, 280, 270, 25);

				//fingers
				Draw.Capsule(315, 210, 350, 230, 20);
				Draw.Capsule(280, 210, 330, 240, 20);
				Draw.Capsule(250, 220, 310, 260, 20);
				Draw.Capsule(200, 200, 290, 280, 20);

				//arm
				Draw.FillColor = Color.Black;
				Draw.Capsule(380, 320, 800, 720, 25);

				//palm
				Draw.FillColor = Color.White;
				Draw.Circle(340, 285, 75);
			}

            else
            {
                Draw.FillColor = Color.Red;
			    Draw.Ellipse(200, 200, 200, 150);
			    Draw.Rectangle(100, 145, 200, 65);
			    Draw.LineColor = Color.Red;
			    Draw.Rectangle(101, 146, 198, 64);
                Draw.LineColor = Color.Black;
			    Draw.Ellipse(200, 150, 200, 150);

			    //hand
			    Draw.FillColor = Color.White;
                Draw.LineColor = Color.Black;
			    //thumb
                Draw.Capsule(Input.GetMouseX() + 140, Input.GetMouseY() + 140, Input.GetMouseX() + 60, Input.GetMouseY() + 140, 25);
			    Draw.Capsule(Input.GetMouseX() + 60, Input.GetMouseY() + 140, Input.GetMouseX() + 80, Input.GetMouseY() + 70, 25);
			
                //fingers
                Draw.Capsule(Input.GetMouseX() + 115, Input.GetMouseY() + 10, Input.GetMouseX() + 150, Input.GetMouseY() + 30, 20);
			    Draw.Capsule(Input.GetMouseX() + 80, Input.GetMouseY() + 10, Input.GetMouseX() + 130, Input.GetMouseY() + 40, 20);
			    Draw.Capsule(Input.GetMouseX() + 50, Input.GetMouseY() + 20, Input.GetMouseX() + 110, Input.GetMouseY() + 60, 20);
			    Draw.Capsule(Input.GetMouseX(), Input.GetMouseY(), Input.GetMouseX() + 90, Input.GetMouseY() + 80, 20);
			
                //arm
                Draw.FillColor = Color.Black;
                Draw.Capsule(Input.GetMouseX() + 180, Input.GetMouseY() + 120, Input.GetMouseX() + 600, Input.GetMouseY() + 520, 25);
			
                //palm
                Draw.FillColor = Color.White;
                Draw.Circle(Input.GetMouseX() + 140, Input.GetMouseY() + 85, 75);
            }
		}
    }

}
