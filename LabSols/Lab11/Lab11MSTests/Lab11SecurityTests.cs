using LabsSolutions.Lab11;

namespace LabsSolutions.Lab11MSTests
{
    [TestClass]
    public sealed class Lab11SecurityTests
    {
        private readonly Security _security = new Security();


        [TestMethod]
        public void TestLogonEmptyUserId()
        {
            String userId = "";
            String password = "Freddy99";
            bool actual = _security.Logon(userId, password);
            bool expected = false;
            Assert.AreEqual(expected, actual);
            // assertFalse(actual);   // can also use this assert
        }

        [TestMethod]
        public void Logon_NullUserId_ReturnsFalse()
        {
            Assert.IsFalse(_security.Logon(null, "Freddy99"));
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("   ")]
        public void Logon_EmptyOrWhitespaceUserId_ReturnsFalse(string userId)
        {
            Assert.IsFalse(_security.Logon(userId, "Freddy99"));
        }

        [TestMethod]
        public void Logon_ShortUserId_AllowsWhenPasswordValid()
        {
            // Current implementation does not enforce a minimum userId length.
            Assert.IsTrue(_security.Logon("a", "Freddy99"));
        }

        [TestMethod]
        public void Logon_NullPassword_ReturnsFalse()
        {
            Assert.IsFalse(_security.Logon("validUser", null));
        }

        [DataTestMethod]
        [DataRow("")]
        [DataRow("   ")]
        public void Logon_EmptyOrWhitespacePassword_ReturnsFalse(string password)
        {
            Assert.IsFalse(_security.Logon("validUser", password));
        }

        [TestMethod]
        public void Logon_PasswordTooShort_ReturnsFalse()
        {
            // 7 chars, has uppercase and digit but too short for ValidatePassword
            Assert.IsFalse(_security.Logon("validUser", "Freddy9"));
        }

        [TestMethod]
        public void Logon_PasswordMissingUppercase_ReturnsFalse()
        {
            Assert.IsFalse(_security.Logon("validUser", "freddy99"));
        }

        [TestMethod]
        public void Logon_PasswordMissingDigit_ReturnsFalse()
        {
            Assert.IsFalse(_security.Logon("validUser", "Freddyyy"));
        }

        [TestMethod]
        public void Logon_ValidPasswordAndUser_ReturnsTrue()
        {
            Assert.IsTrue(_security.Logon("validUser", "Abcdefg1"));
        }

        [DataTestMethod]
        [DataRow("Abcdefg1", true)]
        [DataRow("freddy99", false)]
        [DataRow("Freddyyy", false)]
        [DataRow("Freddy9", false)]
        [DataRow("", false)]
        public void ValidatePassword_VariousInputs_ReturnsExpected(string password, bool expected)
        {
            Assert.AreEqual(expected, _security.ValidatePassword(password));
        }

    }
}
