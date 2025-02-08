using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Wk4Ex3_StringOperations
{
    internal class Program
    {
        // method to validate user string input
        public static string HandleStringInput(string aPrompt = "Write your sentence/string: ", string anErrorMessage = "Something went wrong on our end. Please enter a valid string input.\n")
        {
            // initialize return value
            string returnValue = "";


            // processing


            // start of a do while loop
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a string
                    Console.Write(aPrompt);
                    // Collect input from user and store it in the returnValue
                    returnValue = (Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine(anErrorMessage);
                }
            }
            // loop until returnValue has a different value
            while (returnValue == "");


            // return returnValue
            return returnValue;
        }



        // Module to validate integer input
        static int HandleIntInput(string aPrompt, string anErrorMessage = "Your input is invalid. Please enter a whole number.")
        {
            // initialize return value
            int returnValue = Int32.MaxValue;


            // processing


            // start of a do while loop
            do
            {
                // A try catch to ensure the user input is valid
                try
                {
                    // Ask user to input a number
                    Console.Write(aPrompt);
                    // Convert user input to a double, collect input from user and store it in the returnValue
                    returnValue = Convert.ToInt32(Console.ReadLine());
                }
                // if that doesn't work, output an error message
                catch (Exception e)
                {
                    // output an error message
                    Console.WriteLine(anErrorMessage);
                }
            }
            // loop until returnValue has a different value
            while (returnValue == Int32.MaxValue);


            // return returnValue
            return returnValue;
        }




        // Method to reverse a string 
        public static string ReverseString(string aString)
        {
            // initialize return value
            string returnValue = "";


            // processing


            // Declare Variables
            string reversedString = "";      // Declare a string variable for reversedUserString
            int index = aString.Length - 1;     // Declare an integer variable to hold the length of the string in indexes

            // a foreach loop to go through a loop for ever character in the string
            foreach (char i in aString)
            {
                // add the value of the string's index to the reversed version of the string
                reversedString += aString[index];
                // decrement the index
                index--;
            }


            // set value of returnValue to the reversed string
            returnValue = reversedString;


            // return returnValue
            return returnValue;
        }




        public static int CountVowels(string aString)
        {
            // initialize return value
            int returnValue = Int32.MaxValue;


            // processing


            // Variable Declaration
            int vowelCount = 0;     // declare an int output variable for vowelCount
            int stringIndex = 0;        // declare stringIndex variable to keep track of what the string index is
            char stringChar = 'A';      // declare a character variable to hold each character of the string in turn


            // convert string into all lowercase so we don't need to worry about being case-sensitive
            aString = aString.ToLower();


            // use a for loop to check each index of the string
            // reinitialize stringIndex to 0 so the programmer can see it's value without looking it up
            for (stringIndex = 0; stringIndex < aString.Length; stringIndex++)
            {
                // set stringChar to the first index in userString
                stringChar = aString[stringIndex];
                // use an if statement to determine if the character is a vowel
                if (stringChar == 'a' || stringChar == 'e' || stringChar == 'i' || stringChar == 'o' || stringChar == 'u')
                {
                    // count the character in the string if it is a, e, i, o, or u
                    vowelCount++;
                }
            }


            // set the return value to the total vowel count
            returnValue = vowelCount;


            // return returnValue
            return returnValue;
        }



        // module to determine if a user's string is a palendrome
        public static string IsPalindrome(string userString)
        {
            // initialize return value
            string returnValue = "";       // Declare a string variable for the return value and initialize it to hold nothing


            // processing


            // Declare variables
            string reversedUserString;      // Declare a string variable for reversedUserString
            bool isPalindrome = false;      // Declare a boolean variable to check if the string is a palindrome and initialize it to false


            // reverse the string and store it in another variable
            reversedUserString = ReverseString(userString);


            // check if the reversed string is the same as the user's string
            if (reversedUserString == userString)
            {
                // set isPalindrome to true
                isPalindrome = true;
            }

            // set return value for if the string is NOT a palindrome
            if (isPalindrome == false)
            {
                // set return value to tell user their string is not a palindrome
                returnValue = "Your string is not a Palindrome.";
            }
            // set return value for if the string IS a palindrome
            else
            {
                // set return value to tell user their string is a palindrome
                returnValue = "Your string is a Palindrome.";
            }

            // return returnValue
            return returnValue;
        }

        static void Main(string[] args)
        {
            // Goal: Prompt user to input a string. Have user select an operation to
            // perform on the string. Perform the operation. Output the result.


            // Declare Variables
            string userString = "";     // Declare a string variable for userString
            int selection = Int32.MaxValue;     // declare an integer value for the selection the user will choose



            // Prompt user to type string then store user string in the userString variable
            userString = HandleStringInput();



            // Prompt user to select a choice of what to do with their string
            do
            {
                // Prompt user to select a choice of what to do with their string
                Console.WriteLine("Select an operation to perform on your sentence/string:");


                // Output to tell the user they can type 1 to reverse their string
                Console.WriteLine("1. Type the characters in reverse.");
                // Output to tell the user they can type 2 to count the vowels in their string
                Console.WriteLine("2. Count the number of Vowels");
                // Output to tell the user they can type 3 to check if their string is a palendrome
                Console.WriteLine("3. Check if your string is a palendrome.");


                // Call the try catch in the Interger Conversion module
                // Make selection equal the return value of the module
                selection = HandleIntInput("Your desired operation (1-3): ", "An error occured. Please ensure you enter a valid whole number.");


                // If the selection isn't between 1 and 3, change the input back to the while evaluation number to have them try again
                if (!(selection >= 1 && selection <= 3))
                {
                    // output a message to prompt user to re-enter the value as a number from 1 to 3
                    Console.WriteLine("Please input a value between 1 and 3.");
                    // set selection to the max integer value
                    selection = Int32.MaxValue;
                }
            }
            // continue loop while the selection is the max integer value
            while (selection == Int32.MaxValue);





            // use a switch case to perform an operation based on the selection
            switch (selection)
            {
                // Run this case if selection = 1
                case 1:
                    // Print the string in reverse order
                    Console.WriteLine(ReverseString(userString));

                    // Jump out of switch here.
                    break;


                // Run this case if selection = 2
                case 2:
                    // print how many vowels the string has
                    Console.WriteLine(CountVowels(userString));

                    // Jump out of switch here.
                    break;


                // Run this case if selection = 3
                case 3:
                    // Output whether or not the user's string an a palindrome
                    Console.WriteLine(IsPalindrome(userString));

                    // Jump out of switch here.
                    break;


                default:
                    // Output a polite message in case of unforseen error.
                    Console.WriteLine("It seems something went wrong on our end. Please close the program and try again.");

                    // Jump out of switch here.
                    break;
            }



            // Thank user for using the program
            Console.WriteLine("Thank you for using this currency conversion program! Come again!");


            // Pause at the end of program for user to read
            Console.ReadLine();
        }
    }
}
