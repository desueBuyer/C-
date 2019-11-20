using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        private static void Main(string[] args)
        {
            Account<int> acc1 = new Account<int>(1857) { Sum = 7000 };
            Account<int> acc2 = new Account<int>(3453) { Sum = 5000 };

            Transaction<Account<int>> transaction1 = new Transaction<Account<int>>
            {
                FromAccount = acc1,
                ToAccount = acc2,
                Sum = 6900
            };
            transaction1.Execute();

            Console.Read();
        }
    }
    class Account<T>
    {
        public T Id { get; private set; } // номер счета
        public int Sum { get; set; }
        public Account(T _id)
        {
            Id = _id;
        }
    }
    class Transaction<T> where T : Account<int>
    {
        public T FromAccount { get; set; }  // с какого счета перевод
        public T ToAccount { get; set; }    // на какой счет перевод
        public int Sum { get; set; }        // сумма перевода

        public void Execute()
        {
            if (FromAccount.Sum > Sum)
            {
                FromAccount.Sum -= Sum;
                ToAccount.Sum += Sum;
                Console.WriteLine($"Счет {FromAccount.Id}: {FromAccount.Sum}$ \nСчет {ToAccount.Id}: {ToAccount.Sum}$");
            }
            else
            {
                Console.WriteLine($"Недостаточно денег на счете {FromAccount.Id}");
            }
        }
    }
}
