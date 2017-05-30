using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listas_circulares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Ruta Ruta = new Ruta();
        Base B1;

        private string _nombre;
        private int _minutos;


        private string _nombreTarjeta;
        private int _inicioTarjeta;
        private int _finalTarjeta;
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtMinutos.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Rutas",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                txtNombre.SelectAll();
            }
            else
            {
                _nombre = txtNombre.Text;
                _minutos = Convert.ToInt32(txtMinutos.Text);

                B1 = new Base(_nombre, _minutos);
                Ruta.mAgregar(B1);

                txtNombre.Clear();
                txtMinutos.Clear();
                txtNombre.Focus();
                txtNombre.SelectAll();
            }
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Base B1;

            if (txtNombre.Text != "")
            {
                _nombre = txtNombre.Text;
                B1 = Ruta.mBuscar(_nombre);
                txtInfo.Clear();

                if (B1 != null)
                {
                    txtInfo.Text += B1.ToString();
                    txtNombre.Clear();
                    txtMinutos.Clear();
                    txtNombre.Focus();
                    txtNombre.SelectAll();
                }
                else
                {
                    MessageBox.Show("Ruta no existente.", "Rutas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Clear();
                    txtMinutos.Clear();
                    txtNombre.Focus();
                    txtNombre.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Nombre necesario para buscar una unidad.", "Rutas",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Clear();
                txtMinutos.Clear();
                txtNombre.Focus();
                txtNombre.SelectAll();
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Base B1;
            bool eliminado;

            if (txtNombre.Text != "")
            {
                _nombre = txtNombre.Text;
                B1 = Ruta.mBuscar(_nombre);

                if (B1 != null)
                {
                    eliminado = Ruta.mEliminar(_nombre);
                    
                }
                else
                {
                    MessageBox.Show("Ruta no existente.", "Rutas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Clear();
                    txtMinutos.Clear();
                    txtNombre.Focus();
                    txtNombre.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Ingresa el nombre para eliminar la ruta.", "Rutas",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNombre.Focus();
                txtNombre.SelectAll();
            }
        }

        private void cmdReporte_Click(object sender, EventArgs e)
        {

            txtInfo.Clear();
            txtInfo.Text += Ruta.mListar();

            txtNombre.Clear();
            txtMinutos.Clear();
            txtNombre.Focus();
            txtNombre.SelectAll();
        }

        private void cmdTarjeta_Click(object sender, EventArgs e)
        {
            Base B1;

            if (txtTarjetaNombre.Text == "" || txtInicio.Text == "" || txtFinal.Text == "")
            {
                MessageBox.Show("Favor de llenar todos los campos.", "Rutas",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTarjetaNombre.Focus();
                txtTarjetaNombre.SelectAll();
            }
            else
            {
                _nombreTarjeta = txtTarjetaNombre.Text;
                _inicioTarjeta = Convert.ToInt32(txtInicio.Text);
                _finalTarjeta = Convert.ToInt32(txtFinal.Text);
                B1 = Ruta.mBuscar(_nombreTarjeta);

                if (B1 != null)
                {
                    txtInfo.Clear();
                    txtInfo.Text += Ruta.mTarjeta(_nombreTarjeta, _inicioTarjeta, _finalTarjeta);

                    mLimpiar();
                    txtTarjetaNombre.Focus();
                    txtTarjetaNombre.SelectAll();
                }
                else
                {
                    MessageBox.Show("Ruta no existente.", "Rutas",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtInfo.Clear();
                    txtTarjetaNombre.Focus();
                    txtTarjetaNombre.SelectAll();
                }
            }
        }

        

        private void mLimpiar()
        {
            txtNombre.Clear();
            txtMinutos.Clear();
        }
    }
}
