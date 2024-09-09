using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        List<List<int>> result = new List<List<int>>();
        for (int i = 0; i < t; i++)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> help = new List<int>();
            List<int> numsArray = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int minNum = numsArray[0];
            int p = 0;
            help.Add(1);
            for (int j = 1; j < n; j++)
            {
                minNum = Math.Min(minNum, numsArray[j]);
                if (help[p] + 1 > minNum)
                {
                    help.Add(1);
                    p++;
                    minNum = numsArray[j];
                }
                else
                    help[p]++;
            }
            result.Add(help);
        }
        foreach (List<int> list in result)
        {
            Console.WriteLine(list.Count);
            foreach (int num in list) Console.Write(num + " ");
            Console.WriteLine();
        }
    }
}
