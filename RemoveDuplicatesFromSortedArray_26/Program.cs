internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = [1, 1, 2];
        var k = RemoveDuplicates(nums);
        Console.WriteLine(k);
    }

    private static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        int l = 1; // позиция для записи следующего уникального

        for (int r = 1; r < nums.Length; r++)
        {
            if (nums[r] != nums[r - 1])
            {
                nums[l] = nums[r];
                l++;
            }
        }

        return l; // количество уникальных
    }
}