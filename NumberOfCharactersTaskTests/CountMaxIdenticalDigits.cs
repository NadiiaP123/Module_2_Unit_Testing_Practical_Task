using NumberOfCharactersTask;

namespace NumberOfCharactersTaskTests;

[TestClass]
public class CountMaxIdenticalDigits
{
    [TestMethod]

    [DataRow("", 0)]                    // Empty string
    [DataRow("1", 1)]                   // One digit
    [DataRow("a", 0)]                   // One non-digit
    [DataRow("11", 2)]                  // Two identical digits
    [DataRow("12", 1)]                  // Two non-identical digits
    [DataRow("11111", 5)]               // Only identical digits
    [DataRow("123456", 1)]              // Only non-identical digits
    [DataRow("1aa2bb3cc", 1)]           // Mixed - unequal digits, equal letters
    [DataRow("11aa111aaa", 3)]          // Mixed - equal digits series, equal letters series
    [DataRow("11a11", 2)]               // Non-digit breaks the run
    [DataRow("111122333", 4)]           // Max consecutive digits at the  beginning
    [DataRow("110000333", 4)]           // Max consecutive digits in the middle + zeros
    [DataRow("112223333", 4)]           // Max consecutive digits at the end
    [DataRow("11 222-333+4444", 4)]     // Spaces and dividers are ignored
    [DataRow("٣٣333", 3)]               // Same value but different Unicode are non-identical digits
    [DataRow("٣٣a", 2)]                 // Unicode digits are treated as digits



    public void CountMaxIdenticalDigits_ReturnsExpected(string input, int expected)
    {
        var actual = NumberOfCharacters.CountMaxIdenticalDigits(input);

        Assert.AreEqual(expected, actual, $"Input: {input}\nExpected: {expected}\nActual: {actual}");
    }

    [TestMethod]
    public void MaxConsecutiveIdenticalLatinLetters_ShouldThrow_WhenNull()
    {
        var ex = Assert.Throws<ArgumentNullException>(
            () => NumberOfCharacters.CountMaxIdenticalDigits(null!)
        );

        Assert.AreEqual("str", ex.ParamName);
    }
}
