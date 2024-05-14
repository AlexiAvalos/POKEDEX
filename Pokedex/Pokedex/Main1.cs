using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }
<<<<<<< HEAD


        //no moverle que se rompe
        private void rjButton8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            VistaPokemon vistaPokemon = new VistaPokemon();
            vistaPokemon.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            VistaRegion vistaRegion = new VistaRegion();
            vistaRegion.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            VistaObjetos vistaObjetos = new VistaObjetos();
            vistaObjetos.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            VistaTipo vistaTipo = new VistaTipo();
            vistaTipo.Show();
            this.Hide();
        }
=======
>>>>>>> 2441536261f33169aaf0b473e683c6e3efe90d8e
    }
}
