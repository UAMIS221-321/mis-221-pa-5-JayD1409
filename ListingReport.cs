namespace mis_221_pa_5_JayD1409
{
    public class ListingReport
    {
        Listing [] listings;

        public ListingReport(Listing[] listings){
            this.listings = listings;
        }

        public void PrintAllListings(){
            for(int i = 0; i < Trainer.GetCount(); i++){
                if(false == listings[i].GetDelete()){
                    System.Console.WriteLine(listings[i].ToString());
                }
            }
        }
    }
}