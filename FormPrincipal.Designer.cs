namespace SistemaComercial
{
    partial class FormPrincipal
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
            menuStrip1 = new MenuStrip();
            mnuClientes = new ToolStripMenuItem();
            mnuProdutos = new ToolStripMenuItem();
            mnuVendas = new ToolStripMenuItem();
            mnuRelatorios = new ToolStripMenuItem();
            mnuUsuarios = new ToolStripMenuItem();
            mnuSair = new ToolStripMenuItem();
            mnuClientesCadastrar = new ToolStripMenuItem();
            mnuClientesPesquisar = new ToolStripMenuItem();
            mnuProdutosCadastrar = new ToolStripMenuItem();
            mnuProdutosPesquisar = new ToolStripMenuItem();
            mnuProdutosEstoque = new ToolStripMenuItem();
            mnuNovaVenda = new ToolStripMenuItem();
            mnuHistoricoVendas = new ToolStripMenuItem();
            mnuRelatorioVendas = new ToolStripMenuItem();
            mnuRelatorioProdutos = new ToolStripMenuItem();
            mnuRelatorioEstoque = new ToolStripMenuItem();
            mnuUsuariosCadastrar = new ToolStripMenuItem();
            mnuUsuariosPermissoes = new ToolStripMenuItem();
            pnlPrincipal = new Panel();
            lblTitulo = new Label();
            menuStrip1.SuspendLayout();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuClientes, mnuProdutos, mnuVendas, mnuRelatorios, mnuUsuarios, mnuSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuClientes
            // 
            mnuClientes.DropDownItems.AddRange(new ToolStripItem[] { mnuClientesCadastrar, mnuClientesPesquisar });
            mnuClientes.Name = "mnuClientes";
            mnuClientes.Size = new Size(61, 20);
            mnuClientes.Text = "Clientes";
            // 
            // mnuProdutos
            // 
            mnuProdutos.DropDownItems.AddRange(new ToolStripItem[] { mnuProdutosCadastrar, mnuProdutosPesquisar, mnuProdutosEstoque });
            mnuProdutos.Name = "mnuProdutos";
            mnuProdutos.Size = new Size(67, 20);
            mnuProdutos.Text = "Produtos";
            // 
            // mnuVendas
            // 
            mnuVendas.DropDownItems.AddRange(new ToolStripItem[] { mnuNovaVenda, mnuHistoricoVendas });
            mnuVendas.Name = "mnuVendas";
            mnuVendas.Size = new Size(56, 20);
            mnuVendas.Text = "Vendas";
            // 
            // mnuRelatorios
            // 
            mnuRelatorios.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioVendas, mnuRelatorioProdutos, mnuRelatorioEstoque });
            mnuRelatorios.Name = "mnuRelatorios";
            mnuRelatorios.Size = new Size(71, 20);
            mnuRelatorios.Text = "Relatórios";
            // 
            // mnuUsuarios
            // 
            mnuUsuarios.DropDownItems.AddRange(new ToolStripItem[] { mnuUsuariosCadastrar, mnuUsuariosPermissoes });
            mnuUsuarios.Name = "mnuUsuarios";
            mnuUsuarios.Size = new Size(64, 20);
            mnuUsuarios.Text = "Usuários";
            // 
            // mnuSair
            // 
            mnuSair.Name = "mnuSair";
            mnuSair.Size = new Size(38, 20);
            mnuSair.Text = "Sair";
            mnuSair.Click += mnuSair_Click;
            // 
            // mnuClientesCadastrar
            // 
            mnuClientesCadastrar.Name = "mnuClientesCadastrar";
            mnuClientesCadastrar.Size = new Size(180, 22);
            mnuClientesCadastrar.Text = "Cadastrar";
            // 
            // mnuClientesPesquisar
            // 
            mnuClientesPesquisar.Name = "mnuClientesPesquisar";
            mnuClientesPesquisar.Size = new Size(180, 22);
            mnuClientesPesquisar.Text = "Pesquisar";
            // 
            // mnuProdutosCadastrar
            // 
            mnuProdutosCadastrar.Name = "mnuProdutosCadastrar";
            mnuProdutosCadastrar.Size = new Size(180, 22);
            mnuProdutosCadastrar.Text = "Cadastrar";
            // 
            // mnuProdutosPesquisar
            // 
            mnuProdutosPesquisar.Name = "mnuProdutosPesquisar";
            mnuProdutosPesquisar.Size = new Size(180, 22);
            mnuProdutosPesquisar.Text = "Pesquisar";
            // 
            // mnuProdutosEstoque
            // 
            mnuProdutosEstoque.Name = "mnuProdutosEstoque";
            mnuProdutosEstoque.Size = new Size(180, 22);
            mnuProdutosEstoque.Text = "Estoque";
            // 
            // mnuNovaVenda
            // 
            mnuNovaVenda.Name = "mnuNovaVenda";
            mnuNovaVenda.Size = new Size(180, 22);
            mnuNovaVenda.Text = "Nova Venda";
            // 
            // mnuHistoricoVendas
            // 
            mnuHistoricoVendas.Name = "mnuHistoricoVendas";
            mnuHistoricoVendas.Size = new Size(180, 22);
            mnuHistoricoVendas.Text = "Histórico";
            // 
            // mnuRelatorioVendas
            // 
            mnuRelatorioVendas.Name = "mnuRelatorioVendas";
            mnuRelatorioVendas.Size = new Size(180, 22);
            mnuRelatorioVendas.Text = "Vendas";
            // 
            // mnuRelatorioProdutos
            // 
            mnuRelatorioProdutos.Name = "mnuRelatorioProdutos";
            mnuRelatorioProdutos.Size = new Size(180, 22);
            mnuRelatorioProdutos.Text = "Produtos";
            // 
            // mnuRelatorioEstoque
            // 
            mnuRelatorioEstoque.Name = "mnuRelatorioEstoque";
            mnuRelatorioEstoque.Size = new Size(180, 22);
            mnuRelatorioEstoque.Text = "Estoque";
            // 
            // mnuUsuariosCadastrar
            // 
            mnuUsuariosCadastrar.Name = "mnuUsuariosCadastrar";
            mnuUsuariosCadastrar.Size = new Size(180, 22);
            mnuUsuariosCadastrar.Text = "Cadastrar";
            // 
            // mnuUsuariosPermissoes
            // 
            mnuUsuariosPermissoes.Name = "mnuUsuariosPermissoes";
            mnuUsuariosPermissoes.Size = new Size(180, 22);
            mnuUsuariosPermissoes.Text = "Permissões";
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Controls.Add(lblTitulo);
            pnlPrincipal.Dock = DockStyle.Fill;
            pnlPrincipal.Location = new Point(0, 24);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(800, 426);
            pnlPrincipal.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 30F);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(800, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA COMERCIAL";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlPrincipal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Comercial";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlPrincipal.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuClientes;
        private ToolStripMenuItem mnuProdutos;
        private ToolStripMenuItem mnuVendas;
        private ToolStripMenuItem mnuRelatorios;
        private ToolStripMenuItem mnuClientesCadastrar;
        private ToolStripMenuItem mnuClientesPesquisar;
        private ToolStripMenuItem mnuProdutosCadastrar;
        private ToolStripMenuItem mnuProdutosPesquisar;
        private ToolStripMenuItem mnuProdutosEstoque;
        private ToolStripMenuItem mnuNovaVenda;
        private ToolStripMenuItem mnuHistoricoVendas;
        private ToolStripMenuItem mnuRelatorioVendas;
        private ToolStripMenuItem mnuRelatorioProdutos;
        private ToolStripMenuItem mnuRelatorioEstoque;
        private ToolStripMenuItem mnuUsuarios;
        private ToolStripMenuItem mnuUsuariosCadastrar;
        private ToolStripMenuItem mnuUsuariosPermissoes;
        private ToolStripMenuItem mnuSair;
        private Panel pnlPrincipal;
        private Label lblTitulo;
    }
}
