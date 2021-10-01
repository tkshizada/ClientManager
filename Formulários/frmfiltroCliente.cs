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
    public partial class frmfiltroCliente : Form
    {
        public string condicao = "";

        public frmfiltroCliente()
        {
            InitializeComponent();
        }

        private void rbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rbID.Checked)
            {
                labelvalor.Text = "ID";

                labelvalor.Visible = true;
                txtValor.Visible = true;

                txtValor.Clear();
            }
        }

        private void rbNome_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNome.Checked)
            {
                labelvalor.Text = "Nome";

                labelvalor.Visible = true;
                txtValor.Visible = true;

                txtValor.Clear();
            }
        }

        private void rbUF_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUF.Checked)
            {
                labelvalor.Text = "UF";

                labelvalor.Visible = true;
                txtValor.Visible = true;

                txtValor.Clear();
            }
        }

        private void rbIdade_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIdade.Checked)
            {
                labelvalor.Text = "Idade";

                labelvalor.Visible = true;
                txtValor.Visible = true;

                txtValor.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            condicao = GetFiltro();
            this.Dispose();
        }

        private string GetFiltro()
        {
            if (rbID.Checked)
            {
                condicao = " WHERE ID = "+ txtValor.Text + "";
            }

            if (rbNome.Checked)
            {
                condicao = " WHERE NOME LIKE '%" + txtValor.Text + "%'";
;            }

            if (rbIdade.Checked)
            {
                condicao = " WHERE IDADE = '" + txtValor.Text + "'";
            }

            if (rbUF.Checked)
            {
                condicao = " WHERE UF = '" + txtValor.Text + "'";
            }

            if (rbTodos.Checked)
            {
                condicao = " WHERE 1 = 1";
            }

            return condicao;
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTodos.Checked)
            {
                labelvalor.Visible = false;
                txtValor.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void labelvalor_Click(object sender, EventArgs e)
        {

        }
    }
}
