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

        private string condicaoFiltro = "";

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
            Formulários.frmfiltroCliente frmfiltroCliente = new Formulários.frmfiltroCliente();
            frmfiltroCliente.ShowDialog();

            if (!string.IsNullOrEmpty(frmfiltroCliente.condicao))
            {
                condicaoFiltro = frmfiltroCliente.condicao;

                Controlador.ClienteControlador clienteControlador = new Controlador.ClienteControlador();

                clienteControlador.CarregarGrid(dgPrincipal, condicaoFiltro);
            }
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
                    clienteControlador.CarregarGrid(dgPrincipal, condicaoFiltro);
                    break;  
                default:
                    break;
            }
        }

        private void Excluir()
        {
            controlador = new Controlador.ClienteControlador();

            if (dgPrincipal.SelectedRows.Count > 0)
            {
                row = dgPrincipal.Rows[dgPrincipal.CurrentRow.Index];

                int ID = Convert.ToInt32(row.Cells["ID"].Value);

                string CPF = row.Cells["CPF"].Value.ToString();

                if (controlador.Excluir(ID, CPF))
                {
                    MessageBox.Show("Registro excluido com sucesso", "Registro excluido!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                else
                {
                    MessageBox.Show("Não foi possivel excluir o registro!", "Registro não excluido!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();

            controlador.CarregarGrid(dgPrincipal, condicaoFiltro);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Formulários.frmfiltroCliente frmfiltroCliente = new Formulários.frmfiltroCliente();
            frmfiltroCliente.ShowDialog();

            if (!string.IsNullOrEmpty(frmfiltroCliente.condicao))
            {
                condicaoFiltro = frmfiltroCliente.condicao;

                Controlador.ClienteControlador clienteControlador = new Controlador.ClienteControlador();

                clienteControlador.CarregarGrid(dgPrincipal, condicaoFiltro);
            }
        }
    }
}
