using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Practice
{
    public class Customer
    {
        public string name;
        public string email;
        public int phone;
       
      

        public Customer()
        {
            Console.WriteLine("Please Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter email");
            email = Console.ReadLine();
            Console.WriteLine("Enter phone e.g 5551234");
            phone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thanks!");
        }
    }
}
