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

            for (int y = 0; y < Panel.PanelCorY; y++)
            {
                for (int x = 0; x < Panel.PanelCorX; x++)
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
                    foodXPos = R.Next(0, Panel.PanelCorX);
                    foodYPos = R.Next(0, Panel.PanelCorY);

                    if (Panel.GetBoxColor(foodXPos, foodYPos) == Color.Black)
                    {
                        Panel.SetBoxColor(foodXPos, foodYPos, foodColor);
                        foundBox = true;
                    }
                    else
                    {
                        foodXPos = R.Next(0, Panel.PanelCorX);
                        foodYPos = R.Next(0, Panel.PanelCorY);
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

                    foodXPos = R.Next(0, Panel.PanelCorX);
                    foodYPos = R.Next(0, Panel.PanelCorY);

                    if (Panel.GetBoxColor(foodXPos, foodYPos) == Color.Black)
                    {
                        Panel.SetBoxColor(foodXPos, foodYPos, foodColor);
                        foundBox = true;
                    }
                    else
                    {
                        foodXPos = R.Next(0, Panel.PanelCorX);
                        foodYPos = R.Next(0, Panel.PanelCorY);
                    }
                }

            }
            foodType++;
        }
    }
}