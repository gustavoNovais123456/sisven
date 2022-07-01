namespace TccAtualizado
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelSubCadastro = new System.Windows.Forms.Panel();
            this.btCadProduto = new System.Windows.Forms.Button();
            this.btCadPessoa = new System.Windows.Forms.Button();
            this.btCadastros = new System.Windows.Forms.Button();
            this.SubMenuPessoa = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubMenuProduto = new CustomControls.RJControls.RJDropdownMenu(this.components);
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelSubCadastro.SuspendLayout();
            this.SubMenuPessoa.SuspendLayout();
            this.SubMenuProduto.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panelBarra.Controls.Add(this.minimize);
            this.panelBarra.Controls.Add(this.close);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(1208, 32);
            this.panelBarra.TabIndex = 0;
            // 
            // minimize
            // 
            this.minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(1144, 0);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(32, 32);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimize.TabIndex = 3;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // close
            // 
            this.close.Dock = System.Windows.Forms.DockStyle.Right;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(1176, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(32, 32);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 4;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.panelSubCadastro);
            this.panel1.Controls.Add(this.btCadastros);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(190, 559);
            this.panel1.TabIndex = 1;
            // 
            // panelSubCadastro
            // 
            this.panelSubCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(91)))), ((int)(((byte)(98)))));
            this.panelSubCadastro.Controls.Add(this.btCadProduto);
            this.panelSubCadastro.Controls.Add(this.btCadPessoa);
            this.panelSubCadastro.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubCadastro.Location = new System.Drawing.Point(0, 63);
            this.panelSubCadastro.Name = "panelSubCadastro";
            this.panelSubCadastro.Size = new System.Drawing.Size(190, 126);
            this.panelSubCadastro.TabIndex = 9;
            // 
            // btCadProduto
            // 
            this.btCadProduto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadProduto.FlatAppearance.BorderSize = 0;
            this.btCadProduto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCadProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btCadProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadProduto.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadProduto.ForeColor = System.Drawing.Color.White;
            this.btCadProduto.Image = ((System.Drawing.Image)(resources.GetObject("btCadProduto.Image")));
            this.btCadProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadProduto.Location = new System.Drawing.Point(0, 53);
            this.btCadProduto.Name = "btCadProduto";
            this.btCadProduto.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btCadProduto.Size = new System.Drawing.Size(190, 53);
            this.btCadProduto.TabIndex = 3;
            this.btCadProduto.Text = "Cadastro Produto";
            this.btCadProduto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadProduto.UseVisualStyleBackColor = true;
            this.btCadProduto.Click += new System.EventHandler(this.btCadProduto_Click);
            // 
            // btCadPessoa
            // 
            this.btCadPessoa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadPessoa.FlatAppearance.BorderSize = 0;
            this.btCadPessoa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btCadPessoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SlateGray;
            this.btCadPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadPessoa.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadPessoa.ForeColor = System.Drawing.Color.White;
            this.btCadPessoa.Image = ((System.Drawing.Image)(resources.GetObject("btCadPessoa.Image")));
            this.btCadPessoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadPessoa.Location = new System.Drawing.Point(0, 0);
            this.btCadPessoa.Name = "btCadPessoa";
            this.btCadPessoa.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btCadPessoa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btCadPessoa.Size = new System.Drawing.Size(190, 53);
            this.btCadPessoa.TabIndex = 2;
            this.btCadPessoa.Text = "Cadastro Pessoa";
            this.btCadPessoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadPessoa.UseVisualStyleBackColor = true;
            this.btCadPessoa.Click += new System.EventHandler(this.btCadPessoa_Click);
            // 
            // btCadastros
            // 
            this.btCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btCadastros.FlatAppearance.BorderSize = 0;
            this.btCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastros.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btCadastros.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btCadastros.Image = ((System.Drawing.Image)(resources.GetObject("btCadastros.Image")));
            this.btCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastros.Location = new System.Drawing.Point(0, 0);
            this.btCadastros.Name = "btCadastros";
            this.btCadastros.Padding = new System.Windows.Forms.Padding(15, 5, 25, 0);
            this.btCadastros.Size = new System.Drawing.Size(190, 63);
            this.btCadastros.TabIndex = 8;
            this.btCadastros.Text = "Cadastros";
            this.btCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btCadastros.UseMnemonic = false;
            this.btCadastros.UseVisualStyleBackColor = true;
            this.btCadastros.Click += new System.EventHandler(this.btCadastros_Click);
            // 
            // SubMenuPessoa
            // 
            this.SubMenuPessoa.DropShadowEnabled = false;
            this.SubMenuPessoa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SubMenuPessoa.IsMainMenu = false;
            this.SubMenuPessoa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.SubMenuPessoa.MenuItemHeight = 25;
            this.SubMenuPessoa.MenuItemTextColor = System.Drawing.Color.Empty;
            this.SubMenuPessoa.Name = "rjDropdownMenu1";
            this.SubMenuPessoa.PrimaryColor = System.Drawing.Color.Empty;
            this.SubMenuPessoa.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SubMenuPessoa.Size = new System.Drawing.Size(163, 82);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.clienteToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clienteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.clienteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clienteToolStripMenuItem.Image")));
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.funcionarioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.funcionarioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.funcionarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionarioToolStripMenuItem.Image")));
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usuarioToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.usuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioToolStripMenuItem.Image")));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // SubMenuProduto
            // 
            this.SubMenuProduto.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SubMenuProduto.IsMainMenu = false;
            this.SubMenuProduto.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.categoriaToolStripMenuItem});
            this.SubMenuProduto.MenuItemHeight = 25;
            this.SubMenuProduto.MenuItemTextColor = System.Drawing.Color.Empty;
            this.SubMenuProduto.Name = "SubMenuProduto";
            this.SubMenuProduto.PrimaryColor = System.Drawing.Color.Empty;
            this.SubMenuProduto.Size = new System.Drawing.Size(147, 56);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.produtoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("produtoToolStripMenuItem.Image")));
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // categoriaToolStripMenuItem
            // 
            this.categoriaToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.categoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("categoriaToolStripMenuItem.Image")));
            this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
            this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.categoriaToolStripMenuItem.Text = "Categoria";
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(190, 32);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(1018, 559);
            this.panelConteudo.TabIndex = 2;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 591);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelBarra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelSubCadastro.ResumeLayout(false);
            this.SubMenuPessoa.ResumeLayout(false);
            this.SubMenuProduto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btCadastros;
        private System.Windows.Forms.Panel panelSubCadastro;
        private System.Windows.Forms.Button btCadPessoa;
        private CustomControls.RJControls.RJDropdownMenu SubMenuPessoa;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.Button btCadProduto;
        private CustomControls.RJControls.RJDropdownMenu SubMenuProduto;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.PictureBox close;
    }
}
