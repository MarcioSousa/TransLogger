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
    public partial class frm_Imprevisto : Form
    {
        cls_AcaoNaTela acaoNaTela = new cls_AcaoNaTela();

        //Contrutor
        public frm_Imprevisto()
        {
            InitializeComponent();
            //Não gerar linhas automaticamente
            dgvImprevisto.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Manipulação dos Objetos do Formulário
        /// </summary>
        private void carregaGrid()
        {
            //Verificar se tem algum registro selecionado
            if (dgvImprevisto.SelectedRows.Count == 0)
            {
                return;
            }

            //Pegar o registro selecionado no grid
            Imprevisto imprevisto   = (dgvImprevisto.SelectedRows[0].DataBoundItem as Imprevisto);
            lblCodigo.Text = imprevisto.Codigo.ToString();
            txtImprevisto.Text = imprevisto.Nome;

        }
        private void atualizarGrid()
        {
            ImprevistoNegocios imprevistoNegocios = new ImprevistoNegocios();
            ImprevistoColecao imprevistoColecao = imprevistoNegocios.ConsultarPorNome(txtPesquisarImprevisto.Text);

            dgvImprevisto.DataSource = null;
            dgvImprevisto.DataSource = imprevistoColecao;

            dgvImprevisto.Update();
            dgvImprevisto.Refresh();

            dataGridVazio();
        }
        private void limparCampos()
        {
            lblCodigo.Text = "0";
            txtImprevisto.Text = "";
        }
        private void habilitarCampos()
        {
            txtImprevisto.Enabled = true;

            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;

            btnPesquisarImprevisto.Enabled = false;
            txtPesquisarImprevisto.Enabled = false;
            dgvImprevisto.Enabled = false;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtImprevisto.Focus();
        }
        private void desabilitarCampos()
        {
            txtImprevisto.Enabled = false;

            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;

            btnPesquisarImprevisto.Enabled = true;
            txtPesquisarImprevisto.Enabled = true;
            dgvImprevisto.Enabled = true;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void dataGridVazio()
        {
            if (dgvImprevisto.Rows.Count == 0)
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

        private void frm_Cliente_Load(object sender, EventArgs e)
        {
            dataGridVazio();
        }

        /// <summary>
        /// Comandos do DataGridView
        /// </summary>
        private void dgvImprevisto_SelectionChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }



        /// <summary>
        /// Eventos dos Botões
        /// </summary>       
        private void btnPesquisarImprevisto_Click(object sender, EventArgs e)
        {
            atualizarGrid();
            if(dgvImprevisto.Rows.Count == 0)
            {
                limparCampos();
            }
            dataGridVazio();
        }
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
            if(dgvImprevisto.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Imprevisto selecionado!");
                return;
            }

            if (MessageBox.Show("Deseja excluir o Imprevisto selecionado da lista?", "Exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Pegar o Imprevisto selecionado no dataGrid
                Imprevisto imprevistoSelecionado = (dgvImprevisto.SelectedRows[0].DataBoundItem as Imprevisto);

                //Instanciar a regra de negócio
                ImprevistoNegocios imprevistoNegocios = new ImprevistoNegocios();
                string retorno = imprevistoNegocios.Excluir(imprevistoSelecionado);

                //Verificar se excluiu com sucesso
                //Se o retorno for um número é porque deu certo, senaõ é a mensagem de erro
                try
                {
                    int codimpr = Convert.ToInt32(retorno);
                    MessageBox.Show("Imprevisto Deletado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Imprevisto imprevisto = new Imprevisto();
                    imprevisto.Nome = txtImprevisto.Text;

                    ImprevistoNegocios imprevistoNegocios = new ImprevistoNegocios();
                    string retorno = imprevistoNegocios.Inserir(imprevisto);

                    try
                    {
                        int idImprevisto = Convert.ToInt32(retorno);
                        MessageBox.Show("Imprevisto Inserido com Sucesso. \nCódigo do Imprevisto: " + idImprevisto, "Código do Imprevisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível adicionar o imprevisto.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível adicionar um novo imprevisto.\nPreencha todos os campos Corretamente.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acaoNaTela == cls_AcaoNaTela.Alterar)
            {
                try
                {
                    Imprevisto imprevisto = new Imprevisto();
                    imprevisto.Codigo = Convert.ToInt32(lblCodigo.Text);
                    imprevisto.Nome = txtImprevisto.Text;
     
                    ImprevistoNegocios imprevistoNegocios = new ImprevistoNegocios();
                    string retorno = imprevistoNegocios.Alterar(imprevisto);

                    try
                    {
                        int idImprevisto = Convert.ToInt32(retorno);
                        MessageBox.Show("Imprevisto Alterado com Sucesso. \nCódigo do imprevisto: " + idImprevisto, "Código do imprevisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível alterar o imprevisto.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível alterar o imprevisto.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            carregaGrid();
            dataGridVazio();
        }

        private void frm_Imprevisto_Load(object sender, EventArgs e)
        {

        }
    }
}

//private void btnCancelar_Click(object sender, EventArgs e)
//{
//    desabilitarCampos();
//    carregaGrid();
//    dataGridVazio();
//}

