namespace mis_221_pa_5_JayD1409
{
    public class Booking
    {
        private int sessionID;

        private string customerName;

        private string customerEmail;

        private string trainingDate;

        private string trainerName;

        private string status;

        private string trainingSession;

        private string bookSession;

        private bool isDeleted;

        static private int count;


        public Booking()
        {

        }

        public Booking(int sessionID, string customerName, string customerEmail, string trainingDate, string trainerName, string status, string trainingSession, string bookSession, bool isDeleted)
        {
            this.sessionID = sessionID;
            this.customerName = customerName;
            this.customerEmail = customerEmail;
            this.trainingDate = trainingDate;
            this.trainerName = trainerName;
            this.status = status;
            this.trainingSession = trainingSession;
            this.bookSession = bookSession;
            isDeleted = false;
        }

        public void SetSessionID(int sessionID)
        {
            this.sessionID = sessionID;
        }

        public int GetSessionID()
        {
            return sessionID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }

        private string GetTrainerName()
        {
            return trainerName;
        }

        public void SetCustomerName(string customerName)
        {
            this.customerName = customerName;
        }
        public string GetCustomerName()
        {
            return customerName;
        }
        public void SetCustomerEmail(string customerEmail)
        {
            this.customerEmail = customerEmail;
        }
        public string GetCustomerEmail()
        {
            return customerEmail;
        }

        public void SetTrainingSession(string trainingSession)
        {
            this.trainingSession = trainingSession;
        }

        public string GetTrainingSession()
        {
            return trainingSession;
        }

        public void SetTrainingDate(string trainingDate)
        {
            this.trainingDate = trainingDate;
        }

        public string GetTrainingDate()
        {
            return trainingDate;
        }

        public void SetBookSession(string bookSession)
        {
            this.bookSession = bookSession;
        }

        public string GetBookSession()
        {
            return bookSession;
        }

        private string GetStatus()
        {
            return status;
        }

        public void SetStatus(string status)
        {
            this.status = status;
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

        static public void SetCount(int count)
        {
            Booking.count = count;
        }

        static public void IntCount()
        {
            Booking.count++;
        }

        static public int GetCount()
        {
            return Booking.count;
        }

        public override string ToString()
        {
            return $"Transation ID:" + sessionID + "Customer Name:" + customerName + "Customer Email:" + customerEmail + "Training Date:" + trainingDate + "Trainer Name" + trainerName + "Status:" + status;
        }

    }
}