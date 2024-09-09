using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_algoritms
{
    internal class E1_task
    {
        static void Main(string[] args)
        {
            string[] inputHelp = (Console.ReadLine().Split(' '));
            uint[] input = Array.ConvertAll(inputHelp, uint.Parse);
            uint k = input[1];
            uint n = input[0];
            uint d = input[2];
            string s = Convert.ToString(n);
            uint col = d;
            bool flagNul = false;
            bool flagDelit = false;
            bool flagDelit2 = false;
            for (int i = 0; i < d; i++)
            {
                if (flagDelit2 == false)
                {
                    if (flagNul == false)
                    {
                        flagDelit = false;
                        for (int j = 0; j < 10; j++)
                        {
                            if (Convert.ToUInt64(s + Convert.ToString(j)) % k == 0 && j == 0)
                            {
                                s = s + Convert.ToString(j);
                                flagNul = true;
                                flagDelit = true;
                                break;
                            }
                            else if (Convert.ToUInt64(s + Convert.ToString(j)) % k == 0 && j != 0)
                            {
                                s = s + Convert.ToString(j);
                                flagDelit = true;
                                break;
                            }
                            if (j == 9 && flagDelit == false)
                            {
                                s = "-1";
                                flagDelit2 = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
                col--;
            }
            if (s != "-1")
            {
                if (flagNul == true)
                {
                    Console.Write(s);
                    for (int i = 0; i < col; i++)
                    {
                        Console.Write(Convert.ToString(0));
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(s);
                }
            }
            else
            {
                Console.WriteLine(s);
            }
        }
    }
}
