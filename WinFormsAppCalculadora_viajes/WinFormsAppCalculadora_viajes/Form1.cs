namespace WinFormsAppCalculadora_viajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int origen = int.Parse(textBoxORIGEN.Text.ToString());
            int destino = int.Parse(textBoxDESTINO.Text.ToString());
            int velocidad = int.Parse(textBoxVelocidad.Text.ToString());
            int distancia = (destino)- (origen);
            int tiempo = velocidad * distancia;

            MessageBox.Show($"Tiempo estimado de viaje de {origen} a {destino} es: {tiempo} horas.");
        }
    }
}
