using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("abcd", 2, "aBcDaBcD")]
    [TestCase("AbCd", 1, "aBcD")]
    [TestCase("abcd", 5, "aBcDaBcDaBcDaBcDaBcD")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange
        
       
        // Act 
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = "";
        int repetitionFactor = 2;
        // Act & Assert
       
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abc";
        int repetitionFactor = -2;
        // Act & Assert

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "abc";
        int repetitionFactor = 0;
        // Act & Assert

        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }
    //Един тест с три кеиса който замества трите погорни теста!!!
    [TestCase("", 2 )]
    [TestCase("AbCd", -1 )]
    [TestCase("abcd", 0 )]
    public void Test_GeneratePatternedString_InvalidsInput_ThrowsArgumentException(string input, int repetitionFactor)
    {
        // Arrange


        // Act & Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }
}
