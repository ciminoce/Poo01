using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Poo03B.Entidades
{
    public class Auto : IValidatableObject
    {
        public Auto()
        {
            Marca = MarcaAuto.Ninguna;//valor por defecto
            Color = ColorAuto.Ninguno;//valor por defecto


        }
        public Auto(MarcaAuto marca, string modelo, ColorAuto color, int anioFabricacion, string patente)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
            AnioFabricacion = anioFabricacion;
            Patente = patente;
        }

        public MarcaAuto Marca { get; set; }
        public string Modelo { get; set; } = null!;
        public ColorAuto Color { get; set; }
        public int AnioFabricacion { get; set; }
        public string Patente { get; set; } = null!;

        public int Antiguedad()
        {
            return DateTime.Today.Year - AnioFabricacion;
        }


        private bool ValidarPatente(string patente)
        {
            string formato1 = @"^[A-Z]{3} \d{3}$";
            string formato2 = @"^[A-Z]{2} \d{3} [A-Z]{2}$";
            return Regex.IsMatch(patente, formato1) || Regex.IsMatch(patente, formato2);
        }
        public bool EsFrabricacionPosterior2016()
        {
            return AnioFabricacion < 2016;
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Marca == MarcaAuto.Ninguna)
            {
                yield return new ValidationResult("El marca es requerido", new[] { nameof(Marca) });
            }
            if (string.IsNullOrEmpty(Modelo))
            {
                yield return new ValidationResult("El modelo es requerido.", new[] { nameof(Modelo) });
            }
            if (Color == ColorAuto.Ninguno)
            {
                yield return new ValidationResult("El color es requerido", new[] { nameof(Color) });
            }
            if (AnioFabricacion < 1900 || AnioFabricacion > DateTime.Now.Year)
            {
                yield return new ValidationResult($"El año de fabricación debe estar entre 1900 y {DateTime.Now.Year}.", new[] { nameof(AnioFabricacion) });
            }
            if (string.IsNullOrEmpty(Patente))
            {
                yield return new ValidationResult("La patente es requerida", new[] { nameof(Patente) });
            }
            else if (!ValidarPatente(Patente))
            {
                yield return new ValidationResult("Patente mal ingresada.", new[] { nameof(Patente) });
            }

        }
    }
}
