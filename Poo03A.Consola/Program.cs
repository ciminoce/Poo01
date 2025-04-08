using Poo03A.Entidades;
using System.Text.RegularExpressions;

namespace Poo03A.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Cars!");
            int marcaAuto;
            int colorAuto;
            string? modeloAuto;
            string? patente;
            int anioFab;

            do
            {
                do
                {
                    Console.WriteLine("Lista de Marcas Disponibles");
                    foreach (var item in Enum.GetValues(typeof(AutoMarca)))
                    {
                        Console.WriteLine($"{(int)item} - {item}");
                    }
                    Console.Write("Ingrese marca del Auto:");
                    var input = Console.ReadLine();
                    if (!int.TryParse(input, out marcaAuto))
                    {
                        Console.WriteLine("Nro de marca no válido...Reintentar");
                        Console.ReadLine();
                    }
                    else if (!Enum.IsDefined(typeof(AutoMarca), marcaAuto))
                    {
                        Console.WriteLine("Nro de marca fuera del rango...Reintentar");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }

                } while (true);
                do
                {
                    Console.Write("Ingrese el modelo del auto:");
                    modeloAuto = Console.ReadLine();
                    if (string.IsNullOrEmpty(modeloAuto))
                    {
                        Console.WriteLine("El modelo es requerido");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                do
                {
                    Console.WriteLine("Lista de Colores Disponibles");
                    foreach (var item in Enum.GetValues(typeof(AutoColor)))
                    {
                        Console.WriteLine($"{item.GetHashCode()} - {item}");
                    }
                    Console.Write("Ingrese el color del auto:");
                    var input = Console.ReadLine();
                    if (!int.TryParse(input, out colorAuto))
                    {
                        Console.WriteLine("Nro de color no válido... Reintentar");
                        Console.ReadLine();
                    }
                    else if (!Enum.IsDefined(typeof(AutoColor), colorAuto))
                    {
                        Console.WriteLine("Nro. de color fuera del rango... Reintentar");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                do
                {
                    Console.Write("Ingrese el año de fabricación:");
                    string? anio = Console.ReadLine();
                    if (!int.TryParse(anio, out anioFab))
                    {
                        Console.WriteLine("Nro. mal ingresado... Reintentar");
                    }
                    else if (anioFab < 1900 || anioFab > DateTime.Today.Year)
                    {
                        Console.WriteLine("Año fuera del rango permitido...Reintentar");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                } while (true);
                do
                {
                    Console.Write("Ingrese la patente:");
                    patente = Console.ReadLine();
                    string formato1 = @"^[A-Z]{3} \d{3}$";
                    string formato2 = @"^[A-Z]{2} \d{3} [A-Z]{2}$";
                    if (string.IsNullOrEmpty(patente))
                    {
                        Console.WriteLine("La patente es requerida... Reintentar");
                        Console.ReadLine();
                    }
                    else if (!Regex.IsMatch(patente!, formato1) && !Regex.IsMatch(patente!, formato2))
                    {
                        Console.WriteLine("Formato de patente no válido... Reintentar");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                } while (true);
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
                string respuesta;
                do
                {
                    Console.Write("¿Confirma los datos del auto (s/n):");
                    respuesta = Console.ReadLine();
                    var caracteresValidos = "snSN";
                    if (!caracteresValidos.Contains(respuesta!))
                    {
                        Console.WriteLine("Respuesta mal ingresada...");
                        Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }

                } while (true);
                if (respuesta!.ToLower() == "n")
                {
                    Console.WriteLine("Reingresar datos...");
                    Console.ReadLine();
                }
                else
                {
                    break;
                }

            } while (true);
            Auto auto = new Auto
            {
                Marca = (AutoMarca)marcaAuto,
                Modelo = modeloAuto,
                Color = (AutoColor)colorAuto,
                AnioFabricacion = anioFab,
                Patente = patente
            };

        }
    }
}
