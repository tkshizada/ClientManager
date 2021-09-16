using CountryData.Standard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager.Formulários
{
    public partial class frmCadastroCliente : Form
    {
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
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            controlador.IntegrarPropriedades(0, txtCpf.Text, txtNome.Text, Convert.ToDateTime(txtDataNascimento.Text), txtIdade.Text, txtCep.Text, txtRua.Text, txtBairro.Text, txtNumero.Text, txtComplemento.Text, txtProfissao.Text, txtCidade.Text, txtUF.Text, txtTelefone.Text, txtCelular.Text, txtSexo.Text, txtEstadoCivil.Text, txtNacionalidade.Text);

            if (controlador.Adicionar())
            {
                MessageBox.Show("O cadastro foi salvo!", "Funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MessageBox.Show("O cadastro não foi salvo!", "Não funcionou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
        }

        #region Métodos

        private string CalculoIdade()
        {
            string idade = "";

            idade = (DateTime.Now.Year - txtDataNascimento.Value.Year).ToString();

            return idade;
        }


        #endregion

        private void txtDataNascimento_Leave(object sender, EventArgs e)
        {
            txtIdade.Text = CalculoIdade();
        }
    }
}