namespace MoveZeros_283
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [0, 1, 0, 3, 12];
            MoveZeroes(nums);
        }

        public static void MoveZeroes(int[] nums)
        {
            int slow = 0;

            // Переносим все ненулевые элементы в начало
            for (int fast = 0; fast < nums.Length; fast++)
            {
                if (nums[fast] != 0)
                {
                    nums[slow] = nums[fast];
                    slow++;
                }
            }

            // Заполняем остаток нулями
            while (slow < nums.Length)
            {
                nums[slow] = 0;
                slow++;
            }
        }
    }
}