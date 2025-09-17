using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Models
{
    public abstract class Cuenta
    {
        public string Codigo { get; set; }
        public Cliente Titular { get; set; }
        public decimal Saldo { get; protected set; }
        public List<Operacion> Operaciones { get; set; } = new();

        protected Cuenta(string codigo, Cliente titular)
        {
            Codigo = codigo;
            Titular = titular;
            Saldo = 0;
        }

        public void Depositar(decimal importe)
        {
            if (importe <= 0) throw new ArgumentException("El depósito debe ser mayor a cero.");
            Saldo += importe;
            Operaciones.Add(new Operacion("Depósito", importe));
        }

        public abstract void Extraer(decimal importe);

        public override string ToString() => $"{Codigo} - {Titular.Nombre} - Saldo: {Saldo}";
    }
}
