using System;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        Dictionary<char,int> help = new Dictionary<char, int> ();
        Dictionary<char, int> help1 = new Dictionary<char, int>();
        char[] first = Console.ReadLine().ToCharArray();
        char[] second = Console.ReadLine().ToCharArray();
        bool result = false;
        if (first.Length != second.Length)
        {
            Console.WriteLine("NO");
        }

        else
        {
            Array.Sort(first);
            Array.Sort(second);
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    Console.WriteLine("NO");
                    result = true;
                    break;
                }
            }
            if (result!= true)
            {
                Console.WriteLine("YES");
            }
        }
    }
}