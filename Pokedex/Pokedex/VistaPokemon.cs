using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class VistaPokemon : Form
    {
        private PokemonDAO pokemonDAO;

        public VistaPokemon()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-J97KSH3;Initial Catalog=PokeWiki;Integrated Security=True";
            pokemonDAO = new PokemonDAO(connectionString);
            MostrarPokemones();
        }

        private void MostrarPokemones()
        {
            List<string> nombresPokemon = pokemonDAO.ObtenerNombresPokemon();

            foreach (string nombrePokemon in nombresPokemon)
            {
                PokemonPanelNames pokemonPanel = new PokemonPanelNames();
                pokemonPanel.NombrePokemon = nombrePokemon;
                pokemonPanel.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(pokemonPanel);
            }
        }

        private void MostrarDetallesPokemon(string nombrePokemon)
        {
            // Lógica para mostrar los detalles del Pokémon seleccionado
            MessageBox.Show($"Mostrando detalles de {nombrePokemon}");
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