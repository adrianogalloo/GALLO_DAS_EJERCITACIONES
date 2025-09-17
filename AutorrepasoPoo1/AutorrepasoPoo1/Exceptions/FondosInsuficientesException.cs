using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Exceptions
{
    public class FondosInsuficientesException : Exception
    {
        public FondosInsuficientesException(string mensaje) : base(mensaje) { }
    }
}
