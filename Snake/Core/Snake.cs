using System;
using System.Windows.Forms;
using System.Drawing;

namespace Game.Core
{
    class Snake
    {
        public int snakeHeadXPos;
        public int snakeHeadYPos;
        public string changeToDirection = "left";
        public string direction = "left";
        public int snakeLength = 1;
        public int[] snakeHeadXPositions;
        public int[] snakeHeadYPositions;
        main Game;
        Panel Panel;

        public Snake(main ptr, Panel panel)
        {
            Game = ptr;
            Panel = panel;
            snakeHeadXPositions = new int[100];
            snakeHeadYPositions = new int[100];
            snakeHeadXPos = Panel.CenterPoint;
            snakeHeadYPos = Panel.CenterPoint;
            snakeHeadXPositions[1] = Panel.CenterPoint;
            snakeHeadYPositions[1] = Panel.CenterPoint;
        }

        public void Reset()
        {
            for (int i = 1; i < 100; i++)
            {
                snakeHeadXPositions[i] = -1;
                snakeHeadYPositions[i] = -1;
            }

            snakeLength = 1;
            snakeHeadXPos = Panel.CenterPoint;
            snakeHeadYPos = Panel.CenterPoint;
            direction = "left";
            changeToDirection = "left";
            snakeHeadXPositions[1] = Panel.CenterPoint;
            snakeHeadYPositions[1] = Panel.CenterPoint;
        }

        public void ProcessDirection(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left:
                    changeToDirection = "left";
                    break;
                case Keys.Right:
                    changeToDirection = "right";
                    break;
                case Keys.Up:
                    changeToDirection = "up";
                    break;
                case Keys.Down:
                    changeToDirection = "down";
                    break;
            }
        }

        public void boundaryCheck()
        {
            if (snakeHeadXPos < 0 || snakeHeadXPos >= Panel.PanelSize || snakeHeadYPos < 0 || snakeHeadYPos >= Panel.PanelSize)
                Game.EndGame();
        }

        public void MoveDirection()
        {
            switch (changeToDirection)
            {
                case "left":
                    if (direction != "right")
                    {
                        direction = "left";
                    }
                    break;
                case "right":
                    if (direction != "left")
                    {
                        direction = "right";
                    }
                    break;
                case "up":
                    if (direction != "down")
                    {
                        direction = "up";
                    }
                    break;
                case "down":
                    if (direction != "up")
                    {
                        direction = "down";
                    }
                    break;
            }
            switch (direction)
            {
                case "left":
                    snakeHeadXPos -= 1;
                    boundaryCheck();
                    Panel.SetBoxColor(snakeHeadXPos, snakeHeadYPos, Color.Red);
                    break;
                case "right":
                    snakeHeadXPos += 1;
                    boundaryCheck();
                    Panel.SetBoxColor(snakeHeadXPos, snakeHeadYPos, Color.Red);
                    break;
                case "up":
                    snakeHeadYPos -= 1;
                    boundaryCheck();
                    Panel.SetBoxColor(snakeHeadXPos, snakeHeadYPos, Color.Red);
                    break;
                case "down":
                    snakeHeadYPos += 1;
                    boundaryCheck();
                    Panel.SetBoxColor(snakeHeadXPos, snakeHeadYPos, Color.Red);
                    break;
            }      
        }

        public void Move()
        {
            for (int i = 1; i < 100; i++)
            {
                if (snakeHeadXPos == snakeHeadXPositions[i] && snakeHeadYPos == snakeHeadYPositions[i])
                {
                    Game.EndGame();
                }
            }

            for (int i = 99; i >= 1; i--)
            {
                if (i < snakeLength)
                {
                    snakeHeadXPositions[i + 1] = snakeHeadXPositions[i];
                    snakeHeadYPositions[i + 1] = snakeHeadYPositions[i];
                }
                else if (i > snakeLength)
                {
                    snakeHeadXPositions[i] = -1;
                    snakeHeadYPositions[i] = 0;
                }
            }

            snakeHeadXPositions[1] = snakeHeadXPos;
            snakeHeadYPositions[1] = snakeHeadYPos;
        }
    }
}