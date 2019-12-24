using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game.Core
{
    class Panel
    {
        PictureBox[,] Box;
        main Game;
        Snake Snake;

        public Panel(main ptr)
        {
            Game = ptr;
            Box = new PictureBox[30, 30];

            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    Box[x, y] = new PictureBox();
                    Box[x, y].Left = 36 + x * 16;
                    Box[x, y].Top = 114 + y * 16;
                    Box[x, y].Width = 17;
                    Box[x, y].Height = 17;
                    Box[x, y].BackColor = Color.Black;
                    Box[x, y].BorderStyle = BorderStyle.None;
                    Game.AddControl(Box[x, y]);     
                }
            }
            Box[15, 15].BackColor = Color.Red;
        }

        public void AddSnake(Snake snake)
        {
            Snake = snake;
        }

        public void Render()
        {
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    if (!(GetBoxColor(x, y) == Color.Blue || GetBoxColor(x, y) == Color.Green))
                    {
                        SetBoxColor(x, y, Color.Black);
                    }
                }
            }

            for (int i = 1; i < 100; i++)
            {
                if (Snake.snakeHeadXPositions[i] != -1)
                {
                    SetBoxColor(Snake.snakeHeadXPositions[i], Snake.snakeHeadYPositions[i], Color.Red);
                }
            }
        }

        public void Reset()
        {
            for (int y = 0; y < 30; y++)
            {
                for (int x = 0; x < 30; x++)
                {
                    SetBoxColor(x, y, Color.Black);
                }
            }
        }

        public void SetBoxColor(int x, int y, Color color)
        {
            if (Snake.snakeHeadXPos < 0 || Snake.snakeHeadXPos > 29 || Snake.snakeHeadYPos < 0 || Snake.snakeHeadYPos > 29)
                Game.EndGame();
            else
                Box[x, y].BackColor = color;
        }

        public Color GetBoxColor(int x, int y)
        {
            return Box[x, y].BackColor;
        }
    }
}