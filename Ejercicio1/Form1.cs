namespace Ejercicio1
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "abc123")
            {
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Contraseña Correcta";
            }
            else
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Contraseña Incorrecta";
            }
        }
    }
}
