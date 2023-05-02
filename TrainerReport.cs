namespace mis_221_pa_5_JayD1409
{
    public class TrainerReport
    {
        Trainer[] trainers;

        public TrainerReport(Trainer[] trainers){
            this.trainers = trainers;
        }

        public void PrintAllTrainers(){
            for(int i = 0; i < Trainer.GetCount(); i++){
                if(false == trainers[i].GetDelete()){
                    System.Console.WriteLine(trainers[i].ToString());
                }
                
            }
        }
    } 
} 