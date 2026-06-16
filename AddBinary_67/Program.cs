using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var a = "11";
        var b = "1";
        var output = AddBinary(a, b);
        Console.WriteLine(output);
        Console.WriteLine("Hello, World!");
    }

    public static string AddBinary(string a, string b)
    {
        var sb = new StringBuilder();
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        while (i >= 0 || j >= 0 || carry > 0)
        {
            int sum = carry;

            if (i >= 0)
            {
                sum += a[i] - '0'; // бит из a
                i--;
            }

            if (j >= 0)
            {
                sum += b[j] - '0'; // бит из b
                j--;
            }

            int bit = sum % 2;   // текущий бит результата
            carry = sum / 2;     // перенос в следующий разряд

            sb.Append(bit);      // добавляем справа налево
        }

        // мы строили строку с конца, поэтому переворачиваем
        var chars = sb.ToString().ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}