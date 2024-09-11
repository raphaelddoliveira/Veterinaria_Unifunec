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

        private void sexoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSexo frmSexo = new FrmSexo();
            frmSexo.ShowDialog();
        }
    }
}
