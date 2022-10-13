using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_Validator.Models.Interfaces;

namespace Chess_Validator.Models.Units
{
    internal class Rook : IAgent, IMoved
    {
        private int row;
        private int col;
        private string color;
        private string figType;
        private string filler;
        private bool whiteKingProtection;
        private bool blackKingProtection;
        private bool iMoved;

        public Rook(int row, int col, string color, string type)
        {
            this.Row = row;
            this.Column = col;
            this.Color = color;
            this.FigType = type;
            this.Filler = SetFiller(color, type);
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
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }
        public string FigType
        {
            get
            {
                return this.figType;
            }
            set
            {
                this.figType = value;
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
        public bool IMoved
        {
            get
            {
                return this.iMoved;
            }
            set
            {
                this.iMoved = value;
            }
        }
        //Sets a short symbol combination to be recognised easier on the board.
        private static string SetFiller(string color, string type)
        {
            string result = color[0].ToString().ToUpper() + type[0].ToString().ToUpper();
            return result;
        }
        public bool CanIMove(int endRow, int endCol, ITile[,] board)
        {
            //Validates right movement
            if (endRow == row && endCol > col)
            {
                for (int col = this.col + 1; col < endCol; col++)
                {
                    if (board[endRow, col].Filler[0] == this.Filler[0] || board[endRow, col].Filler != "--")
                    {
                        return false;
                    }
                }
                this.col = endCol;
                IMoved = true;
                return true;
            }
            //Validates left movement
            else if (endRow == row && endCol < col)
            {
                for (int col = this.col - 1; col > endCol; col--)
                {
                    if (board[endRow, col].Filler[0] == this.Filler[0] || board[endRow, col].Filler != "--")
                    {
                        return false;
                    }
                }
                this.col = endCol;
                IMoved = true;
                return true;
            }
            //Validates downward movement
            else if (endCol == col && endRow > row)
            {
                for (int row = this.row + 1; row < endRow; row++)
                {
                    if (board[row, endCol].Filler[0] == this.Filler[0] || board[row, endCol].Filler != "--")
                    {
                        return false;
                    }
                }
                this.row = endRow;
                IMoved = true;
                return true;
            }
            //Validates upward movement
            else if (endCol == col && endRow < row)
            {
                for (int row = this.row - 1; row > endRow; row--)
                {
                    if (board[row, endCol].Filler[0] == this.Filler[0] || board[row, endCol].Filler != "--")
                    {
                        return false;
                    }
                }
                this.row = endRow;
                IMoved = true;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}