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

        Controlador.ClienteControlador controlador = new Controlador.ClienteControlador();

        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
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
    }
}
