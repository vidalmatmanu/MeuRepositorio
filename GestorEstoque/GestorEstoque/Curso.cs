using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    [System.Serializable]
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
            Console.WriteLine($"Adicionar vaga no curso: {nome}");
            Console.WriteLine($"Digite a quantidade de vagas que você deseja adicionar:");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine("Entrada registrada!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Consumir vaga no curso: {nome}");
            Console.WriteLine($"Digite a quantidade de vagas que você deseja consumir:");
            int saida = int.Parse(Console.ReadLine());
            vagas -= saida;
            Console.WriteLine("Saída registrada!");
            Console.ReadLine();
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
