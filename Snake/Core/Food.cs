using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game.Core
{
    class Food
    {
        Panel Panel;
        Random R = new Random();
        public int foodXPos;
        public int foodYPos;
        bool replaceFood = true;
        bool foundBox = false;
        public int foodType = 0;
        public Color foodColor = Color.Blue;
        main App;

        public Food(Panel panel, main app)
        {
            Panel = panel;
            App = app;
        }

        public void Reset()
        {
            foodType = 0;
            foodColor = Color.Blue;
            replaceFood = true;
            New();
        }

        public void New()
        {
            if(foodType == 5)
            {
                foodColor = Color.Green;
                foodType = 0;
                App.EnableBonus();
            }

            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    if (Panel.GetBoxColor(x, y) == Color.Blue || Panel.GetBoxColor(x, y) == Color.Green)
                    {
                        foodXPos = x;
                        foodYPos = y;
                        Panel.SetBoxColor(x, y, Color.Black);
                    }
                }
            }

            if (replaceFood == false)
            {

                Panel.SetBoxColor(foodXPos, foodYPos, foodColor);

                foundBox = false;
                while (foundBox == false)
                {
                    foodXPos = R.Next(0, 30);
                    foodYPos = R.Next(0, 30);

                    if (Panel.GetBoxColor(foodXPos, foodYPos) == Color.Black)
                    {
                        Panel.SetBoxColor(foodXPos, foodYPos, foodColor);
                        foundBox = true;
                    }
                    else
                    {
                        foodXPos = R.Next(0, 30);
                        foodYPos = R.Next(0, 30);
                    }
                }
            }
            else
            {
                replaceFood = false;

                foundBox = false;
                while (foundBox == false)
                {
                    foundBox = false;

                    foodXPos = R.Next(0, 30);
                    foodYPos = R.Next(0, 30);

                    if (Panel.GetBoxColor(foodXPos, foodYPos) == Color.Black)
                    {
                        Panel.SetBoxColor(foodXPos, foodYPos, foodColor);
                        foundBox = true;
                    }
                    else
                    {
                        foodXPos = R.Next(0, 30);
                        foodYPos = R.Next(0, 30);
                    }
                }

            }
            foodType++;
        }
    }
}