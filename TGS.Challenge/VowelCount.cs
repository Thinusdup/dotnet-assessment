using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
    /*
        Devise a function that takes a string & returns the number of 
        vowels (aeiou) in that string.

        "Hi there!" = 3
        "What do you mean?"  = 6

        There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */
    public class VowelCount
    {
        // Build a list of vowels up front
        private static HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        //TODO: Test if rather then using for if foreach statement performance is not better
        public int Count(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Please add a valid string value to count vowels");
            }

            int total = 0;
            value = value.ToLower();

            for (int i = 0; i < value.Length; i++)
            {
                if (vowels.Contains(value[i]))
                {
                    total++;
                }
            }
            return total;
        }
    }
}
