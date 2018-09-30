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
    public partial class Button : System.Windows.Forms.Button
    {       
        public Button()
        {
            InitializeComponent();
        }

        public void CreateButtons(System.Windows.Forms.Button[,] buttons)
        {
            // Getting the number of rows in the array
            int rows = buttons.GetUpperBound(0) + 1;

            // Getting the number of columns in the array
            int columns = buttons.GetUpperBound(buttons.Rank - 1) + 1;

            // Starting row and column point
            int x = 0;
            int y = 0;

            // Instantiating all the buttons in the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    buttons[i, j] = new System.Windows.Forms.Button();
                    buttons[i, j].Size = new Size(30, 30);
                    buttons[i, j].Padding = Padding.Empty;
                    buttons[i, j].Margin = Padding.Empty;
                    buttons[i, j].BackColor = SystemColors.MenuHighlight;
                    buttons[i, j].Location = new Point(x + buttons[i, j].Width + 1,
                       y + buttons[i, j].Height + 1);                    
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
