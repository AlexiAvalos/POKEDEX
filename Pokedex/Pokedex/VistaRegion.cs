using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class VistaRegion : Form
    {
        private PokemonDAO pokemonDAO;

        public VistaRegion()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-UBBP1OB\\NICO;Initial Catalog=PokeWiki;Integrated Security=True";
            pokemonDAO = new PokemonDAO(connectionString);
            MostrarRegiones();
        }

        private void MostrarRegiones()
        {
            List<string> nombresRegiones = pokemonDAO.ObtenerNombresRegiones();

            foreach (string nombreRegion in nombresRegiones)
            {
                PokemonPanelNames regionPanel = new PokemonPanelNames();
                regionPanel.NombrePokemon = nombreRegion;
                regionPanel.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(regionPanel);
            }
        }

        //no moverle que se rompe
        private void rjButton8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

