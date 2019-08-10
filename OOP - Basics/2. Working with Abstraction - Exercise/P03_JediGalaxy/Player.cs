using System;
using System.Collections.Generic;
using System.Text;

namespace P03_JediGalaxy
{
    class Player
    {
        private int row;
        private int col;

        public Player(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }

        public int Row {
            get => row;
            set => row = value;
        }

        public int Col
        {
            get => col;
            set => col = value;
        }
    }
}
