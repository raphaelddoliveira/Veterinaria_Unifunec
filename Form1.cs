using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Veterinaria.control;
using Veterinaria.model;
using Veterinaria.view;

namespace Veterinaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Raca dados = new Raca();
            dados.nomeraca = textBox1.Text;

            //Definido o Controle Raca C_Raca
            C_Raca cr = new C_Raca();
            cr.Insere_Dados(dados);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dados = Int32.Parse(textBox1.Text);

            C_Raca cr = new C_Raca();
            cr.Apaga_Dados(dados);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Raca raca = new Raca();   
            raca.codraca = Int32.Parse(textBox1.Text);
            raca.nomeraca = textBox2.Text;

            C_Raca cr = new C_Raca();
            cr.Atualizar_Dados(raca);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmTipoanimal frmtipoanimal = new FrmTipoanimal();
            frmtipoanimal.ShowDialog();

        }
    }
}
