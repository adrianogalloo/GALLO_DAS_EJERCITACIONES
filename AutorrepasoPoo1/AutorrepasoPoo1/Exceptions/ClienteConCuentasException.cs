using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Exceptions
{
    public class ClienteConCuentasException : Exception
    {
        public ClienteConCuentasException(string mensaje) : base(mensaje) { }
    }
}
