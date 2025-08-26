using Xunit;
using PasswordChecker;

namespace PasswordChecker.Tests
{
    public class PasswordValidatorTests
    {
        [Theory]
        [InlineData("", "INELIGIBLE")]
        [InlineData("abc", "WEAK")]
        [InlineData("ABC", "WEAK")]
        [InlineData("123", "WEAK")]
        [InlineData("@#$", "WEAK")]
        [InlineData("abc123", "MEDIUM")]
        [InlineData("ABC123", "MEDIUM")]
        [InlineData("abcABC", "MEDIUM")]
        [InlineData("abc@#", "MEDIUM")]
        [InlineData("abcABC123", "MEDIUM")]
        [InlineData("Abc1!", "STRONG")]
        [InlineData("Password123!", "STRONG")]
        public void CheckStrength_ReturnsExpectedResult(string input, string expected)
        {
            var result = PasswordValidator.CheckStrength(input);
            Assert.Equal(expected, result);
        }
    }
}
