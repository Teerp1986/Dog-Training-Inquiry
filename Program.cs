using System.Data.Common;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Linq;

namespace Some_Practice
{
    class Program
    {

        static void Main(string[] args)
        {
            string greeting = "Hey There!";

            string greeting2 = "Welcome to Pawsitivty Dog Training!";

            string greeting3 = "Let\'s get started with some Basic Info!";



            Console.WriteLine(greeting);
            Console.WriteLine("");
            Console.WriteLine(greeting2);
            Console.WriteLine("");
            Console.WriteLine(greeting3);
            Console.WriteLine("");
            Console.WriteLine("");

            Customer myCustomer = new Customer();
            Console.WriteLine(myCustomer.email);

            Customer FurBaby= new Customer();
            Console.WriteLine(FurBaby.name);

            Customer TrainingProgram= new Customer();
            Console.WriteLine(TrainingProgram.name);


        }
    }
}   
