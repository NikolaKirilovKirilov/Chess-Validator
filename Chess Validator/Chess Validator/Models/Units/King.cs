using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_Validator.Models.Interfaces;

namespace Chess_Validator.Models.Units
{
    internal class King : IAgent, IMoved
    {
        private int row;
        private int col;
        private string color;
        private string figType;
        private string filler;
        private bool whiteKingProtection;
        private bool blackKingProtection;
        private bool iMoved;
        public King(int row, int col, string color, string type)
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
            //First validates if move is a casteling manuver.
            if ((endRow == 0 || endRow == 7) && endCol == this.col + 2 || endCol == this.col - 2)
            {
                if (Castlenig(endRow, endCol, board))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //If not checks if regular movment is possible.
            else
            {
                if(this.color == "white")
                {
                    //Validates that the move is exactly one tile away in any direction, the tile is not friendly and it is not occupied by the oposite color's king.
                    if ((endRow == this.row - 1 && endCol == this.col - 1) && board[this.row - 1, this.col - 1].Filler[0] != this.color[0] && board[this.row - 1, this.col - 1].BlackKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row - 1 && endCol == this.col && board[this.row - 1, this.col].Filler[0] != this.color[0] && board[this.row - 1, this.col].BlackKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row - 1 && endCol == this.col + 1 && board[this.row - 1, this.col + 1].Filler[0] != this.color[0] && board[this.row - 1, this.col + 1].BlackKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row && endCol == this.col - 1 && board[this.row, this.col - 1].Filler[0] != this.color[0] && board[this.row, this.col - 1].BlackKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row && endCol == this.col + 1 && board[this.row, this.col + 1].Filler[0] != this.color[0] && board[this.row, this.col + 1].BlackKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row + 1 && endCol == this.col - 1 && board[this.row + 1, this.col - 1].Filler[0] != this.color[0] && board[this.row + 1, this.col - 1].BlackKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row + 1 && endCol == this.col && board[this.row + 1, this.col].Filler[0] != this.color[0] && board[this.row + 1, this.col].BlackKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row + 1 && endCol == this.col + 1 && board[this.row + 1, this.col + 1].Filler[0] != this.color[0] && board[this.row + 1, this.col + 1].BlackKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (this.color == "black")
                {
                    //Validates that the move is exactly one tile away in any direction, the tile is not friendly and it is not occupied by the oposite color's king.
                    if ((endRow == this.row - 1 && endCol == this.col - 1) && board[this.row - 1, this.col - 1].Filler[0] != this.color[0] && board[this.row - 1, this.col - 1].WhiteKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row - 1 && endCol == this.col && board[this.row - 1, this.col].Filler[0] != this.color[0] && board[this.row - 1, this.col].WhiteKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row - 1 && endCol == this.col + 1 && board[this.row - 1, this.col + 1].Filler[0] != this.color[0] && board[this.row - 1, this.col + 1].WhiteKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row && endCol == this.col - 1 && board[this.row, this.col - 1].Filler[0] != this.color[0] && board[this.row, this.col - 1].WhiteKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row && endCol == this.col + 1 && board[this.row, this.col + 1].Filler[0] != this.color[0] && board[this.row, this.col + 1].WhiteKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row + 1 && endCol == this.col - 1 && board[this.row + 1, this.col - 1].Filler[0] != this.color[0] && board[this.row + 1, this.col - 1].WhiteKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row + 1 && endCol == this.col && board[this.row + 1, this.col].Filler[0] != this.color[0] && board[this.row + 1, this.col].WhiteKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else if (endRow == this.row + 1 && endCol == this.col + 1 && board[this.row + 1, this.col + 1].Filler[0] != this.color[0] && board[this.row + 1, this.col + 1].WhiteKingProtection != true)
                    {
                        this.row = endRow;
                        this.col = endCol;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
        }
        //Checks if casteling is possible.
        public bool Castlenig(int endRow, int endCol, ITile[,] board)
        {
            //If this king has moved casteling is no longer an option
            if (IMoved)
            {
                return false;
            }
            else
            {
                if (endRow != 0 || endRow != 7)
                {
                    return false;
                }
                else
                {
                    //Checks if tiles to rook on the left are clear.
                    if (endCol < this.col)
                    {
                        for (int col = this.col - 1; col > 0; col--)
                        {
                            if (board[this.row, col].Filler != "--")
                            {
                                return false;
                            }
                        }
                        if (board[this.row, endCol].Filler != this.color[0] + "R")
                        {
                            return false;
                        }
                    }
                    //Checks if tiles to rook on the right are clear.
                    else if (endCol > this.col)
                    {
                        for (int col = this.col = 1; col > 8; col++)
                        {
                            if (board[this.row, col].Filler != "--")
                            {
                                return false;
                            }
                        }
                        if (board[this.row, endCol].Filler != this.color[0] + "R")
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                    return true;
                }
            }
        }
    }
}