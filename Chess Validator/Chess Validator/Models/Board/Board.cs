using Chess_Validator.Models.Interfaces;
using Chess_Validator.Models.Units;
using System;

namespace Chess_Validator.Models.Board
{
    internal class Board : IBoard
    {
        readonly ITile[,] boardArr = new ITile[8, 8];
        private bool whiteAtTop;
        public bool WhiteAtTop
        {
            get
            {
                return this.whiteAtTop;
            }
            set
            {
                this.whiteAtTop = value;
            }
        }

        //Fills the board to corresponding user input at the beginning of the game. 
        public void FillBoard(string WhitesTopOrBottom)
        {
            if (WhitesTopOrBottom == "Top")
            {
                for (int row = 0; row < 2; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        IAgent figure;
                        if ((row == 0 && col == 0) || (row == 0 && col == 7))
                        {
                            figure = new Rook(row, col, "white", "rook");
                            boardArr[row, col] = figure;
                        }
                        else if ((row == 0 && col == 1) || (row == 0 && col == 6))
                        {
                            figure = new Knight(row, col, "white", "knight");
                            boardArr[row, col] = figure;
                        }
                        else if ((row == 0 && col == 2) || (row == 0 && col == 5))
                        {
                            figure = new Bishop(row, col, "white", "bishop");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 0 && col == 3)
                        {
                            figure = new Queen(row, col, "white", "queen");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 0 && col == 4)
                        {
                            figure = new King(row, col, "white", "king");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 1)
                        {
                            figure = new Pawn(row, col, "white", "pawn");
                            boardArr[row, col] = figure;
                        }
                    }
                }

                for (int row = 2; row < 6; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        ITile emptyTile = new Tile(row, col);
                        boardArr[row, col] = emptyTile;
                    }
                }

                for (int row = 6; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        IAgent figure;
                        if ((row == 7 && col == 0) || (row == 7 && col == 7))
                        {
                            figure = new Rook(row, col, "black", "rook");
                            boardArr[row, col] = figure;
                        }
                        else if ((row == 7 && col == 1) || (row == 7 && col == 6))
                        {
                            figure = new Knight(row, col, "black", "knight");
                            boardArr[row, col] = figure;
                        }
                        else if ((row == 7 && col == 2) || (row == 7 && col == 5))
                        {
                            figure = new Bishop(row, col, "black", "bishop");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 7 && col == 3)
                        {
                            figure = new Queen(row, col, "black", "queen");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 7 && col == 4)
                        {
                            figure = new King(row, col, "black", "king");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 6)
                        {
                            figure = new Pawn(row, col, "black", "pawn");
                            boardArr[row, col] = figure;
                        }
                    }
                }
            }
            else if (WhitesTopOrBottom == "Bot")
            {
                for (int row = 0; row < 2; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        IAgent figure;
                        if ((row == 0 && col == 0) || (row == 0 && col == 7))
                        {
                            figure = new Rook(row, col, "black", "rook");
                            boardArr[row, col] = figure;
                        }
                        else if ((row == 0 && col == 1) || (row == 0 && col == 6))
                        {
                            figure = new Knight(row, col, "black", "knight");
                            boardArr[row, col] = figure;
                        }
                        else if ((row == 0 && col == 2) || (row == 0 && col == 5))
                        {
                            figure = new Bishop(row, col, "black", "bishop");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 0 && col == 3)
                        {
                            figure = new Queen(row, col, "black", "queen");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 0 && col == 4)
                        {
                            figure = new King(row, col, "black", "king");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 1)
                        {
                            figure = new Pawn(row, col, "black", "pawn");
                            boardArr[row, col] = figure;
                        }
                    }
                }

                for (int row = 2; row < 6; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        ITile emptyTile = new Tile(row, col);
                        boardArr[row, col] = emptyTile;
                    }
                }

                for (int row = 6; row < 8; row++)
                {
                    for (int col = 0; col < 8; col++)
                    {
                        IAgent figure;
                        if ((row == 7 && col == 0) || (row == 7 && col == 7))
                        {
                            figure = new Rook(row, col, "white", "rook");
                            boardArr[row, col] = figure;
                        }
                        else if ((row == 7 && col == 1) || (row == 7 && col == 6))
                        {
                            figure = new Knight(row, col, "white", "knight");
                            boardArr[row, col] = figure;
                        }
                        else if ((row == 7 && col == 2) || (row == 7 && col == 5))
                        {
                            figure = new Bishop(row, col, "white", "bishop");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 7 && col == 3)
                        {
                            figure = new Queen(row, col, "white", "queen");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 7 && col == 4)
                        {
                            figure = new King(row, col, "white", "king");
                            boardArr[row, col] = figure;
                        }
                        else if (row == 6)
                        {
                            figure = new Pawn(row, col, "white", "pawn");
                            boardArr[row, col] = figure;
                        }
                    }
                }
            }
            StartingKingOccupation();
        }
        //Visualises the board in the console.
        public void DisplayBoard()
        {
            for (int row = 0; row < 8; row++)
            {
                Console.Write(8 - row + "|");
                for (int col = 0; col < 8; col++)
                {
                    Console.Write(" " + boardArr[row, col].Filler + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===================================");
            Console.WriteLine("   a   b   c   d   e   f   g   h   ");
        }

        //Visualises all tiles and helps find those occupied by a king. (Helped during development)
        public void DisplayWhiteKingOccupation()
        {
            for (int row = 0; row < 8; row++)
            {
                Console.Write(8 - row + "|");
                for (int col = 0; col < 8; col++)
                {
                    Console.Write(" " + boardArr[row, col].WhiteKingProtection + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===================================");
            Console.WriteLine("   a   b   c   d   e   f   g   h   ");
        }
        public void DisplayBlackKingOccupation()
        {
            for (int row = 0; row < 8; row++)
            {
                Console.Write(8 - row + "|");
                for (int col = 0; col < 8; col++)
                {
                    Console.Write(" " + boardArr[row, col].BlackKingProtection + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("===================================");
            Console.WriteLine("   a   b   c   d   e   f   g   h   ");
        }

        //Calls the selected tile's "CanIMove" method to validate it's movement.
        public bool ValidateMove(int startColLetter, int startRowNumber, int endColLetter, int endRowNumber)
        {
            if ((startColLetter <= 8 && startRowNumber >= 0) && (endColLetter <= 8 && endRowNumber >= 0))
            {
                if (boardArr[startRowNumber, startColLetter].CanIMove(endRowNumber, endColLetter, boardArr))
                {
                    UpdateBoard(startColLetter, startRowNumber, endRowNumber, endColLetter);
                    UpdateKingOccupation();
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

        //Moves figure from its previous tile to the new tile and replaces the left tile with an empty one.
        public void UpdateBoard(int begCol, int begRow, int rowToMove, int colToMove)
        {
            ITile tile = new Tile(begRow, begCol);

            if (boardArr[begRow, begCol].Filler[1] == 'P' && (rowToMove == 0 || rowToMove == 7))
            {
                this.boardArr[rowToMove, colToMove] = PawnPromotion(rowToMove, colToMove, boardArr[begRow, begCol].Filler[0]);
            }
            else
            {
                this.boardArr[rowToMove, colToMove] = this.boardArr[begRow, begCol];
            }
            this.boardArr[begRow, begCol] = tile;
        }

        //Used only at the begining of the game to occupy tiles around the king. (Tought the game didn't need it but further testing showed otherwise)
        public void StartingKingOccupation()
        {
            int whiteKingRow = 0, whiteKingCol = 0;
            int blackKingRow = 0, blackKingCol = 0;

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    boardArr[row, col].WhiteKingProtection = false;
                    boardArr[row, col].BlackKingProtection = false;
                    //Finds which king moved
                    if (boardArr[row, col].Filler == "WK")
                    {
                        whiteKingRow = row;
                        whiteKingCol = col;
                    }
                    else if (boardArr[row, col].Filler == "BK")
                    {
                        blackKingRow = row;
                        blackKingCol = col;
                    }
                }
            }

            //White King
            if ((whiteKingRow - 1 >= 0 && whiteKingRow - 1 < 8) && (whiteKingCol - 1 >= 0 && whiteKingCol - 1 < 8))
                boardArr[whiteKingRow - 1, whiteKingCol - 1].WhiteKingProtection = true;

            if ((whiteKingRow - 1 >= 0 && whiteKingRow - 1 < 8) && (whiteKingCol >= 0 && whiteKingCol < 8))
                boardArr[whiteKingRow - 1, whiteKingCol].WhiteKingProtection = true;

            if ((whiteKingRow - 1 >= 0 && whiteKingRow - 1 < 8) && (whiteKingCol + 1 >= 0 && whiteKingCol + 1 < 8))
                boardArr[whiteKingRow - 1, whiteKingCol + 1].WhiteKingProtection = true;

            if ((whiteKingRow >= 0 && whiteKingRow < 8) && (whiteKingCol - 1 >= 0 && whiteKingCol - 1 < 8))
                boardArr[whiteKingRow, whiteKingCol - 1].WhiteKingProtection = true;

            if ((whiteKingRow >= 0 && whiteKingRow < 8) && (whiteKingCol >= 0 && whiteKingCol < 8))
                boardArr[whiteKingRow, whiteKingCol].WhiteKingProtection = true;

            if ((whiteKingRow >= 0 && whiteKingRow < 8) && (whiteKingCol + 1 >= 0 && whiteKingCol + 1 < 8))
                boardArr[whiteKingRow, whiteKingCol + 1].WhiteKingProtection = true;

            if ((whiteKingRow + 1 >= 0 && whiteKingRow + 1 < 8) && (whiteKingCol - 1 >= 0 && whiteKingCol - 1 < 8))
                boardArr[whiteKingRow + 1, whiteKingCol - 1].WhiteKingProtection = true;

            if ((whiteKingRow + 1 >= 0 && whiteKingRow + 1 < 8) && (whiteKingCol >= 0 && whiteKingCol < 8))
                boardArr[whiteKingRow + 1, whiteKingCol].WhiteKingProtection = true;

            if ((whiteKingRow + 1 >= 0 && whiteKingRow + 1 < 8) && (whiteKingCol + 1 >= 0 && whiteKingCol + 1 < 8))
                boardArr[whiteKingRow + 1, whiteKingCol + 1].WhiteKingProtection = true;

            //Black King
            if ((blackKingRow - 1 >= 0 && blackKingRow - 1 < 8) && (blackKingCol - 1 >= 0 && blackKingCol - 1 < 8))
                boardArr[blackKingRow - 1, blackKingCol - 1].BlackKingProtection = true;

            if ((blackKingRow - 1 >= 0 && blackKingRow - 1 < 8) && (blackKingCol >= 0 && blackKingCol < 8))
                boardArr[blackKingRow - 1, blackKingCol].BlackKingProtection = true;

            if ((blackKingRow - 1 >= 0 && blackKingRow - 1 < 8) && (blackKingCol + 1 >= 0 && blackKingCol + 1 < 8))
                boardArr[blackKingRow - 1, blackKingCol + 1].BlackKingProtection = true;

            if ((blackKingRow >= 0 && blackKingRow < 8) && (blackKingCol - 1 >= 0 && blackKingCol - 1 < 8))
                boardArr[blackKingRow, blackKingCol - 1].BlackKingProtection = true;

            if ((blackKingRow >= 0 && blackKingRow < 8) && (blackKingCol >= 0 && blackKingCol < 8))
                boardArr[blackKingRow, blackKingCol].BlackKingProtection = true;

            if ((blackKingRow >= 0 && blackKingRow < 8) && (blackKingCol + 1 >= 0 && blackKingCol + 1 < 8))
                boardArr[blackKingRow, blackKingCol + 1].BlackKingProtection = true;

            if ((blackKingRow + 1 >= 0 && blackKingRow + 1 < 8) && (blackKingCol - 1 >= 0 && blackKingCol - 1 < 8))
                boardArr[blackKingRow + 1, blackKingCol - 1].BlackKingProtection = true;

            if ((blackKingRow + 1 >= 0 && blackKingRow + 1 < 8) && (blackKingCol >= 0 && blackKingCol < 8))
                boardArr[blackKingRow + 1, blackKingCol].BlackKingProtection = true;

            if ((blackKingRow + 1 >= 0 && blackKingRow + 1 < 8) && (blackKingCol + 1 >= 0 && blackKingCol + 1 < 8))
                boardArr[blackKingRow + 1, blackKingCol + 1].BlackKingProtection = true;
        }

        //Finds which king moved and uptades his occupied tiles.
        public void UpdateKingOccupation()
        {
            int whiteKingRow = 0, whiteKingCol = 0;
            bool whiteKingChangedPosition = false;
            int blackKingRow = 0, blackKingCol = 0;
            bool blackKingChangedPosition = false;


            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    boardArr[row, col].WhiteKingProtection = false;
                    boardArr[row, col].BlackKingProtection = false;
                    //Finds which king moved
                    if (boardArr[row, col].Filler == "WK")
                    {
                        whiteKingRow = row;
                        whiteKingCol = col;
                        whiteKingChangedPosition = true;
                    }
                    else if (boardArr[row, col].Filler == "BK")
                    {
                        blackKingRow = row;
                        blackKingCol = col;
                        blackKingChangedPosition = true;
                    }
                }
            }

            //Checks if either color king moved
            if (whiteKingChangedPosition)
            {
                //First checks if the coordinates to occupy are in the bounderies of the board and updates the ones which are.
                if ((whiteKingRow - 1 >= 0 && whiteKingRow - 1 < 8) && (whiteKingCol - 1 >= 0 && whiteKingCol - 1 < 8))
                    boardArr[whiteKingRow - 1, whiteKingCol - 1].WhiteKingProtection = true;

                if ((whiteKingRow - 1 >= 0 && whiteKingRow - 1 < 8) && (whiteKingCol >= 0 && whiteKingCol < 8))
                    boardArr[whiteKingRow - 1, whiteKingCol].WhiteKingProtection = true;

                if ((whiteKingRow - 1 >= 0 && whiteKingRow - 1 < 8) && (whiteKingCol + 1 >= 0 && whiteKingCol + 1 < 8))
                    boardArr[whiteKingRow - 1, whiteKingCol + 1].WhiteKingProtection = true;

                if ((whiteKingRow >= 0 && whiteKingRow < 8) && (whiteKingCol - 1 >= 0 && whiteKingCol - 1 < 8))
                    boardArr[whiteKingRow, whiteKingCol - 1].WhiteKingProtection = true;

                if ((whiteKingRow >= 0 && whiteKingRow < 8) && (whiteKingCol >= 0 && whiteKingCol < 8))
                    boardArr[whiteKingRow, whiteKingCol].WhiteKingProtection = true;

                if ((whiteKingRow >= 0 && whiteKingRow < 8) && (whiteKingCol + 1 >= 0 && whiteKingCol + 1 < 8))
                    boardArr[whiteKingRow, whiteKingCol + 1].WhiteKingProtection = true;

                if ((whiteKingRow + 1 >= 0 && whiteKingRow + 1 < 8) && (whiteKingCol - 1 >= 0 && whiteKingCol - 1 < 8))
                    boardArr[whiteKingRow + 1, whiteKingCol - 1].WhiteKingProtection = true;

                if ((whiteKingRow + 1 >= 0 && whiteKingRow + 1 < 8) && (whiteKingCol >= 0 && whiteKingCol < 8))
                    boardArr[whiteKingRow + 1, whiteKingCol].WhiteKingProtection = true;

                if ((whiteKingRow + 1 >= 0 && whiteKingRow + 1 < 8) && (whiteKingCol + 1 >= 0 && whiteKingCol + 1 < 8))
                    boardArr[whiteKingRow + 1, whiteKingCol + 1].WhiteKingProtection = true;
            }

            if (blackKingChangedPosition)
            {
                //First checks if the coordinates to occupy are in the bounderies of the board and updates the ones which are.
                if ((blackKingRow - 1 >= 0 && blackKingRow - 1 < 8) && (blackKingCol - 1 >= 0 && blackKingCol - 1 < 8))
                    boardArr[blackKingRow - 1, blackKingCol - 1].BlackKingProtection = true;

                if ((blackKingRow - 1 >= 0 && blackKingRow - 1 < 8) && (blackKingCol >= 0 && blackKingCol < 8))
                    boardArr[blackKingRow - 1, blackKingCol].BlackKingProtection = true;

                if ((blackKingRow - 1 >= 0 && blackKingRow - 1 < 8) && (blackKingCol + 1 >= 0 && blackKingCol + 1 < 8))
                    boardArr[blackKingRow - 1, blackKingCol + 1].BlackKingProtection = true;

                if ((blackKingRow >= 0 && blackKingRow < 8) && (blackKingCol - 1 >= 0 && blackKingCol - 1 < 8))
                    boardArr[blackKingRow, blackKingCol - 1].BlackKingProtection = true;

                if ((blackKingRow >= 0 && blackKingRow < 8) && (blackKingCol >= 0 && blackKingCol < 8))
                    boardArr[blackKingRow, blackKingCol].BlackKingProtection = true;

                if ((blackKingRow >= 0 && blackKingRow < 8) && (blackKingCol + 1 >= 0 && blackKingCol + 1 < 8))
                    boardArr[blackKingRow, blackKingCol + 1].BlackKingProtection = true;

                if ((blackKingRow + 1 >= 0 && blackKingRow + 1 < 8) && (blackKingCol - 1 >= 0 && blackKingCol - 1 < 8))
                    boardArr[blackKingRow + 1, blackKingCol - 1].BlackKingProtection = true;

                if ((blackKingRow + 1 >= 0 && blackKingRow + 1 < 8) && (blackKingCol >= 0 && blackKingCol < 8))
                    boardArr[blackKingRow + 1, blackKingCol].BlackKingProtection = true;

                if ((blackKingRow + 1 >= 0 && blackKingRow + 1 < 8) && (blackKingCol + 1 >= 0 && blackKingCol + 1 < 8))
                    boardArr[blackKingRow + 1, blackKingCol + 1].BlackKingProtection = true;
            }
        }

        //Promotes pawns when they reach the enemy's end of the board. If the input figure is wrong or nothing hasan't been writen at all nothing changes.
        public ITile PawnPromotion(int endRow, int endCol, char color)
        {
            if (color == 'W')
            {
                if(WhiteAtTop && endRow == 7)
                {
                    Console.Write("White chooses figure!\n(Knight, Rook, Bishop, Queen): ");
                    string upgrade = Console.ReadLine();
                    if(upgrade.ToLower() == "knight")
                    {
                        ITile newFigure = new Knight(endRow, endCol, "white", "knight");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "rook")
                    {
                        ITile newFigure = new Rook(endRow, endCol, "white", "rook");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "bishop")
                    {
                        ITile newFigure = new Bishop(endRow, endCol, "white", "bishop");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "queen")
                    {
                        ITile newFigure = new Queen(endRow, endCol, "white", "queen");
                        return newFigure;
                    }
                    else
                    {
                        Console.Write("Wrong input! No changes!");
                        string stringColor = string.Empty;
                        if (color == 'W')
                        {
                            stringColor = "white";
                        }
                        else if (color == 'B')
                        {
                            stringColor = "black";
                        }
                        ITile noChange = new Pawn(endRow, endCol, stringColor, "pawn");
                        return noChange;
                    }
                }
                else if(!WhiteAtTop && endRow == 0)
                {
                    Console.Write("White chooses figure!\n(Knight, Rook, Bishop, Queen): ");
                    string upgrade = Console.ReadLine();
                    if (upgrade.ToLower() == "knight")
                    {
                        ITile newFigure = new Knight(endRow, endCol, "white", "knight");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "rook")
                    {
                        ITile newFigure = new Rook(endRow, endCol, "white", "rook");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "bishop")
                    {
                        ITile newFigure = new Bishop(endRow, endCol, "white", "bishop");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "queen")
                    {
                        ITile newFigure = new Queen(endRow, endCol, "white", "queen");
                        return newFigure;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input! No changes!");
                        string stringColor = string.Empty;
                        if (color == 'W')
                        {
                            stringColor = "white";
                        }
                        else if (color == 'B')
                        {
                            stringColor = "black";
                        }
                        ITile noChange = new Pawn(endRow, endCol, stringColor, "pawn");
                        return noChange;
                    }
                }
                else
                {
                    string stringColor = string.Empty;
                    if (color == 'W')
                    {
                        stringColor = "white";
                    }
                    else if (color == 'B')
                    {
                        stringColor = "black";
                    }
                    ITile noChange = new Pawn(endRow, endCol, stringColor, "pawn");
                    return noChange;
                }
            }
            else if (color == 'B')
            {
                if (WhiteAtTop && endRow == 0)
                {
                    Console.Write("White chooses figure!\n(Knight, Rook, Bishop, Queen): ");
                    string upgrade = Console.ReadLine();
                    if (upgrade.ToLower() == "knight")
                    {
                        ITile newFigure = new Knight(endRow, endCol, "black", "knight");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "rook")
                    {
                        ITile newFigure = new Rook(endRow, endCol, "black", "rook");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "bishop")
                    {
                        ITile newFigure = new Bishop(endRow, endCol, "black", "bishop");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "queen")
                    {
                        ITile newFigure = new Queen(endRow, endCol, "black", "queen");
                        return newFigure;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input! No changes!");
                        string stringColor = string.Empty;
                        if (color == 'W')
                        {
                            stringColor = "white";
                        }
                        else if (color == 'B')
                        {
                            stringColor = "black";
                        }
                        ITile noChange = new Pawn(endRow, endCol, stringColor, "pawn");
                        return noChange;
                    }
                }
                else if (!WhiteAtTop && endRow == 7)
                {
                    Console.Write("White chooses figure!\n(Knight, Rook, Bishop, Queen): ");
                    string upgrade = Console.ReadLine();
                    if (upgrade.ToLower() == "knight")
                    {
                        ITile newFigure = new Knight(endRow, endCol, "black", "knight");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "rook")
                    {
                        ITile newFigure = new Rook(endRow, endCol, "black", "rook");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "bishop")
                    {
                        ITile newFigure = new Bishop(endRow, endCol, "black", "bishop");
                        return newFigure;
                    }
                    else if (upgrade.ToLower() == "queen")
                    {
                        ITile newFigure = new Queen(endRow, endCol, "black", "queen");
                        return newFigure;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input! No changes!");
                        string stringColor = string.Empty;
                        if (color == 'W')
                        {
                            stringColor = "white";
                        }
                        else if (color == 'B')
                        {
                            stringColor = "black";
                        }
                        ITile noChange = new Pawn(endRow, endCol, stringColor, "pawn");
                        return noChange;
                    }
                }
                else
                {
                    string stringColor = string.Empty;
                    if (color == 'W')
                    {
                        stringColor = "white";
                    }
                    else if (color == 'B')
                    {
                        stringColor = "black";
                    }
                    ITile noChange = new Pawn(endRow, endCol, stringColor, "pawn");
                    return noChange;
                }
            }
            else
            {
                string stringColor = string.Empty;
                if(color == 'W')
                {
                    stringColor = "white";
                }
                else if(color == 'B')
                {
                    stringColor = "black";
                }
                ITile noChange = new Pawn(endRow, endCol, stringColor, "pawn");
                return noChange;
            }
        }
    }
}