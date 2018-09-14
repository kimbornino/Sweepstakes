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
        Sweepstakes sweepstakes;
        //constructor

        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
            sweepstakes = new Sweepstakes("LlamaParty");
        }
        public void ChooseStorageMethod()
        {
            Console.WriteLine("How would you like to store your contestant data?  Type Queue or Stack");
            string dataStructureChoice = Console.ReadLine();

            if (dataStructureChoice == "Queue")
            {
                ISweepstakesManager.SweepstakesQueueManager.AddIndividualContestantsToStructure(sweepstakes.dictionary);
            }
            if (dataStructureChoice == "Stack")
            {
                SweepstakesStackManager.AddIndividualContestantsToStructure(sweepstakes.dictionary);
            }
        }
        public void RunSweepstakes()
        {

        }
    }
}
