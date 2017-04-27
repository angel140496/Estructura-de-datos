﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tortuga T1 = new Tortuga();
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = T1.tablero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = T1.mostrar();
        }

        private void cmdPArriba_Click(object sender, EventArgs e)
        {
            int aux = Convert.ToInt32(textBox2.Text);
            T1.avanzar(aux);
        }

        private void cmdGirarDerecha_Click(object sender, EventArgs e)
        {
            T1.gDerecha();
        }

        private void cmdGirarIzq_Click(object sender, EventArgs e)
        {
            T1.gIzquierda();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            T1.plumaAbajo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            T1.plumaArriba();
        }
    }
}
