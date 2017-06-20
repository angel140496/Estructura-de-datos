using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string ecuacion;
        arboles arbol = new arboles();

        private void txtNodos_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNodos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblPostOrden_Click(object sender, EventArgs e)
        {

        }

        private void lblDatos_Click(object sender, EventArgs e)
        {

        }

        private void lblPreOrden_Click(object sender, EventArgs e)
        {

        }

        private void lblInOrden_Click(object sender, EventArgs e)
        {

        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            txtInOrden.Text = txtDatos.Text;
            ecuacion = txtDatos.Text;
            operacion op = new operacion(ecuacion);
            op.alamacenar();
            arbol.crearArbol();
            txtPostOrden.Text = arbol.PostOrden();
            txtPreOrden.Text = arbol.PreOrden();
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            string Post = txtDatos.Text;
            operacion op = new operacion(ecuacion);
            op.evaluarPost(Post);
            op.evaluarPre(Post);
            textBox2.Text = arbol.postOrdenNotacion();
            textBox1.Text = arbol.preOrdenNotacion();
        }
    }
}
