namespace mis_221_pa_5_JayD1409
{
    public class ListingUtility
    {
        private Listing[] listings;

        public ListingUtility(Listing[] listings)
        {
            this.listings = listings;
        }

        public void AddAllListings()
        {
            // listings[2].SetTrainerAdress();
            Listing.SetCount(0);
            System.Console.WriteLine("Enter listing or stop to stop");
            string userInput = Console.ReadLine();
            while (userInput.ToUpper() != "STOP")
            {
                listings[Listing.GetCount()] = new Listing();
                listings[Listing.GetCount()].SetTrainerName(userInput);

                System.Console.WriteLine("Enter session date");
                listings[Listing.GetCount()].SetSessionDate(Console.ReadLine());

                System.Console.WriteLine("Enter session time");
                listings[Listing.GetCount()].SetSessionTime(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Enter session cost");
                listings[Listing.GetCount()].SetSessionCost(int.Parse(Console.ReadLine()));

                System.Console.WriteLine("Enter listing ID");
                listings[Listing.GetCount()].SetListingID(int.Parse(Console.ReadLine()));
                Listing.IntCount();

                System.Console.WriteLine("Enter available session");
                listings[Listing.GetCount()].SetAvailableSession(Console.ReadLine());

                // update
                System.Console.WriteLine("Enter listing or stop to stop");
                userInput = Console.ReadLine();
                
                using (StreamWriter writer = new StreamWriter("listings.txt"))
                {
                    for (int i = 0; i < listings.Length; i++)
                    {
                        Listing temp = listings[i];
                        writer.WriteLine("{0}#{1}#{2}#{3}", temp.GetTrainerName(), temp.GetSessionDate(), temp.GetSessionTime(), temp.GetSessionCost(), temp.GetAvailableSession(), temp.GetListingID());
                    }
                }

            }

        }

        public void GetAllListingsFromFile()
        {
            // open
            StreamReader inFile = new StreamReader("listings.txt");

            // process
            Listing.SetCount(0);
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split('#');
                listings[Listing.GetCount()] = new Listing(int.Parse(temp[0]), temp[1], temp[2], int.Parse(temp[3]), int.Parse(temp[4]), temp[5]);
                Listing.IntCount();
                line = inFile.ReadLine();
            }
            // close
            inFile.Close();
        }

        public void EditListing()
        {
            System.Console.WriteLine("Enter listing you wish to edit");
            int listingID = int.Parse(Console.ReadLine());
            for (int i = 0; i < listings.Length; i++)
                if (listings[i].GetListingID() == listingID)
                {

                    System.Console.WriteLine("Enter session name");
                    listings[i].SetTrainerName(Console.ReadLine());

                    System.Console.WriteLine("Enter session date");
                    listings[i].SetSessionDate(Console.ReadLine());

                    System.Console.WriteLine("Enter session time");
                    listings[i].SetSessionTime(int.Parse(Console.ReadLine()));

                    System.Console.WriteLine("Enter session cost");
                    listings[i].SetSessionCost(int.Parse(Console.ReadLine()));

                    System.Console.WriteLine("Enter session availability");
                    listings[i].SetAvailableSession(Console.ReadLine());

                    System.Console.WriteLine("Enter listing ID");
                    listings[i].SetListingID(int.Parse(Console.ReadLine()));

                    System.Console.WriteLine("Would you like to delete this listing? Enter y or n");
                    string delete = Console.ReadLine();
                    if (delete == "y")
                    {
                        listings[i].Delete();
                    }
                }

            using (StreamWriter writer = new StreamWriter("listings.txt"))
            {
                for (int i = 0; i < listings.Length; i++)
                {
                    Listing temp = listings[i];
                    writer.WriteLine("{0}#{1}#{2}#{3}", temp.GetTrainerName(), temp.GetSessionDate(), temp.GetSessionTime(), temp.GetSessionCost(), temp.GetAvailableSession(), temp.GetListingID());
                }
            }
        }
    }
}
