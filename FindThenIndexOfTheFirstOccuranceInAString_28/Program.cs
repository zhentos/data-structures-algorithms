internal class Program
{
    private static void Main(string[] args)
    {
        string haystack = "hello";
        string needle = "ll";

        StrStr(haystack, needle);
    }
    private static int StrStr(string haystack, string needle)
    {
        var needleLength = needle.Length;

        if (needleLength > haystack.Length)
            return -1;

        var matchLength = 0;
        var index = -1;
        var firstOccurance = false;

        for (int i = 0; i < haystack.Length; i++)
        {
            for (int j = i; j < needleLength; j++)
            {
                if (haystack[i] == needle[j])
                {
                    matchLength++;

                    if (matchLength == 1)
                    {
                        firstOccurance = true;
                    }
                    else
                    {
                        firstOccurance = false;
                    }

                    if (firstOccurance)
                    {
                        index = i;
                    }

                    break;
                }
                else
                {
                    index = -1;
                    firstOccurance = false;
                }
            }
            if (matchLength > 0 && matchLength == needleLength)
                break;
        }

        return index;
    }
}