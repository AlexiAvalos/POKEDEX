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
            string connectionString = "Data Source=DESKTOP-UBBP1OB\\NICO;Initial Catalog=PokeWiki;Integrated Security=True";
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

                // Suscribirse al evento de clic de cada panel
                pokemonPanel.Click += (sender, e) =>
                {
                    PokemonPanelNames panel = (PokemonPanelNames)sender;
                    string nombre = panel.NombrePokemon;

                    // Obtener el objeto Pokemon correspondiente al nombre
                    Pokemon pokemon = pokemonDAO.ObtenerPokemonPorNombre(nombre);

                    // Mostrar los detalles del Pokémon seleccionado
                    PokemonDetalle pokemonDetalleForm = new PokemonDetalle(pokemon);
                    pokemonDetalleForm.Show();
                };
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