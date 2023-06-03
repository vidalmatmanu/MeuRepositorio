using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    class Curso : Produto, IEstoque
    {
        public string autor;
        private int vagas;

        public Curso(string nome, float preco, string autor)
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
            Console.WriteLine($"Nome do Curso: {nome}");
            Console.WriteLine($"Autor do Curso: {autor}");
            Console.WriteLine($"Preço do Curso: {preco}");
            Console.WriteLine($"Vagas restantes do Curso: {vagas}");
            Console.WriteLine("=====================================");
        }
    }
}
