namespace PasswordChecker
{
    public static class PasswordValidator
    {
        public static string CheckStrength(string password)
        {
            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSymbol = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                else if (char.IsLower(c)) hasLower = true;
                else if (char.IsDigit(c)) hasDigit = true;
                else if (!char.IsLetterOrDigit(c)) hasSymbol = true;
            }

            int score = 0;
            if (hasUpper) score++;
            if (hasLower) score++;
            if (hasDigit) score++;
            if (hasSymbol) score++;

            return score switch
            {
                0 => "INELIGIBLE",
                1 => "WEAK",
                2 or 3 => "MEDIUM",
                4 => "STRONG",
                _ => "INELIGIBLE"
            };
        }
    }
}
