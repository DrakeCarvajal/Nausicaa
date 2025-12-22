namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaF_Click(object sender, EventArgs e)
        {
            txtCentrigrados.Enabled = true;
            txtFahrenheit.Enabled = false;
        }

        private void btbFaC_Click(object sender, EventArgs e)
        {
            txtCentrigrados.Enabled = false;
            txtFahrenheit.Enabled = true;
        }

        private void btn1Cen_Click(object sender, EventArgs e)
        {
            if (txtCentrigrados.Enabled == true)
            {
                if (txtCentrigrados.Text.Length > 0)
                {
                    txtCentrigrados.Text = "" + (Convert.ToDouble(txtCentrigrados.Text) + 1);
                }
                else
                {
                    txtCentrigrados.Text = "" + 1.0;
                }
            }
        }

        private void btn1Fahren_Click(object sender, EventArgs e)
        {
            if (txtFahrenheit.Enabled == true)
            {
                if (txtFahrenheit.Text.Length > 0)
                {
                    txtFahrenheit.Text = "" + (Convert.ToDouble(txtFahrenheit.Text) + 1);
                }
                else
                {
                    txtFahrenheit.Text = "" + 1.0;
                }
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtCentrigrados.Enabled == true)
            {
                double fahrenheit = (Convert.ToDouble(txtCentrigrados.Text) * 1.8) + 32;
                txtFahrenheit.Text = fahrenheit.ToString();
            }
            else 
            {
                double centigrados = (Convert.ToDouble(txtFahrenheit.Text) - 32) / 1.8;
                txtCentrigrados.Text = centigrados.ToString();
            }
        }
    }
}
