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

namespace Veterinaria.view
{
    public partial class FrmSexo : Form
    {
        DataTable Tabela_sexos;
        Boolean novo = true;
        int posicao;
        List<Sexo> lista_sexo = new List<Sexo>();
        public FrmSexo()
        {
            InitializeComponent();

            //Carregar o Datagrid de Sexos.
            CarregaTabela();

            lista_sexo = carregaListaSexo();

            if (lista_sexo.Count - 1 > 0)
            {
                posicao = 0;
                atualizaCampos();
                dataGridView1.Rows[posicao].Selected = true;
            }

        }

        private void atualizaCampos()
        {
            txtCodigo.Text = lista_sexo[posicao].codsexo.ToString();
            txtSexo.Text = lista_sexo[posicao].nomesexo.ToString();
        }

        List<Sexo> carregaListaSexo()
        {
            List<Sexo> lista = new List<Sexo>();

            C_Sexo cr = new C_Sexo();
            lista = cr.DadosSexo();

            return lista;
        }

        List<Sexo> carregaListaSexoFiltro()
        {
            List<Sexo> lista = new List<Sexo>();

            C_Sexo cr = new C_Sexo();
            lista = cr.DadosSexoFiltro(txtBuscar.Text);

            return lista;
        }

        public void CarregaTabela()
        {
            C_Sexo cr = new C_Sexo();
            DataTable dt = new DataTable();
            dt = cr.Buscar_Todos();
            Tabela_sexos = dt;
            dataGridView1.DataSource = Tabela_sexos;

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dr = dataGridView1.Rows[index];
            txtCodigo.Text = dr.Cells[0].Value.ToString();
            txtSexo.Text = dr.Cells[1].Value.ToString();
        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            limparCampos();

            ativarCampos();

            AtivaBotoes();

            novo = true;
        }

        private void AtivaBotoes()
        {
            btnNovo.Enabled = false;
            btnApagar.Enabled = false;
            btnEditar.Enabled = false;

            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void ativarCampos()
        {
            txtSexo.Enabled = true;

        }

        private void limparCampos()
        {
            txtCodigo.Text = "";
            txtSexo.Text = "";
        }

        private void desativaCampos()
        {
            txtSexo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Sexo sexo = new Sexo();

            sexo.nomesexo = txtSexo.Text;

            C_Sexo c_Sexo = new C_Sexo();

            if (novo == true)
            {
                c_Sexo.Insere_Dados(sexo);
            }
            else
            {
                sexo.codsexo = Int32.Parse(txtCodigo.Text);
                c_Sexo.Atualizar_Dados(sexo);
            }

            CarregaTabela();

            desativaCampos();

            desativaBotoes();
        }

        private void desativaBotoes()
        {
            btnNovo.Enabled = true;
            btnApagar.Enabled = true;
            btnEditar.Enabled = true;

            btnSalvar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limparCampos();
            desativaBotoes();
            desativaCampos();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            C_Sexo sexo = new C_Sexo();

            if (txtCodigo.Text != "")
            {
                int valor = Int32.Parse(txtCodigo.Text);
                sexo.Apaga_Dados(valor);
                CarregaTabela();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ativarCampos();
            AtivaBotoes();
            novo = false;

        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[posicao].Selected = false;
            posicao = 0;
            atualizaCampos();
            dataGridView1.Rows[posicao].Selected = true;
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            int total = lista_sexo.Count - 1;
            if (total > posicao)
            {
                dataGridView1.Rows[posicao].Selected = false;
                posicao++;
                atualizaCampos();
                dataGridView1.Rows[posicao].Selected = true;
            }

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[posicao].Selected = false;
            posicao = lista_sexo.Count - 1;
            atualizaCampos();
            dataGridView1.Rows[posicao].Selected = true;
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicao > 0)
            {
                dataGridView1.Rows[posicao].Selected = false;
                posicao--;
                atualizaCampos();
                dataGridView1.Rows[posicao].Selected = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Foi definido um atributo chamado cr do tipo C_Sexo
            C_Sexo cr = new C_Sexo();
            DataTable dt = new DataTable();
            dt = cr.Buscar_Filtro(txtBuscar.Text.ToString() + "%");
            Tabela_sexos = dt;

            //Adiciona os dados do DataTable para o DataGridView
            dataGridView1.DataSource = Tabela_sexos;

            //Carrega a Lista_sexo com o valor da consulta com parâmetro
            lista_sexo = carregaListaSexoFiltro();

            if (lista_sexo.Count >= 0)
            {
                posicao = 0;
                atualizaCampos();
                dataGridView1.Rows[posicao].Selected = true;
            }

        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSexo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
