using System.Drawing;
using System.Windows.Forms;

namespace Pokedex
{
    public class TypePanel : Panel
    {
        private string _typeName;

        public string TypeName
        {
            get { return _typeName; }
            set
            {
                _typeName = value;
                Invalidate(); // Invalidar el control para redibujar
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Dibujar el nombre del tipo en el panel
            using (var brush = new SolidBrush(Color.Black))
            {
                var x = 5;
                var y = (Height - (int)e.Graphics.MeasureString(_typeName, Font).Height) / 2; // Centrar verticalmente
                e.Graphics.DrawString(_typeName, Font, brush, new Point(x, y));
            }
        }

        public TypePanel()
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
