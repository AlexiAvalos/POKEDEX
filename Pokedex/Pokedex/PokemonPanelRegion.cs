using System.Drawing;
using System.Windows.Forms;

namespace Pokedex
{
    public class PokemonPanelRegion : Panel
    {
        private string _nombreRegion;

        public string NombreRegion
        {
            get { return _nombreRegion; }
            set
            {
                _nombreRegion = value;
                Invalidate(); // Invalidar el control para redibujar
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujar el nombre de la región en el panel
            using (var brush = new SolidBrush(Color.Black))
            {
                // Ajustar la posición de dibujado a la izquierda
                var x = 5;
                var y = (Height - (int)e.Graphics.MeasureString(_nombreRegion, Font).Height) / 2; // Centrar verticalmente
                e.Graphics.DrawString(_nombreRegion, Font, brush, new Point(x, y));
            }
        }

        public PokemonPanelRegion()
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
        }
    }
}

