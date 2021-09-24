using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager.Classes
{
    public class Conexao
    {
        public SqlConnection sqlConnection = null;

        string connectionString = "";


        public Conexao()
        {
            connectionString = "Server=.;Database=ClientManager;Trusted_Connection=True;";

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            if (sqlConnection.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("Não Funcionou!");
            }
        }
    }
}
