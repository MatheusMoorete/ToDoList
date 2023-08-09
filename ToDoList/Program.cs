using System;
using System.Collections.Generic;

namespace ToDoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
████████╗░█████╗░  ██████╗░░█████╗░  ██╗░░░░░██╗░██████╗████████╗
╚══██╔══╝██╔══██╗  ██╔══██╗██╔══██╗  ██║░░░░░██║██╔════╝╚══██╔══╝
░░░██║░░░██║░░██║  ██║░░██║██║░░██║  ██║░░░░░██║╚█████╗░░░░██║░░░
░░░██║░░░██║░░██║  ██║░░██║██║░░██║  ██║░░░░░██║░╚═══██╗░░░██║░░░
░░░██║░░░╚█████╔╝  ██████╔╝╚█████╔╝  ███████╗██║██████╔╝░░░██║░░░
░░░╚═╝░░░░╚════╝░  ╚═════╝░░╚════╝░  ╚══════╝╚═╝╚═════╝░░░░╚═╝░░░");

            List<string> listaDeTarefas = new List<string>();
            string opcao = "";

            while (opcao != "e")
            {
                Console.WriteLine("\n\nO que você gostaria de fazer?");
                Console.WriteLine("\nAperte [1] para adicionar uma tarefa na lista.");
                Console.WriteLine("Aperte [2] para remover uma tarefa da lista.");
                Console.WriteLine("Aperte [3] para ver como está a sua lista.");
                Console.WriteLine("\nAperte [0] para fechar o programa.\n");

                opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    Console.Write("\nPor favor, digite o nome do item que deseja adicionar na lista: ");
                    string task = Console.ReadLine();

                    if (int.TryParse(task, out _))
                    {
                        Console.WriteLine("\nIsso não é uma tarefa válida. Tente de outra forma.");
                    }
                    else
                    {
                        listaDeTarefas.Add(task);
                        Console.WriteLine("\nA tarefa foi adicionada na lista.");
                    }
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Tarefas na lista:\n");
                    for (int i = 0; i < listaDeTarefas.Count; i++)
                    {
                        Console.WriteLine(i + " : " + listaDeTarefas[i]);
                    }

                    Console.Write("\nPor favor, digite o número da tarefa que você deseja remover da lista: ");
                    int numeroDaTarefa = Convert.ToInt32(Console.ReadLine());

                    if (numeroDaTarefa >= 0 && numeroDaTarefa < listaDeTarefas.Count)
                    {
                        listaDeTarefas.RemoveAt(numeroDaTarefa);
                        Console.WriteLine("\nA tarefa foi removida da lista.");
                    }
                    else
                    {
                        Console.WriteLine("\nNúmero de tarefa inválido. Tente novamente.");
                    }
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Essas são as tarefas atuais da sua lista:\n");

                    for (int i = 0; i < listaDeTarefas.Count; i++)
                    {
                        Console.WriteLine("• " + listaDeTarefas[i]); 
                    }
                }
                else if (opcao == "0")
                {
                    Console.WriteLine("Fechando o programa...");
                }
                else
                {
                    Console.WriteLine("Opção inválida, por favor tente novamente.");
                }
            }

            Console.WriteLine("Obrigado por usar a To Do List!!");
        }
    }
}
