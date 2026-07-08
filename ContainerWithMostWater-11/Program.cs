internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int MaxArea(int[] height)
    {
        int left = 0;
        int right = height.Length - 1;
        int maxArea = 0;

        while (left < right)
        {
            // текущая ширина
            int width = right - left;

            // высота ограничена более низкой стенкой
            int currentHeight = Math.Min(height[left], height[right]);

            // площадь текущего контейнера
            int currentArea = currentHeight * width;

            // обновляем максимум
            if (currentArea > maxArea)
            {
                maxArea = currentArea;
            }

            // двигаем указатель с меньшей высотой внутрь
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return maxArea;
    }
}