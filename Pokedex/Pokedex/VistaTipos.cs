using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class VistaTipo : Form
    {
        private PokemonDAO pokemonDAO;

        public VistaTipo()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-UBBP1OB\\NICO;Initial Catalog=PokeWiki;Integrated Security=True";
            pokemonDAO = new PokemonDAO(connectionString);
            MostrarTipos();
        }

        private void MostrarTipos()
        {
            List<string> nombresTipos = pokemonDAO.ObtenerNombresTipos();

            foreach (string nombreTipo in nombresTipos)
            {
                TypePanel typePanel = new TypePanel();
                typePanel.TypeName = nombreTipo;
                typePanel.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(typePanel);
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
