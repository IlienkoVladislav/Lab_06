using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var intRepository = new Repository<int>();
            intRepository.Add(1);
            intRepository.Add(2);
            intRepository.Add(3);

            var foundInts = intRepository.Find(x => x > 1);
            Console.WriteLine("Знайдено цілі числа, більші за 1:");
            foreach (var foundInt in foundInts)
                Console.WriteLine(foundInt);

            var stringRepository = new Repository<string>();
            stringRepository.Add("test1");
            stringRepository.Add("test2");
            stringRepository.Add("test3");

            var foundStrings = stringRepository.Find(s => s.StartsWith("b"));
            Console.WriteLine("\nЗнайдено цілі числа, більші за 'b':");
            stringRepository.Add("test6");
            stringRepository.Add("test7");
            stringRepository.Add("test11");
            foreach (var foundString in foundStrings)
                Console.WriteLine(foundString);
        }
    }
}
