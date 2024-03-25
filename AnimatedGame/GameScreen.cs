using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimatedGame
{
    public partial class GameScreen : UserControl
    {
        UpBall upBall;
        Player player;
        int lives = 3;
        SolidBrush playerBrush = new SolidBrush(Color.Salmon);
        SolidBrush wallBrush = new SolidBrush(Color.White);
        SolidBrush ballBrush = new SolidBrush(Color.Chartreuse);

        List<UpBall> upBalls = new List<UpBall>();

        Random randGen = new Random();

        public static int width, height;

        bool leftArrowDown, rightArrowDown, upArrowDown, downArrowDown;

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            gameTimer.Start();

            this.Width = width;
            this.Height = height;

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(playerBrush, player.x, player.y, player.width, player.height);
            e.Graphics.FillRectangle(wallBrush, this.Height / 2, this.Width / 2, 400, 250);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }

    }
}

