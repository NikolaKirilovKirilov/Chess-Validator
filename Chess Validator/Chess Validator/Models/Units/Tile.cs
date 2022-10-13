using Chess_Validator.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Validator.Models.Units
{
    internal class Tile : ITile
    {
        private int row;
        private int col;
        private string filler;
        private bool whiteKingProtection;
        private bool blackKingProtection;

        public Tile(int row, int col)
        {
            this.Row = row;
            this.col = col;
            this.Filler = "--";
        }
        public int Row 
        {
            get
            {
                return this.row;
            }        
            set
            {
                this.row = value;
            }
        }
        public int Column 
        { 
            get
            {
                return this.col;
            }
            set
            {
                this.col = value;
            }
        }
        public string Filler
        {
            get
            {
                return this.filler;
            }
            set
            {
                this.filler = value;
            }
        }

        public bool WhiteKingProtection 
        { 
            get
            {
                return this.whiteKingProtection;
            }
            set
            {
                this.whiteKingProtection = value;
            }
        }
        public bool BlackKingProtection 
        { 
            get
            {
                return this.blackKingProtection;
            }
            set
            {
                this.blackKingProtection = value;
            }
        }

        public bool CanIMove(int endRow, int endCol, ITile[,] board)
        {
            //Do not move! You are a tile! Just return false and leave it there!
            return false;
        }
    }
}