using System;
using System.Collections.Generic;
using System.Text;

namespace NumberOfCharactersTask
{
    internal static class Program
    {
        static void Main()
        {          
            string? str = Console.ReadLine();

            if (str is null)
            {
                return;
            }

            if (str.Length == 0)
            {
                Console.WriteLine("Input string is empty");
                return;
            }

            Console.WriteLine($"Maximum number of unequal consecutive characters: {NumberOfCharacters.CountMaxUnequalConsecutive(str)}");
            Console.WriteLine($"Maximum number of consecutive identical Latin letters: {NumberOfCharacters.CountMaxIdenticalLatinLetters(str)}");
            Console.WriteLine($"Maximum number of consecutive identical digits: {NumberOfCharacters.CountMaxIdenticalDigits(str)}");
        }
    }
}
