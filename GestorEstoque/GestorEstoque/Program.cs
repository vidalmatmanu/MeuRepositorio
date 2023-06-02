using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorEstoque
{
    internal class Program
    {
        enum Menu { Listar = 1, Adicionar, Remover, Entrada, Saida, Sair }

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
                            break;
                        case Menu.Remover:
                            break;
                        case Menu.Entrada:
                            break;
                        case Menu.Saida:
                            break;
                        case Menu.Sair:
                            escolheuSair |= true;
                            break;
                    }
                }
                else
                {
                    escolheuSair = true;
                }

            }

        }
    }
}
