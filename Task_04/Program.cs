using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            TaskScheduler<string, int> scheduler = new TaskScheduler<string, int>(task => task.Length);

            while (true)
            {
                Console.Write("Введіть завдання (або «вийдіть», щоб завершити): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "вихід")
                    break;

                scheduler.AddTask(input);
            }

            scheduler.ExecuteNext(task => Console.WriteLine($"Виконання завдання: {task}"));
        }
    }
}
