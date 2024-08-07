using System;

/*
namespace AA
{
    class CC
    {
        private string name = "";
        
        public void setName(string name){
            this.name = name;
        }

        public string getName(){
            return this.name;
        }
    }
    class BB
    {

        static void Main(String[] args){
            var c = new CC();
            c.setName("Mg Mg");
            Console.WriteLine("Name is {0}", c.getName());
        }
    }
}
*/

namespace Y
{
    class AA
    {
        private string name;

        public string Name
        {
            get {return name;}
            set {name = value;}
        }
    }

    class BB
    {
        static void Main (string[] args){
            var a = new AA();
            a.Name = "Ag Ag";
            Console.WriteLine("His name is {0}", a.Name);
        }
    }
}




