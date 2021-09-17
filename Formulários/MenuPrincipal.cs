using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CountryData;
using CountryData.Standard;

namespace ClientManager
{
    public partial class MenuPrincipal : Form
    {

        private DataGridViewRow row = null;
        public bool edita = false;
        public string id = "";

        Controlador.ClienteControlador controlador = new Controlador.ClienteControlador();

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Controlador.ClienteControlador clienteControlador = new Controlador.ClienteControlador();

            clienteControlador.CarregarGrid(dgPrincipal);
        }


        private void ChamarFormulario(string tabela, bool edicao) 
        {
            switch (tabela)
            {
                case "CLIENTE":
                    Formulários.frmCadastroCliente frmCadastroCliente = new Formulários.frmCadastroCliente();

                    if (edicao == true)
                    {
                        row = dgPrincipal.Rows[dgPrincipal.CurrentRow.Index];
                        frmCadastroCliente.edita = true;
                        frmCadastroCliente.id = row.Cells["ID"].Value.ToString();
                        frmCadastroCliente.cpf = row.Cells["CPF"].Value.ToString();
                    }

                    frmCadastroCliente.ShowDialog();
                    Controlador.ClienteControlador clienteControlador = new Controlador.ClienteControlador();
                    clienteControlador.CarregarGrid(dgPrincipal);
                    break;  
                default:
                    break;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ChamarFormulario("CLIENTE", false);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ChamarFormulario("CLIENTE", true);
        }

        private void dgPrincipal_DoubleClick(object sender, EventArgs e)
        {
            ChamarFormulario("CLIENTE", true);
        }

        private void dgPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow r = dgPrincipal.Rows[e.RowIndex];
            if (e.RowIndex % 2 == 0)
                if (r.DefaultCellStyle.BackColor != Color.White)
                    r.DefaultCellStyle.BackColor = Color.AliceBlue;
        }
    }
}
