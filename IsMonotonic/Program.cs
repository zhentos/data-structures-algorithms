internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = [1, 2, 3];
       var result = IsMonotonic(nums);
       Console.Write(result);
    }
    public static bool IsMonotonic(int[] nums)
    {
        if (nums == null || nums.Length <= 2)
            return true;

        bool nonDecreasing = true; // пока не нашли падения
        bool nonIncreasing = true; // пока не нашли роста

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
                nonIncreasing = false;   // есть рост => не может быть чисто невозрастающим

            if (nums[i] < nums[i - 1])
                nonDecreasing = false;   // есть падение => не может быть чисто неубывающим

            if (!nonDecreasing && !nonIncreasing)
                return false;           // и рост, и падение — точно не монотонный
        }

        return true; // до конца дошли, хотя бы один тип не сломан
    }
}