using System;

using System.Security.AccessControl;
 
namespace Lanchonete

{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 - Ver cardápio");
            Console.WriteLine("2 - Registrar venda");
            Console.WriteLine("3 - Relatorio por produto");
            Console.WriteLine("4 - Relatorio por dia");
            Console.WriteLine("5 - Resumo da semana");
            Console.WriteLine("0 - sair");
            Console.Write("Escolha sua opção: ");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:

                    Console.WriteLine("1 - Pão: 0.50");
                    Console.WriteLine("2 - Café: 7,00");
                    Console.WriteLine("3 - Fatia de bolo: 6,50");
                    Console.WriteLine("4 - Suco: 12,00 ");
                    Console.WriteLine("5 - Vitamina: 15,00");
                    Console.Write("Escolha seu produto: ");

                    int produto = int.Parse(Console.ReadLine());

                    Console.Write("Digite a quantidade do produto: ");

                    int quantidade = int.Parse(Console.ReadLine());
                    switch (produto)
                    {
                        case 1:
                            Console.WriteLine($"Voce selecionou pão e {quantidade} unidades!");
                            break;

                        case 2:
                            Console.WriteLine($"Voce selecionou Café e {quantidade} unidades!");
                            break;
                        case 3:
                            Console.WriteLine($"Voce selecionou Fatia de bolo e {quantidade} unidades!");

                            break;

                        case 4:

                            Console.WriteLine($"Voce selecionou suco e {quantidade} unidades! ");

                            break;

                        case 5:

                            Console.WriteLine($"Voce selecionou vitamina e {quantidade} unidades!");

                            break;

                        default:

                            Environment.Exit(0);

                            break;
                    }
                    break;

                case 2:
                    break;



                case 3:

                    Console.WriteLine("===RELATÓRIO POR PRODUTO===");
                    Console.WriteLine("1 - SEGUNDA");
                    Console.WriteLine("2 - TERÇA");
                    Console.WriteLine("3 - QUARTA");
                    Console.WriteLine("4 - QUINTA");
                    Console.WriteLine("5 - SEXTA");

                    Console.WriteLine("Digite um dia da semana: ");

                    int Dia = int.Parse(Console.ReadLine());
                    switch (Dia)
                    {
                        case 1:
                            Console.WriteLine("=== SEGUNDA-FEIRA ===");
                            switch (Dia)
                            {
                                case 1:
                                    Console.WriteLine("1 - Pão");
                                    Console.WriteLine("2 - Café");
                                    Console.WriteLine("3 - Fatia de bolo");
                                    Console.WriteLine("4 - Suco ");
                                    Console.WriteLine("5 - Vitamina");
                                    Console.WriteLine("Digite um produto: ");


                                    int produto2 = int.Parse(Console.ReadLine());

                                    Console.Write("Digite a quantidade do produto: ");

                                    int quantidade2 = int.Parse(Console.ReadLine());

                                    switch (produto2)
                                    {
                                        case 1: Console.WriteLine($"Pão: {quantidade2} unidades | R$ {0.50 * quantidade2}"); break;
                                        case 2: Console.WriteLine($"Café: {quantidade2} unidades | R$ {7 * quantidade2}"); break;
                                        case 3: Console.WriteLine($"Fatia de bolo: {quantidade2} | R$ {6.5 * quantidade2}"); break;
                                        case 4: Console.WriteLine($"Suco: {quantidade2} | R$ {12 * quantidade2}"); break;
                                        case 5: Console.WriteLine($"Vitamina: {quantidade2} | R$ {15 * quantidade2}"); break;
                                    }

                                    break;
                            }
                            break;

                        case 2:
                            Console.WriteLine("=== TERÇA-FEIRA ===");                           
                                
                                    Console.WriteLine("1 - Pão");
                                    Console.WriteLine("2 - Café");
                                    Console.WriteLine("3 - Fatia de bolo");
                                    Console.WriteLine("4 - Suco ");
                                    Console.WriteLine("5 - Vitamina");
                                    Console.WriteLine("Digite um produto: ");

                                    int produto3 = int.Parse(Console.ReadLine());

                                    Console.Write("Digite a quantidade do produto: ");

                                    int quantidade3 = int.Parse(Console.ReadLine());

                                    switch (produto3)
                                    {
                                        case 1: Console.WriteLine($"Pão: {quantidade3} unidades | R$ {0.50 * quantidade3}"); break;
                                        case 2: Console.WriteLine($"Café: {quantidade3} unidades | R$ {7 * quantidade3}"); break;
                                        case 3: Console.WriteLine($"Fatia de bolo: {quantidade3} | R$ {6.5 * quantidade3}"); break;
                                        case 4: Console.WriteLine($"Suco: {quantidade3} | R$ {12 * quantidade3}"); break;
                                        case 5: Console.WriteLine($"Vitamina: {quantidade3} | R$ {15 * quantidade3}"); break;

                                    }

                                   

                                break;
                            

                        

                    }break;
            
            
            }
                      
        }

    }

}


