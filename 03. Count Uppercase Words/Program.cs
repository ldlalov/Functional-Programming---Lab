using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Where(word => word[0]== word.ToUpper()[0]);
            Console.WriteLine(String.Join("\n", input));
        }
    }
}
