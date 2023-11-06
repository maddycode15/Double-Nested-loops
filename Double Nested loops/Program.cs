using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double_Nested_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Double nested loops");
            Console.WriteLine("a loop within a loop (like inception)");
            Console.WriteLine();

            for (int i = 1; i <=9; i++) ; //

            {
                for (int i = 1; i <= 9; i++) ; //

                {
                    Console.WriteLine(1);
                }

                Console.WriteLine(1);
            }


            Console.WriteLine();
            Console.WriteLine("press any key to exit");

            Console.ReadKey();
        }
    }
}
