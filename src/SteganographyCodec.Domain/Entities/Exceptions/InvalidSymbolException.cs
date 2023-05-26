using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteganographyCodec.Domain.Entities.Exceptions
{
    public class InvalidSymbolException : Exception
    {
        public InvalidSymbolException(char symbol) : base($"Invalid symbol {symbol}, only English") { }
    }
}
