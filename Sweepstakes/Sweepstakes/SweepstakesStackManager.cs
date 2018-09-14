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
        public new void AddIndividualContestantsToStructure(List<Contestant> contestant)
        {
            Stack<List<Contestant>> contestants = new Stack<List<Contestant>>();
            contestants.Push(contestant);
        }
        public new void RemoveContestantsFromStructure(List<Contestant> contestantData)
        {
            //not sure what goes here exactly.  Know that I need to be able to "pop" to remove.
        }
    }
}
