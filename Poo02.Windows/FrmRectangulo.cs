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
            if (ValidarDatos())
            {
                try
                {
                    var ladoMayor = int.Parse(TxtLadoMayor.Text);
                    var ladoMenor = int.Parse(TxtLadoMenor.Text);
                    Rectangulo r = new Rectangulo(ladoMayor, ladoMenor);
                    MessageBox.Show(r.MostrarDatos(), "Info",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {

                    if(ex.Message.Contains("Lado menor"))
                    {
                        errorProvider1.SetError(TxtLadoMenor,ex.Message);
                    }
                    else
                    {
                        errorProvider1.SetError(TxtLadoMayor, ex.Message);

                    }
                }
            }  
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(TxtLadoMayor.Text, out _)){
                valido = false;
                errorProvider1.SetError(TxtLadoMayor, "Debe ingresar un número");
            }
            if (!int.TryParse(TxtLadoMenor.Text, out _))
            {
                valido = false;
                errorProvider1.SetError(TxtLadoMenor, "Debe ingresar un número");
            }
            return valido;
        }
    }
}
