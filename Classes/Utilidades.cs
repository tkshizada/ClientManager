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

 
        public void ChamarFormularioBotao(bool edita, DataGridViewRow dataRow)
        {
            if (botaoSelecionado.ToUpper() == "CLIENTE")
            {
                Formulários.frmCadastroCliente frmCliente = new Formulários.frmCadastroCliente();

                if (edita == true)
                {
                    frmCliente.edita = true;
                    frmCliente.id = dataRow.Cells["ID"].Value.ToString();
                    frmCliente.cpf = dataRow.Cells["CPF"].Value.ToString();
                }
                frmCliente.ShowDialog();
            }
            else if (botaoSelecionado.ToUpper() == "VENDEDOR")
            {
                Formulários.frmCadastroVendedor frmVendedor = new Formulários.frmCadastroVendedor();
                if (edita == true)
                {         
                       frmVendedor.edita = true;
                       frmVendedor.rg = dataRow.Cells["RG"].Value.ToString();
                       frmVendedor.codEmpresa = dataRow.Cells["COD_EMPRESA"].Value.ToString();                                    
                }
                frmVendedor.ShowDialog();
            }
            else if (botaoSelecionado.ToUpper() == "EMPRESA")
            {
                Formulários.frmCadastroEmpresa frmEmpresa = new Formulários.frmCadastroEmpresa();
                if (edita == true)
                {
                    frmEmpresa.edita = true;
                    frmEmpresa.cnpj = dataRow.Cells["CNPJ"].Value.ToString();
                    frmEmpresa.codEmpresa = dataRow.Cells["COD_EMPRESA"].Value.ToString();
                }
                frmEmpresa.ShowDialog();
            }
        }



        #endregion
    }
}
