using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    struct Human
    {
        public string name;
        public int age; 
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DiaplayInfo()
        {
            Console.WriteLine($"Name: {name}. Age: {age}.");
        }
       
    }
    class Person
    {
        public string name;
        public int age;
        public Person() : this("Неизвестно")
        { }
        public Person(string name):this(name, 18)
        { }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Имя: {name}, возраст {age}.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Human tom= new Human { name = "Sam", age = 40 };
            tom.DiaplayInfo();
            Console.ReadKey();
        }
    }
}

