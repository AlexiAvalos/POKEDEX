using System.Drawing;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class PokemonPanel : Panel
{
    public PokemonPanel()
    {
        // Establecer el tamaño del panel
        this.Size = new Size(300, 200);

        // Establecer el fondo del panel como la imagen del borde Pokémon
        this.BackgroundImage = Image.FromFile("Resources/textboxpk(2).png");
        this.BackgroundImageLayout = ImageLayout.Stretch; // Ajustar la imagen al tamaño del panel

        // Establecer la ubicación relativa al formulario
        this.Location = new Point(50, 50);

        // Hacer el fondo del panel transparente
        this.BackColor = Color.Transparent;

        // Agregar el panel al formulario (o a otro contenedor)
        // No es necesario agregarlo al formulario aquí, ya que debería hacerse en el código del formulario principal.
    }
}
