using System.Text.RegularExpressions;

namespace NumberOfCharactersTask
{
    public static class NumberOfCharacters
    {
        public static int CountMaxUnequalConsecutive(string str)
        {
            ArgumentNullException.ThrowIfNull(str);

            if (str.Length == 0)
            {
                return 0;
            }

            int maxSubstrLength = 0;
            int currentLength = 0;
            int startIndex = 0;

            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == str[i - 1])
                {
                    currentLength = i - startIndex;
                    if (currentLength > maxSubstrLength)
                    {
                        maxSubstrLength = currentLength;
                    }

                    startIndex = i;
                }  
            }

            currentLength = str.Length - startIndex;
            if (currentLength > maxSubstrLength)
            {
                maxSubstrLength = currentLength;
            }
            return maxSubstrLength;
        }

        public static int CountMaxIdenticalLatinLetters(string str)
        {
            ArgumentNullException.ThrowIfNull(str);

            if (str.Length == 0)
            {
                return 0;
            }

            int maxSeries = 0;
            int count = 0;
            char prevSymbol = str[0];

            foreach (char c in str)
            {
                if (!Regex.IsMatch(c.ToString(), "^[A-Za-z]$"))
                {
                    count = 0;
                    continue;
                }

                if (c == prevSymbol)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                prevSymbol = c;

                if (count > maxSeries)
                {
                    maxSeries = count;
                }
            }

            return maxSeries;
        }


        public static int CountMaxIdenticalDigits(string str)
        {
            ArgumentNullException.ThrowIfNull(str);

            if (str.Length == 0)
            {
                return 0;
            }

            int maxSeries = 0;
            int count = 0;
            char prevSymbol = str[0];

            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    count = 0;
                    continue;
                }

                if (c == prevSymbol)
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                prevSymbol = c;

                if (count > maxSeries)
                {
                    maxSeries = count;
                }
            }

            return maxSeries;

        }



    }
}