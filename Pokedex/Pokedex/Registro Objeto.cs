using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokedex
{
    public partial class Registro_Objeto : Form
    {
        public Registro_Objeto()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardarObj_btn_Click(object sender, EventArgs e)
        {
            objetoR objeto = new objetoR();
            objeto.Nombre = nombreObj_txt.Text;
            objeto.Descripcion = descObj_txt.Text;
            

            int result = ObjetoDAL.AgregarObjeto(objeto);

            if (result > 0)
            {
                MessageBox.Show("Objeto guardado exitosamente");
            }
            else
            {
                MessageBox.Show("Ocurrio un error al guardar el registro D:");
            }
            recargarData();


        }

        private void Registro_Objeto_Load(object sender, EventArgs e)
        {
            recargarData();
        }

        public void recargarData()
        {
            dataGridViewObj.DataSource = ObjetoDAL.mostrarRegistroObjetos();
        }
    }
    
}
