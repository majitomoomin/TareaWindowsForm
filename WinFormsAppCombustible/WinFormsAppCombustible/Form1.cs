using System.Numerics;

namespace WinFormsAppCombustible
{
<<<<<<< HEAD
    //lfff
=======
>>>>>>> 3525fdb4e850eb540513f662393d5e551553562b
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelDisRecorrida_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelGalones_Click(object sender, EventArgs e)
        {

        }

        private void textBoxKMgal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            int Dis = int.Parse(textBoxDIS.Text.ToString());
            int Gal = int.Parse(textBoxKMgal.Text.ToString());
            int Total = Dis / Gal;

            labelResultado.Text = $"Cantidad de kilometros por galón: {Total}";
<<<<<<< HEAD

=======
>>>>>>> 3525fdb4e850eb540513f662393d5e551553562b
        }

        private void labelResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
