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

        public void AddToQueue(List<string> dictionaryEntry)
        {
            Queue<List<string>> queue = new Queue<List<string>>();
            queue.Enqueue(dictionaryEntry);

        }
        void InsertSweepstakes(Sweepstakes sweepstakes)
        {

        }

        Sweepstakes GetSweepstakes()
        {
            return null;
        }

    }
}
