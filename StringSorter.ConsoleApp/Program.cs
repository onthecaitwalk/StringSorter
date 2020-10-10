using System;
using StringSorter.ConsoleApp.Extensions;

namespace StringSorter.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = GetUserInput();  
            var charstr = myStr.CleanInputString()
                .SortString();
            Console.WriteLine(charstr);  
            Console.ReadLine();
        }

        private static string GetUserInput()
        {
            Console.WriteLine($"\nEnter a sentence you would like to sort:");
            return Console.ReadLine();
        }
    }
}
