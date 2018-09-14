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

        //constructor
        public SweepstakesQueueManager()
        {
            contestant = new Contestant();
            
        }

        public void AddIndividualContestantsToStructure(Dictionary<string, List<string>> dictionary)
        {
            Queue<List<string>> queue = new Queue<List<string>>();
            //this adds
            queue.Enqueue(sweepstakes.dictionaryEntry);

        }
        public void RemoveContestantsFromStructure(Dictionary<string, List<string>> dictionary)
        {
            //not sure where this que came from....
          //  queue.Enqueue(contestant.contestantData);

            //List<string> startOfQueue = queue.Dequeue();

        }

    }
}
