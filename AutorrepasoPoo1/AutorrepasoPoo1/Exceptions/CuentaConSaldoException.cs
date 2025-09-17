using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Exceptions
{
    public class CuentaConSaldoException : Exception
    {
        public CuentaConSaldoException(string mensaje) : base(mensaje) { }
    }
}
