using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Exceptions
{
    public class ClienteYaExisteException : Exception
    {
        public ClienteYaExisteException(string mensaje) : base(mensaje) { }
    }
}
