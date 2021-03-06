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

        Classes.Utilidades util = new Classes.Utilidades();
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

                case "EMPRESA":
                    Formulários.frmCadastroEmpresa frmCadastroEmpresa = new Formulários.frmCadastroEmpresa();

                    if (edicao == true)
                    {
                        row = dgPrincipal.Rows[dgPrincipal.CurrentRow.Index];
                        frmCadastroEmpresa.edita = true;
                        frmCadastroEmpresa.cnpj = row.Cells["CNPJ"].Value.ToString();
                        frmCadastroEmpresa.codEmpresa = row.Cells["COD_EMPRESA"].Value.ToString();

                    }

                    frmCadastroEmpresa.ShowDialog();
                    Controlador.EmpresaControlador empresaControlador = new Controlador.EmpresaControlador();
                    empresaControlador.CarregarGrid(dgPrincipal, condicaoFiltro);
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
            util.ChamarFormularioBotao(false, row);
            util.CarregarGridDinamica(dgPrincipal);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //ChamarFormulario("CLIENTE", true);
            util.ChamarFormularioBotao(true, row = dgPrincipal.CurrentRow);
        }

        private void dgPrincipal_DoubleClick(object sender, EventArgs e)
        {
            util.ChamarFormularioBotao(true, row = dgPrincipal.CurrentRow);
        }

        private void dgPrincipal_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow r = dgPrincipal.Rows[e.RowIndex];
            Color col = System.Drawing.ColorTranslator.FromHtml("#FFCC66");
            if (e.RowIndex % 2 == 0)
            {
                r.DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                r.DefaultCellStyle.BackColor = col;g
            }
                    
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();

            util.CarregarGridDinamica(dgPrincipal);
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

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            util.botaoSelecionado = toolStripButton1.Text;

            util.CarregarGridDinamica(dgPrincipal);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            util.botaoSelecionado = btnCliente.Text;

            util.CarregarGridDinamica(dgPrincipal);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            util.botaoSelecionado = toolStripButton2.Text;

            util.CarregarGridDinamica(dgPrincipal);
        }

        private void dgPrincipal_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void dgPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }
    }
}