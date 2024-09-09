using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_algoritms
{
    class A1_task
    {
        static void Main(string[] args)
        {

            string[] input1 = Console.ReadLine().Split();
            int p = int.Parse(input1[0]);
            int v = int.Parse(input1[1]);
            string[] input2 = Console.ReadLine().Split();
            int q = int.Parse(input2[0]);
            int m = int.Parse(input2[1]);

            int res = CountPaintedTrees(p, v, q, m);
            Console.WriteLine(res);
        }

        static int CountPaintedTrees(int p, int v, int q, int m)
        {
            int min1 = p - v;
            int max1 = p + v;
            int min2 = q - m;
            int max2 = q + m;

            int result = (max1 - min1 + 1) + (max2 - min2 + 1) - Math.Max(0, Math.Min(max1, max2) - Math.Max(min1, min2) + 1);
            return result;
        }
    }

}
