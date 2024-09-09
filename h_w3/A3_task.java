using System;
using System.Collections.Generic;


class MainClass
{
    public static void Main(string[] args)
    {
        HashSet<string> set = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> dict = new Dictionary<string, int>();
        bool check = false;
        bool check2 = false;
        int maxs = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            check = false;
            int k = int.Parse(Console.ReadLine());
            string[] songs = Console.ReadLine().Split(' ');

            for (int j = 0; j < k; j++)
            {
                if (!dict.ContainsKey(songs[j]))
                {
                    dict[songs[j]] = 1;
                    maxs = Math.Max(maxs, 1);
                    set.Add(songs[j]);
                }
                else
                {
                    dict[songs[j]]++;
                    maxs = Math.Max(maxs, dict[songs[j]]);
                    check = true;
                }

            }
            if (check == false && n != 1 && i!=0)
            {
                i = n;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(0);
                Console.ResetColor();
                check2 = true;
            }

        }
        if ((check != false || n == 1) && maxs == n && !check2)
        {
            int o = 0;
            foreach (KeyValuePair<string, int> pair in dict)
            {
                if (pair.Value == maxs)
                {
                    o++;
                }
            }

            string[] result = new string[o];
            int u = 0;
            foreach (KeyValuePair<string, int> pair in dict)
            {
                if (pair.Value == maxs)
                {
                    result[u++] = pair.Key;
                }
            }
            Array.Sort(result);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(o);
            foreach (string s in result)
            {

                Console.Write(s + " ");
            }
            Console.WriteLine();

        }
        else if (!check2) Console.WriteLine(0);
    }
}