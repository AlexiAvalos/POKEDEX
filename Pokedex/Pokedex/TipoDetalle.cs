﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class TiposDetalle : Form
    {
        private Tipo tipo;

        public TiposDetalle(Tipo tipo)
        {
            InitializeComponent();
            //Background Invisible No Tocar
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBoxImagen.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxImagen.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(tipo.Nombre);
            pictureBoxImagen.Size = new Size(298, 254);

            
            
            this.tipo = tipo;
            MostrarDescripcion();
        }

        private void MostrarDescripcion()
        {
            lblNombre.Text = tipo.Nombre;
            lblDescripcion.Text = tipo.Descripcion;
        }

        private void B_btn_Click(object sender, EventArgs e)
        {
            VistaTipos menuTps = new VistaTipos();
            menuTps.Show();
            this.Close();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
