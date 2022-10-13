using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Validator.Core
{
    internal interface IEngine
    {
        void StartGame() { }
        void ValidateMove() { }
    }
}