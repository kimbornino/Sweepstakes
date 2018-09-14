using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables
        public Contestant contestant;

        public SweepstakesStackManager()
        {
            contestant = new Contestant();
        }
        public void AddIndividualContestantsToStructure(List<Contestant> contestantInfo)
        {
            Stack<List<Contestant>> contestants = new Stack<List<Contestant>>();
            contestants.Push(contestantInfo);
        }
        public void RemoveContestantsFromStructure(List<Contestant> contestantInfo)
        {
            //not sure what goes here exactly.  Know that I need to be able to "pop" to remove.
        }
    }
}
