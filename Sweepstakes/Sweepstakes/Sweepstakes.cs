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
        public Dictionary<string, List<string>> contestantDictionary;  
        public Contestant contestant;
        public string name;
        
        //constructor
        public Sweepstakes(String name)
        {
            winner = null;
            contestant = new Contestant();
            contestantInfo = new List<string>();
            contestantDictionary = new Dictionary<string, List<string>>();
            name = null;
        }
        //methods
        public string PickWinner()
        {
            Random getWinnerNumber = new Random();
            int winningNumber = getWinnerNumber.Next(0, contestantDictionary.Count);

            int tempWinner = contestantDictionary[winningNumber];
                return winner;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            {
                Console.WriteLine(winner);
            }

        }

        public void RegisterContestant(Contestant contestant)
        {
            UserInterface.GetContestantInfo();
            contestant.SetContestantObject();
            contestantInfo.Add(contestant.firstName);
            contestantInfo.Add(contestant.lastName);
            contestantInfo.Add(contestant.emailAddress);
            contestantInfo.Add(contestant.registryNumber);

            dictionaryEntry.Add(contestant.registryNumber, contestantInfo);
        }
       //non=essential
        // public void createSweepstakes()
        //{


        //}
    }
}
