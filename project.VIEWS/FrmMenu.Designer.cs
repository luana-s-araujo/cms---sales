namespace CMS.project.VIEWS
{
    partial class FrmMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocaUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSairSistema = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastrarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultarProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtdata = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txthora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuHistóricoDeVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionario,
            this.menuConfiguracoes,
            this.menuProdutos,
            this.menuVendas});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1221, 253);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroCliente,
            this.menuConsultaCliente});
            this.menuCliente.Image = global::CMS.Properties.Resources.clientes;
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(239, 249);
            this.menuCliente.Text = "Clientes";
            this.menuCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuCadastroCliente
            // 
            this.menuCadastroCliente.Name = "menuCadastroCliente";
            this.menuCadastroCliente.Size = new System.Drawing.Size(228, 26);
            this.menuCadastroCliente.Text = "Cadastro de Clientes";
            this.menuCadastroCliente.Click += new System.EventHandler(this.menuCadastroCliente_Click);
            // 
            // menuConsultaCliente
            // 
            this.menuConsultaCliente.Name = "menuConsultaCliente";
            this.menuConsultaCliente.Size = new System.Drawing.Size(228, 26);
            this.menuConsultaCliente.Text = "Consulta de Clientes";
            this.menuConsultaCliente.Click += new System.EventHandler(this.menuConsultaCliente_Click);
            // 
            // menuFuncionario
            // 
            this.menuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFuncionario,
            this.menuConsultaFuncionario});
            this.menuFuncionario.Image = global::CMS.Properties.Resources.funcionarios;
            this.menuFuncionario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFuncionario.Name = "menuFuncionario";
            this.menuFuncionario.Size = new System.Drawing.Size(239, 249);
            this.menuFuncionario.Text = "Funcionários";
            this.menuFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuCadastroFuncionario
            // 
            this.menuCadastroFuncionario.Name = "menuCadastroFuncionario";
            this.menuCadastroFuncionario.Size = new System.Drawing.Size(259, 26);
            this.menuCadastroFuncionario.Text = "Cadastro de Funcionários";
            this.menuCadastroFuncionario.Click += new System.EventHandler(this.menuCadastroFuncionario_Click);
            // 
            // menuConsultaFuncionario
            // 
            this.menuConsultaFuncionario.Name = "menuConsultaFuncionario";
            this.menuConsultaFuncionario.Size = new System.Drawing.Size(259, 26);
            this.menuConsultaFuncionario.Text = "Consulta de Funcionários";
            this.menuConsultaFuncionario.Click += new System.EventHandler(this.menuConsultaFuncionario_Click);
            // 
            // menuConfiguracoes
            // 
            this.menuConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocaUsuario,
            this.menuSairSistema});
            this.menuConfiguracoes.Image = global::CMS.Properties.Resources.config;
            this.menuConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConfiguracoes.Name = "menuConfiguracoes";
            this.menuConfiguracoes.Size = new System.Drawing.Size(239, 249);
            this.menuConfiguracoes.Text = "Configurações";
            this.menuConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuTrocaUsuario
            // 
            this.menuTrocaUsuario.Name = "menuTrocaUsuario";
            this.menuTrocaUsuario.Size = new System.Drawing.Size(224, 26);
            this.menuTrocaUsuario.Text = "Trocar Usuário";
            // 
            // menuSairSistema
            // 
            this.menuSairSistema.Name = "menuSairSistema";
            this.menuSairSistema.Size = new System.Drawing.Size(224, 26);
            this.menuSairSistema.Text = "Sair do Sistema";
            this.menuSairSistema.Click += new System.EventHandler(this.menuSairSistema_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastrarProdutos,
            this.menuConsultarProdutos});
            this.menuProdutos.Image = global::CMS.Properties.Resources.funcionarios;
            this.menuProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(239, 249);
            this.menuProdutos.Text = "Produtos";
            this.menuProdutos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuCadastrarProdutos
            // 
            this.menuCadastrarProdutos.Name = "menuCadastrarProdutos";
            this.menuCadastrarProdutos.Size = new System.Drawing.Size(224, 26);
            this.menuCadastrarProdutos.Text = "Cadastrar Produto";
            this.menuCadastrarProdutos.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // menuConsultarProdutos
            // 
            this.menuConsultarProdutos.Name = "menuConsultarProdutos";
            this.menuConsultarProdutos.Size = new System.Drawing.Size(224, 26);
            this.menuConsultarProdutos.Text = "Consultar Produto";
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaVenda,
            this.menuHistóricoDeVendas});
            this.menuVendas.Image = global::CMS.Properties.Resources.funcionarios;
            this.menuVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(239, 249);
            this.menuVendas.Text = "Vendas";
            this.menuVendas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(224, 26);
            this.menuNovaVenda.Text = "Nova Venda";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtdata,
            this.toolStripStatusLabel3,
            this.txthora,
            this.toolStripStatusLabel5,
            this.txtusuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 441);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1221, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(81, 20);
            this.toolStripStatusLabel1.Text = "Data atual:";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // txtdata
            // 
            this.txtdata.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(95, 20);
            this.txtdata.Text = "17/08/2022";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(82, 20);
            this.toolStripStatusLabel3.Text = "Hora atual:";
            // 
            // txthora
            // 
            this.txthora.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(49, 20);
            this.txthora.Text = "15:06";
            this.txthora.Click += new System.EventHandler(this.txthora_Click);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(118, 20);
            this.toolStripStatusLabel5.Text = "Usuário  logado:";
            // 
            // txtusuario
            // 
            this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(30, 20);
            this.txtusuario.Text = "Sol";
            // 
            // menuHistóricoDeVendas
            // 
            this.menuHistóricoDeVendas.Name = "menuHistóricoDeVendas";
            this.menuHistóricoDeVendas.Size = new System.Drawing.Size(224, 26);
            this.menuHistóricoDeVendas.Text = "Histórico de Vendas";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CMS.Properties.Resources.dicas_gestao_financeira;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1221, 467);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaCliente;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem menuTrocaUsuario;
        private System.Windows.Forms.ToolStripMenuItem menuSairSistema;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripMenuItem menuCadastrarProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuConsultarProdutos;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuNovaVenda;
        public System.Windows.Forms.ToolStripMenuItem menuProdutos;
        public System.Windows.Forms.ToolStripMenuItem menuHistóricoDeVendas;
        public System.Windows.Forms.ToolStripStatusLabel txtdata;
        public System.Windows.Forms.ToolStripStatusLabel txthora;
        public System.Windows.Forms.ToolStripStatusLabel txtusuario;
        private System.Windows.Forms.Timer timer1;
    }
}