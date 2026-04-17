using LabsSolutions.Lab11;

namespace LabsSolutions.Lab11XUnitTests
{
    public class Lab11SecurityTests
    {
        private readonly Security _security = new Security();

        [Fact]
        public void TestLogonEmptyUserId()
        {
            String userId = "";
            String password = "Freddy99";
            bool actual = _security.Logon(userId, password);
            bool expected = false;
            Assert.Equal(expected, actual);
            // assertFalse(actual);   // can also use this assert

        }

        [Fact]
        public void Logon_NullUserId_ReturnsFalse()
        {
            Assert.False(_security.Logon(null, "Freddy99"));
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        public void Logon_EmptyOrWhitespaceUserId_ReturnsFalse(string userId)
        {
            Assert.False(_security.Logon(userId, "Freddy99"));
        }

        [Fact]
        public void Logon_ShortUserId_AllowsWhenPasswordValid()
        {
            // Current implementation doesn't enforce a minimum userId length.
            Assert.True(_security.Logon("a", "Freddy99"));
        }

        [Fact]
        public void Logon_NullPassword_ReturnsFalse()
        {
            Assert.False(_security.Logon("validUser", null));
        }

        [Theory]
        [InlineData("")]
        [InlineData("   ")]
        public void Logon_EmptyOrWhitespacePassword_ReturnsFalse(string password)
        {
            Assert.False(_security.Logon("validUser", password));
        }

        [Fact]
        public void Logon_PasswordTooShort_ReturnsFalse()
        {
            // 7 chars, has uppercase and digit but too short for validatePassword
            Assert.False(_security.Logon("validUser", "Freddy9"));
        }

        [Fact]
        public void Logon_PasswordMissingUppercase_ReturnsFalse()
        {
            Assert.False(_security.Logon("validUser", "freddy99"));
        }

        [Fact]
        public void Logon_PasswordMissingDigit_ReturnsFalse()
        {
            Assert.False(_security.Logon("validUser", "Freddyyy"));
        }

        [Fact]
        public void Logon_ValidPasswordAndUser_ReturnsTrue()
        {
            // 8+ chars, contains an uppercase and a digit
            Assert.True(_security.Logon("validUser", "Abcdefg1"));
        }

        [Theory]
        [InlineData("Abcdefg1", true)]   // valid: uppercase + digit, length 8
        [InlineData("freddy99", false)] // missing uppercase
        [InlineData("Freddyyy", false)] // missing digit
        [InlineData("Freddy9", false)]  // too short
        [InlineData("", false)]
        public void ValidatePassword_VariousInputs_ReturnsExpected(string password, bool expected)
        {
            Assert.Equal(expected, _security.ValidatePassword(password));
        }
    }
}
