internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = [4, 3, 2, 7, 8, 2, 3, 1];
        var result = FindDisappearedNumbers(nums);
    }

    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        var result = new List<int>();
        var presentedNumsSet = new HashSet<int>(nums);
        var total = nums.Length;

        for (int i = 0; i < total; i++)
        {
            if (!presentedNumsSet.Contains(i))
                result.Add(i);
        }
        return result;
    }
}