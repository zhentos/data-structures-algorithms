internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = new int[] { 2, 7, 11, 15 };
        TwoSum(numbers, 9);
    }
    public static int[] TwoSum(int[] numbers, int target)
    {
        var l = 0;
        var r = numbers.Length - 1;

        while (l < r)
        {
            if (numbers[l] + numbers[r] == target)
            {
                return [l + 1, r + 1];
            }
            else if (numbers[l] + numbers[r] > target)
            {
                r--;
            }
            else if (numbers[l] + numbers[r] < target)
            {
                l++;
            }
        }

        return [];
    }
}