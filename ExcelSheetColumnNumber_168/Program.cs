using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var y = 25;
        var result = ConvertToTitle(y);
        Console.WriteLine(result);
    }

    public  static string ConvertToTitle(int columnNumber)
    {
        var result = new StringBuilder();

        while (columnNumber > 0)
        {
            columnNumber--; // Shift to zero-based: A = 0, ..., Z = 25

            char letter = (char)('A' + columnNumber % 26);
            result.Append(letter);

            columnNumber /= 26;
        }

        var chars = result.ToString().ToCharArray();
        Array.Reverse(chars);

        return new string(chars);
    }
}