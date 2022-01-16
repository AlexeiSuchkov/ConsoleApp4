using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Mistake = Console.ReadLine();
            int intMistake = int.Parse(Mistake);
            for ( int count = 0; count < intMistake; count++)
            {
                Console.WriteLine("Раз");
            }
            Console.ReadKey();


        }
        
    }
}
