using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Datas_importantes
{
    internal class DataConfiguracao
    {
        public DataConfiguracao() 
        {
            Formato = 1;
        }
        private byte Formato { get; set; }

        private List <DateTime> ListaDatasImportanteTI
        {
            get => new List<DateTime>() {
                new DateTime(1946, 8, 15),
                new DateTime(1969, 4, 17),
                new DateTime(1912, 6, 23)
            };
        }

        public void SolicitarFormatoData()
        {
            DateTime dataAgora = DateTime.Now;
            Console.Clear();
            Console.WriteLine("Escolha o formato de data você deseja utilizar:");
            Console.WriteLine($"1 - Formatação de sua máquina: {dataAgora.ToString()}");
            Console.WriteLine($"2 - Formatação simples: {string.Format("{0:dd-MM-yy}", dataAgora)}");
            Console.WriteLine($"3 - Formatação longa: {dataAgora.ToLongDateString()}");
            Console.WriteLine($"4 - Formatação longa personalizada: {string.Format("{0:dd-MM-yyyy hh:mm:ss}", dataAgora)}");
            Console.WriteLine($"5 - Formatação  RFC1123 pattern: {string.Format("{0:r}", dataAgora)}");

            Console.Write("Insira o numero da opção que deseja: ");
            byte escolha = byte.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Formato = escolha; break;
                default:
                    Console.WriteLine("Opção invalida. Pressione qualquer tecla para voltar ao menu de formato de data.");
                    Console.ReadKey();
                    SolicitarFormatoData();
                    break;
            }
        }
        
        public void ExibirMenuDataTecnologia()
        {
            Console.Clear();
            Console.WriteLine("Selecione a data especial que deseja consultar:");
            Console.WriteLine("1- ENIAC");
            Console.WriteLine("2- RFC1");
            Console.WriteLine("3- Alan Turing");
            Console.WriteLine("Qualquer outro valor para sair.");

            Console.Write("Insira a opção desejada: ");
            var opcao = byte.Parse(Console.ReadLine());

            if (opcao == 1 || opcao == 2 || opcao == 3)
                ExibirDetalhesData(opcao);
            else
                Console.WriteLine("Opção invalida. Pressione qualquer tecla para voltar ao menu de formato de data.");
                Console.ReadKey();
                ExibirMenuDataTecnologia();
        }
        private void ExibirDetalhesData(byte opcaoDataTecnologia)
        {
            Console.Clear();
            ExibirCabecalhoDataFormatada(opcaoDataTecnologia);

            switch (opcaoDataTecnologia)
            {
                case 1:
                    Console.WriteLine();
                    Console.WriteLine(@"No dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine(@"Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine(@"Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o ""pai da informática"" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                    break;
            }

            Console.ReadKey();
            ExibirMenuDataTecnologia(); //retornar ao menu
        }

        private void ExibirCabecalhoDataFormatada(byte opcaoDataTecnologia)
        {
            // pegar na lista de datas, a data escolhida pelo usuário:
            DateTime dataEscolhida = ListaDatasImportanteTI[opcaoDataTecnologia - 1];
            string dataFormatada = FormatarData(dataEscolhida);

            Console.WriteLine(dataFormatada);
        }

        private string FormatarData(DateTime data)
        {
            string dataFormatada;
            switch (Formato)
            {
                case 1: dataFormatada = data.ToString(); break;
                case 2: dataFormatada = string.Format("{0:dd-MM-yy}", data); break;
                case 3: dataFormatada = data.ToLongDateString(); break;
                case 4: dataFormatada = string.Format("{0:dd-MM-yyyy hh:mm:ss}", data); break;
                case 5: dataFormatada = string.Format("{0:r}", data); break;
                default: dataFormatada = data.ToString(); break;
            }
            return dataFormatada;
        }
    }
}
