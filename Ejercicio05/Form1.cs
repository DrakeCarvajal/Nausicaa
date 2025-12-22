namespace Ejercicio05
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            Random baraja = new Random();
            String carta = "";

            int palo = baraja.Next(1, 5);

            switch (palo) 
            { 
                case 1:
                    carta = "Corazones";
                    break;
                case 2:
                    carta = "Diamantes";
                    break;
                case 3:
                    carta = "Tréboles";
                    break;
                case 4:
                    carta = "Picas";
                    break;
            }

            int tipoCarta = baraja.Next(1, 14);

            switch (tipoCarta)
            {
                case 1:
                    lblCarta.Text = "Tu carta es: As de " + carta;
                    break;
                case 2:
                    lblCarta.Text = "Tu carta es: 2 de " + carta;
                    break;
                case 3:
                    lblCarta.Text = "Tu carta es: 3 de " + carta;
                    break;
                case 4:
                    lblCarta.Text = "Tu carta es: 4 de " + carta;
                    break;
                case 5:
                    lblCarta.Text = "Tu carta es: 5 de " + carta;
                    break;
                case 6:
                    lblCarta.Text = "Tu carta es: 6 de " + carta;
                    break;
                case 7:
                    lblCarta.Text = "Tu carta es: 7 de " + carta;
                    break;
                case 8:
                    lblCarta.Text = "Tu carta es: 8 de " + carta;
                    break;
                case 9:
                    lblCarta.Text = "Tu carta es: 9 de " + carta;
                    break;
                case 10:
                    lblCarta.Text = "Tu carta es: 10 de " + carta;
                    break;
                case 11:
                    lblCarta.Text = "Tu carta es: Jota de " + carta;
                    break;
                case 12:
                    lblCarta.Text = "Tu carta es: Reina de " + carta;
                    break;
                case 13:
                    lblCarta.Text = "Tu carta es: Rey de " + carta;
                    break;
            }

        }
    }
}
