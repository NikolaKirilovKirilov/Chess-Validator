using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chess_Validator.Models.Interfaces;

namespace Chess_Validator.Models.Units
{
    internal class Queen : IAgent
    {
        private int row;
        private int col;
        private string color;
        private string figType;
        private string filler;
        private bool whiteKingProtection;
        private bool blackKingProtection;

        public Queen(int row, int col, string color, string type)
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
            string result = color[0].ToString().ToUpper() + type[0].ToString().ToUpper();
            return result;
        }
        public bool CanIMove(int endRow, int endCol, ITile[,] board)
        {
            bool passedTarget = false;
            int row = this.row;
            int originalEndRow = endRow;
            int col = this.col;
            int originalEndCol = endCol;
            //Validates down-right diagonal Direction (Forwards): From figure to be moved to targeted tile.
            if (endRow > this.row && endCol > this.col)
            {
                while (!passedTarget)
                {
                    //If target is reached rewrite its coordinates and return true.
                    if (row + 1 == endRow && col + 1 == endCol && board[endRow, endCol].Filler == "--")
                    {
                        this.row = originalEndRow;
                        this.col = originalEndCol;
                        return true;
                    }
                    //Checks if target was passed.
                    else if (row + 1 > endRow || col + 1 > endCol)
                    {
                        return false;
                    }
                    //Checks if path is blocked by any figure.
                    else if (board[row + 1, col + 1].Filler != "--" && (row + 1 != endRow && col + 1 != endCol))
                    {
                        return false;
                    }
                    row++;
                    col++;
                }
                return false;
            }
            //Validates down-left diagonal. Direction (Backwards): From targeted tile to figure to be moved.
            else if (endRow > this.row && endCol < this.col)
            {
                while (!passedTarget)
                {
                    //If target is reached rewrite its coordinates and return true.
                    if (endRow - 1 == row && endCol + 1 == col && board[endRow, endCol].Filler == "--")
                    {
                        this.row = originalEndRow;
                        this.col = originalEndCol;
                        return true;
                    }
                    //Checks if target was passed.
                    else if (endRow - 1 < row || endCol + 1 > col)
                    {
                        return false;
                    }
                    //Checks if path is blocked by any figure.
                    else if (board[endRow - 1, endCol + 1].Filler != "--" && (endRow - 1 != row && endCol + 1 != col))
                    {
                        return false;
                    }
                    endRow--;
                    endCol++;
                }
                return false;
            }
            //Validates up-right diagonal. Direction (Backwards): From targeted tile to figure to be moved.
            else if (endRow < this.row && endCol > this.col)
            {
                while (!passedTarget)
                {
                    //If target is reached rewrite its coordinates and return true.
                    if (endRow + 1 == row && endCol - 1 == col && board[endRow, endCol].Filler == "--")
                    {
                        this.row = originalEndRow;
                        this.col = originalEndCol;
                        return true;
                    }
                    //Checks if target was passed.
                    else if (endRow + 1 > row || endCol - 1 < col)
                    {
                        return false;
                    }
                    //Checks if path is blocked by any figure.
                    else if (board[endRow + 1, endCol - 1].Filler != "--" && (endRow + 1 != row && endCol - 1 != col))
                    {
                        return false;
                    }
                    endRow++;
                    endCol--;
                }
                return false;
            }
            //Validates up-left diagonal. From figure to be moved to targeted tile.
            else if (endRow < this.row && endCol < this.col)
            {
                while (!passedTarget)
                {
                    //If target is reached rewrite its coordinates and return true.
                    if (row - 1 == endRow || col - 1 == endCol && board[endRow, endCol].Filler == "--")
                    {
                        this.row = originalEndRow;
                        this.col = originalEndCol;
                        return true;
                    }
                    //Checks if target was passed.
                    else if (row - 1 < endRow || col - 1 < endCol)
                    {
                        return false;
                    }
                    //Checks if path is blocked by any figure.
                    else if (board[row - 1, col - 1].Filler != "--" && (row - 1 != endRow && col - 1 != endCol))
                    {
                        return false;
                    }
                    row--;
                    col--;
                }
                return false;
            }
            //Validates right movement
            else if (endRow == row && endCol > col)
            {
                for (int i = this.col + 1; i < endCol; i++)
                {
                    if (board[endRow, i].Filler[0] == this.Filler[0] || board[endRow, i].Filler != "--")
                    {
                        return false;
                    }
                }
                this.col = endCol;
                return true;
            }
            //Validates left movement
            else if (endRow == row && endCol < col)
            {
                for (int i = this.col - 1; i > endCol; i--)
                {
                    if (board[endRow, i].Filler[0] == this.Filler[0] || board[endRow, i].Filler != "--")
                    {
                        return false;
                    }
                }
                this.col = endCol;
                return true;
            }
            //Validates downward movement
            else if (endCol == col && endRow > row)
            {
                for (int i = this.row + 1; i < endRow; i++)
                {
                    if (board[i, endCol].Filler[0] == this.Filler[0] || board[i, endCol].Filler != "--")
                    {
                        return false;
                    }
                }
                this.row = endRow;
                return true;
            }
            //Validates upward movement
            else if (endCol == col && endRow < row)
            {
                for (int i = this.row - 1; i > endRow; i--)
                {
                    if (board[i, endCol].Filler[0] == this.Filler[0] || board[i, endCol].Filler != "--")
                    {
                        return false;
                    }
                }
                this.row = endRow;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}