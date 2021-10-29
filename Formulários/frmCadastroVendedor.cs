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
    public partial class frmCadastroVendedor : Form
    {

        public bool edita;
        public string rg = "";
        public string codEmpresa = "";


        public frmCadastroVendedor()
        {
            InitializeComponent();
        }

        private void txtData_MouseLeave(object sender, EventArgs e)
        {
            txtIdade.Text = Calculoidade();
        }

        private void txtData_ValueChanged(object sender, EventArgs e)
        {

        }

        private string Calculoidade()
        {

            int hoje = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            int dob = int.Parse(txtData.Value.ToString("yyyyMMdd"));
            int age = (hoje - dob) / 10000;
            return age.ToString();

        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            pbFoto.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|"
       + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbFoto.ImageLocation = openFileDialog.FileName;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
        }

        //private bool ValidarCampos()
        //{
        //    if (txtRG.Text == "")
        //    {
        //        MessageBox.Show("Informar RG!");
        //        return false;
        //    }

        //    if (txt)
        //    {

        //    }

        //    if (true)
        //    {

        //    }

        //    if (true)
        //    {

        //    }

        //    if (true)
        //    {

        //    }

        //    if (true)
        //    {

        //    }

        //    if (true)
        //    {

        //    }

        //    if (true)
        //    {

        //    }

        //    if (true)
        //    {

        //    }
        //}
    }
}
