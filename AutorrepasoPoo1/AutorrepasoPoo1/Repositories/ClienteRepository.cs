using AutorrepasoPoo1.Exceptions;
using AutorrepasoPoo1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Repositories
{
    public class ClienteRepository
    {
        private List<Cliente> clientes = new();

        public void Agregar(Cliente cliente)
        {
            if (clientes.Any(c => c.Dni == cliente.Dni))
                throw new ClienteYaExisteException("El DNI ya está registrado.");
            clientes.Add(cliente);
        }

        public Cliente? BuscarPorDni(string dni) => clientes.FirstOrDefault(c => c.Dni == dni);
        public List<Cliente> BuscarPorNombre(string nombre) =>
            clientes.Where(c => c.Nombre.Contains(nombre, StringComparison.OrdinalIgnoreCase)).ToList();

        public void Eliminar(Cliente cliente, CuentaRepository cuentaRepo)
        {
            if (cuentaRepo.ObtenerPorCliente(cliente).Any())
                throw new ClienteConCuentasException("No se puede eliminar un cliente con cuentas activas.");
            clientes.Remove(cliente);
        }

        public List<Cliente> Listar() => clientes;
    }
}
