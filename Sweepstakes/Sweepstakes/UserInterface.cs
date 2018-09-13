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
        public static string tempRegistryNumber;
        //remeber, this class cannot be instantiated anywhere.  Use only for communicating with user and sending info to other classes.
       public static void GetFirstName()
        {
            Console.WriteLine("Please enter your first name: ");
            string tempFirstName = Console.ReadLine();
            
        }
        public static void GetLastName()
        {
            Console.WriteLine("Please enter your last name: ");
            string tempLastName = Console.ReadLine();
        }
        public static void GetEmail()
        {
            Console.WriteLine("Please enter your email address: ");
            string tempEmail = Console.ReadLine();
        }
        public static void AssignRegistrationNumber()
        {
            Random rnd = new Random();
            int tempRegistryNumber = rnd.Next(0, 10000);
            string tempNumber= tempRegistryNumber.ToString();
        }
       
        public static void GetUserInfo()
        {
            GetFirstName();
            GetLastName();
            GetEmail();
            AssignRegistrationNumber();
            
        }
        public static void DisplayInfoToContestant()
        {

            Console.WriteLine("Thank you for signing up!  Your information is as follows: \n Name: " + tempFirstName + tempLastName + "\n Email: " + tempEmail + "/n Does everything look correct?  Please type YES or NO.");
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
