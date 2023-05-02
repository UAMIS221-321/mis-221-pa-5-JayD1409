namespace mis_221_pa_5_JayD1409
{
    public class Listing
    {
        // instance variables
        private int listingID;

        private string trainerName;

        private string sessionDate;

        private int sessionTime;

        private int sessionCost;

        private string availableSession;

        private bool isDeleted;

        // class variable 
        static private int count;

        //  no arg constructor 
        public Listing()
        {

        }
        //  arg constructor
        public Listing(int listingID, string sessionDate, string trainerName, int sessionTime, int sessionCost, string availableSession)
        {
            this.listingID = listingID;
            this.trainerName = trainerName;
            this.sessionDate = sessionDate;
            this.sessionTime = sessionTime;
            this.sessionCost = sessionCost;
            this.availableSession = availableSession;
            isDeleted = false;
        }

        public void SetListingID(int listingID)
        {
            this.listingID = listingID;
        }

        public int GetListingID()
        {
            return listingID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }

        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetSessionDate(string sessionDate)
        {
            this.sessionDate = sessionDate;
        }

        public string GetSessionDate()
        {
            return sessionDate;
        }

        public void SetSessionTime(int sessionTime)
        {
            this.sessionTime = sessionTime;
        }

        public int GetSessionTime()
        {
            return sessionTime;
        }

        public void SetSessionCost(int sessionCost)
        {
            this.sessionCost = sessionCost;
        }

        public int GetSessionCost()
        {
            return sessionCost;
        }

        public void SetAvailableSession(string availableSession)
        {
            this.availableSession = availableSession;
        }

        public string GetAvailableSession()
        {
            return availableSession;
        }

        static public void SetCount(int count)
        {
            Listing.count = count;
        }

        static public void IntCount()
        {
            Listing.count++;
        }

        static public int GetCount()
        {
            return Listing.count;
        }

        public override string ToString()
        {
            return $"{listingID} {trainerName} {sessionDate} {sessionDate} {sessionTime} {sessionCost} {availableSession} ";
        }

        public bool GetDelete()
        {
            return this.isDeleted;
        }

        public void Delete()
        {
            if (!isDeleted)
            {
                isDeleted = true;
            }
            else
            {
                isDeleted = false;
            }
        }

    }
}