using CountryData.Standard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager.Formulários
{
    public partial class frmCadastroCliente : Form
    {
        public bool edita = false;
        public string id = "";
        public string cpf = "";
        private DataTable dt;
        private string query = "";
        private SqlCommand sqlCommand;
        private Classes.Conexao conexao = new Classes.Conexao();


        Controlador.ClienteControlador controlador = new Controlador.ClienteControlador();



        public frmCadastroCliente()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCadastroCliente_Load(object sender, EventArgs e)
        {
            var country = new CountryHelper();

            var data = country.GetCountryData();

            var paises = data.Select(c => c.CountryName).ToList();

            txtNacionalidade.DataSource = paises;

            if (edita == true)
            {
                CarregaCampos();
            }


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                if (edita == false)
                {
                    controlador.IntegrarPropriedades(0, txtCpf.Text, txtNome.Text, Convert.ToDateTime(txtDataNascimento.Text), txtIdade.Text, txtCep.Text, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text, txtProfissao.Text, txtCidade.Text, txtUF.Text, txtTelefone.Text, txtCelular.Text, txtSexo.Text, txtEstadoCivil.Text, txtNacionalidade.Text);

                    if (controlador.Adicionar())
                    {
                        edita = true;

                        txtID.Text = GetMaxID().ToString();
                        controlador.cliente.ID = Convert.ToInt32(txtID.Text);

                        MessageBox.Show("O cadastro foi salvo!", "Funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("O cadastro não foi salvo!", "Não funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    controlador.IntegrarPropriedades(Convert.ToInt32(txtID.Text), txtCpf.Text, txtNome.Text, Convert.ToDateTime(txtDataNascimento.Text), txtIdade.Text, txtCep.Text, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text, txtProfissao.Text, txtCidade.Text, txtUF.Text, txtTelefone.Text, txtCelular.Text, txtSexo.Text, txtEstadoCivil.Text, txtNacionalidade.Text);

                    if (controlador.Atualizar())
                    {
                        MessageBox.Show("O cadastro foi atualizado!", "Funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("O cadastro não foi atualizado!", "Não funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
        }

        private bool ValidarCampos()
        {
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informar Nome!");
                return false;
            }

            if (txtCpf.Text == "")
            {
                MessageBox.Show("Informar CPF");
                return false;
            }

            if (txtDataNascimento.Text == "")
            {
                MessageBox.Show("Informar Data de Nascimento");
                return false;
            }

            if (txtProfissao.Text == "")
            {
                MessageBox.Show("Informar Profissão");
                return false;
            }

            if (txtTelefone.Text == "")
            {
                MessageBox.Show("Informar Telefone");
                return false;
            }

            if (txtCelular.Text == "")
            {
                MessageBox.Show("Informar Celular");
                return false;
            }

            if (txtSexo.Text == "")
            {
                MessageBox.Show("Informar Sexo");
                return false;
            }

            if (txtEstadoCivil.Text == "")
            {
                MessageBox.Show("Informar Estado Civil");
                return false;
            }

            if (txtNacionalidade.Text == "")
            {
                MessageBox.Show("Informar Nacionalidade");
                return false;
            }

            if (txtCep.Text == "")
            {
                MessageBox.Show("Informar CEP");
                return false;
            }

            if (txtNumero.Text == "")
            {
                MessageBox.Show("Informar Numero");
                return false;
            }

            if (txtCidade.Text == "")
            {
                MessageBox.Show("Informar Cidade");
                return false;
            }

            if (txtComplemento.Text == "")
            {
                MessageBox.Show("Informar Complemento");
                return false;
            }

            if (txtUF.Text == "")
            {
                MessageBox.Show("Informar UF");
                return false;
            }

            return true;
        }

        #region Métodos

        private string CalculoIdade()
        {
            int hoje = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(txtDataNascimento.Value.ToString("yyyyMMdd"));
            int age = (hoje - dob) / 10000;
            return age.ToString();

        }


        private void CarregaCampos()
        {
            DataTable dt = new DataTable();

            query = "SELECT * FROM CLIENTE WHERE ID = '" + id + "' AND CPF = '" + cpf + "'";

            sqlCommand = new SqlCommand(query, conexao.sqlConnection);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            sda.Fill(dt);

            txtBairro.Text = dt.Rows[0]["BAIRRO"].ToString();
            txtCelular.Text = dt.Rows[0]["CELULAR"].ToString();
            txtCep.Text = dt.Rows[0]["CEP"].ToString();
            txtCidade.Text = dt.Rows[0]["CIDADE"].ToString();
            txtComplemento.Text = dt.Rows[0]["COMPLEMENTO"].ToString();
            txtCpf.Text = dt.Rows[0]["CPF"].ToString();
            txtDataNascimento.Text = dt.Rows[0]["DATA_NASCIMENTO"].ToString();
            txtEstadoCivil.Text = dt.Rows[0]["ESTADO_CIVIL"].ToString();
            txtID.Text = dt.Rows[0]["ID"].ToString();
            txtIdade.Text = dt.Rows[0]["IDADE"].ToString();
            txtNacionalidade.Text = dt.Rows[0]["NACIONALIDADE"].ToString();
            txtNome.Text = dt.Rows[0]["NOME"].ToString();
            txtNumero.Text = dt.Rows[0]["NUMERO"].ToString();
            txtProfissao.Text = dt.Rows[0]["PROFISSAO"].ToString();
            txtRua.Text= dt.Rows[0]["RUA"].ToString();
            txtSexo.Text = dt.Rows[0]["SEXO"].ToString();
            txtTelefone.Text = dt.Rows[0]["TELEFONE"].ToString();
            txtUF.Text = dt.Rows[0]["UF"].ToString();
        }



        private int GetMaxID()
        {
            DataTable dt = new DataTable();

            query = "SELECT MAX(ID) AS 'ID' FROM CLIENTE";

            sqlCommand = new SqlCommand(query, conexao.sqlConnection);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCommand);

            sda.Fill(dt);

            int id = Convert.ToInt32(dt.Rows[0]["ID"]);

            return id;
        }

        #endregion

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            txtIdade.Text = CalculoIdade(   );

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDataNascimento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            if (ValidarCampos() == true)
            {
                if (edita == false)
                {
                    controlador.IntegrarPropriedades(0, txtCpf.Text, txtNome.Text, Convert.ToDateTime(txtDataNascimento.Text), txtIdade.Text, txtCep.Text, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text, txtProfissao.Text, txtCidade.Text, txtUF.Text, txtTelefone.Text, txtCelular.Text, txtSexo.Text, txtEstadoCivil.Text, txtNacionalidade.Text);

                    if (controlador.Adicionar())
                    {
                        MessageBox.Show("O cadastro foi salvo!", "Funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("O cadastro não foi salvo!", "Não funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose();
                    }
                }
                else
                {
                    controlador.IntegrarPropriedades(Convert.ToInt32(txtID.Text), txtCpf.Text, txtNome.Text, Convert.ToDateTime(txtDataNascimento.Text), txtIdade.Text, txtCep.Text, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text, txtProfissao.Text, txtCidade.Text, txtUF.Text, txtTelefone.Text, txtCelular.Text, txtSexo.Text, txtEstadoCivil.Text, txtNacionalidade.Text);

                    if (controlador.Atualizar())
                    {
                        MessageBox.Show("O cadastro foi atualizado!", "Funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("O cadastro não foi atualizado!", "Não funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Dispose();
                    }
                }
            }

           
        }
    }
}