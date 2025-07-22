using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LearningCSharp1._Helpers
{
    public static class SecurityHelper
    {
        public static void PasswordChecker ()
        {
            // Get a new password input
            string enterNewPassword = "Enter a new password: ";
            string reEnterPassword = "Re-enter the password: ";
            string newPassword;
            string reEnteredPassword;
            bool isMatch = true;
            //string reset = Console.ReadLine();
            //bool startOver;


            // Prompt the user to re-enter if new password = blank
            do
            {
                Console.Write(enterNewPassword);
                // Store new password
                newPassword = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(newPassword));



            // Prompt the user to re-enter if confirm password = blank
            do
            {
                Console.Write(reEnterPassword);
                // Store new password
                reEnteredPassword = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(reEnteredPassword));

            // Compare the password_confirm with password_new
            if (newPassword == reEnteredPassword)
            {
                Console.WriteLine("Successfully saved new password!");
            }
            else
            {
                isMatch = false ;
            }
            
            // If no match, prompt the user to re-confirm
            if (isMatch == false)
            {
                bool? startOver = null;

                Console.WriteLine("Password does not match. Press 1 to start over, or press 2 to exit.");
                string input = Console.ReadLine();

                while (String.IsNullOrEmpty(input))// Do not allow empty or invalid values.
                {
                    Console.WriteLine("Invalid input. Please enter 1 or 2.");
                    input = Console.ReadLine();
                }

                switch (input)
                {
                    case "1":
                        startOver = true;
                        break;
                    case "2":
                        startOver = false;
                        break;
                    default:
                        break;
                }

                switch (startOver)
                {
                    case true:
                        Console.WriteLine("Starting Over.");
                        PasswordChecker();
                        break;
                    case false:
                        Console.WriteLine("Returning to Main menu.");
                        return;
                    default:
                        break;
                }
            }
            





            /*
            // testing
            for (int i = 0; i < password_new.Length; i++)
            {
                Console.WriteLine(password_new[i]);
            }
            */
            return;
        }
    }
}
