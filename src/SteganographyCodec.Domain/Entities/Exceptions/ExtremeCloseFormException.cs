using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteganographyCodec.Domain.Entities.Exceptions
{
    public class ExtremeCloseFormException : Exception
    {
        public ExtremeCloseFormException() : base("Extreme close form") { }
    }
}
