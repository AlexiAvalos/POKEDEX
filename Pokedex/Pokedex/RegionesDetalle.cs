using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class RegionesDetalle : Form
    {
        private Regiones region;

        public RegionesDetalle(Regiones region)
        {
            InitializeComponent();
            //Background Invisible No Tocar
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagen.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(region.Nombre);
            pictureBoxImagen.Size = new Size(298, 254);

            this.region = region;
            MostrarDescripcion();
        }

        private void MostrarDescripcion()
        {
            lblNombre.Text = region.Nombre;
            lblDescripcion.Text = region.Descripcion;
        }

        private void B_btn_Click(object sender, EventArgs e)
        {
            VistaRegion menuRgn = new VistaRegion();
            menuRgn.Show();
            this.Close();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
