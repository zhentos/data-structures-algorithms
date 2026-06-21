internal class Program
{
    private static void Main(string[] args)
    {
        var version1 = "1.2";
        var version2 = "1.10";

        var result = CompareVersion(version1, version2);
        Console.WriteLine(result);
    }
    public static int CompareVersion(string version1, string version2)
    {
        var v1 = version1.Split('.');
        var v2 = version2.Split('.');

        int n = Math.Max(v1.Length, v2.Length);

        for (int i = 0; i < n; i++)
        {
            int num1 = i < v1.Length ? int.Parse(v1[i]) : 0;
            int num2 = i < v2.Length ? int.Parse(v2[i]) : 0;

            if (num1 < num2) return -1;
            if (num1 > num2) return 1;
        }

        return 0;
    }
}