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
            int[] lottos = {44,1,0,0,31,25 };
            int[] winNums = {31,10,45,1,6,19 };

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
