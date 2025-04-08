namespace UtilidadesConsola;

public static class MostrarHelper
{
    /// <summary>
    /// Muestra una lista de datos con un título.
    /// </summary>
    public static void MostrarLista(string titulo, List<string> datos)
    {
        MostrarTitulo(titulo);
        foreach (var linea in datos)
        {
            Console.WriteLine(linea);
        }
        Console.WriteLine(new string('-', 30));
    }

    /// <summary>
    /// Muestra un título con formato.
    /// </summary>
    public static void MostrarTitulo(string titulo)
    {
        Console.WriteLine($"\n--- {titulo.ToUpper()} ---");
    }

    /// <summary>
    /// Muestra un enumerador con índices numéricos.
    /// </summary>
    public static void MostrarEnum<T>() where T : Enum
    {
        Console.WriteLine($"\nListado de {typeof(T).Name}:");
        foreach (var item in Enum.GetValues(typeof(T)))
        {
            Console.WriteLine($"{(int)item} - {item}");
        }
    }

    /// <summary>
    /// Muestra una línea separadora opcional.
    /// </summary>
    public static void MostrarLineaSeparadora(char caracter = '-', int largo = 30)
    {
        Console.WriteLine(new string(caracter, largo));
    }
}


