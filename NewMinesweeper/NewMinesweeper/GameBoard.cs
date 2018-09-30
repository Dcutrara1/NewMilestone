using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMinesweeper
{
    internal class GameBoard
    {       
        // Create 2D Array of buttons
        System.Windows.Forms.Button[,] buttons = new System.Windows.Forms.Button[Row, Col];

        public GameBoard(System.Windows.Forms.Button[,] buttons, bool visited, bool explored, bool bomb, bool bombUp, bool bombUpRight, bool bombRight, bool bombDownRight, bool bombDown, bool bombDownLeft, bool bombLeft, bool bombUpLeft)
        {
            this.buttons = buttons;
            Visited = visited;
            Explored = explored;
            Bomb = bomb;
            BombUp = bombUp;
            BombUpRight = bombUpRight;
            BombRight = bombRight;
            BombDownRight = bombDownRight;
            BombDown = bombDown;
            BombDownLeft = bombDownLeft;
            BombLeft = bombLeft;
            BombUpLeft = bombUpLeft;
        }
        public Button EachButton { get; set; }
        public bool Visited { get; set; }
        public bool Explored { get; set; }
        public bool Bomb { get; set; }
        public bool BombUp { get; set; }
        public bool BombUpRight { get; set; }
        public bool BombRight { get; set; }
        public bool BombDownRight { get; set; }
        public bool BombDown { get; set; }
        public bool BombDownLeft { get; set; }
        public bool BombLeft { get; set; }
        public bool BombUpLeft { get; set; }
        public static int Count { get; set; }
        public static int Col { get => Col; set => Col = value; }
        public static int Row { get => Row; set => Row = value; }        
    }
}