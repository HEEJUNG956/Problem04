using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_16번___신고결과받기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 확인용
            string[] id_list = { "muzi", "frodo", "apeach", "neo" };
            string[] report= { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            int k = 2;

            int[] answer = new int[id_list.Length];
            int[] receive = new int[id_list.Length];

            report = report.Distinct().ToArray();
            Console.WriteLine("======================report 확인========================");
            for(int i = 0; i < report.Length; i++)
            {
                Console.WriteLine(report[i]);
            }

            for(int i = 0; i < report.Length; i++)
            {
                string report_str = report[i].Split(' ')[1];
                int report_index = Array.IndexOf(id_list, report_str);
                receive[report_index]++;
            }

            for(int i = 0; i < report.Length; i++)
            {
                string report_str = report[i].Split(' ')[1];
                int report_index = Array.IndexOf(id_list, report_str);

                if(receive[report_index] >= k)
                {
                    string send_str = report[i].Split(' ')[0];
                    int send_index = Array.IndexOf(id_list, send_str);
                    answer[send_index]++;
                }
            }
            Console.WriteLine("======================================답=============================");
            for(int i = 0; i < answer.Length; i++)
            {
                Console.WriteLine(answer[i]);
            }


            
        }
        
    }
}
