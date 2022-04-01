using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_14번___숫자문자열과_영단어
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int answer = 0;
            string temp = s;

            temp = temp.Replace("zero", "0");
            temp = temp.Replace("one", "1");
            temp = temp.Replace("two", "2");
            temp = temp.Replace("three", "3");
            temp = temp.Replace("four", "4");
            temp = temp.Replace("five", "5");
            temp = temp.Replace("six", "6");
            temp = temp.Replace("seven", "7");
            temp = temp.Replace("eight", "8");
            temp = temp.Replace("nine", "9");

            answer = Convert.ToInt32(temp);

            Console.WriteLine(answer);
        }
    }
}
