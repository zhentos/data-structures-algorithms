namespace TrappingRainWater_LeetCode_42;

//    Для каждой позиции i количество воды над ней определяется формулой:

//water[i]=min(maxLeft[i], maxRight[i])−height[i]
//где:
//maxLeft[i] — максимальная высота слева от i(включая i);
//    maxRight[i] — максимальная высота справа от i.
//    Но хранить два массива не обязательно.В варианте с двумя указателями мы поддерживаем:
//    l, r — левый и правый указатели;
//    leftMax, rightMax — максимум, который мы уже видели слева и справа


//Ключевая идея:
//всегда двигаем ту сторону, где текущая высота меньше.Если height[l] < height[r], значит уровень воды слева ограничен leftMax,
//потому что справа есть как минимум height[r] ≥ height[l], и «узкое место» — слева.Поэтому:

//если height[l] < leftMax, то над этой колонкой можно налить leftMax - height[l] воды;

//иначе обновляем leftMax = height[l].
//Потом двигаем l++.
//С правой стороной делаем симметрично
class Program
{

    static void Main(string[] args)
    {
        var numbers = new List<int> { 1, 2, 3 };

        var query = numbers.Where(x => {
            Console.WriteLine("filtering");
            return x > 1;
        });

        foreach (var item in query)
        {
            Console.WriteLine(item);
        }

        //int[] input = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1];
        //Trap(input);
    }

    //Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
    //Output: 6
    public static int Trap(int[] height)
    {
        int n = height.Length;
        if (n == 0) return 0;

        int left = 0;
        int right = n - 1;
        int leftMax = 0;
        int rightMax = 0;
        int water = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                {
                    leftMax = height[left];
                }
                else
                {
                    water += leftMax - height[left];
                }
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    water += rightMax - height[right];
                }
                right--;
            }
        }

        return water;
    }
}