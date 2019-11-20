using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            magazine m = new magazine { Name = "bread", Amount = 20 };
            m.Display();

            Console.ReadKey();
        }

        class magazine
        {
            private static string name;
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            private static int amount;
            public int Amount
            {
                get { return amount; }
                set { amount = value; }
            }
            public string getName()
            {
                return Name;
            }
            public int getAmount()
            {
                return Amount;
            }

            public virtual void Display()
            {
                order o = new order();
                o.summ(10, 15);
                o.Display();
            }

        }

        class order : magazine
        {
            private decimal Mass { get; set; }
            private decimal Cost { get; set; }
            private decimal Total_mass { get; set; }
            private decimal Total_Cost { get; set; }
            private string name;
            public  void summ(decimal mass, decimal cost)
            {
                name = getName();
                Amount = getAmount();
                Mass = mass;
                Cost = cost;
                Total_Cost = Cost * Amount;
                Total_mass = Mass * Amount;
            }
            public override void Display()
            {
                Console.WriteLine($"Name:{name}. Amount: {Amount}\n Mass: {Mass}. Cost: {Cost}.\n Total mass: {Total_mass}. Total cost: {Total_Cost}.");
            }
        }

        class buy:order
        {

        }

    }
}