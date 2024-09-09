using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_algoritms
{
    internal class G1_task
    {
        static void Main(string[] args)
        {
            int xMyArmy = int.Parse(Console.ReadLine());
            int yHealthCastle = int.Parse(Console.ReadLine());
            int pGenerateEnemyArmy = int.Parse(Console.ReadLine());
            Help(xMyArmy, yHealthCastle, pGenerateEnemyArmy);

        }

        public static bool CalculateMinCountRounds(int xMyArmy, int yHealthCastle, int enemies, ref int count)
        {
            while (yHealthCastle != 0 && xMyArmy > 0)
            {
                if (yHealthCastle > xMyArmy)
                {
                    yHealthCastle -= xMyArmy;
                    xMyArmy -= enemies;
                }
                else
                {
                    enemies -= (xMyArmy - yHealthCastle);
                    yHealthCastle = 0;
                    xMyArmy -= enemies;
                }

                count += 1;

                if (yHealthCastle > 0)
                {
                    enemies += enemies;
                }
            }

            if (yHealthCastle == 0)
            {
                while (enemies > 0 && xMyArmy > 0)
                {

                    enemies -= xMyArmy;
                    if (enemies > 0)
                    {
                        xMyArmy -= enemies;
                    }
                    count += 1;
                }
                return xMyArmy > 0;
            }
            else
            {
                return false;
            }
        }
        public static void Help(int xMyArmy, int yHealthCastle, int pGenerateEnemyArmy)
        {
            int count1 = -1;
            int help = 1;

            if (xMyArmy >= yHealthCastle)
            {
                Console.WriteLine(help);
                return;
            }

            yHealthCastle -= xMyArmy;

            int enemies = pGenerateEnemyArmy;

            while (yHealthCastle > 0 && xMyArmy > 0)
            {
                int count = help;

                if (CalculateMinCountRounds(xMyArmy, yHealthCastle, enemies, ref count))
                {
                    if (count1 == -1 || count1 > count)
                    {
                        count1 = count;
                    }
                    if (enemies == xMyArmy)
                    {
                        Console.WriteLine(count1);
                        return;
                    }
                }
                else if (enemies == xMyArmy)
                {
                    Console.WriteLine(-1);
                    return;
                }

                if (enemies > xMyArmy)
                {
                    enemies -= xMyArmy;
                    xMyArmy -= enemies;
                }
                else
                {
                    yHealthCastle -= (xMyArmy - enemies);
                    enemies = 0;
                }

                if (yHealthCastle > 0)
                {
                    enemies += pGenerateEnemyArmy;
                }
                help += 1;
            }

            Console.WriteLine(count1);
        }
    }
}
