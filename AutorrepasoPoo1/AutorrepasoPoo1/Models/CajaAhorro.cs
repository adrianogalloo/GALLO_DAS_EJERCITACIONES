using AutorrepasoPoo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Models
{
    public class CajaAhorro : Cuenta
    {
        public decimal LimiteExtraccion { get; set; }

        public CajaAhorro(string codigo, Cliente titular, decimal limiteExtraccion)
            : base(codigo, titular)
        {
            LimiteExtraccion = limiteExtraccion;
        }

        public override void Extraer(decimal importe)
        {
            if (importe > LimiteExtraccion)
                throw new FondosInsuficientesException("La extracción supera el límite permitido.");
            if (Saldo < importe)
                throw new FondosInsuficientesException("Saldo insuficiente.");

            Saldo -= importe;
            Operaciones.Add(new Operacion("Extracción", -importe));
        }
    }
}
