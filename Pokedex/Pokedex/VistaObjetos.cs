using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static Pokedex.PokemonPanelObjetos;

namespace Pokedex
{
    public partial class VistaObjetos : Form
    {
        private ObjetoEvolutivoDAO objetoEvolutivoDAO;

        public VistaObjetos()
        {
            InitializeComponent();
            //Background Invisible No Tocar
            this.TransparencyKey = Color.Magenta;
            this.BackColor = Color.Magenta;
            this.StartPosition = FormStartPosition.CenterScreen;
            string connectionString = "Data Source=DESKTOP-J97KSH3;Initial Catalog=PokeWiki;Integrated Security=True";
            objetoEvolutivoDAO = new ObjetoEvolutivoDAO(connectionString);
            MostrarObjetosEvolutivos();
        }

        private void MostrarObjetosEvolutivos()
        {
            List<string> nombresObjetosEvolutivos = objetoEvolutivoDAO.ObtenerNombresObjetosEvolutivos();

            foreach (string nombreObjetoEvolutivo in nombresObjetosEvolutivos)
            {
                PokemonPanelObjetos objetoPanel = new PokemonPanelObjetos();
                objetoPanel.NombreObjetoEvolutivo = nombreObjetoEvolutivo;
                objetoPanel.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(objetoPanel);

                // Suscribirse al evento de clic de cada panel
                objetoPanel.Click += (sender, e) =>
                {
                    PokemonPanelObjetos panel = (PokemonPanelObjetos)sender;
                    string nombre = panel.NombreObjetoEvolutivo;

                    // Obtener el objeto ObjetoEvolutivo correspondiente al nombre
                    ObjetoEvolutivo objetoEvolutivo = objetoEvolutivoDAO.ObtenerObjetoEvolutivoPorNombre(nombre);

                    // Mostrar los detalles del ObjetoEvolutivo seleccionado
                    ObjetosDetalle objetoDetalleForm = new ObjetosDetalle(objetoEvolutivo);
                    objetoDetalleForm.Show();
                    this.Hide();
                };
            }
        }




        //no moverle que se rompe
        private void rjButton8_Click(object sender, EventArgs e) 
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void registroObj_btn_Click(object sender, EventArgs e)
        {
            Form registroObj = new Registro_Objeto();
            registroObj.Show();
            this.Close();
        }

        private void VistaObjetos_FormClosed(object sender, FormClosedEventArgs e)
        {
   
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

