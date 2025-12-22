namespace Ejercicio6
{
    public partial class Ejercicio6 : Form
    {
        private String codigoCorrecto = "331121";

        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += btn1.Text;

            if (txtCodigo.Text.Length == 6)
            {
                if (txtCodigo.Text == codigoCorrecto)
                {
                    lbl1.ForeColor = Color.Black;
                    lbl1.Text = "Ingrese el código:";
                    MessageBox.Show("Has accedido correctamente.");
                }
                else
                {
                    lbl1.ForeColor = Color.Red;
                    lbl1.Text = "Ingrese el código de nuevo";
                    txtCodigo.Text = "";
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += btn2.Text;

            if (txtCodigo.Text.Length == 6)
            {
                if (txtCodigo.Text == codigoCorrecto)
                {
                    lbl1.ForeColor = Color.Black;
                    lbl1.Text = "Ingrese el código:";
                    MessageBox.Show("Has accedido correctamente.");
                }
                else
                {
                    lbl1.ForeColor = Color.Red;
                    lbl1.Text = "Ingrese el código de nuevo";
                    txtCodigo.Text = "";
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCodigo.Text += btn3.Text;

            if (txtCodigo.Text.Length == 6)
            {
                if (txtCodigo.Text == codigoCorrecto)
                {
                    lbl1.ForeColor = Color.Black;
                    lbl1.Text = "Ingrese el código:";
                    MessageBox.Show("Has accedido correctamente.");
                }
                else
                {
                    lbl1.ForeColor = Color.Red;
                    lbl1.Text = "Ingrese el código de nuevo";
                    txtCodigo.Text = "";
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
        }
    }
}
