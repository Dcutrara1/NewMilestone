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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static bool Easy { get; set; }
        public static bool Moderate { get; set; }
        public static bool Difficult { get; set; }   
        public static int Row { get; set; }
        public static int Col { get; set; }
    

        private void PlayButton_Click(object sender, EventArgs e)
        {
            if (EasyButton.Checked == true)
            { Easy = true; Moderate = false; Difficult = false; }

            if (ModerateButton.Checked == true)
            { Moderate = true; Easy = false; Difficult = false; }

            if (DifficultButton.Checked == true)
            { Difficult = true; Easy = false; Moderate = false; }

            // Set the row and column of Grid. 
           
            if (Easy == true)
            { Row = 9; Col = 9; }

            if (Moderate == true)
            { Row = 16; Col = 16; }

            if (Difficult == true)
            { Row = 16; Col = 30; }

            Form2 form = new Form2();
            form.Show();
        }
    }
}
