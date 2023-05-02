namespace mis_221_pa_5_JayD1409
{
    public class Trainer
    {
        // instance variables
        private int trainerID;

        private string trainerName;

        private string trainerAdress;

        private string trainerEmail;

        private bool isDeleted;

        // class variable 
        static private int count;

        //  no arg constructor 
        public Trainer()
        {

        }
        //  arg constructor
        public Trainer(int trainerID, string trainerName, string trainerAdress, string trainerEmail)
        {
            this.trainerID = trainerID;
            this.trainerName = trainerName;
            this.trainerAdress = trainerAdress;
            this.trainerEmail = trainerEmail;
            isDeleted = false;
        }


        public void SetTrainerID(int trainerID)
        {
            this.trainerID = trainerID;
        }

        public int GetTrainerID()
        {
            return trainerID;
        }

        public void SetTrainerName(string trainerName)
        {
            this.trainerName = trainerName;
        }

        public string GetTrainerName()
        {
            return trainerName;
        }

        public void SetTrainerAdress(string trainerAdress)
        {
            this.trainerAdress = trainerAdress;
        }

        public string GetTrainerAdress()
        {
            return trainerAdress;
        }

        public void SetTrainerEmail(string trainerEmail)
        {
            this.trainerEmail = trainerEmail;
        }

        public string GetTrainerEmail()
        {
            return trainerEmail;
        }


        static public void SetCount(int count)
        {
            Trainer.count = count;
        }

        static public void IntCount()
        {
            Trainer.count++;
        }

        static public int GetCount()
        {
            return Trainer.count;
        }

        public bool GetDelete()
        {
            return this.isDeleted;
        }

        public override string ToString()
        {
            return $"{trainerName} {trainerID} {trainerAdress} {trainerEmail}";
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