using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        // int num = 58;
        // Console.WriteLine(IntToRoman(num));
        var s = "   fly me   to   the moon  ";
        var r = LengthOfLastWord(s);
        Console.WriteLine(r);
    }

    public static string IntToRoman(int num)
    {
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        var sb = new StringBuilder();

        for (int i = 0; i < values.Length && num > 0; i++)
        {
            while (num >= values[i])
            {
                sb.Append(romans[i]);  // добавляем соответствующий римский фрагмент
                num -= values[i];      // вычитаем его из числа
            }
        }

        return sb.ToString();
    }

    public static int LengthOfLastWord(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        int i = s.Length - 1;

        // 1. Пропускаем пробелы с конца
        while (i >= 0 && s[i] == ' ')
            i--;

        int length = 0;

        // 2. Считаем длину последнего слова
        while (i >= 0 && s[i] != ' ')
        {
            length++;
            i--;
        }

        return length;
    }
}