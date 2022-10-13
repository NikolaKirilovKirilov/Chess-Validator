using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_Validator.Models.Interfaces;

namespace Chess_Validator.Models.Units
{
    internal class Pawn : IAgent, IMoved
    {
        private int row;
        private int col;
        private string color;
        private string figType;
        private string filler;
        private bool iMoved;
        private bool amAtTheTop;
        private bool whiteKingProtection;
        private bool blackKingProtection;

        public Pawn(int row, int col, string color, string type)
        {
            this.Row = row;
            this.Column = col;
            this.Color = color;
            this.FigType = type;
            this.Filler = SetFiller(color, type);
            if (this.Row == 1)
            {
                AmAtTheTop = true;
            }
            else if (this.Row == 6)
            {
                AmAtTheTop = false;
            }
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
        public bool AmAtTheTop
        {
            get
            {
                return this.amAtTheTop;
            }
            set
            {
                this.amAtTheTop = value;
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
            string result = color[0].ToString().ToUpper() + type[0].ToString().ToUpper();
            return result;
        }
        public bool CanIMove(int endRow, int endCol, ITile[,] board)
        {
            ITile target = board[endRow, endCol];
            //Validates that the tile is empty.
            if (target.Filler == "--")
            {
                //Helps coordinate movement only up or down depending on position chosen at the begining of the game.
                if (AmAtTheTop)
                {
                    //If pawn has moved it can move 1 tile downward.
                    if (endRow == row + 1 && endCol == col)
                    {
                        row = endRow;
                        return true;
                    }
                    //If pawn hasn't moved it can move 2 tiles downward.
                    else if ((endRow == row + 2 && endCol == col) && IMoved == false)
                    {
                        row = endRow;
                        IMoved = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    //If pawn has moved it can move 1 tile upward.
                    if (endRow == row - 1 && endCol == col)
                    {
                        row = endRow;
                        return true;
                    }
                    //If pawn hasn't moved it can move 2 tiles upward.
                    else if ((endRow == row - 2 && endCol == col) && IMoved == false)
                    {
                        row = endRow;
                        IMoved = true;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            //Validates that tile contains an enemy figure.
            else if (target.Filler != "--" && target.Filler[0] != this.Filler[0])
            {
                //Helps coordinate movement only up or down depending on position chosen at the begining of the game.
                if (AmAtTheTop)
                {
                    //Validates attack downward either to the reight or left.
                    if (endRow == row + 1 && (endCol == col + 1 || endCol == col - 1))
                    {
                        col = endCol;
                        row = endRow;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    //Validates attack upward either to the reight or left.
                    if (endRow == row - 1 && (endCol == col + 1 || endCol == col - 1))
                    {
                        col = endCol;
                        row = endRow;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }
        }
    }
}