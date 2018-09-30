using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMinesweeper
{
    public partial class Form2 : Form
    {
        private static int row = Form1.Row;
        private static int col = Form1.Col;

        public Form2()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {
            if (Form1.Easy == true)
            {
                flowLayoutPanel1.Location = new Point(550, 50);
                flowLayoutPanel1.Size = new Size(275, 275);
                flowLayoutPanel1.Controls.Add(GameBoard.EachButton[row,col])

            else if (Form1.Moderate == true)
            {
                flowLayoutPanel1.Location = new Point(450, 50);
                flowLayoutPanel1.Size = new Size(485, 485);
                flowLayoutPanel1.Controls.Add(" ");
            }

            else if (Form1.Difficult == true)
            {
                flowLayoutPanel1.Location = new Point(200, 50);
                flowLayoutPanel1.Size = new Size(905, 485);
                flowLayoutPanel1.Controls.Add(buttons[i, j]);
            }

        }
    }
}
