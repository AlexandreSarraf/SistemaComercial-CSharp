using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaComercial
{
    public partial class FormProdutos : Form
    {
        private List<Produto> produtos = new List<Produto>();

        private void AtualizarGrid()
        {
            dgvProdutos.Rows.Clear();

            foreach (Produto produto in produtos)
            {
                dgvProdutos.Rows.Add(
                    produto.Codigo,
                    produto.Nome,
                    produto.Preco.ToString("C2"),
                    produto.Estoque,
                    produto.Categoria
                );
            }
        }

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" ||
                txtNome.Text == "" ||
                txtPreco.Text == "" ||
                txtEstoque.Text == "" ||
                cmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Preencha todos os campos.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoque))
            {
                MessageBox.Show("Estoque inválido.");
                return;
            }

            Produto produto = new Produto
            {
                Codigo = codigo,
                Nome = txtNome.Text,
                Preco = preco,
                Estoque = estoque,
                Categoria = cmbCategoria.Text
            };

            produtos.Add(produto);

            dgvProdutos.Rows.Add(
                produto.Codigo,
                produto.Nome,
                produto.Preco.ToString("C2"),
                produto.Estoque,
                produto.Categoria
            );

            MessageBox.Show(
                "Produto cadastrado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();

            cmbCategoria.SelectedIndex = -1;

            txtCodigo.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCodigo.Text, out int codigo))
            {
                MessageBox.Show("Código inválido.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoque))
            {
                MessageBox.Show("Estoque inválido.");
                return;
            }

            Produto produto = produtos.FirstOrDefault(p => p.Codigo == codigo);

            if (produto == null)
            {
                MessageBox.Show(
                    "Produto não encontrado.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            produto.Nome = txtNome.Text;
            produto.Preco = preco;
            produto.Estoque = estoque;
            produto.Categoria = cmbCategoria.Text;

            AtualizarGrid();

            MessageBox.Show(
                "Produto alterado com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
