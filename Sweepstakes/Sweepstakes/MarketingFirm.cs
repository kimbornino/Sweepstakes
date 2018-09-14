using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //member variables
        ISweepstakesManager sweepstakesManager;
        //constructor

        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }
        public void ChooseStorageMethod()
        {
            Console.WriteLine("How would you like to store your contestant data?  Type Queue or Stack");
            string dataStructureChoice = Console.ReadLine();

            if (dataStructureChoice == "Queue")
            {
                //how to I designate which one to acitivate
                //SweepstakesQueueManager.AddIndividualContestantsToStructure();
            }
            else
            {

            }
        }
    }
}
