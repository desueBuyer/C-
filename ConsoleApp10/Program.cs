using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareLenth = int.Parse(Console.ReadLine());
            int ropeLenth = int.Parse(Console.ReadLine());
            if (squareLenth<ropeLenth/2)
            {
                Console.WriteLine("Весь огород будет съеден!");
            }
            else
            {
                double eatenArea = Math.Round(Math.Pow(ropeLenth, 2) * Math.PI / Math.Pow(squareLenth, 2), 2); 
                Console.WriteLine("Будет съедена {0} часть огорода!", eatenArea);
            }
            Console.ReadKey();
            
        }
    }
}
