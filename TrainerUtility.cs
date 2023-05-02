namespace mis_221_pa_5_JayD1409
{
    public class TrainerUtility
    {
        private Trainer[] trainers;

        public TrainerUtility(Trainer[] trainers)
        {
            this.trainers = trainers;
        }

        public void AddAllTrainers()
        {
            // trainers[2].SetTrainerAdress();
            Trainer.SetCount(0);
            System.Console.WriteLine("Enter trainer or stop to stop");
            string userInput = Console.ReadLine();
            while (userInput.ToUpper() != "STOP")
            {
                trainers[Trainer.GetCount()] = new Trainer();
                trainers[Trainer.GetCount()].SetTrainerName(userInput);

                System.Console.WriteLine("Enter trainer adress");
                trainers[Trainer.GetCount()].SetTrainerAdress(Console.ReadLine());

                System.Console.WriteLine("Enter trainer email");
                trainers[Trainer.GetCount()].SetTrainerEmail(Console.ReadLine());

                System.Console.WriteLine("Enter trainer ID");
                trainers[Trainer.GetCount()].SetTrainerID(int.Parse(Console.ReadLine()));
                Trainer.IntCount();

                System.Console.WriteLine("Enter trainer or stop to stop");
                userInput = Console.ReadLine();
            }

            using (StreamWriter writer = new StreamWriter("trainers.txt"))
            {
                for (int i = 0; i < trainers.Length; i++)
                {
                    Trainer temp = trainers[i];
                    writer.WriteLine("{0}#{1}#{2}#{3}", temp.GetTrainerName(), temp.GetTrainerAdress(), temp.GetTrainerEmail(), temp.GetTrainerID());
                }
            }
        }

        public void GetAllTrainersFromFile()
        {
            // open
            StreamReader inFile = new StreamReader("trainers.txt");

            // process
            Trainer.SetCount(0);
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split('#');
                trainers[Trainer.GetCount()] = new Trainer(int.Parse(temp[0]), temp[1], temp[2], temp[3]);
                Trainer.IntCount();
                line = inFile.ReadLine();
            }
            // close
            inFile.Close();
        }


        public void EditTrainer()
        {
            System.Console.WriteLine("Enter name of trainer you wish to edit");
            string trainerName = Console.ReadLine();
            for (int i = 0; i < trainers.Length; i++)
                if (trainers[i].GetTrainerName() == trainerName)
                {

                    System.Console.WriteLine("Enter trainer name");
                    trainers[i].SetTrainerName(Console.ReadLine());

                    System.Console.WriteLine("Enter trainer adress");
                    trainers[i].SetTrainerAdress(Console.ReadLine());

                    System.Console.WriteLine("Enter trainer email");
                    trainers[i].SetTrainerAdress(Console.ReadLine());

                    System.Console.WriteLine("Enter trainer ID");
                    trainers[i].SetTrainerID(int.Parse(Console.ReadLine()));

                    System.Console.WriteLine("Would you like to delete this trainer? Enter y or n");
                    string delete = Console.ReadLine();
                    if (delete == "y")
                    {
                        trainers[i].Delete();
                    }
                }

            using (StreamWriter writer = new StreamWriter("trainers.txt"))
            {
                for (int i = 0; i < trainers.Length; i++)
                {
                    Trainer temp = trainers[i];
                    writer.WriteLine("{0}#{1}#{2}#{3}", temp.GetTrainerName(), temp.GetTrainerAdress(), temp.GetTrainerEmail(), temp.GetTrainerID());
                }
            }
        }

    }
}

// edi
// save
// delete 