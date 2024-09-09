using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_algoritms
{
    internal class I_task
    {
        static string[] week = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        static Dictionary<string, int> monthMap = new Dictionary<string, int>()
    {
        {"january", 1},
        {"february", 2},
        {"march", 3},
        {"april", 4},
        {"may", 5},
        {"june", 6},
        {"july", 7},
        {"august", 8},
        {"september", 9},
        {"october", 10},
        {"november", 11},
        {"december", 12}
    };


        public static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int countDayOfYear = (CheckYear(year)) ? 366 : 365;
            Dictionary<string, int> dictHelp = Help();
            Dictionary<string, int> dictHolidays = Help();
            string[] arrayHoliday = new string[n];
            for (int i = n - 1; i >= 0; i--)
            {
                arrayHoliday[i] = Console.ReadLine();
            }
            string day_of_weak = Console.ReadLine();
            if (countDayOfYear == 365)
            {
                for (int i = 0; i < week.Length; i++)
                {
                    dictHelp[week[i]] = 52;
                }
                dictHelp[day_of_weak]++;
            }
            else if (countDayOfYear == 366)
            {
                for (int i = 0; i < week.Length; i++)
                {
                    dictHelp[week[i]] = 52;
                }
                dictHelp[day_of_weak]++;
                string helpss = "";
                switch (day_of_weak)
                {
                    case "Monday":
                        helpss = "Tuesday";
                        break;
                    case "Tuesday":
                        helpss = "Wednesday";
                        break;
                    case "Wednesday":
                        helpss = "Thursday";
                        break;
                    case "Thursday":
                        helpss = "Friday";
                        break;
                    case "Friday":
                        helpss = "Saturday";
                        break;
                    case "Saturday":
                        helpss = "Sunday";
                        break;
                    case "Sunday":
                        helpss = "Monday";
                        break;
                }
                dictHelp[helpss]++;

            }
            for (int i = 0; i < n; i++)
            {
                dictHolidays[DayOfWeek(day_of_weak, Convert.ToInt32(arrayHoliday[i].Split()[0]), arrayHoliday[i].Split()[1], year)]++;
            }
            string bestResult = "";
            string badResult = "";
            int maxs = -1000;
            int mins = 40000;
            int r = 0;
            for (int i = 0; i < dictHelp.Count; i++)
            {
                r = 0;
                r = dictHelp[week[i]];

                for (int j = 0; j < dictHelp.Count; j++)
                {
                    if (i == j && j != dictHelp.Count - 1) j++;
                    if (i == dictHelp.Count - 1 && i == j) continue;
                    r += dictHolidays[week[j]];
                }
                if (r > maxs)
                {
                    maxs = r;
                    bestResult = week[i];
                }
                if (r < mins)
                {
                    mins = r;
                    badResult = week[i];
                }

            }

            Console.WriteLine("{0} {1}", bestResult, badResult);



        }
        public static Dictionary<string, int> Help()
        {
            Dictionary<string, int> dictHelp = new Dictionary<string, int>();
            dictHelp.Add("Monday", 0);
            dictHelp.Add("Tuesday", 0);
            dictHelp.Add("Wednesday", 0);
            dictHelp.Add("Thursday", 0);
            dictHelp.Add("Friday", 0);
            dictHelp.Add("Saturday", 0);
            dictHelp.Add("Sunday", 0);
            return dictHelp;
        }
        public static bool CheckYear(int year)
        {
            return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
        }


        static string DayOfWeek(string N, int day, string month, int year)
        {

            int numericMonth = monthMap[month.ToLower()];
            Dictionary<int, int> visokos = new Dictionary<int, int>();
            visokos.Add(1, 0);
            visokos.Add(2, 3);
            visokos.Add(3, 4);
            visokos.Add(4, 0);
            visokos.Add(5, 2);
            visokos.Add(6, 5);
            visokos.Add(7, 0);
            visokos.Add(8, 3);
            visokos.Add(9, 6);
            visokos.Add(10, 1);
            visokos.Add(11, 4);
            visokos.Add(12, 6);
            Dictionary<int, int> noVisokos = new Dictionary<int, int>();
            noVisokos.Add(1, 1);
            noVisokos.Add(2, 4);
            noVisokos.Add(3, 4);
            noVisokos.Add(4, 0);
            noVisokos.Add(5, 2);
            noVisokos.Add(6, 5);
            noVisokos.Add(7, 0);
            noVisokos.Add(8, 3);
            noVisokos.Add(9, 6);
            noVisokos.Add(10, 1);
            noVisokos.Add(11, 4);
            noVisokos.Add(12, 6);

            double dayOfWeeks = day;
            double codeOfMonth = CheckYear(year) ? visokos[numericMonth] : noVisokos[numericMonth];
            double help1 = 0;
            double codeOfYear = 0;
            if (year >= 1800 && year <= 1899)
            {
                help1 = year % 100;
                codeOfYear = Math.Floor((2 + help1 + (help1 / 4)) % 7);
            }
            else if (year >= 1900 && year <= 1999)
            {
                help1 = year % 100;
                codeOfYear = Math.Floor((0 + help1 + (help1 / 4)) % 7);
            }
            else if (year >= 2000 && year <= 2099)
            {
                help1 = year % 100;
                codeOfYear = Math.Floor((6 + help1 + (help1 / 4)) % 7);
            }
            else if (year >= 2100 && year <= 2199)
            {
                help1 = year % 100;
                codeOfYear = Math.Floor((4 + help1 + (help1 / 4)) % 7);
            }
            double dayOfWeek = (dayOfWeeks + codeOfMonth + codeOfYear) % 7;
            string result = "";
            switch (dayOfWeek)
            {
                case 0:
                    result = "Saturday";
                    break;
                case 1:
                    result = "Sunday";
                    break;
                case 2:
                    result = "Monday";
                    break;
                case 3:
                    result = "Tuesday";
                    break;
                case 4:
                    result = "Wednesday";
                    break;
                case 5:
                    result = "Thursday";
                    break;
                case 6:
                    result = "Friday";
                    break;


            }
            return result;
        }
    }
}
