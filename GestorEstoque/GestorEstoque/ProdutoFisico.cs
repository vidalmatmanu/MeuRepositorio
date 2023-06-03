using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    [System.Serializable]
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
            Console.WriteLine($"Adicionar entrada no estoque do produto: {nome}");
            Console.WriteLine($"Digite a quantidade que você deseja dar entrada:");
            int entrada = int.Parse(Console.ReadLine());  
            estoque += entrada;
            Console.WriteLine("Entrada registrada!");
            Console.ReadLine();
        }

        public void AdicionarSaida()
        {
            Console.WriteLine($"Adicionar saída no estoque do produto: {nome}");
            Console.WriteLine($"Digite a quantidade que você deseja dar baixa:");
            int saida = int.Parse(Console.ReadLine());
            estoque -= saida;
            Console.WriteLine("Saída registrada!");
            Console.ReadLine();
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
