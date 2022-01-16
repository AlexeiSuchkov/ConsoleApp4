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
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine($"Ну здарова,{name}");
            Console.WriteLine("Назови лучший фильм 2021 года");
            string movie = Console.ReadLine();
            Console.WriteLine($"Лучший фильм 2021 года - {movie}");
            if( movie == "Человек-паук нет пути домой")
            {
                Console.WriteLine("Так и думал");
            }
            if (movie == "Человек-паук: Нет пути домой")
            {
                Console.WriteLine("Так и думал");
            }
            if (movie == "Человек паук: Нет пути домой")
            {
                Console.WriteLine("Так и думал");
            }
            if (movie == "человек паук: нет пути домой")
            {
                Console.WriteLine("Так и думал");
            }
            if (movie == "человек паук нет пути домой")
            {
                Console.WriteLine("Так и думал");
            }
            if (movie == "человекпаук нет пути домой")
            {
                Console.WriteLine("Так и думал");
            }
            if (movie == "человекпаукнетпутидомой")
            {
                Console.WriteLine("Так и думал");
            }
            else
            {
                Console.WriteLine("(0_0)");
            }
            Console.ReadKey();
        }
        
    }
}
