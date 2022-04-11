using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_09번___소수만들기
{

    internal class Program
    {
        static bool IsPrime(int num)
        {
            int temp = (int)Math.Sqrt(num);
            for (int i = 2; i <= temp; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }


        static void Main(string[] args)
        {
            Console.Write("주어질 배열의 크기 입력하기 => ");
            string nums1 = Console.ReadLine();
            int num2 = int.Parse(nums1);
            int[] nums = new int[num2];
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write(i + 1 + "번째 배열 입력하기 => ");
                string num3 = Console.ReadLine();
                int num4 = int.Parse(num3);
                nums[i] = num4;
            }

            int answer = 0;
            for(int i = 0; i < nums.Length - 2; i++)
            {
                for(int j = i + 1; j < nums.Length - 1; j++)
                {
                    for(int k = j + 1; k < nums.Length; k++)
                    {
                        if(IsPrime(nums[i] + nums[j] + nums[k]))
                        {
                            answer++;
                        }
                    }
                }
            }
            Console.WriteLine(answer);
        }
    }
}
