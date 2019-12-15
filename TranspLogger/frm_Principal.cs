using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranspLogger
{
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btnAjudante_Click(object sender, EventArgs e)
        {
            frm_Ajudante Ajudante = new frm_Ajudante();
            Ajudante.ShowDialog();
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            frm_Cliente Cliente = new frm_Cliente();
            Cliente.ShowDialog();
        }
        private void menuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja encerrar a aplicação?","Fechar Aplicação",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMapa_Click(object sender, EventArgs e)
        {
            frm_CalcDist CalcDist = new frm_CalcDist();
            CalcDist.ShowDialog();
        }
        private void btnImprevisto_Click(object sender, EventArgs e)
        {
            frm_Imprevisto Imprevisto = new frm_Imprevisto();
            Imprevisto.ShowDialog();
        }
        private void btnPedagio_Click(object sender, EventArgs e)
        {
            frm_Pedagio pedagio = new frm_Pedagio();
            pedagio.ShowDialog();
        }
        private void btnRota_Click(object sender, EventArgs e)
        {
            frm_Rota rota = new frm_Rota();
            rota.ShowDialog();
        }

        private void btnFrete_Click(object sender, EventArgs e)
        {
            frm_Frete frete = new frm_Frete();
            frete.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void frm_Principal_Load(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
