internal class Program
{
    private static void Main(string[] args)
    {
        var rowIndex = 3;
        var result = GetRow(rowIndex);
    }

    public static IList<int> GetRow(int rowIndex)
    {
        // Создаём массив размером rowIndex + 1 (все элементы = 0)
        int[] result = new int[rowIndex + 1];

        // Первый элемент всегда 1
        result[0] = 1;

        // Строим строки одну за другой до нужной
        for (int i = 1; i <= rowIndex; i++)
        {
            // Идём справа налево, чтобы использовать старые значения
            for (int j = i; j > 0; j--)
            {
                result[j] = result[j] + result[j - 1];
            }
        }

        return [.. result];
    }
}