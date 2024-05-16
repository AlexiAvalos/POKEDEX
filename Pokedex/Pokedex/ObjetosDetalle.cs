using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class ObjetosDetalle : Form
    {
        private ObjetoEvolutivo objeto;

        public ObjetosDetalle(ObjetoEvolutivo objeto)
        {
            InitializeComponent();
            //Background Invisible No Tocar
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;

            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxImagen.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(objeto.Nombre);
            pictureBoxImagen.Size = new Size(298, 254);

            this.objeto = objeto;
            MostrarDescripcion();
        }

        private void MostrarDescripcion()
        {
            lblNombre.Text = objeto.Nombre;
            lblDescripcion.Text = objeto.Descripcion;
        }

        private void B_btn_Click(object sender, EventArgs e)
        {
            VistaObjetos menuObj = new VistaObjetos();
            menuObj.Show();
            this.Close();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
