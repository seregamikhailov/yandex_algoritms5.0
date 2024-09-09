using System;
using System.Collections;
using System.Diagnostics.Eventing.Reader;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Hashtable hashtable = new Hashtable();
        foreach (int num in arr)
        {
            if (!hashtable.ContainsKey(num))
            {
                hashtable[num] = 1;
            }
            else
            {
                hashtable[num] = (int)hashtable[num] + 1;
            }

        }

        int maxss = int.MinValue;
        int maxss1 = int.MinValue;
        int result = 0;
        bool check = false;
        int help = int.MinValue;
        foreach (int num in hashtable.Keys)
        {
            int maxs = 0;
            int maxs1 = 0;
            if (hashtable.ContainsKey(num + 1))
            {
                maxs += (int)hashtable[num + 1];
                maxs += (int)hashtable[num];
                maxss = Math.Max(maxs, maxss);
                check = true;
            }

            if (hashtable.ContainsKey(num - 1))
            {
                maxs1 += (int)hashtable[num - 1];
                maxs1 += (int)hashtable[num];
                maxss1 = Math.Max(maxs1, maxss1);
                check = true;
            }
            int temp =  Math.Max(maxs, maxs1);
            result = Math.Max(result, temp);
            help = Math.Max(help,(int)hashtable[num]);
        }
        if (!check)
        {
            Console.WriteLine(n-help);
        }
        else if (result == 0 || n == 1){
            Console.WriteLine(0);
        }

        else
            Console.WriteLine(n - result);
    }

}

