namespace SistemaCSV.view.cadastrar
{
    partial class FormCadastroPessoa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.btAvançar = new SISVEN.custom.RJButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRua = new SISVEN.custom.RJTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new SISVEN.custom.RJTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCel = new SISVEN.custom.RJTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCNH = new SISVEN.custom.RJTextBox();
            this.txtCPF = new SISVEN.custom.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new SISVEN.custom.RJTextBox();
            this.tabAcesso = new System.Windows.Forms.TabPage();
            this.tgbAtivo = new SISVEN.custom.RJToggleButton();
            this.btSalvar = new SISVEN.custom.RJButton();
            this.cbTipoPessoa = new SISVEN.custom.RJComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPass = new SISVEN.custom.RJTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLogin = new SISVEN.custom.RJTextBox();
            this.btVoltar = new SISVEN.custom.RJButton();
            this.cbMostrar = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 60);
            this.panel1.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(22, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(393, 29);
            this.label10.TabIndex = 111;
            this.label10.Text = "CADASTRO / EDIÇÃO DE PESSOA";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDados);
            this.tabControl1.Controls.Add(this.tabAcesso);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 501);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.btAvançar);
            this.tabDados.Controls.Add(this.label2);
            this.tabDados.Controls.Add(this.txtRua);
            this.tabDados.Controls.Add(this.label7);
            this.tabDados.Controls.Add(this.txtEmail);
            this.tabDados.Controls.Add(this.label6);
            this.tabDados.Controls.Add(this.txtCel);
            this.tabDados.Controls.Add(this.label5);
            this.tabDados.Controls.Add(this.label4);
            this.tabDados.Controls.Add(this.txtCNH);
            this.tabDados.Controls.Add(this.txtCPF);
            this.tabDados.Controls.Add(this.label1);
            this.tabDados.Controls.Add(this.txtNome);
            this.tabDados.Location = new System.Drawing.Point(4, 24);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(676, 473);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados Pessoais";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // btAvançar
            // 
            this.btAvançar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAvançar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btAvançar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAvançar.BorderRadius = 5;
            this.btAvançar.BorderSize = 0;
            this.btAvançar.FlatAppearance.BorderSize = 0;
            this.btAvançar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvançar.ForeColor = System.Drawing.Color.White;
            this.btAvançar.Location = new System.Drawing.Point(567, 425);
            this.btAvançar.Name = "btAvançar";
            this.btAvançar.Size = new System.Drawing.Size(100, 40);
            this.btAvançar.TabIndex = 119;
            this.btAvançar.Text = "Avançar";
            this.btAvançar.TextColor = System.Drawing.Color.White;
            this.btAvançar.UseVisualStyleBackColor = false;
            this.btAvançar.Click += new System.EventHandler(this.btAvançar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(169, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 23);
            this.label2.TabIndex = 118;
            this.label2.Text = "ENDEREÇO";
            // 
            // txtRua
            // 
            this.txtRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.BorderColor = System.Drawing.Color.Black;
            this.txtRua.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtRua.BorderRadius = 3;
            this.txtRua.BorderSize = 1;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRua.Location = new System.Drawing.Point(169, 416);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.Multiline = true;
            this.txtRua.Name = "txtRua";
            this.txtRua.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRua.PasswordChar = false;
            this.txtRua.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtRua.PlaceholderText = "Endereço";
            this.txtRua.Size = new System.Drawing.Size(300, 31);
            this.txtRua.TabIndex = 117;
            this.txtRua.Texts = "";
            this.txtRua.UnderlinedStyle = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(169, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 23);
            this.label7.TabIndex = 116;
            this.label7.Text = "EMAIL";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Black;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtEmail.BorderRadius = 3;
            this.txtEmail.BorderSize = 1;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.Location = new System.Drawing.Point(169, 342);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtEmail.PlaceholderText = "exemplo@gmail.com";
            this.txtEmail.Size = new System.Drawing.Size(300, 31);
            this.txtEmail.TabIndex = 115;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(169, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 23);
            this.label6.TabIndex = 114;
            this.label6.Text = "TELEFONE";
            // 
            // txtCel
            // 
            this.txtCel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCel.BackColor = System.Drawing.Color.White;
            this.txtCel.BorderColor = System.Drawing.Color.Black;
            this.txtCel.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCel.BorderRadius = 3;
            this.txtCel.BorderSize = 1;
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCel.Location = new System.Drawing.Point(169, 270);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCel.Multiline = false;
            this.txtCel.Name = "txtCel";
            this.txtCel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCel.PasswordChar = false;
            this.txtCel.PlaceholderColor = System.Drawing.SystemColors.GrayText;
            this.txtCel.PlaceholderText = "(00)00000-0000";
            this.txtCel.Size = new System.Drawing.Size(300, 31);
            this.txtCel.TabIndex = 113;
            this.txtCel.Texts = "";
            this.txtCel.UnderlinedStyle = false;
            this.txtCel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCel_KeyPress);
            this.txtCel.Leave += new System.EventHandler(this.txtCel_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(169, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 112;
            this.label5.Text = "CNH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(169, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 23);
            this.label4.TabIndex = 111;
            this.label4.Text = "CPF";
            // 
            // txtCNH
            // 
            this.txtCNH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCNH.BackColor = System.Drawing.Color.White;
            this.txtCNH.BorderColor = System.Drawing.Color.Black;
            this.txtCNH.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCNH.BorderRadius = 3;
            this.txtCNH.BorderSize = 1;
            this.txtCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCNH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCNH.Location = new System.Drawing.Point(169, 193);
            this.txtCNH.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNH.Multiline = false;
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCNH.PasswordChar = false;
            this.txtCNH.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCNH.PlaceholderText = "0000000000";
            this.txtCNH.Size = new System.Drawing.Size(300, 31);
            this.txtCNH.TabIndex = 110;
            this.txtCNH.Texts = "";
            this.txtCNH.UnderlinedStyle = false;
            this.txtCNH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNH_KeyPress);
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.BorderColor = System.Drawing.Color.Black;
            this.txtCPF.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtCPF.BorderRadius = 3;
            this.txtCPF.BorderSize = 1;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCPF.Location = new System.Drawing.Point(169, 119);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCPF.PasswordChar = false;
            this.txtCPF.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtCPF.PlaceholderText = "000.000.000-00";
            this.txtCPF.Size = new System.Drawing.Size(300, 31);
            this.txtCPF.TabIndex = 109;
            this.txtCPF.Texts = "";
            this.txtCPF.UnderlinedStyle = false;
            this.txtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCPF_KeyPress);
            this.txtCPF.Leave += new System.EventHandler(this.txtCPF_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderColor = System.Drawing.Color.Black;
            this.txtNome.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtNome.BorderRadius = 3;
            this.txtNome.BorderSize = 1;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(18, 44);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtNome.PlaceholderText = "EX: Aldemir de Souza";
            this.txtNome.Size = new System.Drawing.Size(649, 31);
            this.txtNome.TabIndex = 3;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // tabAcesso
            // 
            this.tabAcesso.BackColor = System.Drawing.SystemColors.Control;
            this.tabAcesso.Controls.Add(this.cbMostrar);
            this.tabAcesso.Controls.Add(this.tgbAtivo);
            this.tabAcesso.Controls.Add(this.btSalvar);
            this.tabAcesso.Controls.Add(this.cbTipoPessoa);
            this.tabAcesso.Controls.Add(this.label8);
            this.tabAcesso.Controls.Add(this.label9);
            this.tabAcesso.Controls.Add(this.label3);
            this.tabAcesso.Controls.Add(this.txtPass);
            this.tabAcesso.Controls.Add(this.label11);
            this.tabAcesso.Controls.Add(this.txtLogin);
            this.tabAcesso.Controls.Add(this.btVoltar);
            this.tabAcesso.Location = new System.Drawing.Point(4, 24);
            this.tabAcesso.Name = "tabAcesso";
            this.tabAcesso.Padding = new System.Windows.Forms.Padding(3);
            this.tabAcesso.Size = new System.Drawing.Size(676, 473);
            this.tabAcesso.TabIndex = 1;
            this.tabAcesso.Text = "Dados de Acesso";
            // 
            // tgbAtivo
            // 
            this.tgbAtivo.AutoSize = true;
            this.tgbAtivo.Location = new System.Drawing.Point(355, 292);
            this.tgbAtivo.MinimumSize = new System.Drawing.Size(45, 22);
            this.tgbAtivo.Name = "tgbAtivo";
            this.tgbAtivo.OffBackColor = System.Drawing.Color.Gray;
            this.tgbAtivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tgbAtivo.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tgbAtivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tgbAtivo.Size = new System.Drawing.Size(45, 22);
            this.tgbAtivo.TabIndex = 130;
            this.tgbAtivo.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSalvar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btSalvar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSalvar.BorderRadius = 5;
            this.btSalvar.BorderSize = 0;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(260, 357);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(151, 48);
            this.btSalvar.TabIndex = 129;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextColor = System.Drawing.Color.White;
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.BackColor = System.Drawing.Color.White;
            this.cbTipoPessoa.BorderColor = System.Drawing.Color.Black;
            this.cbTipoPessoa.BorderSize = 1;
            this.cbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPessoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipoPessoa.ForeColor = System.Drawing.Color.Black;
            this.cbTipoPessoa.IconColor = System.Drawing.Color.Black;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "gerente",
            "motorista"});
            this.cbTipoPessoa.ListBackColor = System.Drawing.Color.White;
            this.cbTipoPessoa.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbTipoPessoa.Location = new System.Drawing.Point(239, 229);
            this.cbTipoPessoa.MinimumSize = new System.Drawing.Size(50, 30);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Padding = new System.Windows.Forms.Padding(1);
            this.cbTipoPessoa.Size = new System.Drawing.Size(200, 30);
            this.cbTipoPessoa.TabIndex = 128;
            this.cbTipoPessoa.Texts = "Tipo de Pessoa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(272, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 126;
            this.label8.Text = "ATIVO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Constantia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(265, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 23);
            this.label9.TabIndex = 125;
            this.label9.Text = "TIPO DE PESSOA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(239, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 124;
            this.label3.Text = "Senha";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.White;
            this.txtPass.BorderColor = System.Drawing.Color.Black;
            this.txtPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtPass.BorderRadius = 3;
            this.txtPass.BorderSize = 1;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtPass.Location = new System.Drawing.Point(239, 129);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Multiline = false;
            this.txtPass.Name = "txtPass";
            this.txtPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPass.PasswordChar = true;
            this.txtPass.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtPass.PlaceholderText = "Senha (6-8 digitos)";
            this.txtPass.Size = new System.Drawing.Size(202, 31);
            this.txtPass.TabIndex = 122;
            this.txtPass.Texts = "";
            this.txtPass.UnderlinedStyle = false;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(239, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 23);
            this.label11.TabIndex = 123;
            this.label11.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.BackColor = System.Drawing.Color.White;
            this.txtLogin.BorderColor = System.Drawing.Color.Black;
            this.txtLogin.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtLogin.BorderRadius = 3;
            this.txtLogin.BorderSize = 1;
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLogin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtLogin.Location = new System.Drawing.Point(239, 43);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogin.Multiline = false;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtLogin.PasswordChar = false;
            this.txtLogin.PlaceholderColor = System.Drawing.Color.Gray;
            this.txtLogin.PlaceholderText = "Usuario";
            this.txtLogin.Size = new System.Drawing.Size(202, 31);
            this.txtLogin.TabIndex = 121;
            this.txtLogin.Texts = "";
            this.txtLogin.UnderlinedStyle = false;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btVoltar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btVoltar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btVoltar.BorderRadius = 5;
            this.btVoltar.BorderSize = 0;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(18, 425);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(100, 40);
            this.btVoltar.TabIndex = 120;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextColor = System.Drawing.Color.White;
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // cbMostrar
            // 
            this.cbMostrar.AutoSize = true;
            this.cbMostrar.Location = new System.Drawing.Point(296, 167);
            this.cbMostrar.Name = "cbMostrar";
            this.cbMostrar.Size = new System.Drawing.Size(102, 19);
            this.cbMostrar.TabIndex = 131;
            this.cbMostrar.Text = "Mostrar Senha";
            this.cbMostrar.UseVisualStyleBackColor = true;
            this.cbMostrar.CheckedChanged += new System.EventHandler(this.cbMostrar_CheckedChanged);
            // 
            // FormCadastroPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 600);
            this.MinimumSize = new System.Drawing.Size(700, 600);
            this.Name = "FormCadastroPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCadastroPessoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadastroPessoa_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.tabAcesso.ResumeLayout(false);
            this.tabAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDados;
        private System.Windows.Forms.TabPage tabAcesso;
        private System.Windows.Forms.Label label1;
        private SISVEN.custom.RJTextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private SISVEN.custom.RJTextBox txtCNH;
        private SISVEN.custom.RJTextBox txtCPF;
        private System.Windows.Forms.Label label2;
        private SISVEN.custom.RJTextBox txtRua;
        private System.Windows.Forms.Label label7;
        private SISVEN.custom.RJTextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private SISVEN.custom.RJTextBox txtCel;
        private SISVEN.custom.RJButton btAvançar;
        private SISVEN.custom.RJComboBox cbTipoPessoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private SISVEN.custom.RJTextBox txtPass;
        private System.Windows.Forms.Label label11;
        private SISVEN.custom.RJTextBox txtLogin;
        private SISVEN.custom.RJButton btVoltar;
        private SISVEN.custom.RJButton btSalvar;
        private SISVEN.custom.RJToggleButton tgbAtivo;
        private System.Windows.Forms.CheckBox cbMostrar;
    }
}