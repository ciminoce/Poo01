namespace Ejercicio01.Entidades
{
    public class Calculadora
    {
        public Calculadora(int numero1, int numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public int Sumar()
        {
            return Numero1 + Numero2;
        }
        public int Restar()
        {
            return Numero1 - Numero2;
        }
        public int Multiplicar()
        {
            return Numero1 * Numero2;
        }
        public double Dividir()
        {
            if (Numero2!=0)
            {
                return (double) Numero1 / Numero2;

            }
            throw new ArgumentException("No se puede dividir por cero",nameof(Numero2));
        }
    }
}
