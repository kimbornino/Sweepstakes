using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    //should take in a "get" that instantiates the correct design pattern
    class MarketingFirm
    {
        //member variables
        ISweepstakesManager sweepstakesManager;
        Sweepstakes sweepstakes;
       
        //constructor

        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
            sweepstakes = new Sweepstakes("");
        }
        
       public static MarketingFirm MarketingFirmFactory (string storageMethod)
        {
            UserInterface.ChooseStorage();
          
            ISweepstakesManager manager;
            if (storageMethod == "queue")
            {
                manager = new SweepstakesQueueManager();
            }
            else if (storageMethod == "stack")
            {
                manager = new SweepstakesStackManager();
            }
            else
            {
                //could throw exception to handle this
                return null;
            }
            return new MarketingFirm(manager);
        }
        
        //started to build method
        //public void RunSweepstakes()
        //{

            //Contestant number = UserInterface.GetNumberOfContestants();
            //sweepstakes.RegisterContestant(sweepstakes.contestant);
            //for (int i = 0; i<= numberOfContestants; i++)
            //{
                //sweepstakes.contestant.SetContestantObject();
                //sweepstakes.RegisterContestant(sweepstakes.contestant);

            //}

        //}
        
         
    }
}
