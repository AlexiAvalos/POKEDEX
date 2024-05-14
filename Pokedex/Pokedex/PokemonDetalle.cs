using System;
using System.Windows.Forms;


namespace Pokedex
{
    public partial class PokemonDetalle : Form
    {
        private PokemonClass PokemonDAO;

       private string nombrePokemon; // Atributo para almacenar el nombre del Pokémon

    public PokemonDetalle(string nombrePokemon)
    {
        InitializeComponent();
        this.nombrePokemon = nombrePokemon; // Almacena el nombre del Pokémon en el atributo de la clase
        MostrarDescripcion(); // Muestra la descripción por defecto al abrir la vista
    }
        public void MostrarPokemonDetalle(string nombrePokemon)
        {
            // Lógica para mostrar los detalles del Pokémon seleccionado
            MessageBox.Show($"Mostrando detalles de {nombrePokemon}");
        }


        private void MostrarDescripcion()
        {
            OcultarTodosLosPaneles();
            panelDescripcion.Visible = true;
            lblDescripcion.Text = PokemonDAO.Descripcion;
        }

        private void MostrarAtributos()
        {
            OcultarTodosLosPaneles();
            panelAtributos.Visible = true;
            lblSalud.Text = $"Salud: {PokemonDAO.Salud}";
            lblAltura.Text = $"Altura: {PokemonDAO.Altura}";
            lblAtaque.Text = $"Ataque: {PokemonDAO.Ataque}";
            lblDefensa.Text = $"Defensa: {PokemonDAO.Defensa}";
        }

        private void MostrarTipoYCategoria()
        {
            OcultarTodosLosPaneles();
            panelTipoCategoria.Visible = true;
            lblTipo.Text = $"Tipo: {PokemonDAO.Tipo}";
            lblCategoria.Text = $"Categoría: {PokemonDAO.NombreCategoria}";

        }

        private void MostrarGeneracion()
        {
            OcultarTodosLosPaneles();
            panelGeneracion.Visible = true;
            lblGeneracion.Text = $"Generación: {PokemonDAO.Generacion}";
            lblHabitat.Text = $"Generación: {PokemonDAO.Habitat}";
        }

        

        private void OcultarTodosLosPaneles()
        {
            panelDescripcion.Visible = false;
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
