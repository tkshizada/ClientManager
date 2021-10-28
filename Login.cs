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

namespace ClientManager
{
    public partial class Login : Form
    {
        public Classes.Cliente cliente = new Classes.Cliente();
        private Classes.Conexao conexao = new Classes.Conexao();
        private SqlCommand sqlCommand;
        private DataTable dt;
        private string tabela = "LOGIN";
        private string query = "";


        bool selecionou;

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Classes.Login login = new Classes.Login();          

            string usuario = login.ObterUsuario(txtUser.Text);
            string senha = login.ObterSenha(txtUser.Text);

            if(ValidarLogin(txtUser.Text, txtPassword.Text) == false)
            {
                return;
            }


            if (login.ValidarLogin(usuario, txtUser.Text, senha, txtPassword.Text))
            {

                MenuPrincipal menuPrincipal = new MenuPrincipal();

                menuPrincipal.ShowDialog();

                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario e/ou Senha incorretor");
            }
        }

        private void pbSenha_Click(object sender, EventArgs e)
        {
            if (selecionou == false)
            {
                selecionou = true;
                pbSenha.Image = Properties.Resources.Aberto;
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                selecionou = false;
                pbSenha.Image = Properties.Resources.Fechado;
                txtPassword.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            pbSenha.Image = Properties.Resources.Fechado;
        }

        private void pbSenha_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void pbSenha_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        #region Métodos

        private bool ValidarLogin(string usuario, string senha)
        {
            if (usuario == "" && senha == "")
            {
                MessageBox.Show("Digite Usuário e Senha!");
                return false;
            }
            else if (usuario == "")
            {
                MessageBox.Show("Digite o Usuário!");
                return false;
            }
            else if (senha == "")
            {
                MessageBox.Show("Digite a Senha");
                return false;
            }
            else 
            {
                return true;
            }
        }
     
        #endregion
    }
}
