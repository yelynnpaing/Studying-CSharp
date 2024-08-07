// See https://aka.ms/new-console-template for more information
using System;

namespace AA
{
    class AAG
    {
        public AAG(string name) : this(name, 0)
        {
            Console.WriteLine(name);
        }

        public AAG(string name, int age) : this(name , age, "")
        {
            Console.WriteLine("his name is {0} and age is {1}", name, age);
        }

        public AAG(String name, int age, string school)
        {
            Console.WriteLine("his name is {0} and age is {1} and school is {2}", name, age, school);
        }
    }


    class BBG
    {
        static void Main(string[] args)
        {
            var b = new AAG("mg mg", 20, "ygn");
            var c = new AAG("Kg Kg");
        }
    }
}