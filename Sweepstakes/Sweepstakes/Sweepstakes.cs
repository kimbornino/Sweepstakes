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
        List<string> contestantInfo;
        public Dictionary<string, Contestant> contestantDictionary;  
        public string name;
        
        //constructor
        public Sweepstakes(String name)
        {
            contestantInfo = new List<string>();
            contestantDictionary = new Dictionary<string, Contestant>();
            this.name = name;
        }
        //methods
        public string PickWinner()
        {
            Random getWinnerNumber = new Random();
            int winningNumber = getWinnerNumber.Next(0, contestantDictionary.Count);

            Contestant winner = Enumerable.ToList(contestantDictionary.Values)[winningNumber];
            return winner.firstName;

        }
        public void PrintContestantInfo(Contestant contestant)
        {
            {
                Console.WriteLine(contestant.firstName + contestant.lastName + contestant.emailAddress + contestant.registryNumber);
            }

        }

        public void RegisterContestant(Contestant contestant)
        {
          
            contestantDictionary.Add(contestant.registryNumber, contestant);
        }
       
        //non=essential
        // public void createSweepstakes()
        //{


        //}
    }
}
