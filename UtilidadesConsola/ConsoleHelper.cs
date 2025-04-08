using System.Text.RegularExpressions;

namespace UtilidadesConsola
{
    public static class ConsoleHelper
    {
        public static bool ConfirmarDatos()
        {
            string? respuesta;
            do
            {
                Console.Write("¿Desea confirmar estos datos? (S/N): ");
                respuesta = Console.ReadLine()?.Trim().ToUpper();

                if (respuesta == "S")
                    return true;
                else if (respuesta == "N")
                    return false;
                else
                    Console.WriteLine("Respuesta no válida. Ingrese 'S' para sí o 'N' para no.");
            } while (true);
        }

        public static T SeleccionarEnum<T>(string mensaje) where T : Enum
        {
            while (true)
            {
                Console.WriteLine($"Listado de {typeof(T).Name}s");
                foreach (var item in Enum.GetValues(typeof(T)))
                {
                    Console.WriteLine($"{(int)item} - {item}");
                }

                Console.Write($"{mensaje}: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int valor) && Enum.IsDefined(typeof(T), valor))
                {
                    return (T)(object)valor;
                }

                Console.WriteLine("Selección no válida!!!... Ingrese otra vez");
                Console.ReadLine();
            }
        }

        public static string PedirTexto(string mensaje, bool obligatorio = true)
        {
            while (true)
            {
                Console.Write($"{mensaje}: ");
                string? texto = Console.ReadLine();
                if (!string.IsNullOrEmpty(texto) || !obligatorio)
                {
                    return texto!;
                }

                Console.WriteLine("El valor es requerido... Reingresar!!!");
                Console.ReadLine();
            }
        }

        public static int PedirEntero(string mensaje, int min, int max)
        {
            while (true)
            {
                Console.Write($"{mensaje}: ");
                var input = Console.ReadLine();
                if (int.TryParse(input, out int valor) && valor >= min && valor <= max)
                {
                    return valor;
                }

                Console.WriteLine("Valor no válido!!!... Ingrese otra vez");
                Console.ReadLine();
            }
        }

        public static string PedirPatente(string mensaje)
        {
            string formato1 = @"^[A-Z]{3} \d{3}$";
            string formato2 = @"^[A-Z]{2} \d{3} [A-Z]{2}$";
            while (true)
            {
                Console.Write($"{mensaje}: ");
                var patente = Console.ReadLine();

                if (string.IsNullOrEmpty(patente))
                {
                    Console.WriteLine("La patente es requerida...");
                    Console.ReadLine();
                }
                else if (!Regex.IsMatch(patente, formato1) && !Regex.IsMatch(patente, formato2))
                {
                    Console.WriteLine("Formato no válido de patente!!!");
                    Console.ReadLine();
                }
                else
                {
                    return patente;
                }
            }
        }
    }
}
