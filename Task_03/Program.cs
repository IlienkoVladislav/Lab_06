using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionCache<string, int> cache = new FunctionCache<string, int>();

            int expensiveFunction(string inputKey)
            {
                Console.WriteLine($"Calculating for key: {inputKey}");
                return inputKey.Length * 10;
            }

            string key = "example";
            int result1 = cache.GetOrAdd(key, expensiveFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Result 1: {result1}");

            int result2 = cache.GetOrAdd(key, (Func<string, int>)expensiveFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Result 2 (from cache): {result2}");

            System.Threading.Thread.Sleep(6000);

            int result3 = cache.GetOrAdd(key, (Func<string, int>)expensiveFunction, TimeSpan.FromSeconds(5));
            Console.WriteLine($"Result 3 (after cache expiration): {result3}");
        }
    }
}
