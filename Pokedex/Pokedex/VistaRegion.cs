using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Pokedex.PokemonPanelRegiones;

namespace Pokedex
{
    public partial class VistaRegion : Form
    {
        private RegionDAO regionDAO;

        public VistaRegion()
        {
            InitializeComponent();
            //Background Invisible No Tocar
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            this.StartPosition = FormStartPosition.CenterScreen;
            string connectionString = "Data Source=DESKTOP-J97KSH3;Initial Catalog=PokeWiki;Integrated Security=True";
            regionDAO = new RegionDAO(connectionString);
            MostrarRegiones();
        }

        private void MostrarRegiones()
        {
            List<string> nombresRegiones = regionDAO.ObtenerNombresRegiones();

            foreach (string nombreRegion in nombresRegiones)
            {
                PokemonPanelRegiones regionPanel = new PokemonPanelRegiones();
                regionPanel.NombreRegion = nombreRegion;
                regionPanel.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(regionPanel);

                regionPanel.Click += (sender, e) =>
                {
                    PokemonPanelRegiones panel = (PokemonPanelRegiones)sender;
                    string nombre = panel.NombreRegion;

                    
                    Regiones regiones = regionDAO.ObtenerRegionPorNombre(nombre);

                    
                    RegionesDetalle regionDetalleForm = new RegionesDetalle(regiones);
                    regionDetalleForm.Show();
                    this.Hide();
                };
            }
        }

        private void B_btn_Click(object sender, EventArgs e)
        {
            Main1 main = new Main1();
            main.Show();
            this.Close();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
