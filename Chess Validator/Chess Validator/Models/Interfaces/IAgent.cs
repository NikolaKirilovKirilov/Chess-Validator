using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Validator.Models.Interfaces
{
    internal interface IAgent : ITile
    {
        string FigType { get; set; }
        string Color { get; set; }

    }
}