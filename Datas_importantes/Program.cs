using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas_importantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o formato de data você deseja utilizar:");
            Console.WriteLine("1 - Formatação de sua máquina");
            Console.WriteLine("2 - Formatação simples");
            Console.WriteLine("3 - Formatação longa");
            Console.WriteLine("4 - Formatação longa personalizada");
            Console.WriteLine("5 - Formatação  RFC1123");

            do
            {
                Console.Write("Insira o numero da opção que deseja: ");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha >= 1 && escolha <= 5) {

                    switch (escolha)
                    {
                        case 1:
                            Console.WriteLine();
                            Console.WriteLine("Escolha qual evento historico deseja visualiar:");
                            Console.WriteLine("1 - ENIAC");
                            Console.WriteLine("2 - RFC1");
                            Console.WriteLine("3 - História de Alan Turing");

                            do
                            {
                                Console.Write("Insira o numero da opção que deseja: ");
                                int opcao = int.Parse(Console.ReadLine());

                                if (opcao >= 1 && opcao <= 3) {

                                    switch(opcao)
                                    {
                                        case 1:
                                            Console.WriteLine();
                                            break;

                                        case 2:
                                            Console.WriteLine();
                                            break;

                                        case 3:
                                            Console.WriteLine();
                                            break;
                                    }
                                    break;
                                }
                                Console.WriteLine();
                                Console.WriteLine("Opção invalida! Escolha outra opção novamente");
                            } while (true);
                            break;

                        case 2:
                            Console.WriteLine();
                            break;

                        case 3:
                            Console.WriteLine();
                            break;

                        case 4:
                            Console.WriteLine();
                            break;

                        case 5:
                            Console.WriteLine();
                            break;
                    }
                    break;
                }
                Console.WriteLine("Opção invalida! Escolha outra opção novamente");
            } while (true);

        }
    }
}
