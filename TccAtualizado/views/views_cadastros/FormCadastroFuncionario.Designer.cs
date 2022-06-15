namespace TccAtualizado.views.views_cadastros
{
    partial class FormCadastroFuncionario
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
            this.btCancelar = new SISVEN.custom.RJButton();
            this.btSalvar = new SISVEN.custom.RJButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbtAtivo = new SISVEN.custom.RJToggleButton();
            this.txtComplemento = new SISVEN.custom.RJTextBox();
            this.txtCel = new SISVEN.custom.RJTextBox();
            this.txtCNH = new SISVEN.custom.RJTextBox();
            this.txtCPF = new SISVEN.custom.RJTextBox();
            this.txtNome = new SISVEN.custom.RJTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btExcluir = new SISVEN.custom.RJButton();
            this.btEditar = new SISVEN.custom.RJButton();
            this.btNovo = new SISVEN.custom.RJButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rjComboBox1 = new SISVEN.custom.RJComboBox();
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
            this.panel1.Controls.Add(this.txtComplemento);
            this.panel1.Controls.Add(this.txtCel);
            this.panel1.Controls.Add(this.txtCNH);
            this.panel1.Controls.Add(this.txtCPF);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(700, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 560);
            this.panel1.TabIndex = 0;
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
            this.btCancelar.Location = new System.Drawing.Point(262, 507);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(116, 40);
            this.btCancelar.TabIndex = 54;
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
            this.btSalvar.Location = new System.Drawing.Point(13, 508);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(120, 40);
            this.btSalvar.TabIndex = 53;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextColor = System.Drawing.Color.Black;
            this.btSalvar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Ativo";
            // 
            // tbtAtivo
            // 
            this.tbtAtivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbtAtivo.AutoSize = true;
            this.tbtAtivo.Location = new System.Drawing.Point(62, 438);
            this.tbtAtivo.MinimumSize = new System.Drawing.Size(45, 22);
            this.tbtAtivo.Name = "tbtAtivo";
            this.tbtAtivo.OffBackColor = System.Drawing.Color.Gray;
            this.tbtAtivo.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.tbtAtivo.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.tbtAtivo.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.tbtAtivo.Size = new System.Drawing.Size(45, 22);
            this.tbtAtivo.TabIndex = 51;
            this.tbtAtivo.UseVisualStyleBackColor = true;
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
            this.txtComplemento.Location = new System.Drawing.Point(10, 249);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.Multiline = true;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtComplemento.PasswordChar = false;
            this.txtComplemento.PlaceholderColor = System.Drawing.Color.Black;
            this.txtComplemento.PlaceholderText = "Endereço";
            this.txtComplemento.Size = new System.Drawing.Size(368, 176);
            this.txtComplemento.TabIndex = 50;
            this.txtComplemento.Texts = "";
            this.txtComplemento.UnderlinedStyle = false;
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
            this.txtCel.Location = new System.Drawing.Point(12, 190);
            this.txtCel.Margin = new System.Windows.Forms.Padding(4);
            this.txtCel.Multiline = false;
            this.txtCel.Name = "txtCel";
            this.txtCel.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCel.PasswordChar = false;
            this.txtCel.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCel.PlaceholderText = "Celular";
            this.txtCel.Size = new System.Drawing.Size(366, 31);
            this.txtCel.TabIndex = 49;
            this.txtCel.Texts = "";
            this.txtCel.UnderlinedStyle = false;
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
            this.txtCNH.Location = new System.Drawing.Point(194, 134);
            this.txtCNH.Margin = new System.Windows.Forms.Padding(4);
            this.txtCNH.Multiline = false;
            this.txtCNH.Name = "txtCNH";
            this.txtCNH.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCNH.PasswordChar = false;
            this.txtCNH.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCNH.PlaceholderText = "CNH";
            this.txtCNH.Size = new System.Drawing.Size(184, 31);
            this.txtCNH.TabIndex = 48;
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
            this.txtCPF.Location = new System.Drawing.Point(10, 134);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.Multiline = false;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCPF.PasswordChar = false;
            this.txtCPF.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCPF.PlaceholderText = "CPF";
            this.txtCPF.Size = new System.Drawing.Size(176, 31);
            this.txtCPF.TabIndex = 47;
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
            this.txtNome.Location = new System.Drawing.Point(10, 83);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Multiline = false;
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNome.PasswordChar = false;
            this.txtNome.PlaceholderColor = System.Drawing.Color.Black;
            this.txtNome.PlaceholderText = "Nome";
            this.txtNome.Size = new System.Drawing.Size(367, 31);
            this.txtNome.TabIndex = 46;
            this.txtNome.Texts = "";
            this.txtNome.UnderlinedStyle = false;
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.panel3.Controls.Add(this.rjComboBox1);
            this.panel3.Controls.Add(this.btPesquisar);
            this.panel3.Controls.Add(this.txtFiltro);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 60);
            this.panel3.TabIndex = 2;
            // 
            // rjComboBox1
            // 
            this.rjComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox1.BorderColor = System.Drawing.Color.Black;
            this.rjComboBox1.BorderSize = 1;
            this.rjComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rjComboBox1.ForeColor = System.Drawing.Color.Black;
            this.rjComboBox1.IconColor = System.Drawing.Color.Black;
            this.rjComboBox1.Items.AddRange(new object[] {
            "todos",
            "ativos",
            "inativos"});
            this.rjComboBox1.ListBackColor = System.Drawing.Color.Silver;
            this.rjComboBox1.ListTextColor = System.Drawing.Color.Black;
            this.rjComboBox1.Location = new System.Drawing.Point(460, 14);
            this.rjComboBox1.MinimumSize = new System.Drawing.Size(50, 30);
            this.rjComboBox1.Name = "rjComboBox1";
            this.rjComboBox1.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox1.Size = new System.Drawing.Size(120, 32);
            this.rjComboBox1.TabIndex = 10;
            this.rjComboBox1.Texts = "Tipo Busca";
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
            // FormCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastroFuncionario";
            this.Text = "FormCadastroFuncionario";
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
        private SISVEN.custom.RJButton btCancelar;
        private SISVEN.custom.RJButton btSalvar;
        private System.Windows.Forms.Label label1;
        private SISVEN.custom.RJToggleButton tbtAtivo;
        private SISVEN.custom.RJTextBox txtComplemento;
        private SISVEN.custom.RJTextBox txtCel;
        private SISVEN.custom.RJTextBox txtCNH;
        private SISVEN.custom.RJTextBox txtCPF;
        private SISVEN.custom.RJTextBox txtNome;
        private SISVEN.custom.RJButton btExcluir;
        private SISVEN.custom.RJButton btEditar;
        private SISVEN.custom.RJButton btNovo;
        private SISVEN.custom.RJComboBox rjComboBox1;
        private SISVEN.custom.RJButton btPesquisar;
        private SISVEN.custom.RJTextBox txtFiltro;
    }
}