using System;
using System.Drawing;
using System.Windows.Forms;
using Game.Core;

namespace Game
{
    public partial class main : Form
    {
        Snake Snake;
        Core.Panel Panel;
        Food Food;

        public main()
        {
            InitializeComponent();
            Panel = new Core.Panel(this);
            Snake = new Snake(this, Panel);
            Food = new Food(Panel, this);
            Panel.AddSnake(Snake);
        }

        public void AddControl(Control control)
        {
            Controls.Add(control);
        }

        private void main_Load(object sender, EventArgs e)
        {
            Board.BackColor = Color.FromArgb(32, 34, 37);
            EndGameLabel.Cursor = Cursors.Hand;
            Food.New();
            Board.SendToBack();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Snake.ProcessDirection(keyData);
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            SnakeLengthLabel.Text = Snake.snakeLength.ToString();
            Snake.MoveDirection();

            if (Snake.snakeHeadXPos == Food.foodXPos && Snake.snakeHeadYPos == Food.foodYPos)
            {
                if (Food.foodColor == Color.Green)
                {
                    Snake.snakeLength += 2;
                    foodTimer.Enabled = false;
                    Food.foodColor = Color.Blue;
                }

                Snake.snakeLength += 1;
                SnakeLengthLabel.Text = Snake.snakeLength.ToString();
                Food.New();
            }

            Snake.Move();
            Panel.Render();
        }

        public void EndGame()
        {
            EndGameLabel.Text = "You Lost!" + Environment.NewLine + Environment.NewLine + "Click to play again";
            EndGameLabel.Visible = true;
            Snake.Reset();
            gameTimer.Stop();
        }

        public void EnableBonus()
        {
            foodTimer.Enabled = true;
        }

        private void EndGameLabel_Click(object sender, EventArgs e)
        {
            EndGameLabel.Visible = false;
            ResetGame();
        }

        private void ResetGame()
        {
            gameTimer.Start();
            Panel.Reset();
            Snake.Reset();
            Food.Reset();
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void foodTimer_Tick(object sender, EventArgs e)
        {
            foodTimer.Enabled = false;
            Food.foodColor = Color.Blue;
            Panel.SetBoxColor(Food.foodXPos, Food.foodYPos, Food.foodColor);
        }
    }
}