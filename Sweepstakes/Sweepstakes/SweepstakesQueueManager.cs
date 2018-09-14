using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variables
        public Contestant contestant;
        Sweepstakes sweepstakes;

        //constructor
        public SweepstakesQueueManager()
        {
            contestant = new Contestant();
        }

        public void AddIndividualContestantsToStructure(List<string> dictionaryEntry)
        {
            Queue<List<string>> queue = new Queue<List<string>>();
            //this adds
            queue.Enqueue(dictionaryEntry);

        }
       //do not know if I need a remove
        //public void RemoveContestantsFromStructure(Dictionary<string, List<string>> dictionaryEntry)
        //{
            //not sure where this que came from....
          //  queue.Enqueue(contestant.contestantData);

            //List<string> startOfQueue = queue.Dequeue();

        //}

    }
}
