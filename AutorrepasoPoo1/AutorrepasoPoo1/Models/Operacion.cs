using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutorrepasoPoo1.Models
{
    public class Operacion
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public decimal Importe { get; set; }

        public Operacion(string tipo, decimal importe)
        {
            Fecha = DateTime.Now;
            Tipo = tipo;
            Importe = importe;
        }

        public override string ToString() => $"{Fecha:g} - {Tipo}: {Importe}";
    }
}
