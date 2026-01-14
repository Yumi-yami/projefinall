using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projefinal
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblBaşla_Click(object sender, EventArgs e)
        {
            GameForm game = new GameForm();
            game.Show();
            this.Hide(); // Ana menüyü gizler
        }

        private void lblÇIK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
