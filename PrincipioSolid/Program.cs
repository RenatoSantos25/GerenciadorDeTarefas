using PrincipioSolid;
using System;
using System.ComponentModel.Design;
using PrincipioSolid.View;

class Program
{
    static void Main(string[] args)
    {
        var manager = new TaskManager();
        ITaskPrinter printer = new ConsoleTaskPrinter();

        while (true)
        {
            //1 - SEPARA A CRIAÇÃO DO MENU EM UM METODO SEPARADO QUE RETORNA UMA STRING
            var view = new Viewing();

            string? opcao = view.GetMenu();

            
            switch (opcao)
            {
                case "1":
                    Console.Write("Título: ");
                    var titulo = Console.ReadLine();
                    Console.Write("Prioridade (Alta, Média, Baixa): ");
                    var prioridade = Console.ReadLine();
                    manager.AddTask(new Task(titulo, prioridade));
                    break;
                case "2":
                    printer.PrintTasks(manager.GetAllTasks());
                    break;
                case "3":
                    printer.PrintTasks(manager.GetAllTasks());
                    Console.Write("Número da tarefa para marcar como concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int index) &&
                        index >= 0 && index < manager.GetAllTasks().Count)
                    {
                        manager.GetAllTasks()[index].MarkAsDone();
                    }
                    else
                    {
                        Console.WriteLine("Índice inválido!");
                    }
                    break;
                case "4":
                    Console.Write("Prioridade para filtrar: ");
                    var filtro = Console.ReadLine();
                    printer.PrintTasks(manager.FilterByPriority(filtro));
                    break;
                case "0":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
