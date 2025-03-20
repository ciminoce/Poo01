// See https://aka.ms/new-console-template for more information
using Ejercicio01.Entidades;

try
{
	Console.WriteLine("Hello, Calculator!");
	Console.Write("Ingrese el primer número:");
	var numero1 = int.Parse(Console.ReadLine()!);
	Console.Write("Ingrese el segundo número:");
	var numero2 = int.Parse(Console.ReadLine()!);
	Calculadora c = new Calculadora(numero1, numero2);
	Console.WriteLine("0-Salir");
	Console.WriteLine("1-Sumar");
	Console.WriteLine("2-Restar");
	Console.WriteLine("3-Multiplicar");
	Console.WriteLine("4-Dividr");
	Console.Write("Ingrese selección:");
	var opcion = Console.ReadLine();
	switch (opcion)
	{
		case "0":
			return;
		case "1":
			Console.WriteLine(c.Sumar());
			break;
		case "2":
			Console.WriteLine(c.Restar());
			break;
		case "3":
			Console.WriteLine(c.Multiplicar());
			break;
		case "4":
			Console.WriteLine(c.Dividir());
			break;
		default:
			break;
	}

}
catch (Exception ex)
{

    Console.WriteLine(ex.Message); ;
}
