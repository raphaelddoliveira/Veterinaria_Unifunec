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

        private void raçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRaca frmRaca = new FrmRaca();
            frmRaca.ShowDialog();
        }

        private void tipoAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoanimal frmTipoanimal = new FrmTipoanimal();
            frmTipoanimal.ShowDialog();
        }

     

        private void bairroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmbairro frmBairro = new Frmbairro();
            frmBairro.ShowDialog();
        }

        private void animalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCep frmcep = new FrmCep();
            frmcep.ShowDialog();
        }

        private void ruaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmrua frmrua = new Frmrua();
            frmrua.ShowDialog();
        }

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmtelefone frmtelefone = new Frmtelefone();
            frmtelefone.ShowDialog();
        }

        private void tipoFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipofuncionario frmtipofun = new FrmTipofuncionario();
            frmtipofun.ShowDialog();
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMarca frmmarca = new FrmMarca();
            frmmarca.ShowDialog();
        }

        private void tipoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTipoproduto frmtipopro = new FrmTipoproduto();
            frmtipopro.ShowDialog();
        }

        private void cidAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCidanimal frmcid = new FrmCidanimal();
            frmcid.ShowDialog();
        }

        private void paísToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPais frmpais = new FrmPais();
            frmpais.ShowDialog();
        }
    }
}
