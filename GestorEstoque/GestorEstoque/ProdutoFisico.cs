using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    internal class ProdutoFisico : Produto
    {
        public float frete;
        private float estoque;

        public ProdutoFisico(string nome, float preco, float frete) 
        { 
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }
    }
}
