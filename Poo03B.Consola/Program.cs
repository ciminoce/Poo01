using Poo03B.Entidades;
using System.ComponentModel.DataAnnotations;
using UtilidadesConsola;

namespace Poo03B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Cars!");

            Auto auto;

            do
            {
                var marcaAuto = ConsoleHelper.SeleccionarEnum<MarcaAuto>("Seleccione una marca");
                var modelo = ConsoleHelper.PedirTexto("Ingrese el modelo");
                var colorAuto = ConsoleHelper.SeleccionarEnum<ColorAuto>("Seleccione un color");
                var anioFabricacion = ConsoleHelper.PedirEntero("Ingrese año de fabricación", 1900, DateTime.Now.Year);
                var patente = ConsoleHelper.PedirPatente("Ingrese la patente");

                var datos = new List<string>
                {
                    $"Marca: {marcaAuto}",
                    $"Modelo: {modelo}",
                    $"Color: {colorAuto}",
                    $"Año de Fabricación: {anioFabricacion}",
                    $"Patente: {patente}"
                };
                MostrarHelper.MostrarLista("Datos del Auto",datos);
                if (ConsoleHelper.ConfirmarDatos())
                {
                    auto = new Auto
                    {
                        Marca = marcaAuto,
                        Modelo = modelo,
                        Color = colorAuto,
                        AnioFabricacion = anioFabricacion,
                        Patente = patente
                    };
                    break;
                }

                Console.WriteLine("Vamos a volver a cargar los datos...\n");

            } while (true);

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
                // Continuar con la lógica
            }
        }
    }
}
