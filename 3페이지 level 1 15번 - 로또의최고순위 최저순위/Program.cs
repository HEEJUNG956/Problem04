using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_15번___로또의최고순위_최저순위
{
    class Solution
    {
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
   
            int[] lottos = new int[6];
            for(int i = 0; i < lottos.Length; i++)
            {
                Console.Write(i + 1 + "번째 로또 번호 입력하기 ==> ");
                string lottos1 = Console.ReadLine();
                int lottos2 = int.Parse(lottos1);
                lottos[i] = lottos2;
            }

            
            int[] winNums = new int[6];
            for(int i = 0; i < winNums.Length; i++)
            {
                Console.Write(i + 1 + "번째 구입한 로또 번호 입력하기 ==> ");
                string winNums1 = Console.ReadLine();
                int winNums2 = int.Parse(winNums1);
                winNums[i] = winNums2;
            }

            int win = lottos.Intersect(winNums).Count();
            int lose = lottos.Where(number => number != 0).Count();

            int[] answer = new int[] { WinToRank(6 - lose), WinToRank(win) };
            Console.WriteLine(answer);
        }

        private static int WinToRank(int count)
        {
            if (count <= 1)
                return 6;

            return 7 - count;
        }

        
    }
}
