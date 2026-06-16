internal class Program
{
    private static void Main(string[] args)
    {
        var s = "leetcode";

        var position = FirstUniqChar(s);

        Console.WriteLine(position);
    }

    public static int FirstUniqChar(string s)
    {
        int[] counts = new int[26];

        // 1. Считаем, сколько раз каждый символ встречается
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            counts[c - 'a']++;
        }

        // 2. Ищем первый символ с частотой 1
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (counts[c - 'a'] == 1)
            {
                return i;
            }
        }

        return -1;
    }
}