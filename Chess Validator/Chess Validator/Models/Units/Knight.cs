using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_Validator.Models.Interfaces;

namespace Chess_Validator.Models.Units
{
    internal class Knight : IAgent
    {
        private int row;
        private int col;
        private string color;
        private string figType;
        private string filler;
        private bool whiteKingProtection;
        private bool blackKingProtection;
        public Knight(int row, int col, string color, string type)
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
        //Sets a short symbol combination to be recognised easier on the board.
        private static string SetFiller(string color, string type)
        {
            string result = color[0].ToString().ToUpper() + type[0].ToString().ToLower();
            return result;
        }
        public bool CanIMove(int endRow, int endCol, ITile[,] board)
        {
            ITile target = board[endRow, endCol];
            //Validates if target is different from friendly figure.
            if (this.Filler[0] != target.Filler[0])
            {
                //Validates if the target is reachable in an L shaped move.
                if (endRow == row + 1 && endCol == col + 2)
                {
                    row = endRow;
                    col = endCol;
                    return true;
                }
                else if (endRow == row + 1 && endCol == col - 2)
                {
                    row = endRow;
                    col = endCol;
                    return true;
                }
                else if (endRow == row + 2 && endCol == col + 1)
                {
                    row = endRow;
                    col = endCol;
                    return true;
                }
                else if (endRow == row + 2 && endCol == col - 1)
                {
                    row = endRow;
                    col = endCol;
                    return true;
                }
                else if (endRow == row - 1 && endCol == col + 2)
                {
                    row = endRow;
                    col = endCol;
                    return true;
                }
                else if (endRow == row - 1 && endCol == col - 2)
                {
                    row = endRow;
                    col = endCol;
                    return true;
                }
                else if (endRow == row - 2 && endCol == col + 1)
                {
                    row = endRow;
                    col = endCol;
                    return true;
                }
                else if (endRow == row - 2 && endCol == col - 1)
                {
                    row = endRow;
                    col = endCol;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}