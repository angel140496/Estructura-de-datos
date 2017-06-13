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

            Proceador Procesador = new Proceador();
            Random r = new Random();
            @base P1;

            int totalPro = 0;
            int proEmpty = 0;
            int numMaxPro = 0;
            int numPend = 0;

            for (int i = 0; i < 200; i++)
            {
                if (r.Next(1, 101) <= 35)
                {
                    P1 = new @base(r.Next(4, 11));
                    Procesador.Enqueue(P1);
                    numMaxPro++;
                    numPend++;
                }

                P1 = Procesador.Peek;

                if (P1 != null)
                {
                    P1.Tiempo--;
                    if (P1.Tiempo == 0)
                    {
                       
                        Procesador.Dequeue();
                        totalPro++;
                        numPend--;
                    }
                }
                else
                {
                    proEmpty++;
                }
            }

            txtMaximo.Text = numMaxPro.ToString();
            txtAtendidos.Text = totalPro.ToString();
            txtRestantes.Text = proEmpty.ToString();
            txtVacios.Text = numPend.ToString();

        }
    }
}

