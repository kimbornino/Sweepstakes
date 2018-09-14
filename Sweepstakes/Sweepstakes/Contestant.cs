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
        public List<String> contestantData;

        public Contestant()
        {
            firstName = UserInterface.tempFirstName;
            lastName = UserInterface.tempLastName;
            emailAddress = UserInterface.tempEmail;
            registryNumber = UserInterface.tempRegistryNumber;
            contestantData = new List<string>();
        }

        public void MakeContestantIntoString()
        {
            contestantData.Add(firstName);
            contestantData.Add(lastName);
            contestantData.Add(emailAddress);
            contestantData.Add(registryNumber);
        }
    }
}
