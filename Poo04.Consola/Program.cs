using Poo04.Entidades;

namespace Poo04.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Bank Accounts!");
            Console.Write("Ingrese la cuenta:");
            var cuenta = Console.ReadLine();
            Console.Write("Ingrese el cliente:");
            var cliente= Console.ReadLine();
            CuentaBancaria cb=new CuentaBancaria(cuenta!, cliente!,1000);
            
            Console.WriteLine(cb);
        }
    }
}
