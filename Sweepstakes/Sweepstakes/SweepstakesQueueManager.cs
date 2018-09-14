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
        public List<Contestant> listOfContestants;

        //constructor
        public SweepstakesQueueManager()
        {
            contestant = new Contestant();
            listOfContestants = new List<Contestant>();
        }
        public void EnqueueOnQueue(List<Contestant> contestantData)
        {
            //have each new contestant created stored here
            Queue<List<string>> queue = new Queue<List<string>>();

        
            {

            }

            queue.Enqueue(contestant.contestantData);

            List<string> startOfQueue = queue.Dequeue();
            //can assign items to take out of queue
        }
    }
}
