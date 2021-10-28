using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager.Controlador
{
    class EmpresaControlador
    {
        public Classes.Empresa Empresa = new Classes.Empresa();
        public Classes.Conexao conexao = new Classes.Conexao();
        private SqlCommand sqlCommand;
        private string query = "";
        private DataTable dt;
        private DataGridViewRow row = null;
        private string tabela = "EMPRESA";

        public EmpresaControlador()
        {
        }
        #region

        public void CarregarGrid(DataGridView dgView, string condicao)
        {
            query = "SELECT * FROM " + tabela + condicao;

            sqlCommand = new SqlCommand(query, conexao.sqlConnection);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            dt = new DataTable();

            sda.Fill(dt);

            dgView.DataSource = dt;
        }


        public void IntegrarPropriedades(string cnpj, string codEmpresa, string nome, DateTime dataCriacao, string cep, string cidade, string endereco, string telefone)
        {
            Empresa.CNPJ = cnpj;
            Empresa.CodEmpresa = codEmpresa;
            Empresa.Nome = nome;
            Empresa.DataCriacao = dataCriacao;
            Empresa.CEP = cep;
            Empresa.Cidade = cidade;
            Empresa.Endereco = endereco;
            Empresa.Telefone = telefone;
        }

        public bool Adicionar()
        {
            try
            {
                bool adicionou = true;

                query = @"INSERT INTO EMPRESA (CNPJ, COD_EMPRESA, NOME, DATA_CRIACAO, CEP, CIDADE, ENDERECO, TELEFONE) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')";

                sqlCommand = new SqlCommand();
                query = string.Format(query, Empresa.CNPJ, Empresa.CodEmpresa, Empresa.Nome, Empresa.DataCriacao.ToString("yyyy-MM-dd"), Empresa.CEP, Empresa.Cidade, Empresa.Endereco, Empresa.Telefone);

                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.CommandText = query;

                sqlCommand.Connection = conexao.sqlConnection;

                if (sqlCommand.ExecuteNonQuery() > 0)
                {
                    adicionou = true;
                }
                else
                {
                    adicionou = false;
                }

                return adicionou;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                return false;
            }
        }

        public bool Atualizar()
        {
            {
                bool alterou = true;

                query = @"UPDATE EMPRESA SET NOME = '{0}', DATA_CRIACAO = '{1}', CEP = '{2}', CIDADE = '{3}', ENDERECO = '{4}', TELEFONE = '{5} WHERE CNPJ = '{6}' AND COD_EMPRESA = '{7}'";

                sqlCommand = new SqlCommand();
                query = string.Format(query, Empresa.Nome, Empresa.DataCriacao.ToString("yyyy-MM-dd"), Empresa.CEP, Empresa.Cidade, Empresa.Endereco, Empresa.Telefone, Empresa.CNPJ, Empresa.CodEmpresa);

                sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;

            sqlCommand.Connection = conexao.sqlConnection;

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                alterou = true;
            }
            else
            {
                alterou = false;
            }

            return alterou;
            }
        }
        
          public bool Excluiu(string cnpj, string codEmpresa)
        {
            bool excluiu = true;

            query = @"DELETE FROM EMPRESA WHERE CNPJ = '" + cnpj + "' AND COD_EMPRESA = '" + codEmpresa + "'";

            sqlCommand = new SqlCommand();

            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = query;

            sqlCommand.Connection = conexao.sqlConnection;

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                excluiu = true;
            }
            else
            {
                excluiu = false;
            }

            return excluiu;
        }
        #endregion
    }
}

































































