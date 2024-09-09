using System;
using System.IO;

namespace SortLines
{

internal class Mikhailov
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] nums = new long[n];
        string[] r = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {
            nums[i] = long.Parse(r[i]);
        }
        Array.Sort(nums);
        int k = int.Parse(Console.ReadLine());

        int[] result = new int[k];
        for (int i = 0; i < k; i++)
        {
            string[] query = Console.ReadLine().Split();
            int L = int.Parse(query[0]);
            int R = int.Parse(query[1]);
            int count = Count(nums, L, R);
            result[i] = count;
        }

        foreach(int i in result)
        {
            Console.Write(i + " ");
        }

        Console.WriteLine();
    }


    public static int Count(long[] nums, int L, int R)
    {
        int leftIndex = BSL(nums, L);
        int rightIndex = BSR(nums, R);
        return rightIndex - leftIndex + 1;
    }

    public static int BSL(long[] nums, int L)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] < L)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return left;
    }

    public static int BSR(long[] nums, int R)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] <= R)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return right;
    }
}
}
