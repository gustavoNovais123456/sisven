namespace TccAtualizado.views.views_cadastros
{
    partial class FormCadastroCliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgListaCliente = new System.Windows.Forms.DataGridView();
            this.panelControle = new System.Windows.Forms.Panel();
            this.btExcluir = new SISVEN.custom.RJButton();
            this.btEditar = new SISVEN.custom.RJButton();
            this.btNovo = new SISVEN.custom.RJButton();
            this.panelBusca = new System.Windows.Forms.Panel();
            this.cbTipo = new SISVEN.custom.RJComboBox();
            this.btPesquisar = new SISVEN.custom.RJButton();
            this.txtFiltro = new SISVEN.custom.RJTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelDireito = new System.Windows.Forms.Panel();
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.panelControleCad = new System.Windows.Forms.Panel();
            this.btCancelar = new SISVEN.custom.RJButton();
            this.brSalvar = new SISVEN.custom.RJButton();
            this.panelCadastro = new System.Windows.Forms.Panel();
            this.btCep = new SISVEN.custom.RJButton();
            this.txtNum = new SISVEN.custom.RJTextBox();
            this.txtCel2 = new SISVEN.custom.RJTextBox();
            this.txtRua = new SISVEN.custom.RJTextBox();
            this.txtComplemento = new SISVEN.custom.RJTextBox();
            this.txtBairro = new SISVEN.custom.RJTextBox();
            this.txtCidade = new SISVEN.custom.RJTextBox();
            this.txtEstado = new SISVEN.custom.RJTextBox();
            this.txtCep = new SISVEN.custom.RJTextBox();
            this.txtCel = new SISVEN.custom.RJTextBox();
            this.txtRG = new SISVEN.custom.RJTextBox();
            this.txtCPF = new SISVEN.custom.RJTextBox();
            this.txtNome = new SISVEN.custom.RJTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCliente)).BeginInit();
            this.panelControle.SuspendLayout();
            this.panelBusca.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelControleCad.SuspendLayout();
            this.panelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1018, 559);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.tabPage1.Controls.Add(this.dgListaCliente);
            this.tabPage1.Controls.Add(this.panelControle);
            this.tabPage1.Controls.Add(this.panelBusca);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1010, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Busca De Cliente";
            // 
            // dgListaCliente
            // 
            this.dgListaCliente.AllowUserToAddRows = false;
            this.dgListaCliente.AllowUserToDeleteRows = false;
            this.dgListaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListaCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgListaCliente.Location = new System.Drawing.Point(3, 67);
            this.dgListaCliente.Name = "dgListaCliente";
            this.dgListaCliente.ReadOnly = true;
            this.dgListaCliente.RowHeadersVisible = false;
            this.dgListaCliente.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgListaCliente.RowTemplate.Height = 25;
            this.dgListaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListaCliente.Size = new System.Drawing.Size(1004, 401);
            this.dgListaCliente.TabIndex = 2;
            // 
            // panelControle
            // 
            this.panelControle.Controls.Add(this.btExcluir);
            this.panelControle.Controls.Add(this.btEditar);
            this.panelControle.Controls.Add(this.btNovo);
            this.panelControle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControle.Location = new System.Drawing.Point(3, 468);
            this.panelControle.Name = "panelControle";
            this.panelControle.Size = new System.Drawing.Size(1004, 60);
            this.panelControle.TabIndex = 1;
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btExcluir.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btExcluir.BorderRadius = 10;
            this.btExcluir.BorderSize = 0;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExcluir.ForeColor = System.Drawing.Color.Black;
            this.btExcluir.Location = new System.Drawing.Point(870, 11);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(120, 40);
            this.btExcluir.TabIndex = 44;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextColor = System.Drawing.Color.Black;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btEditar.BorderRadius = 10;
            this.btEditar.BorderSize = 0;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditar.ForeColor = System.Drawing.Color.Black;
            this.btEditar.Location = new System.Drawing.Point(146, 11);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(112, 40);
            this.btEditar.TabIndex = 43;
            this.btEditar.Text = "Editar";
            this.btEditar.TextColor = System.Drawing.Color.Black;
            this.btEditar.UseVisualStyleBackColor = false;
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.Color.SpringGreen;
            this.btNovo.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btNovo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btNovo.BorderRadius = 10;
            this.btNovo.BorderSize = 0;
            this.btNovo.FlatAppearance.BorderSize = 0;
            this.btNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNovo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btNovo.ForeColor = System.Drawing.Color.Black;
            this.btNovo.Location = new System.Drawing.Point(5, 11);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(112, 40);
            this.btNovo.TabIndex = 42;
            this.btNovo.Text = "Novo";
            this.btNovo.TextColor = System.Drawing.Color.Black;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // panelBusca
            // 
            this.panelBusca.Controls.Add(this.cbTipo);
            this.panelBusca.Controls.Add(this.btPesquisar);
            this.panelBusca.Controls.Add(this.txtFiltro);
            this.panelBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusca.Location = new System.Drawing.Point(3, 3);
            this.panelBusca.Name = "panelBusca";
            this.panelBusca.Size = new System.Drawing.Size(1004, 64);
            this.panelBusca.TabIndex = 0;
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipo.BorderColor = System.Drawing.Color.Black;
            this.cbTipo.BorderSize = 1;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.ForeColor = System.Drawing.Color.Black;
            this.cbTipo.IconColor = System.Drawing.Color.Black;
            this.cbTipo.Items.AddRange(new object[] {
            "todos",
            "ativos",
            "inativos"});
            this.cbTipo.ListBackColor = System.Drawing.Color.Silver;
            this.cbTipo.ListTextColor = System.Drawing.Color.Black;
            this.cbTipo.Location = new System.Drawing.Point(709, 14);
            this.cbTipo.MinimumSize = new System.Drawing.Size(50, 30);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Padding = new System.Windows.Forms.Padding(1);
            this.cbTipo.Size = new System.Drawing.Size(120, 32);
            this.cbTipo.TabIndex = 13;
            this.cbTipo.Texts = "Tipo Busca";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btPesquisar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btPesquisar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btPesquisar.BorderRadius = 10;
            this.btPesquisar.BorderSize = 0;
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btPesquisar.Location = new System.Drawing.Point(882, 14);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(108, 32);
            this.btPesquisar.TabIndex = 11;
            this.btPesquisar.Text = "Buscar";
            this.btPesquisar.TextColor = System.Drawing.Color.Black;
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.txtFiltro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.BorderFocusColor = System.Drawing.Color.Green;
            this.txtFiltro.BorderRadius = 5;
            this.txtFiltro.BorderSize = 2;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.Location = new System.Drawing.Point(6, 14);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Multiline = false;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFiltro.PasswordChar = false;
            this.txtFiltro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFiltro.PlaceholderText = "";
            this.txtFiltro.Size = new System.Drawing.Size(640, 31);
            this.txtFiltro.TabIndex = 12;
            this.txtFiltro.Texts = "";
            this.txtFiltro.UnderlinedStyle = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.tabPage2.Controls.Add(this.panelDireito);
            this.tabPage2.Controls.Add(this.panelEsquerdo);
            this.tabPage2.Controls.Add(this.panelControleCad);
            this.tabPage2.Controls.Add(this.panelCadastro);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1010, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro De Cliente";
            // 
            // panelDireito
            // 
            this.panelDireito.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelDireito.Location = new System.Drawing.Point(777, 3);
            this.panelDireito.Name = "panelDireito";
            this.panelDireito.Size = new System.Drawing.Size(230, 465);
            this.panelDireito.TabIndex = 67;
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdo.Location = new System.Drawing.Point(3, 3);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(230, 465);
            this.panelEsquerdo.TabIndex = 66;
            // 
            // panelControleCad
            // 
            this.panelControleCad.Controls.Add(this.btCancelar);
            this.panelControleCad.Controls.Add(this.brSalvar);
            this.panelControleCad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControleCad.Location = new System.Drawing.Point(3, 468);
            this.panelControleCad.Name = "panelControleCad";
            this.panelControleCad.Size = new System.Drawing.Size(1004, 60);
            this.panelControleCad.TabIndex = 65;
            // 
            // btCancelar
            // 
            this.btCancelar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btCancelar.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btCancelar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btCancelar.BorderRadius = 10;
            this.btCancelar.BorderSize = 0;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.ForeColor = System.Drawing.Color.Black;
            this.btCancelar.Location = new System.Drawing.Point(651, 10);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(116, 40);
            this.btCancelar.TabIndex = 56;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextColor = System.Drawing.Color.Black;
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // brSalvar
            // 
            this.brSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.brSalvar.BackColor = System.Drawing.Color.SpringGreen;
            this.brSalvar.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.brSalvar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.brSalvar.BorderRadius = 10;
            this.brSalvar.BorderSize = 0;
            this.brSalvar.FlatAppearance.BorderSize = 0;
            this.brSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.brSalvar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.brSalvar.ForeColor = System.Drawing.Color.Black;
            this.brSalvar.Location = new System.Drawing.Point(236, 10);
            this.brSalvar.Name = "brSalvar";
            this.brSalvar.Size = new System.Drawing.Size(120, 40);
            this.brSalvar.TabIndex = 55;
            this.brSalvar.Text = "Salvar";
            this.brSalvar.TextColor = System.Drawing.Color.Black;
            this.brSalvar.UseVisualStyleBackColor = false;
            this.brSalvar.Click += new System.EventHandler(this.brSalvar_Click);
            // 
            // panelCadastro
            // 
            this.panelCadastro.Controls.Add(this.btCep);
            this.panelCadastro.Controls.Add(this.txtNum);
            this.panelCadastro.Controls.Add(this.txtCel2);
            this.panelCadastro.Controls.Add(this.txtRua);
            this.panelCadastro.Controls.Add(this.txtComplemento);
            this.panelCadastro.Controls.Add(this.txtBairro);
            this.panelCadastro.Controls.Add(this.txtCidade);
            this.panelCadastro.Controls.Add(this.txtEstado);
            this.panelCadastro.Controls.Add(this.txtCep);
            this.panelCadastro.Controls.Add(this.txtCel);
            this.panelCadastro.Controls.Add(this.txtRG);
            this.panelCadastro.Controls.Add(this.txtCPF);
            this.panelCadastro.Controls.Add(this.txtNome);
            this.panelCadastro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCadastro.Location = new System.Drawing.Point(3, 3);
            this.panelCadastro.Name = "panelCadastro";
            this.panelCadastro.Size = new System.Drawing.Size(1004, 525);
            this.panelCadastro.TabIndex = 64;
            // 
            // btCep
            // 
            this.btCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btCep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btCep.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btCep.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btCep.BorderRadius = 10;
            this.btCep.BorderSize = 0;
            this.btCep.FlatAppearance.BorderSize = 0;
            this.btCep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCep.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCep.ForeColor = System.Drawing.Color.Black;
            this.btCep.Location = new System.Drawing.Point(563, 222);
            this.btCep.Name = "btCep";
            this.btCep.Size = new System.Drawing.Size(108, 32);
            this.btCep.TabIndex = 74;
            this.btCep.Text = "Buscar";
            this.btCep.TextColor = System.Drawing.Color.Black;
            this.btCep.UseVisualStyleBackColor = false;
            this.btCep.Click += new System.EventHandler(this.btCep_Click);
            // 
            // txtNum
            // 
            this.txtNum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNum.BorderFocusColor = System.Drawing.Color.Green;
            this.txtNum.BorderRadius = 5;
            this.txtNum.BorderSize = 2;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNum.Location = new System.Drawing.Point(679, 385);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Multiline = false;
            this.txtNum.Name = "txtNum";
            this.txtNum.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNum.PasswordChar = false;
            this.txtNum.PlaceholderColor = System.Drawing.Color.Black;
            this.txtNum.PlaceholderText = "N°";
            this.txtNum.Size = new System.Drawing.Size(63, 31);
            this.txtNum.TabIndex = 73;
            this.txtNum.Texts = "";
            this.txtNum.UnderlinedStyle = false;
            // 
            // txtCel2
            // 
            this.txtCel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCel2.BackColor = System.Drawing.Color.White;
            this.txtCel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCel2.BorderFocusColor = System.Drawing.Color.Green;
            this.txtCel2.BorderRadius = 5;
            this.txtCel2.BorderSize = 2;
            this.txtCel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCel2.Location = new System.Drawing.Point(510, 168);
            this.txtCel2.Margin = new System.Windows.Forms.Padding(4);
            this.txtCel2.Multiline = false;
            this.txtCel2.Name = "txtCel2";
            this.txtCel2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCel2.PasswordChar = false;
            this.txtCel2.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCel2.PlaceholderText = "Celular (opcional)";
            this.txtCel2.Size = new System.Drawing.Size(224, 31);
            this.txtCel2.TabIndex = 72;
            this.txtCel2.Texts = "";
            this.txtCel2.UnderlinedStyle = false;
            // 
            // txtRua
            // 
            this.txtRua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRua.BorderFocusColor = System.Drawing.Color.Green;
            this.txtRua.BorderRadius = 5;
            this.txtRua.BorderSize = 2;
            this.txtRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRua.Location = new System.Drawing.Point(470, 331);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.Multiline = false;
            this.txtRua.Name = "txtRua";
            this.txtRua.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRua.PasswordChar = false;
            this.txtRua.PlaceholderColor = System.Drawing.Color.Black;
            this.txtRua.PlaceholderText = "RUA";
            this.txtRua.Size = new System.Drawing.Size(272, 31);
            this.txtRua.TabIndex = 71;
            this.txtRua.Texts = "";
            this.txtRua.UnderlinedStyle = false;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtComplemento.BackColor = System.Drawing.Color.White;
            this.txtComplemento.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComplemento.BorderFocusColor = System.Drawing.Color.Green;
            this.txtComplemento.BorderRadius = 5;
            this.txtComplemento.BorderSize = 2;
            this.txtComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtComplemento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtComplemento.Location = new System.Drawing.Point(270, 385);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.Multiline = false;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtComplemento.PasswordChar = false;
            this.txtComplemento.PlaceholderColor = System.Drawing.Color.Black;
            this.txtComplemento.PlaceholderText = "COMPLEMENTO";
            this.txtComplemento.Size = new System.Drawing.Size(401, 31);
            this.txtComplemento.TabIndex = 70;
            this.txtComplemento.Texts = "";
            this.txtComplemento.UnderlinedStyle = false;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBairro.BorderFocusColor = System.Drawing.Color.Green;
            this.txtBairro.BorderRadius = 5;
            this.txtBairro.BorderSize = 2;
            this.txtBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBairro.Location = new System.Drawing.Point(270, 331);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Multiline = false;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBairro.PasswordChar = false;
            this.txtBairro.PlaceholderColor = System.Drawing.Color.Black;
            this.txtBairro.PlaceholderText = "BAIRRO";
            this.txtBairro.Size = new System.Drawing.Size(192, 31);
            this.txtBairro.TabIndex = 69;
            this.txtBairro.Texts = "";
            this.txtBairro.UnderlinedStyle = false;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCidade.BackColor = System.Drawing.Color.White;
            this.txtCidade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.BorderFocusColor = System.Drawing.Color.Green;
            this.txtCidade.BorderRadius = 5;
            this.txtCidade.BorderSize = 2;
            this.txtCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCidade.Location = new System.Drawing.Point(391, 276);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4);
            this.txtCidade.Multiline = false;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCidade.PasswordChar = false;
            this.txtCidade.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCidade.PlaceholderText = "CIDADE";
            this.txtCidade.Size = new System.Drawing.Size(351, 31);
            this.txtCidade.TabIndex = 68;
            this.txtCidade.Texts = "";
            this.txtCidade.UnderlinedStyle = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEstado.BackColor = System.Drawing.Color.White;
            this.txtEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstado.BorderFocusColor = System.Drawing.Color.Green;
            this.txtEstado.BorderRadius = 5;
            this.txtEstado.BorderSize = 2;
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEstado.Location = new System.Drawing.Point(270, 276);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstado.Multiline = false;
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtEstado.PasswordChar = false;
            this.txtEstado.PlaceholderColor = System.Drawing.Color.Black;
            this.txtEstado.PlaceholderText = "ESTADO";
            this.txtEstado.Size = new System.Drawing.Size(104, 31);
            this.txtEstado.TabIndex = 67;
            this.txtEstado.Texts = "";
            this.txtEstado.UnderlinedStyle = false;
            // 
            // txtCep
            // 
            this.txtCep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCep.BackColor = System.Drawing.Color.White;
            this.txtCep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCep.BorderFocusColor = System.Drawing.Color.Green;
            this.txtCep.BorderRadius = 5;
            this.txtCep.BorderSize = 2;
            this.txtCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCep.Location = new System.Drawing.Point(370, 223);
            this.txtCep.Margin = new System.Windows.Forms.Padding(4);
            this.txtCep.Multiline = false;
            this.txtCep.Name = "txtCep";
            this.txtCep.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCep.PasswordChar = false;
            this.txtCep.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCep.PlaceholderText = "CEP";
            this.txtCep.Size = new System.Drawing.Size(176, 31);
            this.txtCep.TabIndex = 66;
            this.txtCep.Texts = "";
            this.txtCep.UnderlinedStyle = false;
            // 
            // txtCel
            // 
            this.txtCel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCel.BackColor = System.Drawing.Color.White;
            this.txtCel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCel.BorderFocusColor = System.Drawing.Color.Green;
            this.txtCel.BorderRadius = 5;
            this.txtCel.BorderSize = 2;
            this.txtCel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCel.Location = new System.Drawing.Point(270, 168);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCel.Multiline = false;
            this.txtCel.Name = "txtCel";
            this.txtCel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCel.PasswordChar = false;
            this.txtCel.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCel.PlaceholderText = "Celular";
            this.txtCel.Size = new System.Drawing.Size(224, 31);
            this.txtCel.TabIndex = 65;
            this.txtCel.Texts = "";
            this.txtCel.UnderlinedStyle = false;
            // 
            // txtRG
            // 
            this.txtRG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRG.BackColor = System.Drawing.Color.White;
            this.txtRG.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRG.BorderFocusColor = System.Drawing.Color.Green;
            this.txtRG.BorderRadius = 5;
            this.txtRG.BorderSize = 2;
            this.txtRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRG.Location = new System.Drawing.Point(510, 106);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtRG.Multiline = false;
            this.txtRG.Name = "txtRG";
            this.txtRG.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRG.PasswordChar = false;
            this.txtRG.PlaceholderColor = System.Drawing.Color.Black;
            this.txtRG.PlaceholderText = "RG";
            this.txtRG.Size = new System.Drawing.Size(224, 31);
            this.txtRG.TabIndex = 64;
            this.txtRG.Texts = "";
            this.txtRG.UnderlinedStyle = false;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCPF.BackColor = System.Drawing.Color.White;
            this.txtCPF.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCPF.BorderFocusColor = System.Drawing.Color.Green;
            this.txtCPF.BorderRadius = 5;
            this.txtCPF.BorderSize = 2;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCPF.Location = new System.Drawing.Point(270, 106);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCPF.PasswordChar = false;
            this.txtCPF.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCPF.PlaceholderText = "CPF";
            this.txtCPF.Size = new System.Drawing.Size(224, 31);
            this.txtCPF.TabIndex = 63;
            this.txtCPF.Texts = "";
            this.txtCPF.UnderlinedStyle = false;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNome.BackColor = System.Drawing.Color.White;
            this.txtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.BorderFocusColor = System.Drawing.Color.Green;
            this.txtNome.BorderRadius = 5;
            this.txtNome.BorderSize = 2;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.Location = new System.Drawing.Point(270, 49);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.Black;
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(464, 31);
            this.txtNome.TabIndex = 62;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1018, 559);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroCliente";
            this.Text = "FormCadastroCliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgListaCliente)).EndInit();
            this.panelControle.ResumeLayout(false);
            this.panelBusca.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelControleCad.ResumeLayout(false);
            this.panelCadastro.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelCadastro;
        private SISVEN.custom.RJTextBox txtNum;
        private SISVEN.custom.RJTextBox txtCel2;
        private SISVEN.custom.RJTextBox txtRua;
        private SISVEN.custom.RJTextBox txtComplemento;
        private SISVEN.custom.RJTextBox txtBairro;
        private SISVEN.custom.RJTextBox txtCidade;
        private SISVEN.custom.RJTextBox txtEstado;
        private SISVEN.custom.RJTextBox txtCep;
        private SISVEN.custom.RJTextBox txtCel;
        private SISVEN.custom.RJTextBox txtRG;
        private SISVEN.custom.RJTextBox txtCPF;
        private SISVEN.custom.RJTextBox txtNome;
        private System.Windows.Forms.Panel panelDireito;
        private System.Windows.Forms.Panel panelEsquerdo;
        private System.Windows.Forms.Panel panelControleCad;
        private SISVEN.custom.RJButton btCancelar;
        private SISVEN.custom.RJButton brSalvar;
        private System.Windows.Forms.Panel panelControle;
        private System.Windows.Forms.Panel panelBusca;
        private System.Windows.Forms.DataGridView dgListaCliente;
        private SISVEN.custom.RJButton btExcluir;
        private SISVEN.custom.RJButton btEditar;
        private SISVEN.custom.RJButton btNovo;
        private SISVEN.custom.RJComboBox cbTipo;
        private SISVEN.custom.RJButton btPesquisar;
        private SISVEN.custom.RJTextBox txtFiltro;
        private SISVEN.custom.RJButton btCep;
    }
}