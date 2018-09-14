using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager //: ISweepStakesManager
    {
        //member variables
        Contestant contestant = new Contestant();

        //constructor
        public SweepstakesQueueManager()
        {
            
        }
        public void EnqueueOnQueue(List<Contestant> contestantData)
        {
            Queue<List<string>> queue = new Queue<List<string>>();

            queue.Enqueue(constestant.contestantData)

            List<string> startOfQueue = queue.Dequeue();
            //can assign items to take out of queue
        }
    }
}
