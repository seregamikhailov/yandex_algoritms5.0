using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_algoritms
{
    internal class F1_task
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] numbers = Console.ReadLine().Split(' ');
            int sum1 = Math.Abs(int.Parse(numbers[0])) % 2;
            char sum = (char)(sum1 + '0');
            for (int i = 1; i < n; i++)
            {

                if ((numbers[i].Last() == '1' || numbers[i].Last() == '3' || numbers[i].Last() == '5' || numbers[i].Last() == '7' || numbers[i].Last() == '9') && sum == '1')
                {
                    sum = '1';
                    Console.Write("x");
                }

                else if ((numbers[i].Last() == '0' || numbers[i].Last() == '2' || numbers[i].Last() == '4' || numbers[i].Last() == '8' || numbers[i].Last() == '6') && sum == '0')
                {
                    sum = '0';
                    Console.Write("+");
                }
                else
                {
                    sum = '1';
                    Console.Write("+");
                }
            }
            Console.WriteLine();
        }
    }
}
