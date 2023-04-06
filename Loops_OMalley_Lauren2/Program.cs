using System;

namespace Loops_OMalley_Lauren2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Askes the user why they want to make games and has a string for the users response
            Console.WriteLine("Why do you want to make games?");
            string response = Console.ReadLine();

            // Tells the user how many spaces are in the sentence that they typed
            Console.WriteLine($"The sentence, \"{response}\" has {CountNumberOfSpaces(response)} spaces in it.");

            // Askes the user to enter a whole number and has a string for the users response
            Console.WriteLine("Please enter a whole number!");
            string response2 = Console.ReadLine();

            // Tells the user the sum of each digit that was typed
            Console.WriteLine($"The sum of the individual digits of {response2} is {SumOfDigits(response2)}!");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sentence">The sentence to count number of spaces in</param>
        /// <returns>The number of spaces in the sentence</returns>
        static int CountNumberOfSpaces(string sentence)
        {
            int numberOfSpaces = 0;
            foreach (char character in sentence)
            {
                if (character == ' ')
                    numberOfSpaces++;
            }

            return numberOfSpaces;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number">Adds the sum of each number that was typed</param>
        /// <returns>The sum of all the numbers</returns>
        static int SumOfDigits(string number)
        {
            int sum = 0;
            foreach (char digit in number)
            {
                sum += (int)Char.GetNumericValue(digit);
            }

            return sum;
        }
    }
}
