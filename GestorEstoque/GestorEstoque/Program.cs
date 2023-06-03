using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    internal class Program
    {
        static List<IEstoque> produtos = new List<IEstoque>();
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }
        enum OpcaoProduto { ProdutoFísico = 1, Ebook, Curso }
        static void Main(string[] args)
        {
            Carregar();
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
                            Listagem();
                            break;
                        case Menu.Adicionar:
                            Cadastro();
                            break;
                        case Menu.Remover:
                            Remover();
                            break;
                        case Menu.Entrada:
                            Entrada();
                            break;
                        case Menu.Saida:
                            Saida();
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

        static void Listagem()
        {
            Console.WriteLine("Lista de produtos:");
            int id = 0;
            foreach (IEstoque produto in produtos)
            {
                Console.WriteLine($"ID: {id}");
                produto.Exibir();
                id++;
            }
            Console.ReadLine();
        }

        static void Remover()
        {
            Listagem();
            Console.WriteLine("Digite o ID do produto que você deseja remover:");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos.RemoveAt(id);
                Salvar();
            }
        }

        static void Entrada()
        {
            Listagem();
            Console.WriteLine("Digite o ID do produto que você deseja dar entrada:");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarEntrada();
                Salvar();
            }
        }

        static void Saida()
        {
            Listagem();
            Console.WriteLine("Digite o ID do produto que você deseja dar baixa:");
            int id = int.Parse(Console.ReadLine());
            if (id >= 0 && id < produtos.Count)
            {
                produtos[id].AdicionarSaida();
                Salvar();
            }
        }

        static void Cadastro()
        {

            Console.WriteLine("Cadastro de produto:");
            Console.WriteLine("1 - Produto Físico\n2 - E-book\n3 - Curso");
            string opcEsc = Console.ReadLine();
            int escolhaInt = int.Parse(opcEsc);
            OpcaoProduto opcaoProduto = (OpcaoProduto)escolhaInt;

            switch (opcaoProduto)
            {
                case OpcaoProduto.ProdutoFísico:
                    CadastrarProdFisico();
                    break;
                case OpcaoProduto.Ebook:
                    CadastrarEbook();
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
            produtos.Add(pf);
            Salvar();
        }

        static void CadastrarEbook()
        {
            Console.WriteLine("Cadastrando E-book:");
            Console.WriteLine("Nome do E-book:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço do E-book:");
            float preco = float.Parse(Console.ReadLine());
            Console.WriteLine("Autor do E-book:");
            string autor = Console.ReadLine();

            Ebook ebook = new Ebook(nome, preco, autor);
            produtos.Add(ebook);
            Salvar();
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
            produtos.Add(curso);
            Salvar();
        }

        static void Salvar()
        {
            FileStream salvandoOsArquivos = new FileStream("produtosEstoque.dat", FileMode.OpenOrCreate);
            BinaryFormatter codificandoArquivos = new BinaryFormatter();

            codificandoArquivos.Serialize(salvandoOsArquivos, produtos);

            salvandoOsArquivos.Close();
        }

        static void Carregar()
        {
            FileStream salvandoOsArquivos = new FileStream("produtosEstoque.dat", FileMode.OpenOrCreate);
            BinaryFormatter codificandoArquivos = new BinaryFormatter();

            try
            {
                produtos = (List<IEstoque>)codificandoArquivos.Deserialize(salvandoOsArquivos);

                if (produtos == null)
                {
                    produtos = new List<IEstoque>();
                }
            }
            catch (Exception ex)
            {
                produtos = new List<IEstoque>();
            }

            salvandoOsArquivos.Close();
        }
    }
}
