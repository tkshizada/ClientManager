using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientManager
{
    public partial class Login : Form
    {
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

        }

        private void pbSenha_Click(object sender, EventArgs e)
        {
            if (selecionou == false)
            {
                selecionou = true;
                pbSenha.Image = Properties.Resources.Aberto;
                textBox1.PasswordChar = '\0';
            }
            else
            {
                selecionou = false;
                pbSenha.Image = Properties.Resources.Fechado;
                textBox1.PasswordChar = '*';
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
    }
}
