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
    public partial class frmCadastroEmpresa : Form
    {
        Controlador.EmpresaControlador EmpresaControlador = new Controlador.EmpresaControlador();
        public bool edita = false;
        public string cnpj = "";
        public string codEmpresa = "";
        private DataTable dt;
        private string query = "";
        private SqlCommand sqlCommand;
        private Classes.Conexao conexao = new Classes.Conexao();



        public frmCadastroEmpresa()
        {
            InitializeComponent();
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                if (edita == false)
                {
                    EmpresaControlador.IntegrarPropriedades(txtcnpj.Text, txtcodigo.Text, txtnome.Text, Convert.ToDateTime(txtdata.Text), txtcep.Text, txtcidade.Text, txtendereco.Text, txttelefone.Text);

                    if (EmpresaControlador.Adicionar())
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
                    EmpresaControlador.IntegrarPropriedades(txtcnpj.Text, txtcodigo.Text, txtnome.Text, Convert.ToDateTime(txtdata.Text), txtcep.Text, txtcidade.Text, txtendereco.Text, txttelefone.Text);

                    if (EmpresaControlador.Atualizar())
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

        private bool ValidarCampos()
        {
            if (txtcodigo.Text == "")
            {
                MessageBox.Show("Informar Código!");
                return false;
            }

            if (txtcnpj.Text == "")
            {
                MessageBox.Show("Informar Cnpj!");
                return false;
            }

            if (txtnome.Text == "")
            {
                MessageBox.Show("Informar Nome!");
                return false;
            }

            if (txtdata.Text == "")
            {
                MessageBox.Show("Informar Data de Criação!");
                return false;
            }

            if (txtcep.Text == "")
            {
                MessageBox.Show("Informar Cep!");
                return false;
            }

            if (txtcidade.Text == "")
            {
                MessageBox.Show("Informar Cidade!");
                return false;
            }

            if (txtendereco.Text == "")
            {
                MessageBox.Show("Informar Endereço!");
                return false;
            }

            if (txttelefone.Text == "")
            {
                MessageBox.Show("Informar Telefone!");
                return false;
            }

            return true;
        }
    }
}
