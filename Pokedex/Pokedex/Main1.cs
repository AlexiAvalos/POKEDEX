using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pokedex
{
    public partial class Main1 : Form
    {

        public Main1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.TransparencyKey = Color.Magenta;

          
            this.BackColor = Color.Magenta;

        }



        //no moverle que se rompe
        private void rjButton8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            VistaPokemon vistaPokemon = new VistaPokemon();
            vistaPokemon.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            VistaRegion vistaRegion = new VistaRegion();
            vistaRegion.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            VistaObjetos vistaObjetos = new VistaObjetos();
            vistaObjetos.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            VistaTipos vistaTipo = new VistaTipos();
            vistaTipo.Show();
            this.Hide();
        }

        private void Main1_Load(object sender, EventArgs e)
        {

        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

