using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager.Controlador
{
    public class ClienteControlador
    {
        public Classes.Cliente cliente = new Classes.Cliente();
        private Classes.Conexao conexao = new Classes.Conexao();
        private SqlCommand sqlCommand;
        private string query = "";
        private DataTable dt;
        private DataGridViewRow row = null;
        private string tabela = "CLIENTE";

        public ClienteControlador()
        {

        }

        #region Métodos

        public void CarregarGrid(DataGridView dgView, string condicao)
        {
            query = "SELECT * FROM " + tabela + condicao;

            sqlCommand = new SqlCommand(query, conexao.sqlConnection);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            dt = new DataTable();

            sda.Fill(dt);

            dgView.DataSource = dt;
        }

        public void IntegrarPropriedades(int id, string cpf, string nome, DateTime dataNascimento, string idade, string cep, string rua, string bairro, string numero, string complemento, string profissao, string cidade, string uf, string telefone, string celular, string sexo, string estadoCivil, string nacionalidade)
        {
            cliente.ID = id;
            cliente.CPF = cpf;
            cliente.Nome = nome;
            cliente.DataDeNascimento = dataNascimento;
            cliente.Idade = idade;
            cliente.CEP = cep;
            cliente.Rua = rua;
            cliente.Bairro = bairro;
            cliente.Numero = numero;
            cliente.Complemento = complemento;
            cliente.Profissao = profissao;
            cliente.Cidade = cidade;
            cliente.UF = uf;
            cliente.Telefone = telefone;
            cliente.Celular = celular;
            cliente.Sexo = sexo;
            cliente.EstadoCivil = estadoCivil;
            cliente.Nacionalidade = nacionalidade;

        }

        public bool Adicionar()
        {
            try
            {
                bool adicionou = true;

                query = @"INSERT INTO CLIENTE (ID, CPF, NOME, DATA_NASCIMENTO, IDADE, CEP, RUA, BAIRRO, NUMERO, COMPLEMENTO, PROFISSAO, CIDADE, UF, TELEFONE, CELULAR, SEXO, ESTADO_CIVIL, NACIONALIDADE) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}')";

                sqlCommand = new SqlCommand();
                query = string.Format(query,cliente.ID, cliente.CPF, cliente.Nome, cliente.DataDeNascimento.ToString("yyyy-MM-dd"), cliente.Idade, cliente.CEP, cliente.Rua, cliente.Bairro, cliente.Numero, cliente.Complemento, cliente.Profissao, cliente.Cidade, cliente.UF, cliente.Telefone, cliente.Celular, cliente.Sexo, cliente.EstadoCivil, cliente.Nacionalidade);

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
            bool alterou = true;

            query = @"UPDATE CLIENTE SET NOME = '{0}', DATA_NASCIMENTO = '{1}', IDADE = '{2}', CEP = '{3}', RUA = '{4}', BAIRRO = '{5}', NUMERO = '{6}', COMPLEMENTO = '{7}', PROFISSAO = '{8}', CIDADE = '{9}', UF = '{10}', TELEFONE = '{11}', CELULAR = '{12}', SEXO = '{13}', ESTADO_CIVIL = '{14}', NACIONALIDADE = '{15}' WHERE ID = {16} AND CPF = '{17}'";

            sqlCommand = new SqlCommand();
            query = string.Format(query, cliente.Nome, cliente.DataDeNascimento.ToString("yyyy-MM-dd"), cliente.Idade, cliente.CEP, cliente.Rua, cliente.Bairro, cliente.Numero, cliente.Complemento, cliente.Profissao, cliente.Cidade, cliente.UF, cliente.Telefone, cliente.Celular, cliente.Sexo, cliente.EstadoCivil, cliente.Nacionalidade, cliente.ID, cliente.CPF);

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

        public bool Excluir(int id, string cpf)
        {
            bool excluiu = true;

            query = @"DELETE FROM CLIENTE WHERE ID = " + id + " AND CPF = '" + cpf + "'";

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
