namespace SistemaComercial
{
    partial class FormProdutos
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
            lblTitulo = new Label();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblNome = new Label();
            txtNome = new TextBox();
            lblPreco = new Label();
            txtPreco = new TextBox();
            lblEstoque = new Label();
            textBox1 = new TextBox();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            dgvProdutos = new DataGridView();
            colCodigo = new DataGridViewTextBoxColumn();
            colNome = new DataGridViewTextBoxColumn();
            colPreco = new DataGridViewTextBoxColumn();
            colEstoque = new DataGridViewTextBoxColumn();
            colCategoria = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 30F);
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(984, 50);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CADASTRO DE PRODUTOS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 15F);
            lblCodigo.Location = new Point(146, 129);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(81, 28);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(233, 132);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(192, 23);
            txtCodigo.TabIndex = 2;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 15F);
            lblNome.Location = new Point(477, 129);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(70, 28);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(569, 132);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(214, 23);
            txtNome.TabIndex = 4;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Font = new Font("Segoe UI", 15F);
            lblPreco.Location = new Point(146, 196);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(65, 28);
            lblPreco.TabIndex = 5;
            lblPreco.Text = "Preço:";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(224, 199);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(201, 23);
            txtPreco.TabIndex = 6;
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Font = new Font("Segoe UI", 15F);
            lblEstoque.Location = new Point(477, 196);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(86, 28);
            lblEstoque.TabIndex = 7;
            lblEstoque.Text = "Estoque:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(569, 199);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(214, 23);
            textBox1.TabIndex = 8;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 15F);
            lblCategoria.Location = new Point(146, 272);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(101, 28);
            lblCategoria.TabIndex = 0;
            lblCategoria.Text = "Categoria:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Informática", "Periféricos", "Monitores", "Acessórios", "Móveis", "Software", "Outros" });
            cmbCategoria.Location = new Point(247, 275);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(178, 23);
            cmbCategoria.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Font = new Font("Segoe UI", 15F);
            btnCadastrar.Location = new Point(199, 335);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(113, 37);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.TopCenter;
            btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            btnAlterar.Font = new Font("Segoe UI", 15F);
            btnAlterar.Location = new Point(356, 335);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(113, 37);
            btnAlterar.TabIndex = 11;
            btnAlterar.Text = "Alterar";
            btnAlterar.TextAlign = ContentAlignment.TopCenter;
            btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Font = new Font("Segoe UI", 15F);
            btnExcluir.Location = new Point(513, 335);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(113, 37);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.TextAlign = ContentAlignment.TopCenter;
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            btnLimpar.Font = new Font("Segoe UI", 15F);
            btnLimpar.Location = new Point(670, 335);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(113, 37);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.TextAlign = ContentAlignment.TopCenter;
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // dgvProdutos
            // 
            dgvProdutos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Columns.AddRange(new DataGridViewColumn[] { colCodigo, colNome, colPreco, colEstoque, colCategoria });
            dgvProdutos.Location = new Point(178, 407);
            dgvProdutos.MultiSelect = false;
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProdutos.Size = new Size(605, 192);
            dgvProdutos.TabIndex = 14;
            // 
            // colCodigo
            // 
            colCodigo.HeaderText = "Código";
            colCodigo.Name = "colCodigo";
            // 
            // colNome
            // 
            colNome.HeaderText = "Nome";
            colNome.Name = "colNome";
            // 
            // colPreco
            // 
            colPreco.HeaderText = "Preço";
            colPreco.Name = "colPreco";
            // 
            // colEstoque
            // 
            colEstoque.HeaderText = "Estoque";
            colEstoque.Name = "colEstoque";
            // 
            // colCategoria
            // 
            colCategoria.HeaderText = "Categoria";
            colCategoria.Name = "colCategoria";
            // 
            // FormProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(dgvProdutos);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(textBox1);
            Controls.Add(lblEstoque);
            Controls.Add(txtPreco);
            Controls.Add(lblPreco);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(lblTitulo);
            Name = "FormProdutos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCodigo;
        private TextBox txtCodigo;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblPreco;
        private TextBox txtPreco;
        private Label lblEstoque;
        private TextBox textBox1;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Button btnLimpar;
        private DataGridView dgvProdutos;
        private DataGridViewTextBoxColumn colCodigo;
        private DataGridViewTextBoxColumn colNome;
        private DataGridViewTextBoxColumn colPreco;
        private DataGridViewTextBoxColumn colEstoque;
        private DataGridViewTextBoxColumn colCategoria;
    }
}