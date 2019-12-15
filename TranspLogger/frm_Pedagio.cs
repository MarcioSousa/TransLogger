using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Negocios;
using Dto;

namespace TranspLogger
{
    public partial class frm_Pedagio : Form
    {
        cls_AcaoNaTela acaoNaTela = new cls_AcaoNaTela();
        public frm_Pedagio()
        {
            InitializeComponent();
            //Não gerar linhas automaticamente
            dgvPedagio.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Manipulação dos Objetos do Formulário
        /// </summary>
        private void carregaGrid()
        {
            //Verificar se tem algum registro selecionado
            if (dgvPedagio.SelectedRows.Count == 0)
            {
                return;
            }

            //Pegar o registro selecionado no grid
            Pedagio pedagio = (dgvPedagio.SelectedRows[0].DataBoundItem as Pedagio);
            lblCodigo.Text = pedagio.Codigo.ToString();
            txtNome.Text = pedagio.Nome;
            txtPreco.Text = string.Format("{0:f2}", pedagio.Preco);
        }
        private void atualizarGrid()
        {
            PedagioNegocios pedagioNegocios = new PedagioNegocios();
            PedagioColecao pedagioColecao = pedagioNegocios.ConsultarPorNome(txtPesquisaPedagio.Text);

            dgvPedagio.DataSource = null;
            dgvPedagio.DataSource = pedagioColecao;

            dgvPedagio.Update();
            dgvPedagio.Refresh();

            dataGridVazio();
        }
        private void limparCampos()
        {
            lblCodigo.Text = "0";
            txtNome.Text = "";
            txtPreco.Text = "0";
        }
        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtPreco.Enabled = true;

            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;

            btnPesquisaPedagio.Enabled = false;
            txtPesquisaPedagio.Enabled = false;
            dgvPedagio.Enabled = false;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtNome.Focus();
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtPreco.Enabled = false;

            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;

            btnPesquisaPedagio.Enabled = true;
            txtPesquisaPedagio.Enabled = true;
            dgvPedagio.Enabled = true;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void dataGridVazio()
        {
            if (dgvPedagio.Rows.Count == 0)
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                lblCodigo.Text = "0";
                limparCampos();
            }
            else
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void frm_pedagio_Load(object sender, EventArgs e)
        {
            dataGridVazio();
        }
        private void txtPreco_Leave(object sender, EventArgs e)
        {
            if (Convert.ToString(txtPreco.Text) == "")
            {
                txtPreco.Text = "0";
            }
        }

        /// <summary>
        /// Comandos do DataGridView
        /// </summary>
        private void dgvPedagio_SelectionChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }
        /// <summary>
        /// Eventos dos Botões
        /// </summary>
        private void btnPesquisaPedagio_Click(object sender, EventArgs e)
        {
            atualizarGrid();

            if (dgvPedagio.Rows.Count == 0)
            {
                limparCampos();
            }
            
            dataGridVazio();
        }

        /// <summary>
        /// Manipulação do Banco de Dados
        /// </summary>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            acaoNaTela = cls_AcaoNaTela.Inserir;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            acaoNaTela = cls_AcaoNaTela.Alterar;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvPedagio.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum pedágio selecionado!");
                return;
            }

            if (MessageBox.Show("Deseja excluir o pedágio selecionado da lista?", "Exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Pegar o Pegádio selecionado no dataGrid
                Pedagio pedagioSelecionado = (dgvPedagio.SelectedRows[0].DataBoundItem as Pedagio);

                //Instanciar a regra de negócio
                PedagioNegocios pedagioNegocios = new PedagioNegocios();
                string retorno = pedagioNegocios.Excluir(pedagioSelecionado);

                //Verificar se excluiu com sucesso
                //Se o retorno for um número é porque deu certo, senaõ é a mensagem de erro
                try
                {
                    int codped = Convert.ToInt32(retorno);
                    MessageBox.Show("Pedágio Deletado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarGrid();
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //Verificar se é inserção ou alteração
            if (acaoNaTela == cls_AcaoNaTela.Inserir)
            {
                try
                {
                    Pedagio pedagio = new Pedagio();
                    pedagio.Nome = txtNome.Text;
                    pedagio.Preco = Convert.ToDouble(txtPreco.Text);
                 
                    PedagioNegocios pedagioNegocios = new PedagioNegocios();
                    string retorno = pedagioNegocios.Inserir(pedagio);

                    try
                    {
                        int idpedagio = Convert.ToInt32(retorno);
                        MessageBox.Show("Pedágio Inserido com Sucesso. \nCódigo do Pedágio: " + idpedagio, "Código do Pedágio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível adicionar o pedágio.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível adicionar um novo pedágio.\nPreencha todos os campos Corretamente.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acaoNaTela == cls_AcaoNaTela.Alterar)
            {
                try
                {
                    Pedagio pedagio = new Pedagio();
                    pedagio.Codigo = Convert.ToInt32(lblCodigo.Text);
                    pedagio.Nome = txtNome.Text;
                    pedagio.Preco = Convert.ToDouble(txtPreco.Text);

                    PedagioNegocios pedagioNegocios = new PedagioNegocios();
                    string retorno = pedagioNegocios.Alterar(pedagio);

                    try
                    {
                        int idpedagio = Convert.ToInt32(retorno);
                        MessageBox.Show("Pedágio Alterado com Sucesso. \nCódigo do pedágio: " + idpedagio, "Código do pedagio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível alterar o pedágio.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível alterar um novo pedágio.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            carregaGrid();
            dataGridVazio();
        }
    }
}