using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Equipamento e1 = new Equipamento();

            Console.WriteLine("-- Gerenciamento de equipamentos --");
            int contador = 0;
            int respostaMenu;

            do
            {
                Console.WriteLine("            -- Menu --");
                Console.WriteLine("1 - Visualizar todos os equipamentos\r\n2 - Registrar equipamento\r\n3 - Editar equipamento\r\n4 - Excluir equipamento \r\n5 - Sair do programa");
                Console.Write("-> ");

                respostaMenu = int.Parse(Console.ReadLine());

                if (respostaMenu == 1)
                {
                    if (contador == 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Você ainda não inseriu nenhum equipamento!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("-- Visualizar equipamentos --");
                        Console.WriteLine("Nome do equipamento: " + e1.NomeEquipamento);
                        Console.WriteLine("Preço da data de aquisição: " + e1.PrecoAquisicao);
                        Console.WriteLine("Número de série: " + e1.NumeroSerie);
                        Console.WriteLine("Data de fabricação: " + e1.DataFabricacao);
                        Console.WriteLine("Nome do fabricante: " + e1.NomeFabricante);
                    }
                }
                else if (respostaMenu == 2)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Registrar equipamento");
                    Console.WriteLine("");

                    Console.Write("Digite o nome do equipamento: ");
                    string nomeEquipamento = Console.ReadLine();

                    Console.Write("Digite o preço da data de aquisição: ");
                    double precoAquisicao = double.Parse(Console.ReadLine());

                    Console.Write("Digite o número de série: ");
                    int numeroSerie = int.Parse(Console.ReadLine());

                    Console.Write("Digite a data de fabricação (DD/MM/YYY): ");
                    string dataFabricacao = Console.ReadLine();

                    Console.Write("Digite o nome do fabricante: ");
                    string nomeFabricante = Console.ReadLine();

                    e1.NomeEquipamento = nomeEquipamento;
                    e1.PrecoAquisicao = precoAquisicao;
                    e1.NumeroSerie = numeroSerie;
                    e1.DataFabricacao = dataFabricacao;
                    e1.NomeFabricante = nomeFabricante;

                    contador = 1;
                }
                else if (respostaMenu == 3)
                {
                    Console.WriteLine("");
                    Console.WriteLine("-- Editar equipamento --");
                    Console.WriteLine("");

                    if (contador == 1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Registrar equipamento");
                        Console.WriteLine("");

                        Console.Write("Digite o nome do equipamento: ");
                        string nomeEquipamento = Console.ReadLine();

                        Console.Write("Digite o preço da data de aquisição: ");
                        double precoAquisicao = double.Parse(Console.ReadLine());

                        Console.Write("Digite o número de série: ");
                        int numeroSerie = int.Parse(Console.ReadLine());

                        Console.Write("Digite a data de fabricação (DD/MM/YYY): ");
                        string dataFabricacao = Console.ReadLine();

                        Console.Write("Digite o nome do fabricante: ");
                        string nomeFabricante = Console.ReadLine();

                        e1.NomeEquipamento = nomeEquipamento;
                        e1.PrecoAquisicao = precoAquisicao;
                        e1.NumeroSerie = numeroSerie;
                        e1.DataFabricacao = dataFabricacao;
                        e1.NomeFabricante = nomeFabricante;
                    }
                    else
                    {
                        Console.WriteLine("Você ainda não fez o registro de nenhum equipamento!");
                    }

                    Console.WriteLine("");

                }
                else if (respostaMenu == 4)
                {
                    Console.WriteLine("");
                    Console.WriteLine("-- Excluir equipamento --");
                    Console.WriteLine("");

                    if(contador == 1)
                    {
                        e1.NomeEquipamento = null;
                        e1.PrecoAquisicao = 0;
                        e1.NumeroSerie = 0;
                        e1.DataFabricacao = null;
                        e1.NomeFabricante = null;

                        Console.WriteLine("Equipamento excluido do sistema!");
                    }
                    else
                    {
                        Console.WriteLine("Você ainda não cadastrou nenhum equpamento !");
                    }

                    Console.WriteLine();
                }
                else if (respostaMenu == 5)
                {
                    Console.WriteLine("Volte sempre!!!");
                }
                else
                {
                    Console.WriteLine("Por favor digite uma opção válida");
                }
            } while (respostaMenu != 5);
        }
    }
}
