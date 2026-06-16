internal class Program
{
    private static void Main(string[] args)
    {
        var result = IsPalindrome("test");
        Console.WriteLine(result);
    }
    public static bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length < 2)
            return true;

        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }
            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }
            if (left < right)
            {
                var leftChar = char.ToLower(s[left]);
                var rightChar = char.ToLower(s[right]);

                if (leftChar != rightChar)
                    return false;

                left++;
                right--;
            }
        }

        return true;
    }
}