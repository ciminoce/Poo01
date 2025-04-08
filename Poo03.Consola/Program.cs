using Poo03.Entidades;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Poo03.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Cars!");
            string? patente;
            MarcaAuto marcaAuto;
            string? modelo;
            ColorAuto colorAuto;
            int anioFabricacion;

            do
            {
                Console.WriteLine("Listado de Marcas");
                foreach (var item in Enum.GetValues(typeof(MarcaAuto)))
                {
                    Console.WriteLine($"{item.GetHashCode()} - {item}");
                }
                int mayorValor = (int)Enum.GetValues(typeof(MarcaAuto)).Cast<int>().Max();
                Console.Write("Seleccione una marca:");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out var valorEntero) || valorEntero < 0 || valorEntero > mayorValor)
                {
                    Console.WriteLine("Selección no válida!!!... Ingrese otra vez");
                    Console.ReadLine();
                }
                else
                {
                    marcaAuto = (MarcaAuto)int.Parse(input);
                    break;
                }
            }
            while (true);
            do
            {
                Console.Write("Ingrese el modelo:");
                modelo = Console.ReadLine();
                if (string.IsNullOrEmpty(modelo))
                {
                    Console.WriteLine("El modelo es requerido...Reingresar!!!");
                    Console.ReadLine();
                }
                else
                {
                    
                    break;
                }
            } while (true);
            do
            {
                Console.WriteLine("Listado de Colores");
                foreach (var item in Enum.GetValues(typeof(ColorAuto)))
                {
                    Console.WriteLine($"{item.GetHashCode()} - {item}");
                }
                int mayorValor = (int)Enum.GetValues(typeof(ColorAuto)).Cast<int>().Max();
                Console.Write("Seleccione un color:");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out var valorEntero) || valorEntero < 0 || valorEntero > mayorValor)
                {
                    Console.WriteLine("Selección no válida!!!... Ingrese otra vez");
                    Console.ReadLine();
                }
                else
                {
                    colorAuto = (ColorAuto)int.Parse(input);
                    break;
                }
            }
            while (true);
            do
            {
                int valorEntero;
                Console.Write("Ingrese año de fabricación:");
                var input = Console.ReadLine();
                if (!int.TryParse(input, out valorEntero) || valorEntero < 1900 || valorEntero > DateTime.Now.Year)
                {
                    Console.WriteLine("Año no válido!!!... Ingrese otra vez");
                    Console.ReadLine();
                }
                else
                {
                    anioFabricacion = valorEntero;
                    break;
                }
            }
            while (true);
            do
            {
                
                Console.Write("Ingrese la patente:");
                string formato1 = @"^[A-Z]{3} \d{3}$";
                string formato2 = @"^[A-Z]{2} \d{3} [A-Z]{2}$";
                patente = Console.ReadLine();
                if (string.IsNullOrEmpty(patente))
                {
                    Console.WriteLine("La patente es requerida...");
                    Console.ReadLine();
                }
                else if (!Regex.IsMatch(patente, formato1)
                        && !Regex.IsMatch(patente, formato2))
                {
                    Console.WriteLine("Formato no válido de patente!!!");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }

            } while (true);
            Auto auto = new Auto();
            auto.Patente = patente;
            auto.Marca = marcaAuto;
            auto.Modelo = modelo;
            auto.Color=colorAuto;
            auto.AnioFabricacion=anioFabricacion;

            var validationContext = new ValidationContext(auto);
            var errores = auto.Validate(validationContext);
            if (errores.Any())
            {
                Console.WriteLine("El objeto Auto no es válido. Errores:");
                foreach (var error in errores)
                {
                    Console.WriteLine($"- {error.ErrorMessage} (Propiedad: {string.Join(", ", error.MemberNames)})");
                }
            }
            else
            {
                Console.WriteLine("El objeto Auto es válido.");
                // Realizar la operación con el objeto Auto
            }

        }
    }
}
