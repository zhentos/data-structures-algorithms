internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
    public static int[] SortedSquares(int[] nums)
    {
        var result = new int[nums.Length];
        var l = 0;
        var r = nums.Length - 1;
        var pos = result.Length - 1;

        while (l <= r)
        {
            var lSqr = nums[l] * nums[l];
            var rSqr = nums[r] * nums[r];

            if (lSqr > rSqr)
            {
                result[pos] = lSqr;
                l++;
            }
            else
            {
                result[pos] = rSqr;
                r--;
            }
            pos--;
        }
        return result;
    }
}