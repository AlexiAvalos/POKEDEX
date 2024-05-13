using System.Drawing;
using System.Windows.Forms;

namespace Pokedex
{
    public class ObjetoEvolutivoPanel : Panel
    {
        private string _nombreObjetoEvolutivo;

        public string NombreObjetoEvolutivo
        {
            get { return _nombreObjetoEvolutivo; }
            set
            {
                _nombreObjetoEvolutivo = value;
                Invalidate(); // Invalidar el control para redibujar
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujar el nombre del objeto evolutivo en el panel
            using (var brush = new SolidBrush(Color.Black))
            {
                var x = 5;
                var y = (Height - (int)e.Graphics.MeasureString(_nombreObjetoEvolutivo, Font).Height) / 2; // Centrar verticalmente
                e.Graphics.DrawString(_nombreObjetoEvolutivo, Font, brush, new Point(x, y));
            }
        }

        public ObjetoEvolutivoPanel()
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



