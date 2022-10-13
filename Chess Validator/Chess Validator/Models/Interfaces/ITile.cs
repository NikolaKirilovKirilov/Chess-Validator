using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Validator.Models.Interfaces
{
    internal interface ITile
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public string Filler { get; set; }
        public bool WhiteKingProtection { get; set; }
        public bool BlackKingProtection { get; set; }
        public abstract bool CanIMove(int endRow, int endCol, ITile[,] board);
    }
}