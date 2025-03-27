using Poo02.Entidades;

namespace Poo02.Windows
{
    public partial class FrmRectangulo : Form
    {
        public FrmRectangulo()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            Rectangulo r = new Rectangulo(int.Parse(TxtLadoMayor.Text),
                int.Parse(TxtLadoMenor.Text));
            r.MostrarDatos();
        }
    }
}
