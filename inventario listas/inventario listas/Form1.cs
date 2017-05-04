using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario_listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        inventario In1 = new inventario();

        private int _codigo;
        private string _nombre;
        private int _cantidad;
        private int _costo;
        private int _lugar;
        private void txtLugar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            product p1;

            if (txtCod.Text != "")
            {
                _codigo = Convert.ToInt32(txtCod.Text);
                p1 = In1.mBuscar(_codigo);
                txtInfo.Clear();

                if (p1 != null)
                {
                    txtInfo.Text += p1.ToString();
                }
                else
                {
                    MessageBox.Show("el producto no existente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {
                MessageBox.Show("error en codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            product p1;
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

                p1 = new product(_codigo, _nombre, _cantidad, _costo);
                In1.mAgregar(p1);
                MessageBox.Show("Guardadooo", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCod.Clear();
                txtNombre.Clear();
                txtCant.Clear();
                txtCost.Clear();

            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            int aux;
            if (txtCod.Text != "")
            {
                _codigo = Convert.ToInt32(txtCod.Text);
                aux = In1.mEliminar(_codigo);

                if (aux == 1)
                {
                    MessageBox.Show("el producto ha sido eliminado", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("el producto no fue encontrado", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("tiene que ibgresar un codigo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void cmdListarProd_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtInfo.Text += In1.mListar();
        }
    }
}
