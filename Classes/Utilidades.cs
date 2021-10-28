using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ClientManager.Classes
{
    public class Utilidades
    {
        #region Variáveis

        public string botaoSelecionado = "";
        private DataGridViewRow row = null;
        public bool edita = false;
        private SqlCommand sqlCommand;
        private string query = "";
        public string condicao = "";
        public Classes.Conexao conexao = new Classes.Conexao();
        private DataTable dt;

        #endregion

        #region Construtor

        public Utilidades()
        {

        }

        #endregion

        #region Métodos

        public void CarregarGridDinamica(DataGridView dgView)
        {
            switch (botaoSelecionado.ToUpper())
            {
                case "CLIENTE":

                    CarregaGridByMenu(dgView, "CLIENTE");

                    break;

                case "EMPRESA":

                    CarregaGridByMenu(dgView, "EMPRESA");

                    break;

                case "VENDEDOR":

                    CarregaGridByMenu(dgView, "VENDEDOR");

                    break;
                default:
                    break;
            }
        }

        private void CarregaGridByMenu(DataGridView dgView, string menu)
        {
            try
            {
                query = "SELECT * FROM "+ menu +"" + condicao;

                sqlCommand = new SqlCommand(query, conexao.sqlConnection);

                SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);
                dt = new DataTable();

                sda.Fill(dt);

                dgView.DataSource = dt;
            }
            catch (Exception)
            {
                throw;
            }
        }




        #endregion
    }
}
