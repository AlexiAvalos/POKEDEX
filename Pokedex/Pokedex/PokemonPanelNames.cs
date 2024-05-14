using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pokedex
{
    public class PokemonPanelNames : Panel
    {
        private string _nombrePokemon;

        public string NombrePokemon
        {
            get { return _nombrePokemon; }
            set
            {
                _nombrePokemon = value;
                Invalidate(); // Invalidar el control para redibujar
            }
        }

        public event EventHandler PokemonSeleccionado;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujar el nombre del Pokémon en el panel
            using (var brush = new SolidBrush(Color.Black))
            {
                // Ajustar la posición de dibujado a la izquierda
                var x = 5;
                var y = (Height - (int)e.Graphics.MeasureString(_nombrePokemon, Font).Height) / 2; // Centrar verticalmente
                e.Graphics.DrawString(_nombrePokemon, Font, brush, new Point(x, y));
            }
        }

        public PokemonPanelNames()
        {
            // Establecer el tamaño del panel
            Size = new Size(112, 41);

            // Establecer la imagen de fondo del panel
            BackgroundImage = Properties.Resources.panel; // Asegúrate de que 'panel' sea el nombre correcto de tu imagen en los recursos
            BackgroundImageLayout = ImageLayout.Stretch;

            // Hacer el fondo del panel transparente
            BackColor = Color.Transparent;

            // Establecer el color de fondo del panel
            BackColor = Color.White;

            // Establecer la fuente y el tamaño del texto
            Font = new Font("Segoe UI Emoji", 10, FontStyle.Regular);

            // Manejar el evento de clic en el panel
            Click += PokemonPanelNames_Click;
        }

        private void PokemonPanelNames_Click(object sender, EventArgs e)
        {
            // Al hacer clic en el panel, se dispara el evento PokemonSeleccionado
            PokemonSeleccionado?.Invoke(this, e);
        }
    }
}
