using Chess_Validator.Models.Board;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Validator.Core
{
    internal class Engine : IEngine
    {
        Board board = new();

        public Engine(string whitePostion)
        {
            board.FillBoard(whitePostion);
            board.DisplayBoard();
            board.WhiteAtTop = SetWhiteAtTopValue(whitePostion);
        }
        public void Play()
        {
            string move;

            Console.Write("(From - To): ");

            while ((move = Console.ReadLine()) != "End")
            {
                string[] moves = move.Split(' ');

                foreach (string action in moves)
                {
                    if (action.Length == 5)
                    {
                        //Takes coorddinates from input.
                        string[] coordinates = action.Split('-');
                        string beginning = coordinates[0].ToLower(), end = coordinates[1].ToLower();
                        beginning.ToCharArray(); end.ToCharArray();

                        int startColLetter = (int)beginning[0] - 97;
                        int startRowNumber = 8 - (int)Char.GetNumericValue(beginning[1]);

                        int endColLetter = (int)end[0] - 97;
                        int endRowNumber = 8 - (int)Char.GetNumericValue(end[1]);

                        //Finds out if move is valid with extracted coordinates and displays message if not, else displays the updated board.
                        if (board.ValidateMove(startColLetter, startRowNumber, endColLetter, endRowNumber))
                        {
                            board.DisplayBoard();
                        }
                        else
                        {
                            Console.WriteLine($"Wrong move: {action}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Wrong move: {action}");
                    }
                }
                Console.Write("(From - To): ");
            }
        }
        public bool SetWhiteAtTopValue(string position)
        {
            if(position.ToLower() == "top")
            {
                return true;
            }
            else if(position.ToLower() == "bot")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Wrong input!");
                return false;
            }
        }
    }
}