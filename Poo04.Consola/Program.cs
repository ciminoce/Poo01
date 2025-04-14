using Poo04.Entidades;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using UtilidadesConsola;

namespace Poo04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Bank Accounts!");
            var listaFormatos = new List<string>()
            {
                 new string(@"^\d{3} \d{7} \d \d{13}$")
            };
            var cuenta =ExtensionesConsola.PedirTextoConFormato("Ingrese el nro. de cuenta [000 0000000 0 0000000000000]:",
                listaFormatos,
                "Nro. de Cuenta no válido");

            var cliente =ExtensionesConsola.PedirTextoConFormato("Ingrese el cliente:", 
                new List<string> { @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$" },
                 
                "Nombre del cliente no válido");
            var saldo =ExtensionesConsola.PedirEntero("Ingrese el saldo de la cuenta:", 0);
            CuentaBancaria cb=new CuentaBancaria(cuenta!, cliente!,saldo);
            
            Console.WriteLine(cb);
        }
    }
}
