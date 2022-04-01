using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_12번___음양더하기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a1 입력 => ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("a2 입력 => ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("a3 입력 => ");
            int a3 = int.Parse(Console.ReadLine());
            Console.Write("a4 입력 => ");
            int a4 = int.Parse(Console.ReadLine());

            Console.Write("a1의 true false 입력 => ");
            bool t1 = bool.Parse(Console.ReadLine());
            Console.Write("a2의 true false 입력 => ");
            bool t2 = bool.Parse(Console.ReadLine());
            Console.Write("a3의 true false 입력 => ");
            bool t3 = bool.Parse(Console.ReadLine());
            Console.Write("a4의 true false 입력 => ");
            bool t4 = bool.Parse(Console.ReadLine());

            int[] absolutes = {a1,a2,a3,a4 };
            bool[] signs = {t1,t2,t3,t4 };

            int answer = 0;
            int count = absolutes.Length;

            for(int i = 0 ; i < count; i++)
            {
                if(signs[i] == true)
                {
                    answer += absolutes[i];
                }
                else
                {
                    answer -= absolutes[i];
                }
            }
            Console.WriteLine("음양의 합은 => " + answer);
        }
    }
}
