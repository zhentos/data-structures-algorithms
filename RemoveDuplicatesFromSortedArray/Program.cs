internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static int RemoveDuplicates(int[] nums)
    {
        if(nums.Length == 0) return 0;

        var l = 1; // начинаем запись с 1й позиции, 0я и так уникальна

        for(int r = 1; r <nums.Length; r++) 
        {
            if (nums[r] != nums[r-1]) 
            {
                nums[l] = nums[r];
                l++;
            }
        }
        return l;
    }
}