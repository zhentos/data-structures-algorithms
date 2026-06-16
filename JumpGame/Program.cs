internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = [1, 2, 3, 4];
        var result = ProductExceptSelf(nums);

        Console.WriteLine(result);
    }

    private static bool CanJump(int[] nums)
    {
        int maxReach = 0; // самый дальний индекс, который можем достигнуть сейчас

        for (int i = 0; i < nums.Length; i++)
        {
            // если мы стоим на индексе, который вообще недостижим
            if (i > maxReach)
            {
                return false;
            }

            // обновляем максимально достижимый индекс
            int reachFromHere = i + nums[i];
            if (reachFromHere > maxReach)
            {
                maxReach = reachFromHere;
            }
        }

        // если цикл не вернул false, до последнего индекса можно дойти
        return true;
    }

    private static int[] ProductExceptSelf(int[] nums)
    {
        int n = nums.Length;
        int[] answer = new int[n];

        int leftProd = 1;
        for (int i = 0; i < n; i++)
        {
            answer[i] = leftProd;      // произведение всех слева от i
            leftProd *= nums[i];
        }

        int rightProd = 1;
        for (int i = n - 1; i >= 0; i--)
        {
            answer[i] *= rightProd;    // домножаем на произведение всех справа от i
            rightProd *= nums[i];
        }

        return answer;
    }
}