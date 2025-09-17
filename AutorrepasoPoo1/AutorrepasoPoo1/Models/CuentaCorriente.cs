using AutorrepasoPoo1.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Models
{
    public class CuentaCorriente : Cuenta
    {
        public decimal DescubiertoMaximo { get; set; }

        public CuentaCorriente(string codigo, Cliente titular, decimal descubiertoMaximo)
            : base(codigo, titular)
        {
            DescubiertoMaximo = descubiertoMaximo;
        }

        public override void Extraer(decimal importe)
        {
            if (Saldo - importe < -DescubiertoMaximo)
                throw new FondosInsuficientesException("Se superó el límite de descubierto.");

            Saldo -= importe;
            Operaciones.Add(new Operacion("Extracción", -importe));
        }
    }
}
