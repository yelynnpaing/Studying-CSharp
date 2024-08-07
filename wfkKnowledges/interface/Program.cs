using System;

namespace myApp
{

    interface BC
    {
        void show();
    }

    interface BD
    {
        void go();
    }

    class CC:BC, BD
    {
        public void show()
        {
            Console.WriteLine("A class extends interface call implement.");
        }

        public void go()
        {
            Console.WriteLine("A class can implement multiple interface.");
        }
    }

    abstract class EE
    {
        abstract public void play();

        public void doIt()
        {
            Console.WriteLine("Concrete Method");
        }
    }

    class FF:EE
    {
        override public void play()
        {
            Console.WriteLine("This is abstract method override from abstract class. A class extend from a class call extend.");
        }
    }

    class AB
    {
        static void Main(string[] args)
        {
            var c = new CC();
            c.show();
            c.go();

            BC d = new CC();
            d.show();
            

            Console.WriteLine(d.GetType().Name);

            var f = new FF();
            f.play();
            f.doIt();
        }
    }
}