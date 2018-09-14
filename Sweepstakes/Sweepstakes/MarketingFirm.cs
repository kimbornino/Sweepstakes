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
                //run this version of sweepstakes
            }
            if (dataStructureChoice == "Stack")
            {
                //run this version of sweepstakes
            }
            else
            {
                Console.WriteLine("Please type a valid storage type.");
            }
        }
        public void RunSweepstakesWithStack()
        {

            sweepstakes.RegisterContestant(sweepstakes.contestant);
            sweepstakes.
            sweepstakes.SweepstakesStackManager.AddIndividualContestantsToStructure(Dictionary<string, List<string>> dictionaryEntry);
            sweepstakes.PickWinner();
            sweepstakes.PrintWinner();
            sweepstakes.PrintContestantInfo(sweepstakes.contestant);
            //method to notify winner

        }
        public void RunSweepstakesWithQueue()
        {
            sweepstakes.RegisterContestant(sweepstakes.contestant);
            sweepstakes.sweepstakesQueueManager.AddIndividualContestantsToStructure(Dictionary<string, List<string>> dictionaryEntry);
            sweepstakes.PickWinner();
            sweepstakes.PrintContestantInfo(sweepstakes.contestant);
            //method to notify winner
        }
        
    }
}
