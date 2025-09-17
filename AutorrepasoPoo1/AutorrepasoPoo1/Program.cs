using AutorrepasoPoo1.Models;
using AutorrepasoPoo1.Repositories;
using AutorrepasoPoo1.Exceptions;

ClienteRepository clienteRepo = new();
CuentaRepository cuentaRepo = new();

bool salir = false;

while (!salir)
{
    Console.WriteLine("\n--- BANCO APP ---");
    Console.WriteLine("1. Agregar Cliente");
    Console.WriteLine("2. Listar Clientes");
    Console.WriteLine("3. Agregar Cuenta");
    Console.WriteLine("4. Depositar");
    Console.WriteLine("5. Extraer");
    Console.WriteLine("6. Listar Cuentas");
    Console.WriteLine("0. Salir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine()!;
    try
    {
        switch (opcion)
        {
            case "1":
                Console.Write("DNI: "); string dni = Console.ReadLine()!;
                Console.Write("Nombre: "); string nombre = Console.ReadLine()!;
                Console.Write("Teléfono: "); string telefono = Console.ReadLine()!;
                Console.Write("Email: "); string email = Console.ReadLine()!;
                Console.Write("Fecha Nac (yyyy-mm-dd): "); DateTime fnac = DateTime.Parse(Console.ReadLine()!);
                clienteRepo.Agregar(new Cliente(dni, nombre, telefono, email, fnac));
                Console.WriteLine("Cliente agregado.");
                break;

            case "2":
                foreach (var c in clienteRepo.Listar())
                    Console.WriteLine(c);
                break;

            case "3":
                Console.Write("DNI del titular: "); dni = Console.ReadLine()!;
                var titular = clienteRepo.BuscarPorDni(dni);
                if (titular == null) { Console.WriteLine("Cliente no encontrado."); break; }
                Console.Write("Código de cuenta: "); string codigo = Console.ReadLine()!;
                Console.Write("Tipo (caja/cc): "); string tipo = Console.ReadLine()!;
                if (tipo == "caja")
                {
                    Console.Write("Límite de extracción: "); decimal limite = decimal.Parse(Console.ReadLine()!);
                    cuentaRepo.Agregar(new CajaAhorro(codigo, titular, limite));
                }
                else
                {
                    Console.Write("Descubierto máximo: "); decimal desc = decimal.Parse(Console.ReadLine()!);
                    cuentaRepo.Agregar(new CuentaCorriente(codigo, titular, desc));
                }
                Console.WriteLine("Cuenta agregada.");
                break;

            case "4":
                Console.Write("Código de cuenta: "); codigo = Console.ReadLine()!;
                var cuenta = cuentaRepo.Listar().FirstOrDefault(c => c.Codigo == codigo);
                if (cuenta == null) { Console.WriteLine("Cuenta no encontrada."); break; }
                Console.Write("Importe: "); decimal dep = decimal.Parse(Console.ReadLine()!);
                cuenta.Depositar(dep);
                Console.WriteLine("Depósito realizado.");
                break;

            case "5":
                Console.Write("Código de cuenta: "); codigo = Console.ReadLine()!;
                cuenta = cuentaRepo.Listar().FirstOrDefault(c => c.Codigo == codigo);
                if (cuenta == null) { Console.WriteLine("Cuenta no encontrada."); break; }
                Console.Write("Importe: "); decimal ext = decimal.Parse(Console.ReadLine()!);
                cuenta.Extraer(ext);
                Console.WriteLine("Extracción realizada.");
                break;

            case "6":
                foreach (var cu in cuentaRepo.Listar())
                    Console.WriteLine(cu);
                break;

            case "0":
                salir = true;
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
    }
}
