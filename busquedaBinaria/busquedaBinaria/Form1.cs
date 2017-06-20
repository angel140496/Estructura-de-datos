using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace busquedaBinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Random n = new Random();
        private string vCadena;
        private short i;
        private int _vComp;
        int[] Vector = new int[1000];


        public string mMostrar()
        {
            vCadena = "";

            for (i = 0; i <= Vector.Length - 1; i++)
            {
                vCadena += "[ " + i + " ] = " + Vector[i] + Environment.NewLine;
            }

            return vCadena;
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {

        }

        public void Busqueda_Binaria(int[] Vector, int _vValor)
        {
            int U = Vector.Length - 1; 
            int P = 0; 
            _vComp = 0;

            int Central = (P + U) / 2; 

            while (P <= U && Vector[Central] != _vValor)
            {
                _vComp++;

                if (_vValor < Vector[Central])
                {
                    U = Central - 1;
                }
                else
                {
                    P = Central + 1;
                }

                Central = (U + P) / 2;
            }

            if (_vValor == Vector[Central])
            {
                txtResBus.Text += "Pos: [" + Central + "] Num: " + _vValor + " Comp: " + _vComp + Environment.NewLine;
            }
            else
            {
                txtResBus.Text += "Pos: [" + Central + "] Num: " + _vValor + " Comp: " + -_vComp + Environment.NewLine;
            }

            if (_vComp != -10)
            {
                MessageBox.Show("numero no encontrado");
            }
            
        }

        private void cmdLlenar_Click_1(object sender, EventArgs e)
        {
            Vector[0] = 1;

            for (i = 1; i <= Vector.Length - 1; i++)
            {
                Vector[i] = Vector[i - 1] + n.Next(1, 6);
            }

            txtLlenar.Text = mMostrar().ToString();
        }

        private void cmdBuscar_Click_1(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(txtBuscar.Text);

            Busqueda_Binaria(Vector, val);
        }
    }


}

