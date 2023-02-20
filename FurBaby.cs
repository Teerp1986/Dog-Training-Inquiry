using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Practice
{
    public class FurBaby
    {
        public Customer owner;
        public string name;
        public int age;
       


        public FurBaby(Customer owner) 
        {
            this.owner = owner;
            this.name = name;
            this.age = 0;

            Console.WriteLine("Now we need some basic info of your FurBaby:");

            Console.WriteLine("Fur Baby\'s name:");
            Console.ReadLine();
            Console.WriteLine("Fur Baby\'s age:");
            Convert.ToInt32(Console.ReadLine());
        }

    }
}
