using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_algoritms
{
    internal class C1_task
    {
        static void Main(string[] args)
        {
            decimal kol = int.Parse(Console.ReadLine());
            decimal res = 0;
            for (int i = 0; i < kol; i++)
            {
                decimal space = decimal.Parse(Console.ReadLine());
                decimal ostatokspace = Math.Floor(space / 4);
                if (space % 4 == 0)
                {
                    res += ostatokspace;
                }
                else if (space % 4 == 1)
                {
                    res += ostatokspace + 1;
                }
                else if (space % 4 == 2)
                {
                    res += ostatokspace + 2;
                }
                else if (space % 4 == 3)
                {
                    res += ostatokspace + 2;
                }
            }
            Console.WriteLine(res);

        }
    }
}
