using InquiryForm;
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

FurBaby furBaby = GetFurBaby();
myCustomer.FurBaby= furBaby;

TrainingProgram trainingProgram = GetTrainingProgram();
furBaby.TrainingProgram= trainingProgram;

InfoConfirmation infoConfirmation = GetInfoConfirmation();
Console.WriteLine();
myCustomer.InfoConfirmation= infoConfirmation;


static Customer GetCustomer()
{
    Customer customer = new Customer();

    Console.WriteLine("Please enter your name:");
    customer.Name = Console.ReadLine();

    Console.WriteLine("\nEnter email:");
    customer.Email = Console.ReadLine();

    Console.WriteLine("\nEnter phone: e.g 5025551234");
    customer.Phone = Console.ReadLine();

    return customer;
}
static FurBaby GetFurBaby()
{
    FurBaby furBaby = new FurBaby();
    Console.WriteLine("\n\nPlease provide some information about your furbaby.\n");

    Console.WriteLine("What is your furbaby's name?");
    furBaby.Name = Console.ReadLine();

    Console.WriteLine("How old is your furbaby?");
    furBaby.Age = Convert.ToInt32(Console.ReadLine());

    return furBaby;
}


static TrainingProgram GetTrainingProgram()
{
    TrainingProgram trainingProgram = new TrainingProgram();

    Console.WriteLine("\n\nNow, let's find the right training for your pup!\n");

    Console.WriteLine("What kind of training services are you interested in? \n\n");

    Console.WriteLine("Service 1 -Basic Cues and Enrichment");
    Console.WriteLine("Service 2 -Learn Tricks");
    Console.WriteLine("Service 3 -Service Dog");
    Console.WriteLine("Service 4 -Behavior Moification\n\n");
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


    Console.WriteLine("\n\nWhat kind of training environment would you prefer? " +
        "Private or Group");

    string myarea;
    myarea = Console.ReadLine();
    switch (myarea.ToLower())
    {
        case "group":
            Console.WriteLine();
            trainingProgram.Environment = "Group";
            break;

        case "private":
            Console.WriteLine();
            trainingProgram.Environment = "Private";
            break;
    }
    return trainingProgram;


}

Console.WriteLine("                                               ****Information Confirmed****");
Console.WriteLine($"\n\n\nCustomer Name: {myCustomer.Name}");
Console.WriteLine($"Email: {myCustomer.Email}");
Console.WriteLine($"Phone: {myCustomer.Phone}");
Console.WriteLine($"Furbaby's Age: {furBaby.Age}");
Console.WriteLine($"Furbaby's Name: {furBaby.Name}");
Console.WriteLine($"Training Service: {trainingProgram.Service}");
Console.WriteLine($"Training Environment: {trainingProgram.Environment}");



static InfoConfirmation GetInfoConfirmation() 


{
    InfoConfirmation infoConfirmation = new InfoConfirmation();

    Console.WriteLine("\n\nPlease Confirm your information by typing Y or N");

    string userconfirm;
    userconfirm = Console.ReadLine();
    switch (userconfirm.ToLower()) 
    {
        case "Y":
            Console.WriteLine();
            infoConfirmation.Answer1 = "Y";
            break;

        case "N":
            Console.WriteLine();
            infoConfirmation.Answer2 = "N";
            break;
    }
    return infoConfirmation;
}


Console.WriteLine("\n\nThank you for providing your information.");
Console.WriteLine("\nWe will be in contact within the next 24 hours to schedule your furbaby's training.");
Console.WriteLine("\nWe look forward to meeting you both!\n\n\n\n");
