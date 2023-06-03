using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    internal class Program
    {
        static List<IEstoque> Produtos = new List<IEstoque>();
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }
        enum OpcaoProduto { ProdutoFísico = 1, Livro, Curso }
        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while (!escolheuSair)
            {

                Console.WriteLine("Sistema de Estoque");
                Console.WriteLine("1 - Listar\n2 - Adicionar\n3 - Remover\n4 - Registar Entrada\n5 - Registrar Saída\n6 - Sair");
                string opcEscolhida = Console.ReadLine();
                int opcInt = int.Parse(opcEscolhida);

                if (opcInt > 0 && opcInt < 7)
                {
                    Menu escolha = (Menu)opcInt;

                    switch (escolha)
                    {
                        case Menu.Listar:
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.Entrada:
                            break;
                        case Menu.Saida:
                            break;
                        case Menu.Sair:
                            escolheuSair = true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }
                Console.Clear();
            }

        }

        static void Cadastro()
        {

            Console.WriteLine("Cadastro de produto:");
            Console.WriteLine("1 - Produto Físico\n2 - Livro\n3 - Curso");
            string opcEsc = Console.ReadLine();
            int escolhaInt = int.Parse(opcEsc);
            OpcaoProduto opcaoProduto = (OpcaoProduto)escolhaInt;

            switch (opcaoProduto)
            {
                case OpcaoProduto.ProdutoFísico:
                    CadastrarProdFisico();
                    break;
                case OpcaoProduto.Livro:
                    CadastrarLivro();
                    break;
                case OpcaoProduto.Curso:
                    CadastrarCurso();
                    break;
            }

        }

        static void CadastrarProdFisico()
        {
            Console.WriteLine("Cadastrando produto físico:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Valor do frete:");
            float frete = float.Parse(Console.ReadLine());

            ProdutoFisico pf = new ProdutoFisico(nome, preco, frete);
            Produtos.Add(pf);
        }

        static void CadastrarLivro()
        {
            Console.WriteLine("Cadastrando livro:");
            Console.WriteLine("Nome do livro:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço do livro:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor do livro:");
            string autor = Console.ReadLine();

            Livro livro = new Livro(nome, preco, autor);
            Produtos.Add(livro);
        }

        static void CadastrarCurso()
        {
            Console.WriteLine("Cadastrando curso:");
            Console.WriteLine("Nome do curso:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço do curso:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor do curso:");
            string autor = Console.ReadLine();

            Curso curso = new Curso(nome, preco, autor);
            Produtos.Add(curso);
        }
    }
}
