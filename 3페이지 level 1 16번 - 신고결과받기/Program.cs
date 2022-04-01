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
            string[] id_list = { "muzi", "frodo", "apeach", "neo" };
            string[] report= { "muzi frodo", "apeach frodo", "frodo neo", "muzi neo", "apeach muzi" };
            int k = 2;

            Solution(id_list, report, k);
            
        }
        private static int[] Solution(string[] id_list, string[] report, int k)
        {
            List<string> reportList = report.ToList().Distinct().ToList();
            Dictionary<string, int> reportCountLog = new Dictionary<string, int>();
            Dictionary<string, List<string>> reportLog = new Dictionary<string, List<string>>();
            Dictionary<string, int> result = new Dictionary<string, int>();

            foreach (string id in id_list)
            {
                reportCountLog[id] = 0;
                reportLog[id] = new List<string>();
                result[id] = 0;
            }

            foreach (string reportItem in reportList)
            {
                var split = reportItem.Split(' ');
                ++reportCountLog[split[1]];
                reportLog[split[0]].Add(split[1]);
            }

            foreach (var countLog in reportCountLog.Where((e) => e.Value >= k))
            {
                foreach (var log in reportLog)
                {
                    if (log.Value.Contains(countLog.Key))
                    {
                        ++result[log.Key];
                    }
                }
            }
            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result.Values.ToArray());
            }

            return result.Values.ToArray();
        }
    }
}
