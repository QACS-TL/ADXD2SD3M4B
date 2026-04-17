namespace LabsSolutions.Lab11;
public class Security
{
    public bool Logon(string userId, string password)
    {
        string errorMessage;

        // userId must not be null or spaces. Must be 8 chars minimum.
        // password must contain a digit and an upper case char

        if (userId == null || userId.Trim() == "")
        {
            errorMessage = "UserID may not be null or empty";
            return false;
        }
        else if (password == null || password.Trim() == "")
        {
            errorMessage = "Password may not be null or empty";
            return false;
        }
        else if (!ValidatePassword(password))
        {
            errorMessage = "Password must be min 8 chars with an uppercase and a number";
            return false;
        }
        else
        {
            errorMessage = "";
            return true;
        }
    }
    public bool ValidatePassword(String password)
    {
        bool hasUpper = false, hasDigit = false;

        if (password.Length < 8)
            return false;

        foreach (char c in password)
        {

            if (Char.IsUpper(c))
            {
                hasUpper = true;
                // continue loop as no character can be both!
                continue;
            }
            if (Char.IsDigit(c))
            {
                hasDigit = true;
            }
        }
        return hasUpper && hasDigit;
    }
}
