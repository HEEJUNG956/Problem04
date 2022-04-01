using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_13번___없는숫자더하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8};
            int answer = 0;

            for(int i = 0; i < 10; i++)
            {
                answer += i;
            }

            foreach(var item in numbers)
            {
                answer -= item;
            }
            Console.WriteLine("없는 숫자를 더한 값은 => " + answer);
        }
    }
}
