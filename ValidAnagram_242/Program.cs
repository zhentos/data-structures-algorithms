internal class Program
{
    private static void Main(string[] args)
    {
        string s = "anagram", t = "nagaram";

        Console.WriteLine(IsAnagram(s, t)); 
    }
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        char[] orderedS = s.ToCharArray();
        char[] orderedT = t.ToCharArray();

        Array.Sort(orderedS);
        Array.Sort(orderedT);

        string sortedS = new(orderedS);
        string sortedT = new(orderedT);

        if (sortedS == sortedT)
            return true;

        return false;
    }
}