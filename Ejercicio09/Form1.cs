namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblEnteros.Text = "";
            lblCubos.Text = "";

            for (int i = 1; i <= 10; i++) 
            { 
                lblEnteros.Text += i.ToString() + "\n";
                lblCubos.Text += (i * i * i).ToString() + "\n";
            }
        }
    }
}
