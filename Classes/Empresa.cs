using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientManager.Classes
{
    public class Empresa
    {
        public Empresa()
        { }

        public string CNPJ { get; set; }

        public string CodEmpresa { get; set; }

        public string Nome { get; set; }

        public DateTime DataCriacao { get; set; }

        public string CEP { get; set; }

        public string Cidade { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }
    }
}
