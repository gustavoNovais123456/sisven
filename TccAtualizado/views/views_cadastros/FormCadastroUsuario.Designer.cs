namespace TccAtualizado.views.views_cadastros
{
    partial class FormCadastroUsuario
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCNH = new SISVEN.custom.RJTextBox();
            this.txtCPF = new SISVEN.custom.RJTextBox();
            this.rjComboBox1 = new SISVEN.custom.RJComboBox();
            this.rjComboBox2 = new SISVEN.custom.RJComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtAtivo = new SISVEN.custom.RJToggleButton();
            this.btCancelar = new SISVEN.custom.RJButton();
            this.btSalvar = new SISVEN.custom.RJButton();
            this.btExcluir = new SISVEN.custom.RJButton();
            this.btEditar = new SISVEN.custom.RJButton();
            this.btNovo = new SISVEN.custom.RJButton();
            this.rjComboBox3 = new SISVEN.custom.RJComboBox();
            this.btPesquisar = new SISVEN.custom.RJButton();
            this.txtFiltro = new SISVEN.custom.RJTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Controls.Add(this.btSalvar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbtAtivo);
            this.panel1.Controls.Add(this.rjComboBox2);
            this.panel1.Controls.Add(this.rjComboBox1);
            this.panel1.Controls.Add(this.txtCNH);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 560);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel2.Controls.Add(this.btExcluir);
            this.panel2.Controls.Add(this.btEditar);
            this.panel2.Controls.Add(this.btNovo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 495);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 65);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.rjComboBox3);
            this.panel3.Controls.Add(this.btPesquisar);
            this.panel3.Controls.Add(this.txtFiltro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 60);
            this.panel3.TabIndex = 2;
            // 
            // txtCNH
            // 
            this.txtCNH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCNH.BackColor = System.Drawing.Color.White;
            this.txtCNH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCNH.BorderFocusColor = System.Drawing.Color.Green;
            this.txtCNH.BorderRadius = 5;
            this.txtCNH.BorderSize = 2;
            this.txtCNH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCNH.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCNH.Location = new System.Drawing.Point(80, 208);
            this.txtCNH.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNH.Multiline = false;
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCNH.PasswordChar = false;
            this.txtCNH.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCNH.PlaceholderText = "Senha";
            this.txtCNH.Size = new System.Drawing.Size(256, 31);
            this.txtCNH.TabIndex = 43;
            this.txtCNH.Texts = "";
            this.txtCNH.UnderlinedStyle = false;
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
            this.txtCPF.Location = new System.Drawing.Point(80, 144);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCPF.PasswordChar = false;
            this.txtCPF.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCPF.PlaceholderText = "Usuario";
            this.txtCPF.Size = new System.Drawing.Size(256, 31);
            this.txtCPF.TabIndex = 42;
            this.txtCPF.Texts = "";
            this.txtCPF.UnderlinedStyle = false;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.Black;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.IconColor = System.Drawing.Color.Black;
            this.rjComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox1.Location = new System.Drawing.Point(80, 264);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(50, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(256, 32);
            this.rjComboBox1.TabIndex = 44;
            this.rjComboBox1.Texts = "Acesso";
            // 
            // rjComboBox2
            // 
            this.rjComboBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox2.BorderColor = System.Drawing.Color.Black;
            this.rjComboBox2.BorderSize = 1;
            this.rjComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox2.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox2.IconColor = System.Drawing.Color.Black;
            this.rjComboBox2.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox2.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox2.Location = new System.Drawing.Point(80, 328);
            this.rjComboBox2.MinimumSize = new System.Drawing.Size(50, 30);
            this.rjComboBox2.Name = "rjComboBox2";
            this.rjComboBox2.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox2.Size = new System.Drawing.Size(256, 32);
            this.rjComboBox2.TabIndex = 45;
            this.rjComboBox2.Texts = "Funcionario";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Ativo";
            // 
            // tbtAtivo
            // 
            this.tbtAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtAtivo.AutoSize = true;
            this.tbtAtivo.Location = new System.Drawing.Point(208, 392);
            this.tbtAtivo.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbtAtivo.Name = "tbtAtivo";
            this.tbtAtivo.OffBackColor = System.Drawing.Color.Gray;
            this.tbtAtivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtAtivo.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtAtivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtAtivo.Size = new System.Drawing.Size(45, 22);
            this.tbtAtivo.TabIndex = 46;
            this.tbtAtivo.UseVisualStyleBackColor = true;
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
            this.btCancelar.Location = new System.Drawing.Point(258, 508);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(116, 40);
            this.btCancelar.TabIndex = 49;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.TextColor = System.Drawing.Color.Black;
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btSalvar.BackColor = System.Drawing.Color.SpringGreen;
            this.btSalvar.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.btSalvar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btSalvar.BorderRadius = 10;
            this.btSalvar.BorderSize = 0;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btSalvar.ForeColor = System.Drawing.Color.Black;
            this.btSalvar.Location = new System.Drawing.Point(22, 508);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(120, 40);
            this.btSalvar.TabIndex = 48;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextColor = System.Drawing.Color.Black;
            this.btSalvar.UseVisualStyleBackColor = false;
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
            this.btExcluir.Location = new System.Drawing.Point(562, 13);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(120, 40);
            this.btExcluir.TabIndex = 41;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextColor = System.Drawing.Color.Black;
            this.btExcluir.UseVisualStyleBackColor = false;
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
            this.btEditar.Location = new System.Drawing.Point(164, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(112, 40);
            this.btEditar.TabIndex = 40;
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
            this.btNovo.Location = new System.Drawing.Point(19, 12);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(112, 40);
            this.btNovo.TabIndex = 39;
            this.btNovo.Text = "Novo";
            this.btNovo.TextColor = System.Drawing.Color.Black;
            this.btNovo.UseVisualStyleBackColor = false;
            // 
            // rjComboBox3
            // 
            this.rjComboBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox3.BorderColor = System.Drawing.Color.Black;
            this.rjComboBox3.BorderSize = 1;
            this.rjComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox3.ForeColor = System.Drawing.Color.Black;
            this.rjComboBox3.IconColor = System.Drawing.Color.Black;
            this.rjComboBox3.Items.AddRange(new object[] {
            "todos",
            "ativos",
            "inativos"});
            this.rjComboBox3.ListBackColor = System.Drawing.Color.Silver;
            this.rjComboBox3.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBox3.Location = new System.Drawing.Point(460, 14);
            this.rjComboBox3.MinimumSize = new System.Drawing.Size(50, 30);
            this.rjComboBox3.Name = "rjComboBox3";
            this.rjComboBox3.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox3.Size = new System.Drawing.Size(120, 32);
            this.rjComboBox3.TabIndex = 10;
            this.rjComboBox3.Texts = "Tipo Busca";
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
            this.btPesquisar.Location = new System.Drawing.Point(587, 14);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(108, 32);
            this.btPesquisar.TabIndex = 8;
            this.btPesquisar.Text = "Buscar";
            this.btPesquisar.TextColor = System.Drawing.Color.Black;
            this.btPesquisar.UseVisualStyleBackColor = false;
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
            this.txtFiltro.Location = new System.Drawing.Point(5, 15);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Multiline = false;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFiltro.PasswordChar = false;
            this.txtFiltro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFiltro.PlaceholderText = "";
            this.txtFiltro.Size = new System.Drawing.Size(448, 31);
            this.txtFiltro.TabIndex = 9;
            this.txtFiltro.Texts = "";
            this.txtFiltro.UnderlinedStyle = false;
            // 
            // FormCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroUsuario";
            this.Text = "FormCadastroUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private SISVEN.custom.RJComboBox rjComboBox2;
        private SISVEN.custom.RJComboBox rjComboBox1;
        private SISVEN.custom.RJTextBox txtCNH;
        private SISVEN.custom.RJTextBox txtCPF;
        private System.Windows.Forms.Label label1;
        private SISVEN.custom.RJToggleButton tbtAtivo;
        private SISVEN.custom.RJButton btCancelar;
        private SISVEN.custom.RJButton btSalvar;
        private SISVEN.custom.RJButton btExcluir;
        private SISVEN.custom.RJButton btEditar;
        private SISVEN.custom.RJButton btNovo;
        private SISVEN.custom.RJComboBox rjComboBox3;
        private SISVEN.custom.RJButton btPesquisar;
        private SISVEN.custom.RJTextBox txtFiltro;
    }
}