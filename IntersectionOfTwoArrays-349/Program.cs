internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        var result = new List<int>();

        var set = new HashSet<int>(nums1);

        foreach (var item in nums2)
        {
            if (set.Contains(item))
            {
                result.Add(item);
                set.Remove(item);
            }
        }

        return [.. result];
    }
}