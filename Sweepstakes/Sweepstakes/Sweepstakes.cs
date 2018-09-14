using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //Member variables
        String winner;
        List<string> contestantInfo;
        public Contestant contestant;
        
        //constructor
        public Sweepstakes()
        {
            contestant = new Contestant();
            contestantInfo = new List<string>();
            // need to put contestant data here
        }
        //methods
        public string PickWinner()
        {
            //where is the list of contestants coming from?  Need to designate in method so can grab contestants (plural) list
            Random getWinnerNumber = new Random();
            //int winningNumber = getWinnerNumber.Next(0, contestants.Count);

           // winner = contestants[winningNumber]
                return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Dictionary<string, List<string>> contestantInfo = new Dictionary<string, List<string>>();
            //what should I pass in that has the rest of the data?
            Console.WriteLine(contestant);
            //do I need a "foreach"
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantInfo.Add(contestant.firstName);
            contestantInfo.Add(contestant.lastName);
            contestantInfo.Add(contestant.emailAddress);
            contestantInfo.Add(contestant.registryNumber);
            
        }
        public void DoSomethingWithSweepstakes(String name)
        {

        }

    }
}
