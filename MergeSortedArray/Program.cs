internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums1 = [1, 2, 3, 0, 0, 0];
        var m = 3;
        int[] nums2 = [2, 5, 6];
        int n = 3;

        Merge(nums1,m,nums2,n);
    }

    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int i = m - 1;          // последний «реальный» элемент в nums1
        int j = n - 1;          // последний элемент в nums2
        int k = m + n - 1;      // позиция, куда сейчас будем писать в nums1

        // пока в nums2 ещё есть элементы
        while (j >= 0)
        {
            // если в nums1 ещё есть элементы И текущий nums1[i] больше nums2[j]
            if (i >= 0 && nums1[i] > nums2[j])
            {
                nums1[k] = nums1[i];
                i--;
            }
            else
            {
                // иначе берём элемент из nums2
                nums1[k] = nums2[j];
                j--;
            }
            k--;
        }
        // остаток nums1 (если i >= 0) уже на своих местах — ничего делать не нужно
    }
}