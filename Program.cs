using mis_221_pa_5_JayD1409;

Trainer[] trainers = new Trainer[100];
TrainerUtility utility = new TrainerUtility(trainers);
TrainerReport report = new TrainerReport(trainers);

Listing[] listings = new Listing[100];
ListingUtility utility1 = new ListingUtility(listings);
ListingReport report1 = new ListingReport(listings);

string userInput;
string menuChoice;
bool exitProgram = false;

System.Console.WriteLine("████████╗██████╗░░█████╗░██╗███╗░░██╗  ██╗░░░░░██╗██╗░░██╗███████╗  ░█████╗░");
System.Console.WriteLine("╚══██╔══╝██╔══██╗██╔══██╗██║████╗░██║  ██║░░░░░██║██║░██╔╝██╔════╝  ██╔══██╗");
System.Console.WriteLine("░░░██║░░░██████╔╝███████║██║██╔██╗██║  ██║░░░░░██║█████═╝░█████╗░░  ███████║");
System.Console.WriteLine("░░░██║░░░██╔══██╗██╔══██║██║██║╚████║  ██║░░░░░██║██╔═██╗░██╔══╝░░  ██╔══██║");
System.Console.WriteLine("░░░██║░░░██║░░██║██║░░██║██║██║░╚███║  ███████╗██║██║░╚██╗███████╗  ██║░░██║");
System.Console.WriteLine("░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝╚═╝░░╚══╝  ╚══════╝╚═╝╚═╝░░╚═╝╚══════╝  ╚═╝░░╚═╝");

System.Console.WriteLine("     ░█████╗░██╗░░██╗░█████╗░███╗░░░███╗██████╗░██╗░█████╗░███╗░░██╗");
System.Console.WriteLine("     ██╔══██╗██║░░██║██╔══██╗████╗░████║██╔══██╗██║██╔══██╗████╗░██║");
System.Console.WriteLine("     ██║░░╚═╝███████║███████║██╔████╔██║██████╔╝██║██║░░██║██╔██╗██║");
System.Console.WriteLine("     ██║░░██╗██╔══██║██╔══██║██║╚██╔╝██║██╔═══╝░██║██║░░██║██║╚████║");
System.Console.WriteLine("     ╚█████╔╝██║░░██║██║░░██║██║░╚═╝░██║██║░░░░░██║╚█████╔╝██║░╚███║");
System.Console.WriteLine("     ░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");

System.Console.WriteLine("----------------------------------------------------------------------------");
System.Console.WriteLine("      █▀█ █▀▀ █▀█ █▀ █▀█ █▄░█ ▄▀█ █░░   █▀▀ █ ▀█▀ █▄░█ █▀▀ █▀ █▀");
System.Console.WriteLine("      █▀▀ ██▄ █▀▄ ▄█ █▄█ █░▀█ █▀█ █▄▄   █▀░ █ ░█░ █░▀█ ██▄ ▄█ ▄█");


    System.Console.WriteLine("Choose an option");
    System.Console.WriteLine("Enter 1 to view Trainer Menu");
    System.Console.WriteLine("Enter 2 to view Listing Menu");
    System.Console.WriteLine("Enter 3 to view Booking Menu");
    System.Console.WriteLine("Enter 4 to exit the program");

    userInput = Console.ReadLine();

    if (userInput == "1")
    {

System.Console.WriteLine("▀▀█▀▀ █▀▀█ █▀▀█ ─▀─ █▀▀▄ █▀▀ █▀▀█ 　 ░█▀▄▀█ █▀▀ █▀▀▄ █──█ ");
System.Console.WriteLine("─░█── █▄▄▀ █▄▄█ ▀█▀ █──█ █▀▀ █▄▄▀ 　 ░█░█░█ █▀▀ █──█ █──█ ");
System.Console.WriteLine("─░█── ▀─▀▀ ▀──▀ ▀▀▀ ▀──▀ ▀▀▀ ▀─▀▀ 　 ░█──░█ ▀▀▀ ▀──▀ ▀▀▀▀");

        System.Console.WriteLine("Enter a to view all trainers");
        System.Console.WriteLine("Enter b to add a new trainer");
        System.Console.WriteLine("Enter c to edit/delete existing trainer");
        System.Console.WriteLine("Enter d to view trainer report");

        menuChoice = Console.ReadLine();

        if (menuChoice == "a")
        { 
            utility.GetAllTrainersFromFile();
        }
        if (menuChoice == "b")
        {
            utility.AddAllTrainers();
        }
        if (menuChoice == "c")
        {
            utility.EditTrainer();
        }
        if (menuChoice == "d")
            report.PrintAllTrainers();

    }

    if (userInput == "2")
    {

System.Console.WriteLine("░█─── ─▀─ █▀▀ ▀▀█▀▀ ─▀─ █▀▀▄ █▀▀▀ 　 ░█▀▄▀█ █▀▀ █▀▀▄ █──█ ");
System.Console.WriteLine("░█─── ▀█▀ ▀▀█ ──█── ▀█▀ █──█ █─▀█ 　 ░█░█░█ █▀▀ █──█ █──█ ");
System.Console.WriteLine("░█▄▄█ ▀▀▀ ▀▀▀ ──▀── ▀▀▀ ▀──▀ ▀▀▀▀ 　 ░█──░█ ▀▀▀ ▀──▀ ▀▀▀▀");

        System.Console.WriteLine("Enter aa view all listings");
        System.Console.WriteLine("Enter bb to add a new listing");
        System.Console.WriteLine("Enter cc to edit/delete existing listing");
        System.Console.WriteLine("Enter dd to view listing report");

        menuChoice = Console.ReadLine();

        if (menuChoice == "aa")
        {
            utility1.GetAllListingsFromFile();
        }
        if (menuChoice == "bb")
        {
            utility1.AddAllListings();
        }
        if (menuChoice == "cc")
        {
            utility1.EditListing();
        }
        if (menuChoice == "dd")
            report1.PrintAllListings();
    }

    else if (userInput == "4")
    {
        exitProgram = true;
    }
    else
    {
        System.Console.WriteLine("Invalid");
    }



