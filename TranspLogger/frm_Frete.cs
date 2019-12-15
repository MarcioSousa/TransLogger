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
    public partial class frm_Frete : Form
    {
        public frm_Frete()
        {
            InitializeComponent();
        }

        private void carregaGridAjudante()
        {
            AjudanteNegocios ajudanteNegocios = new AjudanteNegocios();
            AjudanteColecao ajudanteColecao = ajudanteNegocios.ConsultarPorNome("");

            dgvAjudante.DataSource = null;
            dgvAjudante.DataSource = ajudanteColecao;

            dgvAjudante.Update();
            dgvAjudante.Refresh();

            //Limpa O grid deixando somente o nome do Ajudante
            for(int t = 0; t < 13; t++)
            {
                if(t != 1)
                 dgvAjudante.Columns[t].Visible = false;
            }
            dgvAjudante.Columns[1].Width = 200;
        }
        private void carregaGridImprevisto()
        {
            ImprevistoNegocios imprevistoNegocios = new ImprevistoNegocios();
            ImprevistoColecao imprevistoColecao = imprevistoNegocios.ConsultarPorNome("");

            dgvImprevisto.DataSource = null;
            dgvImprevisto.DataSource = imprevistoColecao;

            dgvImprevisto.Update();
            dgvImprevisto.Refresh();

            //Limpa o Grid deixandos somente o nome do imprevisto
            for (int t = 0; t < 2; t++)
            {
                if (t != 1)
                    dgvImprevisto.Columns[t].Visible = false;
            }
            dgvImprevisto.Columns[1].Width = 200;

        }
        private void carregaComboOrigem()
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
        private void carregaGridFrete()
        {
            PedagioNegocios pedagioNegocios = new PedagioNegocios();
            PedagioColecao pedagioColecao = pedagioNegocios.PedagioRotaFrete(cbxOrigem.Text,cbxDestino.Text);

            dgvPedagio.DataSource = null;
            dgvPedagio.DataSource = pedagioColecao;

            dgvPedagio.Update();
            dgvPedagio.Refresh();

            dgvPedagio.ClearSelection();

            dgvPedagio.Columns[0].Visible = false;
            dgvPedagio.Columns[1].Width = 250;

        }
        private void frm_Frete_Load(object sender, EventArgs e)
        {
            limpaLabels();
            carregaGridAjudante();
            carregaGridImprevisto();
            carregaComboOrigem();
            cbxOrigem.Text = "";
            cbxDestino.Text = "";
        }
        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                carregaCliente();
            }
            else
            {
                limpaLabels();
            }
        }

        private void limpaLabels()
        {
            lblLogradouro.Text = "";
            lblNumero.Text = "";
            lblBairro.Text = "";
            lblCidade.Text = "";
            lblUf.Text = "";
            lblCep.Text = "";
            lblCelularUm.Text = "";
            lblCelularDois.Text = "";
            lblContatoFixo.Text = "";
        }
        private void carregaCliente()
        {
            AjudanteNegocios ajudanteNegocios = new AjudanteNegocios();
            AjudanteColecao ajudanteColecao = ajudanteNegocios.ConsultarPorCodigo(Convert.ToInt32(txtCodigo.Text));
            try
            {
                txtNome.Text = ajudanteColecao[0].Nome;
                lblLogradouro.Text = ajudanteColecao[0].Logradouro;
                lblNumero.Text = ajudanteColecao[0].Numero;
                lblBairro.Text = ajudanteColecao[0].Bairro;
                lblCidade.Text = ajudanteColecao[0].Cidade;
                lblUf.Text = ajudanteColecao[0].Uf;
                lblCep.Text = ajudanteColecao[0].Cep;
                lblCelularUm.Text = ajudanteColecao[0].CelularUm;
                lblCelularDois.Text = ajudanteColecao[0].CelularDois;
                lblContatoFixo.Text = ajudanteColecao[0].ContatoFixo;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ajudante não existe. Erro: " + ex.Message, "Inexistente.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCodigo.Text = "";
                txtNome.Text = "";
                txtCodigo.Focus();
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dgvFrete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAjudante_Click(object sender, EventArgs e)
        {
            if(dgvAjudante.Visible)
            {
                dgvAjudante.Visible = false;
            }
            else
            {
                dgvAjudante.Visible = true;
            }
        }

        private void btnImprevisto_Click(object sender, EventArgs e)
        {
            if (dgvImprevisto.Visible)
            {
                dgvImprevisto.Visible = false;
            }else
            {
                dgvImprevisto.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dgvImprevisto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaComboBoxDestino();
        }

        private void cbxDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaGridFrete();
        }

        private void btnCadastrarEntrega_Click(object sender, EventArgs e)
        {
            int ajudanteb, imprevistob;

            if(dgvAjudante.Visible == true)
            {
                ajudanteb = dgvAjudante.ColumnCount;
                MessageBox.Show(ajudanteb.ToString());
            }
        }
    }
}