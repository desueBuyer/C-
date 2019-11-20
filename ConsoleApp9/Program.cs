using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            string parametrs = Console.ReadLine();
            Console.WriteLine(Calculate(parametrs));
            Console.ReadKey();
            
        }
        static string Calculate(string userInput)
        {
            var parts = userInput.Split(' ');
            double summValue = double.Parse(parts[0]);
            double percetnsPerMonth = 1 + (double.Parse(parts[1]) / 12)*0.01;
            int monthsAmount = int.Parse(parts[2])+1;
            double summGeometric = summValue * (Math.Pow(percetnsPerMonth, monthsAmount) - 1) / (percetnsPerMonth - 1);
            double summGeometricMinusOne = summValue * (Math.Pow(percetnsPerMonth, (monthsAmount - 1)) - 1) / (percetnsPerMonth - 1);
            return (summGeometric-summGeometricMinusOne).ToString();
        }

        
    }
 }

