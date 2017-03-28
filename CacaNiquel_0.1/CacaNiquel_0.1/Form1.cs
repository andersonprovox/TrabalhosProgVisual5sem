﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//chamando a namespace para o barulho de beep
using System.Runtime.InteropServices;

namespace CacaNiquel_0._1
{
    public partial class Form1 : Form
    {
        //dll de sons da placa mae
        [DllImport("kernel32.dll")]
        //metodo para acionar o beep
        public static extern bool Beep(UInt32 frequency, UInt32 duration);
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFim_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGirar_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            Random random = new Random();
            int um = random.Next(0, 8);
            int dois = random.Next(0, 8);
            int tres = random.Next(0, 8);
            lblUm.Text = um.ToString();
            lblDois.Text = dois.ToString();
            lblTres.Text = tres.ToString();

            if ((lblUm.Text == "7") || (lblDois.Text == "7") || (lblTres.Text == "7"))
            {
                pictureBox1.Image = Properties.Resources.dinheiro;
                pictureBox1.Visible = true;
                //chamando o beep quando um numero 7 aparecer
                Beep(1000, 300);
                lblResult.Text = "Você Tirou um 7!!,\n Parabens!!!";

            }
            else
                lblResult.Text = "";
        }
    }
}
