﻿using System;
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
    public partial class Frmtelefone : Form
    {
        DataTable Tabela_telefone;
        Boolean novo = true;
        int posicao;
        List<Telefone> lista_telefone = new List<Telefone>();
        public Frmtelefone()
        {
            InitializeComponent();

            //Carregar o Datagrid de Telefones.
            CarregaTabela();

            if (lista_telefone.Count - 1 > 0)
            {
                posicao = 0;
                atualizaCampos();
                dataGridView1.Rows[posicao].Selected = true;
            }
        }

        private void atualizaCampos()
        {
            txtCodigo.Text = lista_telefone[posicao].codtelefone.ToString();
            txtTelefone.Text = lista_telefone[posicao].numerotelefone.ToString();
        }

        List<Telefone> carregaListaTelefone()
        {
            List<Telefone> lista = new List<Telefone>();

            C_Telefone cr = new C_Telefone();
            lista = cr.DadosTelefone();

            return lista;
        }

        List<Telefone> carregaListaTelefoneFiltro()
        {
            List<Telefone> lista = new List<Telefone>();

            C_Telefone cr = new C_Telefone();
            lista = cr.DadosTelefoneFiltro(txtBuscar.Text);

            return lista;
        }

        public void CarregaTabela()
        {
            C_Telefone cr = new C_Telefone();
            DataTable dt = new DataTable();
            dt = cr.Buscar_Todos();
            Tabela_telefone = dt;
            dataGridView1.DataSource = Tabela_telefone;
            lista_telefone = carregaListaTelefone();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow dr = dataGridView1.Rows[index];
            txtCodigo.Text = dr.Cells[0].Value.ToString();
            txtTelefone.Text = dr.Cells[1].Value.ToString();
        }

        private void btnNovo_Click(object sender, EventArgs e)
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
            txtTelefone.Enabled = true;
        }

        private void limparCampos()
        {
            txtCodigo.Text = "";
            txtTelefone.Text = "";
        }

        private void desativaCampos()
        {
            txtTelefone.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Telefone telefone = new Telefone();

            telefone.numerotelefone = txtTelefone.Text;

            C_Telefone c_Telefone = new C_Telefone();

            if (novo == true)
            {
                c_Telefone.Insere_Dados(telefone);
            }
            else
            {
                telefone.codtelefone = Int32.Parse(txtCodigo.Text);
                c_Telefone.Atualizar_Dados(telefone);
            }

            CarregaTabela();
            lista_telefone = carregaListaTelefone();

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
            C_Telefone telefone = new C_Telefone();

            if (txtCodigo.Text != "")
            {
                int valor = Int32.Parse(txtCodigo.Text);
                telefone.Apaga_Dados(valor);
                CarregaTabela();
                lista_telefone = carregaListaTelefone();
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
            int total = lista_telefone.Count - 1;
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
            posicao = lista_telefone.Count - 1;
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
            C_Telefone cr = new C_Telefone();
            DataTable dt = new DataTable();
            dt = cr.Buscar_Filtro(txtBuscar.Text.ToString() + "%");
            Tabela_telefone = dt;

            dataGridView1.DataSource = Tabela_telefone;
            lista_telefone = carregaListaTelefoneFiltro();

            if (lista_telefone.Count >= 0)
            {
                posicao = 0;
                atualizaCampos();
                dataGridView1.Rows[posicao].Selected = true;
                lista_telefone = carregaListaTelefone();
            }
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
