using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTestPlayground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            string myString = Console.ReadLine().ToLower();

            var inputString = "";
            var compareString = "";

            // Cleanup our input (N punctuation, spaces, lowercase)
            foreach (char mychar in myString)
            {
                if (!char.IsPunctuation(mychar))
                {
                    inputString += mychar;
                }
            }
            inputString = inputString.Replace(" ", string.Empty);

            // Reverse the input
            compareString = ReverseString(inputString);

            // Compare the two strings
            if (compareString == inputString)
            {
                Console.WriteLine("You made one of those palin thingies!");
            }
            else
            {
                Console.WriteLine("You are dumb!");
            }

            Console.ReadLine();
        }

        // Method to reverse the input string goes here
        public static string ReverseString(string s)
        {
            char[] array = s.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
