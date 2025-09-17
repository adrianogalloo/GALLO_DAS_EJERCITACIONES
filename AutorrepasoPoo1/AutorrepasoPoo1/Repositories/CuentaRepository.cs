using AutorrepasoPoo1.Exceptions;
using AutorrepasoPoo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Repositories
{
    public class CuentaRepository
    {
        private List<Cuenta> cuentas = new();

        public void Agregar(Cuenta cuenta)
        {
            if (cuentas.Any(c => c.Codigo == cuenta.Codigo))
                throw new ArgumentException("El código de cuenta ya existe.");
            cuentas.Add(cuenta);
        }

        public List<Cuenta> ObtenerPorCliente(Cliente cliente) =>
            cuentas.Where(c => c.Titular == cliente).ToList();

        public void Eliminar(Cuenta cuenta)
        {
            if (cuenta.Saldo != 0)
                throw new CuentaConSaldoException("No se puede eliminar una cuenta con saldo distinto de cero.");
            cuentas.Remove(cuenta);
        }

        public List<Cuenta> Listar() => cuentas;
    }
}
