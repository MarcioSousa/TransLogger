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
    public partial class frm_Cliente : Form
    {
        cls_AcaoNaTela acaoNaTela = new cls_AcaoNaTela();

        //Contrutor
        public frm_Cliente()
        {
            InitializeComponent();

            //Não gerar linhas automaticamente
            dgvCliente.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Comandos do DataGridView
        /// </summary>
        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }

        /// <summary>
        /// Eventos dos Botões
        /// </summary>
        private void btnPesquisaCep_Click(object sender, EventArgs e)
        {
            cls_Cep novoCep = new cls_Cep(mtbCep.Text);
            txtBairro.Text = novoCep.Bairro;
            txtLogradouro.Text = novoCep.Lagradouro;
            txtCidade.Text = novoCep.Cidade;
            cbxUf.Text = novoCep.UF;

            if (txtLogradouro.Text != "")
            {
                txtNumero.Focus();
            }
            else
            {
                MessageBox.Show("Cep não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCep.Text = "";
                txtLogradouro.Focus();
            }
        }
        private void btnPesquisaCliente_Click(object sender, EventArgs e)
        {
            atualizarGrid();

            if (dgvCliente.Rows.Count == 0)
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

            if (dgvCliente.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum Cliente selecionado!");
                return;
            }

            if (MessageBox.Show("Deseja excluir o Cliente selecionado da lista?", "Exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Pegar o Funcionário selecionado no dataGrid
                Pessoa clienteSelecionado = (dgvCliente.SelectedRows[0].DataBoundItem as Pessoa);

                //Instanciar a regra de negócio
                ClienteNegocios clienteNegocios = new ClienteNegocios();
                string retorno = clienteNegocios.Excluir(clienteSelecionado);

                //Verificar se excluiu com sucesso
                //Se o retorno for um número é porque deu certo, senaõ é a mensagem de erro
                try
                {
                    int codfunc = Convert.ToInt32(retorno);
                    MessageBox.Show("Cliente Deletado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //string Cep;
                    //Cep = mtbCep.Text.Replace("-","");

                    Pessoa cliente = new Pessoa();
                    cliente.Nome = txtNome.Text;
                    cliente.Logradouro = txtLogradouro.Text;
                    cliente.Numero = txtNumero.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.Uf = cbxUf.Text;
                    cliente.Cep = Convert.ToString(mtbCep.Text.Replace("-", ""));
                    cliente.CelularUm = Convert.ToString(mtbCelularUm.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""));
                    cliente.CelularDois = Convert.ToString(mtbCelularDois.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""));
                    cliente.ContatoFixo = Convert.ToString(mtbFixo.Text.Replace("(", "").Replace(") ", "").Replace("-", ""));

                    ClienteNegocios clienteNegocios = new ClienteNegocios();
                    string retorno = clienteNegocios.Inserir(cliente);

                    try
                    {
                        int idcliente = Convert.ToInt32(retorno);
                        MessageBox.Show("Cliente Inserido com Sucesso. \nCódigo do cliente: " + idcliente, "Código do cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível adicionar o cliente.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível adicionar um novo cliente.\nPreencha todos os campos Corretamente.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acaoNaTela == cls_AcaoNaTela.Alterar)
            {
                try
                {
                    Pessoa cliente = new Pessoa();
                    cliente.Codigo = Convert.ToInt32(lblCodigo.Text);
                    cliente.Nome = txtNome.Text;
                    cliente.Logradouro = txtLogradouro.Text;
                    cliente.Numero = txtNumero.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Cidade = txtCidade.Text;
                    cliente.Uf = cbxUf.Text;
                    cliente.Cep = Convert.ToString(mtbCep.Text.Replace("-", ""));
                    cliente.CelularUm = Convert.ToString(mtbCelularUm.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""));
                    cliente.CelularDois = Convert.ToString(mtbCelularDois.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""));
                    cliente.ContatoFixo = Convert.ToString(mtbFixo.Text.Replace("(", "").Replace(") ", "").Replace("-", ""));

                    ClienteNegocios clienteNegocios = new ClienteNegocios();
                    string retorno = clienteNegocios.Alterar(cliente);

                    try
                    {
                        int idcliente = Convert.ToInt32(retorno);
                        MessageBox.Show("Cliente Alterado com Sucesso. \nCódigo do cliente: " + idcliente, "Código do cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível alterar o cliente.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível alterar o cliente.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            carregaGrid();
            dataGridVazio();
        }

        /// <summary>
        /// Manipulação dos Objetos do Formulário
        /// </summary>
        private void carregaGrid()
        {
            //Verificar se tem algum registro selecionado
            if (dgvCliente.SelectedRows.Count == 0)
            {
                return;
            }

            //Pegar o registro selecionado no grid
            Pessoa Cliente = (dgvCliente.SelectedRows[0].DataBoundItem as Pessoa);
            lblCodigo.Text = Cliente.Codigo.ToString();
            txtNome.Text = Cliente.Nome;
            //dtpCadastro.Value = Cliente.DataCadastro;
            txtLogradouro.Text = Cliente.Logradouro;
            txtNumero.Text = Cliente.Numero;
            txtBairro.Text = Cliente.Bairro;
            txtCidade.Text = Cliente.Cidade;
            cbxUf.Text = Cliente.Uf;

            if (Cliente.Cep != "0")
            {
                mtbCep.Text = Convert.ToString(Cliente.Cep);
            }
            else
            {
                mtbCep.Text = "";
            }

            if (Cliente.CelularUm != "0")
            {
                mtbCelularUm.Text = Convert.ToString(Cliente.CelularUm);
            }
            else
            {
                mtbCelularUm.Text = "";
            }

            if (Cliente.CelularDois != "0")
            {
                mtbCelularDois.Text = Convert.ToString(Cliente.CelularDois);
            }
            else
            {
                mtbCelularDois.Text = "0";
            }

            if (mtbFixo.Text != "0")
            {
                mtbFixo.Text = Convert.ToString(Cliente.ContatoFixo);
            }
            else
            {
                mtbFixo.Text = "";
            }
        }
        private void atualizarGrid()
        {
            ClienteNegocios clienteNegocios = new ClienteNegocios();
            ClienteColecao clienteColecao = clienteNegocios.ConsultarPorNome(txtPesquisaCliente.Text);

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = clienteColecao;

            dgvCliente.Update();
            dgvCliente.Refresh();

            dataGridVazio();
        }
        private void limparCampos()
        {
            lblCodigo.Text = "0";
            txtNome.Text = "";
            dtpCadastro.Value = DateTime.Today;
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cbxUf.Text = "";
            mtbCep.Text = "";
            mtbCelularUm.Text = "";
            mtbCelularDois.Text = "";
            mtbFixo.Text = "";
        }
        private void habilitarCampos()
        {
            txtNome.Enabled = true;
            txtLogradouro.Enabled = true;
            txtNumero.Enabled = true;
            txtBairro.Enabled = true;
            txtCidade.Enabled = true;
            cbxUf.Enabled = true;
            mtbCep.Enabled = true;
            mtbCelularUm.Enabled = true;
            mtbCelularDois.Enabled = true;
            mtbFixo.Enabled = true;

            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;
            btnPesquisaCep.Enabled = true;

            btnPesquisaCliente.Enabled = false;
            txtPesquisaCliente.Enabled = false;
            dgvCliente.Enabled = false;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtNome.Focus();
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtLogradouro.Enabled = false;
            txtNumero.Enabled = false;
            txtBairro.Enabled = false;
            txtCidade.Enabled = false;
            cbxUf.Enabled = false;
            mtbCep.Enabled = false;
            mtbCelularUm.Enabled = false;
            mtbCelularDois.Enabled = false;
            mtbFixo.Enabled = false;

            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;
            btnPesquisaCep.Enabled = false;

            btnPesquisaCliente.Enabled = true;
            txtPesquisaCliente.Enabled = true;
            dgvCliente.Enabled = true;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void dataGridVazio()
        {
            if (dgvCliente.Rows.Count == 0)
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

    }
}

