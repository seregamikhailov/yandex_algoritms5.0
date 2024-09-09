using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yandex_algoritms
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] game1 = Console.ReadLine().Split(':');
            int scoreGame1Team1 = int.Parse(game1[0]);
            int scoreGame1Team2 = int.Parse(game1[1]);
            string[] game2 = Console.ReadLine().Split(':');
            int scoreGame2Team1 = int.Parse(game2[0]);
            int scoreGame2Team2 = int.Parse(game2[1]);
            int flag = int.Parse(Console.ReadLine());
            Console.WriteLine(Win(scoreGame1Team1, scoreGame1Team2, scoreGame2Team1, scoreGame2Team2, flag));


        }
        static public int Win(int scoreGame1Team1, int scoreGame1Team2, int scoreGame2Team1, int scoreGame2Team2, int flag)
        {
            int resultTeam1 = scoreGame1Team1 + scoreGame2Team1;
            int resultTeam2 = scoreGame1Team2 + scoreGame2Team2;
            int result = scoreGame2Team2 + scoreGame1Team2 - (scoreGame1Team1 + scoreGame2Team1);

            if (resultTeam2 >= resultTeam1)
            {
                if (flag == 1)
                {
                    if (scoreGame1Team2 >= result + scoreGame2Team1)
                    {
                        return scoreGame2Team2 + scoreGame1Team2 - (scoreGame1Team1 + scoreGame2Team1) + 1;
                    }
                    else
                    {
                        return scoreGame2Team2 + scoreGame1Team2 - (scoreGame1Team1 + scoreGame2Team1);
                    }
                }
                else
                {
                    if (scoreGame1Team1 <= scoreGame2Team2)
                    {
                        return scoreGame2Team2 + scoreGame1Team2 - (scoreGame1Team1 + scoreGame2Team1) + 1;
                    }
                    else
                    {
                        return scoreGame2Team2 + scoreGame1Team2 - (scoreGame1Team1 + scoreGame2Team1);
                    }
                }
            }
            else
            {
                return 0;
            }

        }
    }

}
