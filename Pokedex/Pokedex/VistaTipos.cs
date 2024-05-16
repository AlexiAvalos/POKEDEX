using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Pokedex.PokemonPanelTipos;

namespace Pokedex
{
    public partial class VistaTipos : Form
    {
        private TipoDAO tipoDAO;

        public VistaTipos()
        {
            InitializeComponent();
            //Background Invisible No Tocar
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            this.StartPosition = FormStartPosition.CenterScreen;
            string connectionString = "Data Source=DESKTOP-J97KSH3;Initial Catalog=PokeWiki;Integrated Security=True";
            tipoDAO = new TipoDAO(connectionString);
            MostrarTipos();
        }

        private void MostrarTipos()
        {
            List<string> nombresTipos = tipoDAO.ObtenerNombresTipos();

            foreach (string nombreTipo in nombresTipos)
            {
                PokemonPanelTipos tipoPanel = new PokemonPanelTipos();
                tipoPanel.NombreTipo = nombreTipo;
                tipoPanel.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(tipoPanel);

                
                tipoPanel.Click += (sender, e) =>
                {
                    PokemonPanelTipos panel = (PokemonPanelTipos)sender;
                    string nombre = panel.NombreTipo;

                   
                    Tipo tipo = tipoDAO.ObtenerTipoPorNombre(nombre);

                    
                    TiposDetalle tipoDetalleForm = new TiposDetalle(tipo);
                    tipoDetalleForm.Show();
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
