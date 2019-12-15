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

    public partial class frm_Rota : Form
    {
        cls_AcaoNaTela acaoNaTela = new cls_AcaoNaTela();
        int idRota;

        public frm_Rota()
        {
            InitializeComponent();
            //Não Gerar linhas automaticamente
            dgvPedagio.AutoGenerateColumns = false;
        }

        /// <summary>
        /// Manipulação dos Objetos do Formulário
        /// </summary>
        private void carregaGrid()
        {
            //    Verificar se tem algum registro selecionado
            if (dgvRota.SelectedRows.Count == 0)
            {
                return;
            }

            //Pegar o registro selecionado no grid
            //Rota rota = (dgvRota.SelectedRows[0].DataBoundItem as Rota);
            //cbxOrigem.ValueMember = rota.Origem.ToString();
            //cbxDestino.ValueMember = rota.Destino.ToString();
            //txtDistancia.Text = rota.Km.ToString();
            //txtDuracao.Text = rota.Horas.ToString();
            carregaComboBox();

            atualizarGrid();

            if (dgvPedagio.Rows.Count == 0)
            {
                limparCampos();
            }

            dataGridVazio();
        }
        private void carregaComboBox()
        {
            RotaNegocios rotaNegocios = new RotaNegocios();
            RotaColecao rotaColecao = new RotaColecao();

            rotaColecao = rotaNegocios.CarregaComboOrigem();

            cbxOrigem.DataSource = rotaColecao;

            cbxOrigem.ValueMember = "Codigo";
            cbxOrigem.DisplayMember = "Origem";

        }
        private void carregaComboBoxDestino()
        {
            RotaNegocios rotaNegocios = new RotaNegocios();
            RotaColecao rotaColecao = new RotaColecao();

            rotaColecao = rotaNegocios.CarregaComboDestino(cbxOrigem.Text);

            cbxDestino.DataSource = rotaColecao;

            cbxDestino.ValueMember = "Codigo";
            cbxDestino.DisplayMember = "Destino";
        }
        private void carregaGridPedagio()
        {
            PedagioNegocios pedagioNegocios = new PedagioNegocios();
            PedagioColecao pedagioColecao = pedagioNegocios.PedagioRota(Convert.ToInt32(dgvRota.CurrentRow.Cells["Codigo"].Value));

            dgvPedagio.DataSource = null;
            dgvPedagio.DataSource = pedagioColecao;

            dgvPedagio.Update();
            dgvPedagio.Refresh();

            dgvPedagio.ClearSelection();
        }
        private void carregaGridPedagioCadastro()
        {
            PedagioNegocios pedagioNegocios = new PedagioNegocios();
            PedagioColecao pedagioColecao = pedagioNegocios.ConsultarPorNome("");

            dgvPedCadastrar.DataSource = null;
            dgvPedCadastrar.DataSource = pedagioColecao;

            dgvPedCadastrar.Update();
            dgvPedCadastrar.Refresh();
        }
        private void habilitarCampos()
        {
            cbxOrigem.Enabled = true;
            cbxDestino.Enabled = true;
            btnCalcularDistancia.Enabled = true;
            dgvPedCadastrar.Enabled = true;

            btnConfirmar.Enabled = true;
            btnCancelar.Enabled = true;

            dgvRota.Enabled = false;
            dgvPedagio.Enabled = false;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;

            cbxOrigem.Focus();
        }
        private void desabilitarCampos()
        {
            cbxOrigem.Enabled = false;
            cbxDestino.Enabled = false;
            btnCalcularDistancia.Enabled = false;
            dgvPedCadastrar.Enabled = false;

            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;

            dgvRota.Enabled = true;
            dgvPedagio.Enabled = true;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;

            dgvPedCadastrar.DataSource = null;
        }
        private void atualizarGrid()
        {
            RotaNegocios rotaNegocios = new RotaNegocios();
            RotaColecao rotaColecao = rotaNegocios.ConsultarPorNome("");

            dgvRota.DataSource = null;
            dgvRota.DataSource = rotaColecao;

            dgvRota.Update();
            dgvRota.Refresh();

            dataGridVazio();

        }
        private void limparCampos()
        {
            cbxOrigem.Text = null;
            cbxDestino.Text = null;
            txtDistancia.Text = "";
            txtDuracao.Text = "";
        }
        private void dataGridVazio()
        {
            //dgvRota.Columns[0].Visible = false;
           // dgvRota.Columns[3].Visible = false;
           // dgvRota.Columns[4].Visible = false;

            if (dgvRota.Rows.Count == 0)
            {
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                limparCampos();
            }
            else
            {
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
            }

        }
        private void gravaPedagioRota()
        {
            //Verificar se é inserção ou alteração
            if (acaoNaTela == cls_AcaoNaTela.Inserir)
            {
                for (int t = 0; t < dgvPedCadastrar.Rows.Count; t++)
                {
                    try
                    {
                        if (dgvPedCadastrar.Rows[t].Cells[0].Selected == true)
                        {
                            PedagioRota pedagioRota = new PedagioRota();
                            pedagioRota.CodigoRota = idRota;
                            pedagioRota.CodigoPedagio =Convert.ToInt32(dgvPedCadastrar.Rows[t].Cells[0].Value.ToString());

                            PedagioRotaNegocios pedagioRotaNegocios = new PedagioRotaNegocios();
                            string retorno = pedagioRotaNegocios.Inserir(pedagioRota);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro " + ex.Message);
                    }                
                }
            }
            else if (acaoNaTela == cls_AcaoNaTela.Alterar)
            {
                for (int t = 0; t < dgvPedCadastrar.Rows.Count; t++)
                {
                    try
                    {
                        if (dgvPedCadastrar.Rows[t].Cells[0].Selected == true)
                        {
                            //MessageBox.Show(dgvPedCadastrar.SelectedRows[t].Cells[0].Value.ToString());
                            PedagioRota pedagioRota = new PedagioRota();
                            //Rota rotaSelecionado = (dgvRota.SelectedRows[0].DataBoundItem as Rota);
                            //pedagioRota.Codigo = rotaSelecionado.Codigo;
                            MessageBox.Show(dgvPedCadastrar.SelectedRows[t].Cells[0].Value.ToString());

                            pedagioRota.CodigoRota = Convert.ToInt32(dgvPedCadastrar.Rows[t].Cells[0].Value.ToString());
                            pedagioRota.CodigoPedagio = Convert.ToInt32(dgvPedCadastrar.Rows[t].Cells[0].Value.ToString());

                            PedagioRotaNegocios pedagioRotaNegocios = new PedagioRotaNegocios();
                            string retorno = pedagioRotaNegocios.Alterar(pedagioRota);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("erro " + ex.Message);
                    }
                }
            }
        }
        private void gravaRota()
        {
            //Verificar se é inserção ou alteração
            if (acaoNaTela == cls_AcaoNaTela.Inserir)
            {
                try
                {
                    Rota rota = new Rota();
                    rota.Origem = cbxOrigem.Text;
                    rota.Destino = cbxDestino.Text;
                    rota.Km = txtDistancia.Text.ToString();
                    rota.Horas = txtDuracao.Text.ToString();

                    RotaNegocios rotaNegocios = new RotaNegocios();
                    string retorno = rotaNegocios.Inserir(rota);

                    try
                    {
                        idRota = Convert.ToInt32(retorno);
                        MessageBox.Show("Rota Inserido com Sucesso. \nCódigo da Rota: " + idRota, "Código da Rota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gravaPedagioRota();
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível adicionar a Rota.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível adicionar uma nova Rota.\nPreencha todos os campos Corretamente.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acaoNaTela == cls_AcaoNaTela.Alterar)
            {
                try
                {
                    MessageBox.Show("Alteração");

                    Rota rota = new Rota();
                    Rota rotaSelecionado = (dgvRota.SelectedRows[0].DataBoundItem as Rota);

                    rota.Codigo = rotaSelecionado.Codigo;
                    rota.Origem = cbxOrigem.Text;
                    rota.Destino = cbxDestino.Text;
                    rota.Km = txtDistancia.Text;
                    rota.Horas = txtDuracao.Text;

                    RotaNegocios rotaNegocios = new RotaNegocios();
                    string retorno = rotaNegocios.Alterar(rota);

                    try
                    {
                        idRota = Convert.ToInt32(retorno);
                        MessageBox.Show("Rota Alterado com Sucesso. \nCódigo da Rota: " + idRota, "Código da Rota", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gravaPedagioRota();
                        desabilitarCampos();
                        atualizarGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Não foi possível alterar a Rota.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível alterar um nova Rota.\nErro: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void fechaCampos()
        {
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnConfirmar.Enabled = false;
            btnCancelar.Enabled = false;

            btnNovo.Enabled = true;
        }

        private void btnCalcularDistancia_Click(object sender, EventArgs e)
        {
            frm_CalcDist calcDist = new frm_CalcDist();
            calcDist.ShowDialog();

            cbxOrigem.Text = calcDist.ExibeOrigem;
            cbxDestino.Text = calcDist.ExibeDestino;
            txtDistancia.Text = calcDist.ExibeDistancia;
            txtDuracao.Text = calcDist.ExibeDuracao;

            //Arruma tudo e carrega os datagrids
            carregaComboBox();

            atualizarGrid();

            if (dgvPedagio.Rows.Count == 0)
            {
                limparCampos();
            }

            dataGridVazio();
        }
        private void frm_Rota_Load(object sender, EventArgs e)
        {
            carregaComboBox();

            atualizarGrid();

            if (dgvRota.Rows.Count == 0)
            {
                limparCampos();
            }

            dataGridVazio();

            //cbxOrigem.Enabled = false;
            //cbxOrigem.Items.Add("Teste");
            //cbxOrigem.Text = "Teste";

        }
        private void cbxOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboBoxDestino();
        }
        private void dgvPedCadastrar_SelectionChanged(object sender, EventArgs e)
        {
            //for (int t = 0; t < dgvPedCadastrar.Rows.Count; t++)
            //{
            //    if (dgvPedCadastrar.Rows[t].Cells[0].Selected == true)
            //    {
            //        MessageBox.Show(dgvPedCadastrar.Rows[t].Cells[0].Value.ToString());
            //    }
            //}
        }

        /// <summary>
        /// Comandos do DataGridView
        /// </summary>
        private void dgvRota_SelectionChanged(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dgvRota.SelectedRows.Count == 0)
            {
                return;
            }

            //Pegar o registro selecionado no grid
            Rota rota = (dgvRota.SelectedRows[0].DataBoundItem as Rota);

            cbxOrigem.Text = rota.Origem.ToString();
            cbxDestino.Text = rota.Destino.ToString();
            txtDistancia.Text = rota.Km.ToString();
            txtDuracao.Text = rota.Horas.ToString();

            carregaGridPedagio();
        }

        /// <summary>
        /// Manipulação do Banco de Dados
        /// </summary>
        private void btnNovo_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            limparCampos();
            acaoNaTela = cls_AcaoNaTela.Inserir;
            carregaGridPedagioCadastro();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarCampos();
            acaoNaTela = cls_AcaoNaTela.Alterar;
            carregaGridPedagioCadastro();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvRota.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhuma Rota selecionado!");
                return;
            }

            if (MessageBox.Show("Deseja excluir a Rota selecionado da lista?", "Exclusão.", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Pegar a Rora selecionado no dataGrid
                Rota rotaSelecionado = (dgvRota.SelectedRows[0].DataBoundItem as Rota);

                //Instanciar a regra de negócio
                RotaNegocios rotaNegocios = new RotaNegocios();
                string retorno = rotaNegocios.Excluir(rotaSelecionado);

                //Verificar se excluiu com sucesso
                //Se o retorno for um número é porque deu certo, senaõ é a mensagem de erro
                try
                {

                    int codfunc = Convert.ToInt32(retorno);
                    MessageBox.Show("Rota Deletado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            gravaRota();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Verificar se tem algum registro selecionado
            if (dgvRota.SelectedRows.Count == 0)
            {
                fechaCampos();
                return;
            }

            //Pegar o registro selecionado no grid
            Rota rota = (dgvRota.SelectedRows[0].DataBoundItem as Rota);

            cbxOrigem.Text = rota.Origem.ToString();
            cbxDestino.Text = rota.Destino.ToString();
            txtDistancia.Text = rota.Km.ToString();
            txtDuracao.Text = rota.Horas.ToString();

            desabilitarCampos();
        }

    }
}