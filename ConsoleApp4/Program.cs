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
            int str = 1;
            int sum = 0;
            while (sum <1095)
            {
                if (str<10)
                {
                    sum++;
                }
                else
                {
                    if (str>=10&&str<100)
                    {
                        sum += 2;
                    }
                    else
                    {
                        if (str>=100&&str<1000)
                        {
                            sum += 3;
                        }
                    }
                }
                str++;
            }
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
