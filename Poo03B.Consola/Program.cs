using Poo03B.Entidades;
using UtilidadesConsola;

namespace Poo03B.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Cars!");
            AutoMarca marcaAuto;
            AutoColor colorAuto;
            string? modeloAuto;
            string? patente;
            int anioFab;

            do
            {
                marcaAuto = ExtensionesConsola.SeleccionarEnum<AutoMarca>("Lista de Marcas Disponibles",
                    "Ingrese marca del Auto:");
                modeloAuto =ExtensionesConsola.PedirString("Ingrese el modelo del auto:");
                colorAuto = ExtensionesConsola.SeleccionarEnum<AutoColor>("Lista de Colores Disponibles",
                    "Ingrese el color del auto:");
                anioFab = ExtensionesConsola.PedirEntero("Ingrese el año de fabricación:",
                    1900, DateTime.Today.Year);
                //patente = PedirPatente("Ingrese la patente:");
                List<string> listaFormatos = new List<string>();
                string formato1 = @"^[A-Z]{3} \d{3}$";
                string formato2 = @"^[A-Z]{2} \d{3} [A-Z]{2}$";
                listaFormatos.Add(formato1);
                listaFormatos.Add(formato2);
                patente = ExtensionesConsola.PedirTextoConFormato("Ingrese la patente:",
                    listaFormatos, "Patente no válida");
                List<string> datosAuto = new List<string>()
                    {
                        $"Datos del Auto",
                        $"Marca..: {(AutoMarca)marcaAuto}",
                        $"Modelo.: {modeloAuto}",
                        $"Color..: {(AutoColor)colorAuto}",
                        $"Año....: {anioFab}",
                        $"Patente: {patente}"

                    };
                foreach (string dato in datosAuto)
                {
                    Console.WriteLine($"{dato}");
                }
                var respuesta = ExtensionesConsola.ConfirmarDatos("¿Confirma los datos del auto (s/n):");
                if (respuesta)
                {
                    break;
                }
                Console.WriteLine("Reingresar datos... ENTER para continuar");
                Console.ReadLine();
            } while (true);
            Auto auto = new Auto
            {
                Marca = marcaAuto,
                Modelo = modeloAuto,
                Color = colorAuto,
                AnioFabricacion = anioFab,
                Patente = patente
            };

        }
    }
}
