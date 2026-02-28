using NumberOfCharactersTask;

namespace NumberOfCharactersTaskTests;

[TestClass]
public class CountMaxIdenticalLatinLetters
{
    [TestMethod]

    [DataRow("", 0)]                                    // Empty string
    [DataRow("a", 1)]                                   // One Latin symbol
    [DataRow("ааа", 0)]                                 // Only Cyrillic
    [DataRow("123", 0)]                                 // Only digits
    [DataRow("aaa123аааа", 3)]                          // Latin + Digits + Cyrillic  
    [DataRow("aa", 2)]                                  // Minimum consecutive
    [DataRow("ababab", 1)]                              // No consecutive
    [DataRow("aabcabc", 2)]                             // At the beginning
    [DataRow("abaabc", 2)]                              // In the middle
    [DataRow("abcabcaa", 2)]                            // At the end
    [DataRow("aa bbbcccc dd", 4)]                       // Several consecutive and spaces
    [DataRow("AaAa", 1)]                                // Case-sensitive
    [DataRow("!@#$ %^&*()_+-=[] aaa{}| ;':,./<>?", 3)]  // Other Symbols + valid consecutive

    public void CountMaxIdenticalLatinLetters_ReturnsExpected(string input, int expected)
    {
        var actual = NumberOfCharacters.CountMaxIdenticalLatinLetters(input);

        Assert.AreEqual(expected, actual, $"Input: {input}\nExpected: {expected}\nActual: {actual}");
    }

    [TestMethod]
    public void MaxConsecutiveIdenticalLatinLetters_ShouldThrow_WhenNull()
    {
        var ex = Assert.Throws<ArgumentNullException>(
            () => NumberOfCharacters.CountMaxIdenticalLatinLetters(null!)
        );

        Assert.AreEqual("str", ex.ParamName);
    }
}
