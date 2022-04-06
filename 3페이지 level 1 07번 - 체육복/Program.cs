using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3페이지_level_1_07번___체육복
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                Console.Write("전체 학생 수 입력 => ");
                int n = int.Parse(Console.ReadLine()); // 전체 학생의 수
                Console.Write("체육복을 도난당한 학생들의 번호가 담긴 배열 크기 입력 => ");
                string lost1 = Console.ReadLine();
                int lost2 = Convert.ToInt32(lost1);
                int[] lost = new int[lost2]; //체육복을 도난당한 학생들의 번호가 담긴 배열
                for (int i = 0; i < lost2; i++)
                {
                    Console.Write(i + "번째 학생 번호 입력 => ");
                    String lost3 = Console.ReadLine();
                    int lost4 = Convert.ToInt32(lost3);
                    lost[i] = lost4;
                }
                Console.Write("여벌의 체육복을 가져온 학생들의 번호가 담긴 배열 크기 입력 => ");
                string reserve1 = Console.ReadLine();
                int reserve2 = Convert.ToInt32(reserve1);
                int[] reserve = new int[reserve2]; // 여벌의 체육복을 가져온 학생들의 번호가 담긴 배열
                for (int i = 0; i < reserve2; i++)
                {
                    Console.Write(i + "번째 학생 번호 입력 => ");
                    String reserve3 = Console.ReadLine();
                    int reserve4 = Convert.ToInt32(reserve3);
                    reserve[i] = reserve4;
                }

                int answer = 0;

                for (int i = 1; i <= n; i++)
                {
                    if (lost.Contains(i))
                    {
                        if (reserve.Contains(i - 1) && !lost.Contains(i - 1))
                        {
                            reserve = reserve.Where(value => value != i - 1).ToArray();
                            answer++;
                        }
                        else if (reserve.Contains(i))
                        {
                            reserve = reserve.Where(value => value != i).ToArray();
                            answer++;
                        }
                        else if (reserve.Contains(i + 1) && !lost.Contains(i + 1))
                        {
                            reserve = reserve.Where(value => value != i + 1).ToArray();
                            answer++;
                        }
                    }
                    else
                    {
                        answer++;
                    } 
                }
                Console.WriteLine("수업을 들을 수 있는 학생의 수는 " + answer + "명입니다.");

                Console.Write("계속하시겠습니까? (Y/N) => ");
                String temp = Console.ReadLine();
                if (temp == "Y")
                {
                    continue;
                }
                else if(temp == "N")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                }

                /* int[] Person = new int[n];

                 for(int i = 0; i < n; i++)
                 {
                     Person[i] = 1;
                 }

                 for(int i = 0; i < lost.Length; i++)
                 {
                     --Person[lost[i] - 1];
                 }

                 for(int i = 0; i < reserve.Length; i++)
                 {
                     ++Person[reserve[i] - 1];
                 }

                 for(int i = 0; i <Person.Length - 1; i++)
                 {
                     if(Math.Abs(Person[i] - Person[i + 1]) == 2)
                     {
                         Person[i] = 1;
                         Person[i + 1] = 1;
                     }
                 }

                 int count = 0;
                 for(int i = 0; i < Person.Length; i++)
                 {
                     if(Person[i] == 0)
                     {
                         count++;
                     }
                 }
                 int answer = Person.Length - count;
                 Console.WriteLine("체육 수업을 들을 수 있는 학생의 최대 수 => " + answer );*/
            }
        }
    }
}
