using System.Drawing;
using System.Windows.Forms;

namespace Pokedex// Aquí reemplaza 'NombreDelProyecto' con el nombre real de tu proyecto
{
    public class PokemonPanel : Panel
    {
        public PokemonPanel()
        {
            // Establecer el tamaño del panel
            this.Size = new Size(300, 200);

            // Establecer el fondo del panel como la imagen del borde Pokémon
            this.BackgroundImage = Properties.Resources.panel; // Asegúrate de que 'panel' sea el nombre correcto de tu imagen en los recursos

            // Ajustar la imagen al tamaño del panel
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Establecer la ubicación relativa al formulario
            this.Location = new Point(50, 50);

            // Hacer el fondo del panel transparente
            this.BackColor = Color.Transparent;
        }
    }
}
