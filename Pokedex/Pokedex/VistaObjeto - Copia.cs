using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class VistaObjetos : Form
    {
        private PokemonDAO pokemonDAO;

        public VistaObjetos()
        {
            InitializeComponent();
            string connectionString = "Data Source=DESKTOP-UBBP1OB\\NICO;Initial Catalog=PokeWiki;Integrated Security=True";
            pokemonDAO = new PokemonDAO(connectionString);
            MostrarObjetosEvolutivos();
        }

        private void MostrarObjetosEvolutivos()
        {
            List<string> nombresObjetosEvolutivos = pokemonDAO.ObtenerNombresObjetosEvolutivos();

            foreach (string nombreObjetoEvolutivo in nombresObjetosEvolutivos)
            {
                ObjetoEvolutivoPanel objetoEvolutivoPanel = new ObjetoEvolutivoPanel();
                objetoEvolutivoPanel.NombreObjetoEvolutivo = nombreObjetoEvolutivo;
                objetoEvolutivoPanel.Margin = new Padding(10);
                flowLayoutPanel1.Controls.Add(objetoEvolutivoPanel);
            }
        }

        private void MostrarDetallesObjetoEvolutivo(string nombreObjetoEvolutivo)
        {
            
            MessageBox.Show($"Mostrando detalles de {nombreObjetoEvolutivo}");
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
        }

        private void VistaObjetos_FormClosed(object sender, FormClosedEventArgs e)
        {
   
        }
    }
}

