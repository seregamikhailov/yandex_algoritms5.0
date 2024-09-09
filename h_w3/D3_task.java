using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split();
        int n = int.Parse(input1[0]);
        int k = int.Parse(input1[1]);
        string[] input2 = Console.ReadLine().Split();
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(input2[i]);
        }

        Console.WriteLine(ContainsRepeatedNumber(numbers, k) ? "YES" : "NO");
    }

    static bool ContainsRepeatedNumber(int[] numbers, int k)
    {
        Dictionary<int, int> kNum = new Dictionary<int, int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (kNum.ContainsKey(numbers[i]) && i - kNum[numbers[i]] <= k)
                return true;

            kNum[numbers[i]] = i;
        }
        return false;
    }
}
