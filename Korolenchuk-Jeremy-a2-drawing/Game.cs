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
            void DrawHand(float x, float y)
            {
				//hand
				Draw.FillColor = Color.White;
				Draw.LineColor = Color.Black;
				//thumb
				Draw.Capsule(x + 140, y + 140, x + 60, y + 140, 25);
				Draw.Capsule(x + 60, y + 140, x + 80, y + 70, 25);

				//fingers
				for (int count = 0; count < 3; count += 1)
				{
					Draw.Capsule(x + 125 - (35 * count), y + 20, x + 150 - (35 * count), y + 30, 20);
				}
				Draw.Capsule(x, y, x + 90, y + 80, 20);

				//arm
				Draw.FillColor = Color.Black;
				Draw.Capsule(x + 180, y + 120, x + 600, y + 520, 25);

				//palm
				Draw.FillColor = Color.White;
				Draw.Circle(x + 140, y + 85, 75);
			}

            Window.ClearBackground(Color.LightGray);
            Draw.FillColor = Color.DarkGray;
            Draw.LineColor = Color.Black;
            Draw.Square(50, 50, 300);

            if (Input.IsKeyboardKeyDown(KeyboardInput.Space))
            {
				Draw.LineColor = Color.Black;
				Draw.FillColor = Color.Red;
				Draw.Ellipse(200, 200, 200, 150);
				DrawHand(200, 200);
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

				DrawHand(Input.GetMouseX(), Input.GetMouseY());
			}
		}
    }

}
