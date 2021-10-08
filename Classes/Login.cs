using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ClientManager.Classes
{
    public class Login
    {
        public Classes.Cliente cliente = new Classes.Cliente();
        private Classes.Conexao conexao = new Classes.Conexao();
        private SqlCommand sqlCommand;
        private DataTable dt;
        private string tabela = "LOGIN";
        private string query = "";

        public Login() {

        }

        public string ObterUsuario(string usuario)
        {
            query = "SELECT * FROM " + tabela + " WHERE USUARIO = '" + usuario + "'";

            sqlCommand = new SqlCommand(query, conexao.sqlConnection);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["USUARIO"].ToString();
            }
            else
            {
                return "";
            }
        }

        public string ObterSenha(string usuario)
        {
            query = "SELECT SENHA FROM " + tabela + " WHERE USUARIO = '" + usuario + "'";

            sqlCommand = new SqlCommand(query, conexao.sqlConnection);

            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
            dt = new DataTable();

            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["SENHA"].ToString();
            }
            else
            {
                return "";
            }
        }

        public bool ValidarLogin(string usuario, string usuariotext, string senha, string senhatext)
        {
            if (usuario == usuariotext && senha == senhatext)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}