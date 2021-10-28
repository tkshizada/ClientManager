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
   public class VendedorControlador
    {

        public Classes.Vendedor Vendedor = new Classes.Vendedor();
        public Classes.Conexao conexao = new Classes.Conexao();
        private SqlCommand sqlCommand;
        private string query = "";
        private DataTable dt;
        private DataGridViewRow row = null;
        private string tabela = "VENDEDOR";


        public VendedorControlador()
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

        public void IntegrarPropriedades(string rg, string codEmpresa, string cpf, string nome, DateTime dataNascimento, string idade, string cep, string rua, string numero, string complemento, string bairro, string cidade, string estado, string celular, string sexo)
        {
            Vendedor.RG = rg;
            Vendedor.COD_EMPRESA = codEmpresa;
            Vendedor.CPF = cpf;
            Vendedor.Nome = nome;
            Vendedor.DataDeNascimento = dataNascimento;
            Vendedor.Idade = idade;
            Vendedor.CEP = cep;
            Vendedor.Rua = rua;
            Vendedor.Numero = numero;
            Vendedor.Complemento = complemento;
            Vendedor.Bairro = bairro;
            Vendedor.Cidade = cidade;
            Vendedor.Estado = estado;
            Vendedor.Celular = celular;
            Vendedor.Sexo = sexo;          
        }

        public bool Adicionar()
        {

            try
            {
                bool adicionou = true;

                query = @"INSERT INTO VENDEDOR (RG, COD_EMPRESA, CPF, NOME, DATA_NASCIMENTO, IDADE, CEP, RUA, NUMERO, COMPLEMENTO, BAIRRO, CIDADE, ESTADO, CELULAR, SEXO) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}')";

                sqlCommand = new SqlCommand();
                query = string.Format(query, Vendedor.RG, Vendedor.COD_EMPRESA, Vendedor.CPF, Vendedor.Nome, Vendedor.DataDeNascimento.ToString("yyyy-MM-dd"), Vendedor.Idade, Vendedor.CEP, Vendedor.Rua, Vendedor.Numero, Vendedor.Complemento, Vendedor.Bairro, Vendedor.Cidade, Vendedor.Estado, Vendedor.Celular, Vendedor.Sexo);

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

                query = @"UPDATE VENDEDOR SET CPF = '{0}', NOME = '{1}', DATA_NASCIMENTO = '{2}', IDADE = '{3}', CEP = '{4}', RUA = '{5}', NUMERO = '{6}', COMPLEMENTO = '{7}', BAIRRO = '{8}', CIDADE = '{9}', ESTADO = '{10}', CELULAR = '{11}', SEXO = '{12}' WHERE RG = '{13}' AND COD_EMPRESA = '{14}'";

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

        private bool Excluiu(string rg, string codEmpresa)
        {
            bool excluiu = true;

            query = @"DELETE FROM VENDEDOR WHERE RG = '" + rg + "' AND COD_EMPRESA = '" + codEmpresa + "'";

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
