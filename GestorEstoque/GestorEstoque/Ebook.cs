using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    [System.Serializable]
    class Ebook : Produto, IEstoque
    {
        public string autor;
        private int vendas;

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            Console.WriteLine("Não é possível dar entrada no estoque de um E-book, pois trata-se de um produto digital!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar venda no E-book: {nome}");
            Console.WriteLine($"Digite a quantidade de vendas que você deseja adicionar:");
            int saida = int.Parse(Console.ReadLine());
            vendas += saida;
            Console.WriteLine("Saída registrada!");
            Console.ReadLine();
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome do E-book: {nome}");
            Console.WriteLine($"Autor do E-book: {autor}");
            Console.WriteLine($"Preço do E-book: {preco}");
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("=====================================");
        }
    }
}
