using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    class Livro : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Livro(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
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
            Console.WriteLine($"Nome do Livro: {nome}");
            Console.WriteLine($"Autor do Livro: {autor}");
            Console.WriteLine($"Preço do Livro: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("=====================================");
        }
    }
}
