using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Models
{
    public class Cliente
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad => DateTime.Now.Year - FechaNacimiento.Year -
                          (DateTime.Now.DayOfYear < FechaNacimiento.DayOfYear ? 1 : 0);

        public Cliente(string dni, string nombre, string telefono, string email, DateTime fechaNacimiento)
        {
            if (string.IsNullOrWhiteSpace(nombre)) throw new ArgumentException("El nombre es obligatorio.");
            if (string.IsNullOrWhiteSpace(telefono)) throw new ArgumentException("El teléfono es obligatorio.");
            if (string.IsNullOrWhiteSpace(email)) throw new ArgumentException("El email es obligatorio.");

            Dni = dni;
            Nombre = nombre;
            Telefono = telefono;
            Email = email;
            FechaNacimiento = fechaNacimiento;
        }

        public override string ToString() => $"{Nombre} - DNI: {Dni} - Edad: {Edad}";
    }
}
