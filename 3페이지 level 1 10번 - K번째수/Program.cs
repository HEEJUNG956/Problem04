using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_10번___K번째수
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("배열의 크기 입력하기 ==> ");
            string array1 = Console.ReadLine();
            int array2 = int.Parse(array1);
            int[] array = new int[array2];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(i + 1 + "번째 배열 입력하기 ==> ");
                string array3 = Console.ReadLine();
                int array4 = int.Parse(array3);
                array[i] = array4;
            }

            int[,] commands = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };
           

            int[] answer = new int[commands.GetLength(0)];
            List<int> list = new List<int>(array);

            for(int i = 0; i < commands.GetLength(0); i++)
            {
                int nStart = commands[i, 0];
                int nEnd = commands[i, 1];
                int nIndex = commands[i, 2];
                List<int> listSub = list.Where((x, idx) => idx >= nStart - 1 && idx < nEnd).OrderBy(x => x).ToList();
                answer[i] = listSub[nIndex - 1];
            }

            for(int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine("답 ==> " + answer[i]); 
            }
        }
    }
}
