using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TranspLogger.cls_Distancia;
using System.Data.SqlClient;
using Negocios;
using Dto;

namespace TranspLogger
{
    public partial class frm_CalcDist : Form
    {
        cls_AcaoNaTela acaoNaTela = new cls_AcaoNaTela();

        public string ExibeOrigem { get; set; }
        public string ExibeDestino { get; set; }
        public string ExibeDistancia { get; set;}
        public string ExibeDuracao { get; set; }
        public string ExibeQtdePedagio { get; set; }

        //Construtor
        public frm_CalcDist()
        {
            InitializeComponent();
        }

        private bool CalcularDistanciaEDuracao(string origem, string destino, out double distancia, out double duracao)
        {
            bool sucesso = false;
            distancia = duracao = 0;

            try
            {
                string url = string.Format(
                    "http://maps.googleapis.com/maps/api/directions/json?origin={0}&destination={1}&sensor=false",
                    origem, destino);
                System.Net.WebRequest request = System.Net.HttpWebRequest.Create(url);
                System.Net.WebResponse response = request.GetResponse();
                using (var reader = new System.IO.StreamReader(response.GetResponseStream()))
                {
                    System.Web.Script.Serialization.JavaScriptSerializer parser = new System.Web.Script.Serialization.JavaScriptSerializer();
                    string responseString = reader.ReadToEnd();
                    RootObject responseData = parser.Deserialize<RootObject>(responseString);
                    if (responseData != null)
                    {
                        double distanciaRetornada = responseData.routes.Sum(r => r.legs.Sum(l => l.distance.value));
                        double duracaoRetornada = responseData.routes.Sum(r => r.legs.Sum(l => l.duration.value));
                        if (distanciaRetornada != 0)
                        {
                            sucesso = true;
                            distancia = distanciaRetornada;
                            duracao = duracaoRetornada;
                        }
                    }
                }
            }
            catch { }

            return sucesso;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double distancia, duracao;

            if (CalcularDistanciaEDuracao(txtOrigem.Text, txtDestino.Text, out distancia, out duracao))
            {
                txtDistancia.Text = string.Format("{0:n2} km", distancia/1000);
                txtDuracao.Text = string.Format("{0:n2} min", duracao/60);
                mapaWebBrowser.Navigate(string.Format("http://maps.google.com/maps/dir/{0}/{1}", txtOrigem.Text, txtDestino.Text));
            }
            else
            {
                MessageBox.Show("Não foi possível encontrar um caminho entre a origem e o destino.\nVerifique a digitação, é necessário digitar o nome da cidade mais o estado.\nEx: Sorocaba - SP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ExibeOrigem = txtOrigem.Text.ToString();
            ExibeDestino = txtDestino.Text.ToString();
            ExibeDistancia = txtDistancia.Text.ToString();
            ExibeDuracao = txtDuracao.Text.ToString();

            try
            {
                Rota rota = new Rota();
                rota.Origem = txtOrigem.Text;
                rota.Destino = txtDestino.Text;
                rota.Km = txtDistancia.Text;
                rota.Horas = txtDuracao.Text;

                RotaNegocios rotaNegocios = new RotaNegocios();
                string retorno = rotaNegocios.Inserir(rota);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar a Rota.\nTente novamente.\nAviso: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtOrigem.Enabled = true;
            txtDestino.Enabled = true;
            txtOrigem.Text = "";
            txtDestino.Text = "";
            txtDistancia.Text = "";
            txtDuracao.Text = "";
        }

        private void frm_CalcDist_Load(object sender, EventArgs e)
        {

        }
    }
}