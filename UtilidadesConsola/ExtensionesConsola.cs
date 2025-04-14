using System.Text.RegularExpressions;

namespace UtilidadesConsola
{
    public static class ExtensionesConsola
    {
        /// <summary>
        /// Método estático para devolver un string
        /// </summary>
        /// <param name="mensajePantalla">Mensaje para solicitar el ingreso</param>
        /// <param name="esRequerido">Parametro opcional para establecer si el requerido o no</param>
        /// <returns>El texto pertinente</returns>
        public static string PedirString(string mensajePantalla, bool esRequerido = true)
        {
            string? texto;
            do
            {
                Console.Write(mensajePantalla);
                texto = Console.ReadLine();
                if (!string.IsNullOrEmpty(texto) && esRequerido)
                {
                    return texto;
                }
                Console.WriteLine("El dato es requerido...Reintentar");
                Console.ReadLine();
            } while (true);

        }
        /// <summary>
        /// Método estático para pedir un entero entre dos extremos
        /// </summary>
        /// <param name="mensaje">Mensaje en Pantalla</param>
        /// <param name="min">Valor mínimo del entero</param>
        /// <param name="max">Valor máximo del entero</param>
        /// <returns>El entero resultante</returns>
        public static int PedirEntero(string mensaje, int min=int.MinValue,
            int max=int.MaxValue)
        {
            string? textoEntero;
            do
            {
                textoEntero = PedirString(mensaje);
                if (int.TryParse(textoEntero, out int entero)
                    && entero >= min && entero <= max)
                {
                    return entero;
                }
                Console.WriteLine("Año no válido o fuera del rango permitido...Reintentar");
                Console.ReadLine();
            } while (true);

        }
        /// <summary>
        /// Método para pedir el ingreso del nro de cuenta
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static string PedirTextoConFormato(string mensaje,
            List<string> formatos, string error)
        {
            string? texto;
            do
            {
                texto = PedirString(mensaje);

                foreach (var formato in formatos)
                {
                    if (Regex.IsMatch(texto, formato))
                    {
                        return texto.Trim();
                    }
                }
                Console.WriteLine(error);
                Console.ReadLine();
            } while (true);

        }

        /// <summary>
        /// Método para solicitar la patente entre 2 formatos
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static string PedirPatente(string mensaje)
        {
            string? patente;
            do
            {
                patente = PedirString(mensaje);
                string formato1 = @"^[A-Z]{3} \d{3}$";
                string formato2 = @"^[A-Z]{2} \d{3} [A-Z]{2}$";
                if (Regex.IsMatch(patente!, formato1) || Regex.IsMatch(patente!, formato2))
                {
                    return patente;
                }
                Console.WriteLine("Formato de patente no válido... Reintentar");
                Console.ReadLine();
            } while (true);

        }
        /// <summary>
        /// Método estático para retornar un bool para confirmar ingreso de datos
        /// </summary>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public static bool ConfirmarDatos(string mensaje)
        {
            string respuesta;
            do
            {
                respuesta = PedirString(mensaje);
                if (respuesta.Trim().ToLower() == "s")
                {
                    return true;
                }
                else if (respuesta.Trim().ToLower() == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Opción ingresada no válida!!!");
                }
            } while (true);

        }
        public static T SeleccionarEnum<T>(string mensajeLista, string mensajePantalla)
        {
            do
            {
                Console.WriteLine(mensajeLista);
                foreach (var item in Enum.GetValues(typeof(T)))
                {
                    Console.WriteLine($"{(int)item} - {item}");
                }
                Console.Write(mensajePantalla);
                var input = Console.ReadLine();
                if (int.TryParse(input, out int valorEnum) && Enum.IsDefined(typeof(T), valorEnum))
                {
                    return (T)Enum.ToObject(typeof(T), valorEnum);
                }

                Console.WriteLine("Valor fuera del rango... Reintentar");
                Console.ReadLine();
            } while (true);

        }

    }
}
