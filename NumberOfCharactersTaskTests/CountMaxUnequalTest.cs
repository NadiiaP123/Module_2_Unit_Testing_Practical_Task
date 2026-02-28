using NumberOfCharactersTask;

namespace NumberOfCharactersTaskTests
{
    [TestClass]
    public class CountMaxUnequalTest
    {
        [TestMethod]

        [DataRow("", 0)]                // Empty string
        [DataRow("a", 1)]               // Min valid
        [DataRow("abcdefабвгд", 11)]    // Alphabet (Latin + Cyrillic) + only unequal consecutive
        [DataRow("123455", 5)]          // Digits + count unequal 
        [DataRow("!@#|;':,./<>", 12)]   // Other symbols + only unequal consecutive
        [DataRow("ab", 2)]              // Min unequal consecutive
        [DataRow("aA", 2)]              // Min unequal consecutive + Case sensitive
        [DataRow("aAaAaA", 6)]          // Case sensitive
        [DataRow("aaaaa", 1)]           // No unequal
        [DataRow("aa   aaa   aaa", 2)]  // Spaces
        [DataRow("abcdeeabccab", 5)]    // Max unequal consecutive at the beginning
        [DataRow("abcddabcdeeabc", 6)]  // Max unequal consecutive in the middle
        [DataRow("abccabcddabcdef", 7)] // Max unequal consecutive at the end       

        public void CountMaxUnequalConsecutive_ReturnsExpected(string input, int expected)
        {
            var actual = NumberOfCharacters.CountMaxUnequalConsecutive(input);

            Assert.AreEqual(expected, actual, $"Input: {input}\nExpected: {expected}\nActual: {actual}");
        }

        [TestMethod]
        public void MaxConsecutiveIdenticalLatinLetters_ShouldThrow_WhenNull()
        {
            var ex = Assert.Throws<ArgumentNullException>(
                () => NumberOfCharacters.CountMaxUnequalConsecutive(null!)
            );

            Assert.AreEqual("str", ex.ParamName);
        }


    }
}
