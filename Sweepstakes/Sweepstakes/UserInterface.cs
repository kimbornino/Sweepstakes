using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //member variables
        public static string tempFirstName;
        public static string tempLastName;
        public static string tempEmail;
        public static string tempNumber;
        //remeber, this class cannot be instantiated anywhere.  Use only for communicating with user and sending info to other classes.
        public static void DisplaySweepstakesConditions()
        {
            Console.WriteLine("There is an exciting opportunity fo you to join our email list and win big. \n Our current sweepstakes offer is giving you the change to WIN A VISIT FROM A LLAMA! \n Invite all of your friends and family to a costumized llama party, complete with refreshments, wine, and treats for the llama. \n You will be notified via the email you submit if your name is chosen.\n Thanks for joining us!\n\n");
        }
        public static void GetFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            tempFirstName = Console.ReadLine();
            
        }
        public static void GetLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            tempLastName = Console.ReadLine();
        }
        public static void GetEmail()
        {
            Console.WriteLine("Please enter your email address: ");
            tempEmail = Console.ReadLine();
        }
        public static void AssignRegistrationNumber()
        {
            Random rnd = new Random();
            int tempRegistryNumber = rnd.Next(1000, 9999);
            tempNumber= tempRegistryNumber.ToString();
        }
       
        public static void GetUserInfo()
        {
            GetFirstName();
            GetLastName();
            GetEmail();
            AssignRegistrationNumber();
            DisplayInfoToContestant();
            
        }
        public static void DisplayInfoToContestant()
        {

            Console.WriteLine("Thank you for signing up!  Your information is as follows: \n Name: " + tempFirstName + " " + tempLastName + "\n Email: " + tempEmail + "\n Does everything look correct?  Please type YES or NO.");
            string confirmation = Console.ReadLine();

            if (confirmation == "YES")
            {

            }
            else
            {
                UserInterface.GetUserInfo();
            }
        }
    }
}
