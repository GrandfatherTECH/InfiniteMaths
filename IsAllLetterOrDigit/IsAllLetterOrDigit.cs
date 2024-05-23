namespace IsAllLettersOrDigitsLib
{
    public static class IsAllLettersOrDigitsClass
    {
        public static bool IsAllDigit(string s)
        {
            foreach (char c in s) 
            {
                if (char.IsDigit(c)) return true;
            }
            return false;
        }

        public static bool IsAllLetter(string s)
        {
            foreach(char c in s)
            {
                if(char.IsLetter(c)) return true;
            }
            return false;
        }

        public static bool IsAllLetterOrDigit(string s)
        {
            foreach (char c in s)
            {
                if(char.IsLetterOrDigit(c)) return true;
            }
            return false;
        }
    }
}
