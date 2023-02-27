using Some_Practice;
using System.Data.Common;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using System.Xml.Linq;


Console.WriteLine("Hey There!\n");

Console.WriteLine("Welcome to Pawsitivty Dog Training!\n");

Console.WriteLine("Let's get started with some basic information!\n\n");


Customer myCustomer = GetCustomer();
Console.WriteLine(myCustomer.Email);
Console.WriteLine(myCustomer.Name);
Console.WriteLine(myCustomer.Phone);

FurBaby furBaby = GetFurBaby();
Console.WriteLine($"Furbaby's Age: {furBaby.Age}\n");
Console.WriteLine($"Furbaby's Name: {furBaby.Name}\n\n");
myCustomer.FurBaby= furBaby;

TrainingProgram trainingProgram = GetTrainingProgram();
Console.WriteLine(trainingProgram.Service);
Console.WriteLine(trainingProgram.Environment);
furBaby.TrainingProgram= trainingProgram;


static Customer GetCustomer()
{
    Customer customer = new Customer();

    Console.WriteLine("Please enter your name:\n");
    customer.Name = Console.ReadLine();

    Console.WriteLine("\nEnter email\n");
    customer.Email = Console.ReadLine();

    Console.WriteLine("\nEnter phone e.g 5025551234\n");
    customer.Phone = Console.ReadLine();

    return customer;
}
static FurBaby GetFurBaby()
{
    FurBaby furBaby = new FurBaby();
    Console.WriteLine("\n\nPlease provide some information about your furbaby.\n\n");

    Console.WriteLine("What is your furbaby's name?\n");
    furBaby.Name = Console.ReadLine();

    Console.WriteLine("How old is your furbaby?\n");
    furBaby.Age = Convert.ToInt32(Console.ReadLine());

    return furBaby;
}

static TrainingProgram GetTrainingProgram()
{
    TrainingProgram trainingProgram = new TrainingProgram();

    Console.WriteLine("Now, let's find the right training for your pup!\n\n");

    Console.WriteLine("What kind of training services are you interested in? \n");

    Console.WriteLine("Service 1 -Basic Cues and Enrichment");
    Console.WriteLine("Service 2 -Learn Tricks");
    Console.WriteLine("Service 3 -Service Dog");
    Console.WriteLine("Service 4 -Behavior Moification");
    Console.WriteLine("For service type, please enter the corresponding number above.");
    Console.WriteLine("e.g. For Service Dog, enter 3.");

    string myoptions;
    myoptions = Console.ReadLine();
    switch (myoptions)
    {
        case "1":
            Console.WriteLine("\nService 1 - Basic Cues and Enrichment");
            trainingProgram.Service = 1;
            break;

        case "2":
            Console.WriteLine("Service 2 -Learn Tricks");
            trainingProgram.Service = 2;
            break;

        case "3":
            Console.WriteLine("Service 3 -Service Dog");
            trainingProgram.Service = 3;
            break;

        case "4":
            Console.WriteLine("Service 4 -Behavior Modification");
            trainingProgram.Service = 4;
            break;
    }


    Console.WriteLine("What kind of training environment would you prefer? Private or Group\n");

    string myarea;
    myarea = Console.ReadLine();
    switch (myarea.ToLower())
    {
        case "group":
            Console.WriteLine("Group");
            trainingProgram.Environment = "Group";
           
            break;

        case "private":
            Console.WriteLine("Private");
            trainingProgram.Environment = "Private";
            break;
    }
    return trainingProgram;
}
Console.WriteLine("\nThank you for providing your information, we will be in contact within the next 24 hours to schedule your furbaby's training.");
Console.WriteLine("We look forward to meeting you both!\n\n\n\n");
