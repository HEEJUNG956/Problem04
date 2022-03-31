using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_11번___내적
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a배열의 첫번째숫자 입력 => ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("a배열의 두번째숫자 입력 => ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("a배열의 세번째숫자 입력 => ");
            int a3 = int.Parse(Console.ReadLine());
            Console.Write("a배열의 네번째숫자 입력 => ");
            int a4 = int.Parse(Console.ReadLine());
            Console.Write("b배열의 첫번째숫자 입력 => ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("b배열의 두번째숫자 입력 => ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("b배열의 세번째숫자 입력 => ");
            int b3 = int.Parse(Console.ReadLine());
            Console.Write("b배열의 네번째숫자 입력 => ");
            int b4 = int.Parse(Console.ReadLine());

            int[] a = { a1, a2, a3, a4 };
            int[] b = { b1, b2, b3, b4 };

            int answer = 0;
            for(int i = 0; i < a.Length; i++)
            {
                answer += a[i] * b[i];
            }
            Console.Write("내적의 합은 => ");
            Console.WriteLine(answer);
        }
    }
}
