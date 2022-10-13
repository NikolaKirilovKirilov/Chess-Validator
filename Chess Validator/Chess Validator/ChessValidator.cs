using Chess_Validator.Core;
using System;

namespace Chess_Validator
{
    internal class ChessValidator
    {
        static void Main()
        {
            Console.Write("Hello World! Welcome to My Chess Validator!\nPlease choose where the white pieces should stay.\nChoose (Top/Bot): ");
            string position = Console.ReadLine();
            Engine startUp= new(position);
            startUp.Play();
        }
    }
}