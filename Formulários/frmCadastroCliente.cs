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

            comboBox1.DataSource = paises;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
