using System;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class PokemonDetalle : Form
    {
        private Pokemon pokemon;

        public PokemonDetalle(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            MostrarDescripcion(); // Muestra la descripción por defecto al abrir la vista
        }

        private void MostrarDescripcion()
        {
            OcultarTodosLosPaneles();
            panelDescripcion2.Visible = true;
            lblDescripcion.Text = pokemon.Descripcion;
        }

        private void MostrarAtributos()
        {
            OcultarTodosLosPaneles();
            panelAtributos.Visible = true;
            lblSalud.Text = $"Salud: {pokemon.Salud}";
            lblAltura.Text = $"Altura: {pokemon.Altura}";
            lblAtaque.Text = $"Ataque: {pokemon.Ataque}";
            lblDefensa.Text = $"Defensa: {pokemon.Defensa}";
        }

        private void MostrarTipoYCategoria()
        {
            OcultarTodosLosPaneles();
            panelTipoCategoria.Visible = true;
            lblTipo.Text = $"Tipo: {pokemon.Tipo}";
        }

        private void MostrarGeneracion()
        {
            OcultarTodosLosPaneles();
            panelGeneracion.Visible = true;
            lblGeneracion.Text = $"Generación: {pokemon.Generacion}";
            lblHabitat.Text = $"Habitat: {pokemon.Habitat}";
        }

        private void OcultarTodosLosPaneles()
        {
            panelDescripcion2.Visible = false;
            panelAtributos.Visible = false;
            panelTipoCategoria.Visible = false;
            panelGeneracion.Visible = false;
        }

        private void n1_btn_Click(object sender, EventArgs e)
        {
            MostrarDescripcion();
        }

        private void n2_btn_Click(object sender, EventArgs e)
        {
            MostrarAtributos();
        }

        private void n3_btn_Click(object sender, EventArgs e)
        {
            MostrarTipoYCategoria();
        }

        private void n4_btn_Click(object sender, EventArgs e)
        {
            MostrarGeneracion();
        }
    }
}
