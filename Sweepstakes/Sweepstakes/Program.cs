using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("llama party");
            UserInterface.GetContestantInfo();

            Console.ReadKey();

            //where is the best place for these?
            //UserInterface.GetContestantInfo();
            //contestant.SetContestantObject();
        }
        
    }
}
