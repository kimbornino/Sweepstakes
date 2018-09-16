using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        //Has A member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public string registryNumber;

        public Contestant()
        {
            firstName = null;
            lastName = null;
            emailAddress = null;
            registryNumber = null;
        }
        public void SetContestantObject()
        {
            firstName = UserInterface.tempFirstName;
            lastName = UserInterface.tempLastName;
            emailAddress = UserInterface.tempEmail;
            registryNumber = UserInterface.tempNumber;
        }
    }
}
