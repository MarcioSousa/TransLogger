using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class Pessoa
    {
        public int Codigo { get; set; }
        private string _nome;
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                _nome = value;
            }
        }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Uf { get; set; }
        public string Cep { get; set; }
        public string CelularUm { get; set; }
        public string CelularDois { get; set; }
        public string ContatoFixo { get; set; }
        public double Custo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
