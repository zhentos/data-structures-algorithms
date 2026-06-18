internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = [0, 1, 0, 3, 12];
        MoveZeroes(nums);
        Console.WriteLine('a');
    }
    public static void MoveZeroes(int[] nums)
    {
        var slow = 0;

        for (int fast = 0; fast < nums.Length; fast++) 
        {
            if (nums[fast] != 0) 
            {
                nums[slow] = nums[fast];
                slow++;
            }
        }

        while(slow < nums.Length)
        {
            nums[slow] = 0;
            slow++;
        }
        
    }
}