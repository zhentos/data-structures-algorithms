internal class Program
{
    private static void Main(string[] args)
    {
        var nums = [1, 2, 3];
        var result = Permute(nums);
    }

    public static IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();
        var current = new List<int>();
        var used = new bool[nums.Length];

        void Backtrack()
        {
            // Собрали одну полную перестановку
            if (current.Count == nums.Length)
            {
                result.Add(new List<int>(current));
                return;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                // Одно и то же число нельзя взять дважды
                if (used[i])
                    continue;

                // Выбираем nums[i]
                used[i] = true;
                current.Add(nums[i]);

                Backtrack();

                // Отменяем выбор и пробуем следующий вариант
                current.RemoveAt(current.Count - 1);
                used[i] = false;
            }
        }

        Backtrack();
        return result;
    }
}