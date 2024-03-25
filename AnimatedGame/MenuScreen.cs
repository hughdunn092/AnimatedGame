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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playButton_MouseHover(object sender, EventArgs e)
        {
            playButton.Text = "Exit";
        }

        private void exitButton_MouseHover(object sender, EventArgs e)
        {
            exitButton.Text = "Play";
        }

        private void exitButton_MouseLeave(object sender, EventArgs e)
        {
            exitButton.Text = "Exit";
        }

        private void playButton_MouseLeave(object sender, EventArgs e)
        {
            playButton.Text = "Play";
        }
    }
}
