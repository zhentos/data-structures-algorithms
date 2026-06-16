internal class Program
{
    private static void Main(string[] args)
    {
        ReverseString([ 'A', 'B' ]);
    }
    public static void ReverseString(char[] s)
    {
        var left = 0;
        var right = s.Length - 1;

        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
    }
}