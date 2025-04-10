using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipioSolid.View
{
    public class Viewing
    {
        public string GetMenu()
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Criar nova tarefa");
            Console.WriteLine("2. Listar tarefas");
            Console.WriteLine("3. Marcar tarefa como concluída");
            Console.WriteLine("4. Filtrar por prioridade");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha: ");

            return Console.ReadLine();
        }
    }
}
