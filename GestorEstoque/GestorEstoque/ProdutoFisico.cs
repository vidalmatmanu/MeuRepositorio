using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    class ProdutoFisico : Produto, IEstoque
    {
        public float frete;
        private float estoque;

        public ProdutoFisico(string nome, float preco, float frete) 
        { 
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public void AdicionarEntrada()
        {
            throw new NotImplementedException();
        }

        public void AdicionarSaida()
        {
            throw new NotImplementedException();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome do produto: {nome}");            
            Console.WriteLine($"Preço do produto: {preco}");
            Console.WriteLine($"Valor do frete: {frete}");
            Console.WriteLine($"Estoque: {estoque}");
            Console.WriteLine("=====================================");
        }
    }
}
