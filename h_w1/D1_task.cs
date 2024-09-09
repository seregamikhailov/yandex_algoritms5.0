using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_algoritms
{
    internal class D1_task
    {
        static void Main(string[] args)
        {
            char[,] chars = new char[8, 8];
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                char[] chars1 = (Console.ReadLine().Trim()).ToCharArray();
                for (int j = 0; j < chars1.Length; j++)
                {
                    chars[i, j] = chars1[j];
                }
            }

            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    if (chars[i, j] == '*')
                    {
                        chars[i, j] = '0';
                    }
                    if (chars[i, j] == 'B')
                    {
                        chars[i, j] = '2';

                    }
                    if (chars[i, j] == 'R')
                    {
                        chars[i, j] = '3';
                    }

                }
            }

            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    if (chars[i, j] == '2')
                    {
                        Bgiad1RightHigh(i, j, chars);
                        Bgiad2LeftLow(i, j, chars);
                        Bgiad3RightLow(i, j, chars);
                        Bgiad4LeftHigh(i, j, chars);
                    }
                    if (chars[i, j] == '3')
                    {
                        RHorizontalRight(i, j, chars);
                        RHorizontalLeft(i, j, chars);
                        RVerticalHigh(i, j, chars);
                        RVerticalLow(i, j, chars);
                    }
                }

            }
            int sums = 0;
            for (int i = 0; i < chars.GetLength(0); i++)
            {
                for (int j = 0; j < chars.GetLength(1); j++)
                {
                    if (chars[i, j] == '0') sums++;
                }

            }
            Console.WriteLine(sums);
        }
        public static void Bgiad1RightHigh(int i, int j, char[,] chars)
        {
            while (j < 7 && i > 0)
            {
                if (chars[i - 1, j + 1] == '2' || chars[i - 1, j + 1] == '3') break;
                chars[i - 1, j + 1] = '1';
                j++;
                i--;
            }
        }
        public static void Bgiad2LeftLow(int i, int j, char[,] chars)
        {

            while (i < 7 && j > 0)
            {
                if (chars[i + 1, j - 1] == '2' || chars[i + 1, j - 1] == '3') break;
                chars[i + 1, j - 1] = '1';
                j--;
                i++;
            }
        }
        public static void Bgiad3RightLow(int i, int j, char[,] chars)
        {

            while (j < 7 && i < 7)
            {
                if (chars[i + 1, j + 1] == '2' || chars[i + 1, j + 1] == '3') break;
                chars[i + 1, j + 1] = '1';
                j++;
                i++;
            }
        }
        public static void Bgiad4LeftHigh(int i, int j, char[,] chars)
        {
            while (i > 0 && j > 0)
            {
                if (chars[i - 1, j - 1] == '2' || chars[i - 1, j - 1] == '3') break;
                chars[i - 1, j - 1] = '1';
                j--;
                i--;
            }

        }
        public static void RHorizontalRight(int i, int j, char[,] chars)
        {
            while (j < 7)
            {
                if (chars[i, j + 1] == '2' || chars[i, j + 1] == '3') break;
                chars[i, j + 1] = '1';
                j++;
            }
        }
        public static void RHorizontalLeft(int i, int j, char[,] chars)
        {
            while (j > 0)
            {
                if (chars[i, j - 1] == '2' || chars[i, j - 1] == '3') break;
                chars[i, j - 1] = '1';
                j--;
            }
        }
        public static void RVerticalHigh(int i, int j, char[,] chars)
        {
            while (i > 0)
            {
                if (chars[i - 1, j] == '2' || chars[i - 1, j] == '3') break;
                chars[i - 1, j] = '1';
                i--;
            }
        }
        public static void RVerticalLow(int i, int j, char[,] chars)
        {
            while (i < 7)
            {
                if (chars[i + 1, j] == '2' || chars[i + 1, j] == '3') break;
                chars[i + 1, j] = '1';
                i++;
            }
        }
    }
}
