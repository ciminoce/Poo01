using System.Text.RegularExpressions;

namespace Poo03.Entidades
{
    public class Auto
    {
        public Auto(string marca, string modelo, string color, int anioFabricacion, string patente)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            AnioFabricacion = anioFabricacion;
            Patente = patente;
            if (!Validar())
            {
                throw new ArgumentException("Algún dato hay mal ingresado");
            }
        }

        public string Marca { get; set; } = null!;
        public string Modelo { get; set; }=null!;
        public string Color { get; set; }= null!;
        public int AnioFabricacion { get; set; }
        public string Patente { get; set; } = null!;

        public int Antiguedad()
        {
            return DateTime.Today.Year - AnioFabricacion;
        }

        public bool Validar()
        {
            return !string.IsNullOrEmpty(Marca) &&
                !string.IsNullOrEmpty(Modelo) && 
                !string.IsNullOrEmpty(Color) && 
                AnioFabricacion>=1900 && AnioFabricacion<=DateTime.Today.Year &&
                ValidarPatente(Patente);
        }

        public bool ValidarPatente(string patente)
        {
            string formato1 = @"^[A-Z]{3} \d{3}$";
            string formato2 = @"^[A-Z]{2} \d{3} [A-Z]{2}$";
            return Regex.IsMatch(patente, formato1)|| Regex.IsMatch(patente,formato2);
        }
        public bool EsPosterior2016(string patente)
        {
            return patente.Length == 9;
        }
    }
}
