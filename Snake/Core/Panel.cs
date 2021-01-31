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

        // Change this to the ratio value to increase/decrease the Panel's size 
        // The "Size" goes from 0 to 12
        public static int Size = 5;
        public static int[] SizeOffset = {1,2,4,5,10,20,25,50,100,125,250,500};

        // Declare statically to initialize the panel
        public static int PanelSize = SizeOffset[Size];
        public static int PanelBoardSize = 500;

        // Starting point to fit  the panel to the Border
        public static int StartingXPoint = 29;
        public static int StartingYPoint = 107;
  
        // Define the unit size and the panel coordinate index amount
        public static int PanelUnitSize = PanelBoardSize / PanelSize;
        public static int PanelCorX = PanelSize;
        public static int PanelCorY = PanelSize;
        public static int CenterPoint = PanelSize / 2;

        System.Windows.Forms.Panel[,] Box;
        main Game;
        Snake Snake;

        public Panel(main ptr)
        {

            Game = ptr;
            Box = new System.Windows.Forms.Panel[PanelCorX, PanelCorY];

            for (int y = 0; y < PanelCorY; y++)
            {
                for (int x = 0; x < PanelCorX; x++)
                {
                    Box[x, y] = new System.Windows.Forms.Panel();
                    Box[x, y].Left = StartingXPoint + x * PanelUnitSize;
                    Box[x, y].Top = StartingYPoint + y * PanelUnitSize;
                    Box[x, y].Width = PanelUnitSize;
                    Box[x, y].Height = PanelUnitSize;
                    Box[x, y].BackColor = Color.Black;
                    Box[x, y].BorderStyle = BorderStyle.None;
                    Game.AddControl(Box[x, y]);                 
                    
                }
            }
            Box[1, 1].BackColor = Color.Red;
        }

        public void AddSnake(Snake snake)
        {
            Snake = snake;
        }

        public void Render()
        {
            for (int y = 0; y < PanelCorY; y++)
            {
                for (int x = 0; x < PanelCorX; x++)
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
            for (int y = 0; y < PanelCorY; y++)
            {
                for (int x = 0; x < PanelCorX; x++)
                {
                    SetBoxColor(x, y, Color.Black);
                }
            }
        }

        public void SetBoxColor(int x, int y, Color color)
        {
            if (Snake.snakeHeadXPos < 0 || Snake.snakeHeadXPos >= PanelSize || Snake.snakeHeadYPos < 0 || Snake.snakeHeadYPos >= PanelSize)
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