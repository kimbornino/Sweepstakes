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
               
  
        public static void GetFirstName()
        {
            Console.WriteLine("Please enter contestants first name: ");
            tempFirstName = Console.ReadLine();
            
        }
        public static void GetLastName()
        {
            Console.WriteLine("Please enter last name: ");
            tempLastName = Console.ReadLine();
        }
        public static void GetEmail()
        {
            Console.WriteLine("Please enter contestant's email address: ");
            tempEmail = Console.ReadLine();
        }
        public static void AssignRegistrationNumber()
        {
            Random rnd = new Random();
            int tempRegistryNumber = rnd.Next(1000, 9999);
            tempNumber= tempRegistryNumber.ToString();
        }
       
        public static void GetContestantInfo()
        {
            GetFirstName();
            GetLastName();
            GetEmail();
            AssignRegistrationNumber();
            DisplayContestantInfoToUser();
            
        }
        public static void DisplayContestantInfoToUser()
        {

            Console.WriteLine("You entered: \n Name: " + tempFirstName + " " + tempLastName + "\n Email: " + tempEmail + "\n Does everything look correct?  Please type YES or NO.");
            string confirmation = Console.ReadLine();

            if (confirmation == "YES")
            {

            }
            else
            {
                UserInterface.GetContestantInfo();
            }
        }

        public static void GetNumberOfContestants()
        {
            Console.WriteLine("How many contestants would you like to register?");
            int numberOfContestants = Int32.Parse(Console.ReadLine());
        }

    public static string ChooseStorage()
        {
            Console.WriteLine("How would you like to store this sweepstakes?  stack or queue?");
            string storageMethod = Console.ReadLine();
            return storageMethod;
        }
    }
}
