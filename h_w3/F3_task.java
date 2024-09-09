using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();
        string[] input = Console.ReadLine().Split(' ');
        foreach(string s in input)
        {
            set.Add(s);
        }
        string[] LLL = Console.ReadLine().Split(' ');
        foreach(string s in LLL)
        {
            for (int i = 0; i< s.Length; i++)
            {
                string prefix = s.Substring(0, i);
                if (set.Contains(Convert.ToString(prefix)))
                {
                    Console.Write(prefix + " ");
                    break;
                }
                else if (s.Length - 1 == i)
                {
                    Console.Write(s+ " ");
                    break;
                }
            }
        }
        Console.WriteLine();
    }
}
