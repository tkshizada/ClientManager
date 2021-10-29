
namespace ClientManager.Formulários
{
    partial class frmCadastroVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroVendedor));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.DateTimePicker();
            this.txtRG = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.ComboBox();
            this.txtCodEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtCodEmpresa);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.pbFoto);
            this.groupBox2.Controls.Add(this.txtCPF);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.txtSexo);
            this.groupBox2.Controls.Add(this.txtCelular);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtData);
            this.groupBox2.Controls.Add(this.txtRG);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtIdade);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(694, 196);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Principal";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(9, 164);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Adicionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(90, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // pbFoto
            // 
            this.pbFoto.Location = new System.Drawing.Point(9, 25);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(156, 133);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 32;
            this.pbFoto.TabStop = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(193, 91);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(86, 20);
            this.txtCPF.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(190, 75);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(27, 13);
            this.label20.TabIndex = 1;
            this.label20.Text = "CPF";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(564, 91);
            this.txtCelular.Mask = "(00) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(100, 20);
            this.txtCelular.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(431, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Sexo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(561, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Celular";
            // 
            // txtData
            // 
            this.txtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtData.Location = new System.Drawing.Point(285, 91);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 5;
            this.txtData.ValueChanged += new System.EventHandler(this.txtData_ValueChanged);
            this.txtData.MouseLeave += new System.EventHandler(this.txtData_MouseLeave);
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(263, 41);
            this.txtRG.Mask = "00,000,000-0";
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(75, 20);
            this.txtRG.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(344, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 20);
            this.txtNome.TabIndex = 4;
            // 
            // txtIdade
            // 
            this.txtIdade.Enabled = false;
            this.txtIdade.Location = new System.Drawing.Point(391, 91);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(37, 20);
            this.txtIdade.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Nome";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(388, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Idade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(282, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Data de Nascimento";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(260, 25);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(23, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "RG";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(6, 88);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(185, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(6, 39);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(75, 20);
            this.txtCEP.TabIndex = 0;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(446, 39);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(44, 20);
            this.txtNumero.TabIndex = 3;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(210, 39);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(230, 20);
            this.txtRua.TabIndex = 2;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(496, 39);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(168, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(87, 39);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(117, 20);
            this.txtBairro.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(443, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Numero";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Cidade";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(493, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "Estado";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(210, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 4;
            this.label17.Text = "Rua";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(88, 23);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Bairro";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "CEP";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(633, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(471, 366);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnOK
            // 
            this.btnOK.AccessibleName = "";
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(552, 366);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "Ok";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtCEP);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(12, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 146);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // txtSexo
            // 
            this.txtSexo.Enabled = false;
            this.txtSexo.FormattingEnabled = true;
            this.txtSexo.Items.AddRange(new object[] {
            "",
            "Masculino",
            "Feminino"});
            this.txtSexo.Location = new System.Drawing.Point(434, 90);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(121, 21);
            this.txtSexo.TabIndex = 7;
            // 
            // txtCodEmpresa
            // 
            this.txtCodEmpresa.Location = new System.Drawing.Point(193, 41);
            this.txtCodEmpresa.Name = "txtCodEmpresa";
            this.txtCodEmpresa.Size = new System.Drawing.Size(64, 20);
            this.txtCodEmpresa.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            // 
            // frmCadastroVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 397);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmCadastroVendedor";
            this.Text = "frmCadastroVendedor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.DateTimePicker txtData;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.MaskedTextBox txtRG;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox txtSexo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodEmpresa;
    }
}