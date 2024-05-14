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
        private void MostrarDetallesPokemon(string nombrePokemon)
        {
            // Aquí debes abrir el formulario PokemonDetalle y pasarle el nombre del Pokémon seleccionado
            PokemonDetalle pokemonDetalleForm = new PokemonDetalle(nombrePokemon);
            pokemonDetalleForm.Show();
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
                    MostrarDetallesPokemon(nombrePokemon);
                };
            }
        }


        private void PokemonPanelNames_PokemonSeleccionado(object sender, EventArgs e)
        {
            // Obtener el nombre del Pokémon seleccionado
            PokemonPanelNames panel = (PokemonPanelNames)sender;
            string nombrePokemon = panel.NombrePokemon;

            // Mostrar los detalles del Pokémon seleccionado
            MostrarDetallesPokemon(nombrePokemon);
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