namespace Ejercicio07
{
    public partial class Ejercicio7 : Form
    {
        private Random random = new Random();

        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            int jugadaIA = random.Next(1, 4);

            lblGanaste.ForeColor = Color.Black;
            lblPerdiste.ForeColor = Color.Black;
            lblEmpate.ForeColor = Color.Black;

            switch (jugadaIA)
            {
                case 1:
                    lblEmpate.ForeColor = Color.Blue;
                    lblUsaste.Text = "Tu usaste: Piedra";
                    lblUso.Text = "Él usó: Piedra";
                    break;
                case 2:
                    lblPerdiste.ForeColor = Color.Red;
                    lblUsaste.Text = "Tu usaste: Piedra";
                    lblUso.Text = "Él usó: Papel";
                    break;
                case 3:
                    lblGanaste.ForeColor = Color.Green;
                    lblUsaste.Text = "Tu usaste: Piedra";
                    lblUso.Text = "Él usó: Tijeras";
                    break;
            }
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            int jugadaIA = random.Next(1, 4);

            lblGanaste.ForeColor = Color.Black;
            lblPerdiste.ForeColor = Color.Black;
            lblEmpate.ForeColor = Color.Black;

            switch (jugadaIA)
            {
                case 1:
                    lblGanaste.ForeColor = Color.Green;
                    lblUsaste.Text = "Tu usaste: Papel";
                    lblUso.Text = "Él usó: Piedra";
                    break;
                case 2:
                    lblEmpate.ForeColor = Color.Blue;
                    lblUsaste.Text = "Tu usaste: Papel";
                    lblUso.Text = "Él usó: Papel";
                    break;
                case 3:
                    lblPerdiste.ForeColor = Color.Red;
                    lblUsaste.Text = "Tu usaste: Papel";
                    lblUso.Text = "Él usó: Tijeras";
                    break;
            }
        }

        private void btnTijeras_Click(object sender, EventArgs e)
        {
            int jugadaIA = random.Next(1, 4);

            lblGanaste.ForeColor = Color.Black;
            lblPerdiste.ForeColor = Color.Black;
            lblEmpate.ForeColor = Color.Black;

            switch (jugadaIA)
            {
                case 1:
                    lblPerdiste.ForeColor = Color.Red;
                    lblUsaste.Text = "Tu usaste: Tijeras";
                    lblUso.Text = "Él usó: Piedra";
                    break;
                case 2:
                    lblGanaste.ForeColor = Color.Green;
                    lblUsaste.Text = "Tu usaste: Tijeras";
                    lblUso.Text = "Él usó: Papel";
                    break;
                case 3:
                    lblEmpate.ForeColor = Color.Blue;
                    lblUsaste.Text = "Tu usaste: Tijeras";
                    lblUso.Text = "Él usó: Tijeras";
                    break;
            }
        }
    }
}
