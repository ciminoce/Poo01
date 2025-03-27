// See https://aka.ms/new-console-template for more information
using Poo02.Entidades;
using System.Drawing;

try
{
	Console.WriteLine("Hello,Rectángulos");
	Rectangulo r = new Rectangulo(10, 5);
	//r.LadoMayor = 5;
	r.MostrarDatos();
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
