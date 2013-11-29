using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Platformer
{
    public partial class Main : Form
    {
        bool right, left;
        bool jump;
        int grav = 30;
        int force;

        public Main()
        {
            InitializeComponent();
        }

        private void movment_Tick(object sender, EventArgs e)
        {
            // side collision
            if (player.Right > platform.Left && player.Left < platform.Right - player.Width / 2 && player.Bottom > platform.Top)
            {
                right = false;

            }
            if (player.Left < platform.Right && player.Right > platform.Left + player.Width / 2 && player.Bottom > platform.Top)
            {
                left = false;
            }
            //top collision
            if (player.Left + player.Width - 1 > platform.Left && player.Left + player.Width + 5 < platform.Left + platform.Width && player.Top + player.Height >= platform.Top && player.Top < platform.Top)
            {
                player.Top = playedField.Height - platform.Height - player.Height;
                force = 0;
                jump = false;
            }
            if (right == true) {player.Left += 5; }
            if (left== true) { player.Left -= 5; }
            if (jump == true)
            {
                player.Top -= force;
                force -= 1;
            }
            if (player.Top + player.Height >= playedField.Height)
            {
                player.Top = playedField.Height - player.Height;
                jump = false;
            } 
            else
            {
                player.Top += 5;  
            }

        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) { right = true; }
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.Escape) { this.Close(); }
            if (jump != true)
            {
                if (e.KeyCode == Keys.W)
                {
                    jump = true;
                    force = grav;
                }
            }
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D) { right = false; }
            if (e.KeyCode == Keys.A) { left = false; }
        }
    }
}
