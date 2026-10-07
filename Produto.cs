using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaComercial
{
    public class Produto
    {
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public decimal Preco { get; set; }

        public int Estoque { get; set; }

        public string Categoria { get; set; }
    }
}
