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
       
        public Queue<Sweepstakes> queue;

        //constructor
       public SweepstakesQueueManager()
        {
            queue = new Queue<Sweepstakes>();
        }

        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            queue = new Queue<Sweepstakes>();
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            return queue.Dequeue();
        }
    }
}
