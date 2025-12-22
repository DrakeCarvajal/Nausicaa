namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double calificacion1 = 44;
            double calificacion2 = 51;

            lblPromedio.Text = "Promedio: " + (calificacion1 + calificacion2 / 2);
        }
    }
}
