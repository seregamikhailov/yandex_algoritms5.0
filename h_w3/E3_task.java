using System;
using System.Collections.Generic;
using System.Linq;

namespace Lol
{
internal class Program
{

    public static void Main(string[] args)
    {
        HashSet<int> result = new HashSet<int>();
        HashSet<int> m13 = new HashSet<int>();
        HashSet<int> m12 = new HashSet<int>();
        HashSet<int> m23 = new HashSet<int>();
        HashSet<int> m1 = new HashSet<int>();
        HashSet<int> m2 = new HashSet<int>();
        HashSet<int> m3 = new HashSet<int>();
        int r1 = int.Parse(Console.ReadLine());
        string[] s1 = Console.ReadLine().Split();
        for (int l = 0; l < r1; l++)
        {
            m1.Add(int.Parse(s1[l]));
        }
        int r2 = int.Parse(Console.ReadLine());
        string[] s2 = Console.ReadLine().Split();
        for (int l = 0; l < r2; l++)
        {
            m2.Add(int.Parse(s2[l]));
        }
        int r3 = int.Parse(Console.ReadLine());
        string[] s3 = Console.ReadLine().Split();
        for (int l = 0; l < r3; l++)
        {
            m3.Add(int.Parse(s3[l]));
        }
        if (m1.Count > m2.Count)
        {
            foreach(int i in m2)
            {
                if (m1.Contains(i))
                {
                    m12.Add(i);
                }
            }
        }
        else
        {
            foreach (int i in m1)
            {
                if (m2.Contains(i))
                {
                    m12.Add(i);
                }
            }
        }
        if (m2.Count > m3.Count)
        {
            foreach (int i in m3)
            {
                if (m2.Contains(i))
                {
                    m23.Add(i);
                }
            }
        }
        else
        {
            foreach (int i in m2)
            {
                if (m3.Contains(i))
                {
                    m23.Add(i);
                }
            }
        }
        if (m1.Count > m3.Count)
        {
            foreach (int i in m3)
            {
                if (m1.Contains(i))
                {
                    m13.Add(i);
                }
            }
        }
        else
        {
            foreach (int i in m1)
            {
                if (m3.Contains(i))
                {
                    m13.Add(i);
                }
            }
        }
        foreach(int i in m12)
        {
            result.Add(i);
        }
        foreach (int i in m13)
        {
            result.Add(i);
        }
        foreach (int i in m23)
        {
            result.Add(i);
        }
        int[] r = result.ToArray();
        Array.Sort(r);
        foreach(int i in r)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
}
