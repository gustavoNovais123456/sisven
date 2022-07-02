namespace SistemaCSV.view.consultar
{
    partial class FormConsultaPessoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFiltro = new SISVEN.custom.RJTextBox();
            this.cbTipo = new SISVEN.custom.RJComboBox();
            this.cbRegistro = new SISVEN.custom.RJComboBox();
            this.btPesquisar = new SISVEN.custom.RJButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btNovo = new SISVEN.custom.RJButton();
            this.btEditar = new SISVEN.custom.RJButton();
            this.btExcluir = new SISVEN.custom.RJButton();
            this.dgPesquisaPessoas = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisaPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.txtFiltro);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Controls.Add(this.cbRegistro);
            this.panel1.Controls.Add(this.btPesquisar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 100);
            this.panel1.TabIndex = 0;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.AutoSize = true;
            this.txtFiltro.BackColor = System.Drawing.SystemColors.Window;
            this.txtFiltro.BorderColor = System.Drawing.Color.Black;
            this.txtFiltro.BorderFocusColor = System.Drawing.Color.Green;
            this.txtFiltro.BorderRadius = 5;
            this.txtFiltro.BorderSize = 1;
            this.txtFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFiltro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFiltro.Location = new System.Drawing.Point(12, 17);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltro.Multiline = false;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFiltro.PasswordChar = false;
            this.txtFiltro.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtFiltro.PlaceholderText = "BUSCAR POR - NOME / CPF / CNH";
            this.txtFiltro.Size = new System.Drawing.Size(958, 31);
            this.txtFiltro.TabIndex = 21;
            this.txtFiltro.Texts = "";
            this.txtFiltro.UnderlinedStyle = false;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // cbTipo
            // 
            this.cbTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbTipo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbTipo.BorderColor = System.Drawing.Color.Black;
            this.cbTipo.BorderSize = 1;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbTipo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipo.ForeColor = System.Drawing.Color.Black;
            this.cbTipo.IconColor = System.Drawing.Color.Black;
            this.cbTipo.Items.AddRange(new object[] {
            "todos",
            "gerente",
            "motorista"});
            this.cbTipo.ListBackColor = System.Drawing.Color.Silver;
            this.cbTipo.ListTextColor = System.Drawing.Color.Black;
            this.cbTipo.Location = new System.Drawing.Point(12, 60);
            this.cbTipo.MinimumSize = new System.Drawing.Size(50, 30);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Padding = new System.Windows.Forms.Padding(1);
            this.cbTipo.Size = new System.Drawing.Size(200, 32);
            this.cbTipo.TabIndex = 27;
            this.cbTipo.Texts = "Tipo de Cadastro";
            this.cbTipo.OnSelectedIndexChanged += new System.EventHandler(this.cbTipo_OnSelectedIndexChanged);
            // 
            // cbRegistro
            // 
            this.cbRegistro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRegistro.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbRegistro.BorderColor = System.Drawing.Color.Black;
            this.cbRegistro.BorderSize = 1;
            this.cbRegistro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.cbRegistro.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbRegistro.ForeColor = System.Drawing.Color.Black;
            this.cbRegistro.IconColor = System.Drawing.Color.Black;
            this.cbRegistro.Items.AddRange(new object[] {
            "todos",
            "ativos",
            "inativos"});
            this.cbRegistro.ListBackColor = System.Drawing.Color.Silver;
            this.cbRegistro.ListTextColor = System.Drawing.Color.Black;
            this.cbRegistro.Location = new System.Drawing.Point(247, 60);
            this.cbRegistro.MinimumSize = new System.Drawing.Size(50, 30);
            this.cbRegistro.Name = "cbRegistro";
            this.cbRegistro.Padding = new System.Windows.Forms.Padding(1);
            this.cbRegistro.Size = new System.Drawing.Size(180, 32);
            this.cbRegistro.TabIndex = 26;
            this.cbRegistro.Texts = "Registro Ativo";
            this.cbRegistro.OnSelectedIndexChanged += new System.EventHandler(this.cbRegistro_OnSelectedIndexChanged);
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
            this.btPesquisar.Location = new System.Drawing.Point(860, 63);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(112, 32);
            this.btPesquisar.TabIndex = 25;
            this.btPesquisar.Text = "Buscar";
            this.btPesquisar.TextColor = System.Drawing.Color.Black;
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btNovo);
            this.panel2.Controls.Add(this.btEditar);
            this.panel2.Controls.Add(this.btExcluir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 601);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 60);
            this.panel2.TabIndex = 1;
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
            this.btNovo.Location = new System.Drawing.Point(12, 8);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(112, 40);
            this.btNovo.TabIndex = 56;
            this.btNovo.Text = "Novo";
            this.btNovo.TextColor = System.Drawing.Color.Black;
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEditar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btEditar.BorderRadius = 10;
            this.btEditar.BorderSize = 0;
            this.btEditar.FlatAppearance.BorderSize = 0;
            this.btEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btEditar.ForeColor = System.Drawing.Color.Black;
            this.btEditar.Location = new System.Drawing.Point(153, 8);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(112, 40);
            this.btEditar.TabIndex = 57;
            this.btEditar.Text = "Editar";
            this.btEditar.TextColor = System.Drawing.Color.Black;
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btExcluir.BackColor = System.Drawing.Color.IndianRed;
            this.btExcluir.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btExcluir.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btExcluir.BorderRadius = 10;
            this.btExcluir.BorderSize = 0;
            this.btExcluir.FlatAppearance.BorderSize = 0;
            this.btExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExcluir.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btExcluir.ForeColor = System.Drawing.Color.Black;
            this.btExcluir.Location = new System.Drawing.Point(852, 8);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(120, 40);
            this.btExcluir.TabIndex = 58;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.TextColor = System.Drawing.Color.Black;
            this.btExcluir.UseVisualStyleBackColor = false;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // dgPesquisaPessoas
            // 
            this.dgPesquisaPessoas.AllowUserToAddRows = false;
            this.dgPesquisaPessoas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPesquisaPessoas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgPesquisaPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgPesquisaPessoas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgPesquisaPessoas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgPesquisaPessoas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgPesquisaPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesquisaPessoas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPesquisaPessoas.EnableHeadersVisualStyles = false;
            this.dgPesquisaPessoas.Location = new System.Drawing.Point(0, 100);
            this.dgPesquisaPessoas.MultiSelect = false;
            this.dgPesquisaPessoas.Name = "dgPesquisaPessoas";
            this.dgPesquisaPessoas.ReadOnly = true;
            this.dgPesquisaPessoas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgPesquisaPessoas.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgPesquisaPessoas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgPesquisaPessoas.RowTemplate.Height = 25;
            this.dgPesquisaPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgPesquisaPessoas.Size = new System.Drawing.Size(984, 501);
            this.dgPesquisaPessoas.TabIndex = 2;
            this.dgPesquisaPessoas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPesquisaPessoas_CellClick);
            // 
            // FormConsultaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.dgPesquisaPessoas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormConsultaPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Pessoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConsultaPessoa_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesquisaPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private SISVEN.custom.RJTextBox txtFiltro;
        private SISVEN.custom.RJComboBox cbRegistro;
        private SISVEN.custom.RJButton btPesquisar;
        private SISVEN.custom.RJButton btNovo;
        private SISVEN.custom.RJButton btEditar;
        private SISVEN.custom.RJButton btExcluir;
        private System.Windows.Forms.DataGridView dgPesquisaPessoas;
        private SISVEN.custom.RJComboBox cbTipo;
    }
}