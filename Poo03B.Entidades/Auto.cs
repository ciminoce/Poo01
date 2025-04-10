
namespace Poo03B.Entidades
{
    public class Auto
    {
        public Auto()
        {
            
        }
        public Auto(AutoMarca marca, string modelo, AutoColor color)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;

        }
        public Auto(AutoMarca marca, string modelo, AutoColor color, int anioFabricacion, string patente):this(marca,modelo,color)
        {
            AnioFabricacion = anioFabricacion;
            Patente = patente;
        }

        public AutoMarca Marca { get; set; }
        public string Modelo { get; set; }=null!;
        public AutoColor Color { get; set; }
        public int AnioFabricacion { get; set; }
        public string Patente { get; set; } = null!;
        public override string ToString()
        {
            return $"{Marca} {Modelo}";
        }

    }
}
