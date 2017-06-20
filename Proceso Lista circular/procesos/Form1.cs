using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace procesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdInicio_Click(object sender, EventArgs e)
        {

            txtInfo.Clear();

            Proceador Procesador = new Proceador();
            Random r = new Random();
            @base P1;

            int totalPro = 0;
            int proEmpty = 0;
            int numMaxPro = 0;

            for (int i = 0; i < 200; i++)
            {
                if (r.Next(1, 101) <= 30)
                {
                    P1 = new @base(r.Next(4, 13));
                    Procesador.mAgregar(P1);
                    P1.Proceso = numMaxPro;
                    numMaxPro++;
                }

                P1 = Procesador.mActual();

                if (P1 != null)
                {

                    P1.Tiempo--;

                    if (P1.Tiempo == 0)
                    {
                        Procesador.mEliminar(P1);
                        totalPro++;
                    }

                    Procesador.mMoverSiguiente();
                }
                else
                {
                    proEmpty++;
                }
            }

            txtInfo.Text = Procesador.mListar();

            txtMaximo.Text = numMaxPro.ToString();
            txtAtendidos.Text = totalPro.ToString();
            txtRestantes.Text = proEmpty.ToString();
            txtVacios.Text = Procesador._proPen.ToString();
            textBox1.Text= Procesador._cicPen.ToString();

        }
    }
}

