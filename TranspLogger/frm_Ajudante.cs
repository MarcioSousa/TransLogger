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
    public partial class frm_Ajudante : Form
    {
        cls_AcaoNaTela acaoNaTela = new cls_AcaoNaTela();

        //Construtor
        public frm_Ajudante()
        {
            InitializeComponent();

            //Não gerar linhas automaticamente
            dgvAjudante.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Comandos do DataGridView
        /// </summary>
        private void dgvAjudante_SelectionChanged(object sender, EventArgs e)
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
            } else
            {
                MessageBox.Show("Cep não encontrado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                mtbCep.Text = "";
                txtLogradouro.Focus();
            }
        }
        private void btnPesquisaAjudante_Click(object sender, EventArgs e)
        {
            atualizarGrid();
            
            if (dgvAjudante.Rows.Count == 0)
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
            if(dgvAjudante.SelectedRows.Count  == 0)
            {
                MessageBox.Show("Nenhum Ajudante selecionado!");
                return;
            }

            if(MessageBox.Show("Deseja excluir o Ajudante selecionado da lista?", "Exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Pegar o ajudante selecionado no dataGrid
                Pessoa funcionarioSelecionado = (dgvAjudante.SelectedRows[0].DataBoundItem as Pessoa);

                //Instanciar a regra de negócio
                AjudanteNegocios ajudanteNegocios = new AjudanteNegocios();
                string retorno = ajudanteNegocios.Excluir(funcionarioSelecionado);

                //Verificar se excluiu com sucesso
                //Se o retorno for um número é porque deu certo, senaõ é a mensagem de erro
                try
                {

                    int codfunc = Convert.ToInt32(retorno);
                    MessageBox.Show("Ajudante Deletado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    atualizarGrid();
                }
                catch
                {
                    MessageBox.Show("Não foi possível excluir. Detalhes: " + retorno, "Atenção",MessageBoxButtons.OK,MessageBoxIcon.Error);

                }      
            }
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            //Verificar se é inserção ou alteração
            if(acaoNaTela == cls_AcaoNaTela.Inserir)
            {
                try
                {
                    //string Cep;
                    //Cep = mtbCep.Text.Replace("-","");

                    Pessoa ajudante = new Pessoa();
                    ajudante.Nome = txtNome.Text;
                    ajudante.Custo = Convert.ToDouble(txtCusto.Text);
                    ajudante.Logradouro = txtLogradouro.Text;
                    ajudante.Numero = txtNumero.Text.ToString();
                    ajudante.Bairro = txtBairro.Text;
                    ajudante.Cidade = txtCidade.Text;
                    ajudante.Uf = cbxUf.Text;
                    ajudante.Cep = Convert.ToString(mtbCep.Text.Replace("-",""));
                    ajudante.CelularUm = Convert.ToString(mtbCelularUm.Text.Replace("(","").Replace(")","").Replace(" ","").Replace("-",""));
                    ajudante.CelularDois = Convert.ToString(mtbCelularDois.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""));
                    ajudante.ContatoFixo = Convert.ToString(mtbFixo.Text.Replace("(", "").Replace(") ", "").Replace("-", ""));

                    AjudanteNegocios ajudanteNegocios = new AjudanteNegocios();
                    string retorno = ajudanteNegocios.Inserir(ajudante);

                    try
                    {
                        int idAjudante = Convert.ToInt32(retorno);
                        MessageBox.Show("Ajudante Inserido com Sucesso. \nCódigo do Ajudante: " + idAjudante, "Código do Ajudante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível adicionar o Ajudante.\nTente novamente.\nAviso: "+ ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                } catch(Exception ex)
                {
                    MessageBox.Show("Não foi possível adicionar um novo Ajudante.\nPreencha todos os campos Corretamente.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
            else if (acaoNaTela == cls_AcaoNaTela.Alterar)
            {
                try
                {
                    Pessoa ajudante = new Pessoa();
                    ajudante.Codigo =Convert.ToInt32(lblCodigo.Text);
                    ajudante.Nome = txtNome.Text;
                    ajudante.Custo = Convert.ToDouble(txtCusto.Text);
                    ajudante.Logradouro = txtLogradouro.Text;
                    ajudante.Numero = txtNumero.Text.ToString();
                    ajudante.Bairro = txtBairro.Text;
                    ajudante.Cidade = txtCidade.Text;
                    ajudante.Uf = cbxUf.Text;
                    ajudante.Cep = Convert.ToString(mtbCep.Text.Replace("-",""));
                    ajudante.CelularUm = Convert.ToString(mtbCelularUm.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""));
                    ajudante.CelularDois = Convert.ToString(mtbCelularDois.Text.Replace("(", "").Replace(")", "").Replace(" ", "").Replace("-", ""));
                    ajudante.ContatoFixo = Convert.ToString(mtbFixo.Text.Replace("(", "").Replace(") ", "").Replace("-", ""));


                    AjudanteNegocios ajudanteNegocios = new AjudanteNegocios();
                    string retorno = ajudanteNegocios.Alterar(ajudante);

                    try
                    {
                        int idAjudante = Convert.ToInt32(retorno);
                        MessageBox.Show("Ajudante Alterado com Sucesso. \nCódigo do Ajudante: " + idAjudante, "Código do Ajudante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível alterar o Ajudante.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível alterar um novo Ajudante.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (dgvAjudante.SelectedRows.Count == 0)
            {
                return;
            }

            //Pegar o registro selecionado no grid
            Pessoa Ajudante = (dgvAjudante.SelectedRows[0].DataBoundItem as Pessoa);
            lblCodigo.Text = Ajudante.Codigo.ToString();
            txtNome.Text = Ajudante.Nome;
            txtCusto.Text = string.Format("{0:f2}", Ajudante.Custo);
            txtLogradouro.Text = Ajudante.Logradouro;
            txtNumero.Text = Ajudante.Numero;
            txtBairro.Text = Ajudante.Bairro;
            txtCidade.Text = Ajudante.Cidade;
            cbxUf.Text = Ajudante.Uf;

            if(Ajudante.Cep != "0")
            {
                mtbCep.Text = Convert.ToString(Ajudante.Cep);
            }
            else
            {
                mtbCep.Text = "";
            }

            if(Ajudante.CelularUm != "0")
            {
                mtbCelularUm.Text = Convert.ToString(Ajudante.CelularUm);
            }
            else
            {
                mtbCelularUm.Text = "";
            }
            
            if(Ajudante.CelularDois != "0")
            {
                mtbCelularDois.Text = Convert.ToString(Ajudante.CelularDois);
            }
            else
            {
                mtbCelularDois.Text = "0";
            }

            if(mtbFixo.Text != "0")
            {
                mtbFixo.Text = Convert.ToString(Ajudante.ContatoFixo);
            }
            else
            {
                mtbFixo.Text = "";
            }
        }
        private void atualizarGrid()
        {
            AjudanteNegocios ajudanteNegocios = new AjudanteNegocios();
            AjudanteColecao ajudanteColecao = ajudanteNegocios.ConsultarPorNome(txtPesquisaAjudante.Text);

            dgvAjudante.DataSource = null;
            dgvAjudante.DataSource = ajudanteColecao;

            dgvAjudante.Update();
            dgvAjudante.Refresh();

            dataGridVazio();
        }
        private void limparCampos()
        {
            lblCodigo.Text = "0";
            txtNome.Text = "";
            txtCusto.Text = "0";
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
            txtCusto.Enabled = true;
            txtLogradouro.Enabled = true ;
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

            btnPesquisaAjudante.Enabled = false;
            txtPesquisaAjudante.Enabled = false;
            dgvAjudante.Enabled = false;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            txtNome.Focus();
        }
        private void desabilitarCampos()
        {
            txtNome.Enabled = false;
            txtCusto.Enabled = false;
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

            btnPesquisaAjudante.Enabled = true;
            txtPesquisaAjudante.Enabled = true;
            dgvAjudante.Enabled = true;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        private void dataGridVazio()
        {
            if (dgvAjudante.Rows.Count == 0)
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                lblCodigo.Text = "0";
                limparCampos();
            }else
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }
        }

        private void frm_Ajudante_Load(object sender, EventArgs e)
        {
            dataGridVazio();
        }

        private void txtCusto_Leave(object sender, EventArgs e)
        {
            if(Convert.ToString(txtCusto.Text) == "")
            {
                txtCusto.Text = "0";
            }
        }
    }
}