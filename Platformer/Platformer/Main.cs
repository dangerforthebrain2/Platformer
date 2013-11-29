﻿using System;
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
        bool right;
        bool left;

        public Main()
        {
            InitializeComponent();
        }

        private void movment_Tick(object sender, EventArgs e)
        {
            if (right == true) {player.Left += 5; }
            if (left== true) { player.Left -= 5; }
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = true; }
            if (e.KeyCode == Keys.Left) { left = true; }
        }

        private void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { right = false; }
            if (e.KeyCode == Keys.Left) { left = false; }
        }
    }
}
