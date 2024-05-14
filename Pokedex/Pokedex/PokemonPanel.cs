using System.Drawing;
using System.Windows.Forms;

namespace Pokedex
{
    public class PokemonPanel : Panel
    {
        public PokemonPanel()
        {
            // Establecer el tamaño del panel para que coincida con el tamaño de la imagen
            this.Size = Properties.Resources.panel.Size;

            // Establecer el fondo del panel como la imagen del borde Pokémon
            this.BackgroundImage = Properties.Resources.panel; // Asegúrate de que 'panel' sea el nombre correcto de tu imagen en los recursos

            // Ajustar la imagen al tamaño del panel
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Establecer la fuente del panel
            this.Font = new Font("Segoe UI Emoji", 10, FontStyle.Regular);
        }
    }
}