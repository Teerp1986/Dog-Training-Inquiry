using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Some_Practice
{
    public class Training_Program
    {
        public Customer owner;
        public string Level;
        public string levelName;



        public Training_Program(string level)
        {
            this.Level = level;
            this.owner = new Customer();
            this.levelName = level;

            Console.WriteLine("Now, Let Find the Right Training for your pup!");

            Console.WriteLine("What's kind of training level would you like to Accomplish? ");
            Console.WriteLine("");
            Console.WriteLine("Level 1 -Basic Commands and Enrichment");
            Console.WriteLine("Level 2 -Learn Tasks and Tricks");
            Console.WriteLine("Level 3 -Service Dog Proffesional");
            Console.WriteLine("");
            Console.WriteLine("For Level Please Type Level 1 or Level 2 or Level 3 to navigate");
            Console.WriteLine("");

            string myoptions;
            myoptions = Console.ReadLine();
            switch (myoptions)
            {
                case "1":
                    First();
                    break;

                case "2":
                    Second();
                    break;

                case "3":
                    Third();
                    break;

            }
            static void First()
            {
                Console.WriteLine("Level 1 - Basic Commands and Enrichment");
                Console.ReadLine();
            }

            static void Second()
            {
                Console.WriteLine("Level 2 -Learn Tasks and Tricks");
                Console.ReadLine();
            }

            static void Third()
            {
                Console.WriteLine("Level 3 -Service Dog Proffesional");
                Console.ReadLine();
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("What's kind of training atmosphere would you like us to provide? ");
            Console.WriteLine("");
            Console.WriteLine("Group- Small group 3-4 dogs");
            Console.WriteLine("Individual- One on One with Trainer");
            Console.WriteLine("");
            Console.WriteLine("For Atmosphere selection, please type: Group or 1on1 to navigate");
            Console.WriteLine("");

            string myarea;
            myarea = Console.ReadLine();
            switch (myarea)
            {
                case "1":
                    First();
                    break;

                case "2":
                    Second();
                    break;
            }
            static void Group()
            {
                Console.WriteLine("Group- Group of 3 to 4 dogs");
                Console.WriteLine("");
                Console.ReadLine();
            }
            static void One_on_One()
            {
                Console.WriteLine("One on One with Trainer");
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }
}