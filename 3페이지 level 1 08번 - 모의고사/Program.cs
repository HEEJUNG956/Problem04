using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_08번___모의고사
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문제의 답배열 입력하기 =>");
            string answer1 = Console.ReadLine();
            int answer2 = Convert.ToInt32(answer1);
            int[] answers = new int[answer2];
            for(int i = 0; i < answer2; i++)
            {
                Console.Write(i + 1 + "번째 답 입력하기 => ");
                string answer3 = Console.ReadLine();
                int answer4 = Convert.ToInt32(answer3);
                answers[i] = answer4;
            }

            int[] student1 = new int[] { 1, 2, 3, 4, 5 };
            int[] student2 = new int[] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] student3 = new int[] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };
            int[] temp = new int[3];

            for(int i = 0; i < answers.Length; i++)
            {
                if (answers[i] == student1[i % student1.Length]) ++temp[0];
                if (answers[i] == student2[i % student2.Length]) ++temp[1];
                if (answers[i] == student3[i % student3.Length]) ++temp[2];
            }

            List<int> answer = new List<int>();
            if(temp[0] == temp.Max()) answer.Add(1);
            if(temp[1] == temp.Min()) answer.Add(2);
            if(temp[2] == temp.Max()) answer.Add(3);

            
        }
    }
}
