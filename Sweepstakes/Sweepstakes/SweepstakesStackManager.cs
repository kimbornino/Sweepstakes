using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
       
        public Stack<Sweepstakes> stack;

        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }
        
        void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack.Push(sweepstakes);

        }

        //figure this one out
        Sweepstakes GetSweepstakes()
        {
        return stack.Pop();

        }
    }
}
