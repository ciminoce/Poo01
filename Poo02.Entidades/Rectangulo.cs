using System.Text;

namespace Poo02.Entidades
{
    public class Rectangulo
    {
        private int ladoMayor;
        private int ladoMenor;

        public int LadoMenor
        {
            get { return ladoMenor; }
            set {
                if(value <= 0 || value>=LadoMayor )
                {
                    throw new ArgumentException("Lado menor mal ingresado");
                }
                ladoMenor = value;
            }
        }

        public int LadoMayor
        {
            get { return ladoMayor; }
            set {
                if (value <= 0|| value<=LadoMenor)
                {
                    throw new ArgumentException("Lado mayor mal ingresado");
                }

                ladoMayor = value;
            }
        }


        public Rectangulo(int ladoMayor, int ladoMenor)
        {
            LadoMayor = ladoMayor;
            LadoMenor = ladoMenor;
        }
        public int GetPerimetro()
        {
            return 2*LadoMayor+2*LadoMenor;
        }
        public int GetSuperficie()
        {
            return LadoMayor*LadoMenor;
        }
        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Rectángulo");
            sb.AppendLine($"Lado mayor:{LadoMayor}");
            sb.AppendLine($"Lado menor: {LadoMenor}");
            sb.AppendLine($"Perímetro: {GetPerimetro()}");
            sb.AppendLine($"Superficie: {GetSuperficie()}");
            return sb.ToString();
        }
    }
}
