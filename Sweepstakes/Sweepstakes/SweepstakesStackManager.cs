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


        void ISweepstakesManager.InsertSweepstakes(Sweepstakes sweepstakes)
        {
            stack = new Stack<Sweepstakes>();
        }

        Sweepstakes ISweepstakesManager.GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
