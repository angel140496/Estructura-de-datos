using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_doblemente_enlazada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        producto p1;
        listaDoble In1 = new listaDoble();
        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;
        private void cmdAgregarInicio_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "" || txtNombre.Text == "" || txtCant.Text == "" || txtCost.Text == "")
            {
                MessageBox.Show("Llenar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _codigo = Convert.ToInt32(txtCod.Text);
                _nombre = txtNombre.Text;
                _cantidad = Convert.ToInt32(txtCant.Text);
                _costo = Convert.ToInt32(txtCost.Text);

                p1 = new producto(_codigo, _nombre, _cantidad, _costo);
                In1.mAgregar(p1);
                MessageBox.Show("Guardadooo", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCod.Clear();
                txtNombre.Clear();
                txtCant.Clear();
                txtCost.Clear();
            }
        }

        private void cmdEliminarPrimero_Click(object sender, EventArgs e)
        {
            In1.mEliminarPrimero();
        }

        private void cmdEliminarUltimo_Click(object sender, EventArgs e)
        {
            In1.mEliminarUltimo();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text != "")
            {
                _codigo = Convert.ToInt32(txtCod.Text);
                In1.mEliminar(_codigo);                       
            }
            else
            {
                MessageBox.Show("tiene que ibgresar un codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtCod.Text == "" || txtNombre.Text == "" || txtCant.Text == "" || txtCost.Text == "")
            {
                MessageBox.Show("Llenar los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                _codigo = Convert.ToInt32(txtCod.Text);
                _nombre = txtNombre.Text;
                _cantidad = Convert.ToInt32(txtCant.Text);
                _costo = Convert.ToInt32(txtCost.Text);

                p1 = new producto(_codigo, _nombre, _cantidad, _costo);
                In1.mAgregar(p1);
                MessageBox.Show("Guardadooo", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCod.Clear();
                txtNombre.Clear();
                txtCant.Clear();
                txtCost.Clear();
            }
        }

        private void cmdListarProd_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtInfo.Text += In1.mListar();
        }
    }
}
