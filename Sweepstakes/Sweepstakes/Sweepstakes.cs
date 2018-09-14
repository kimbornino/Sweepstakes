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
        public Dictionary<string, List<string>> dictionaryEntry;  
        public Contestant contestant;
        public string name;
        
        //constructor
        public Sweepstakes(String name)
      
        {
            winner = null;
            contestant = new Contestant();
            contestantInfo = new List<string>();
            dictionaryEntry = new Dictionary<string, List<string>>();
            name = "llama Party";
            // need to put contestant data here
        }
        //methods
        public string PickWinner()
        {
            //where is the data  of contestants coming from?  Need to designate in method so can grab contestants (plural) list
            Random getWinnerNumber = new Random();
            //need to search randomly through QUEUE to pull
            //int winningNumber = getWinnerNumber.Next(0, contestants.Count);

           //winner = contestants[winningNumber]
                return winner;
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            //
            //foreach (contestentInfo in dictionay)

        }

        public void RegisterContestant(Contestant contestant)
        {
            contestantInfo.Add(contestant.firstName);
            contestantInfo.Add(contestant.lastName);
            contestantInfo.Add(contestant.emailAddress);
            contestantInfo.Add(contestant.registryNumber);

            dictionaryEntry.Add(contestant.registryNumber, contestantInfo);
        }
    }
}
