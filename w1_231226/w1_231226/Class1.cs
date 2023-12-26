using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_231226
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            /*            Console.WriteLine("Hello, World!\n"); // 출력
                        Console.WriteLine("Hello!! \n");

                        Console.WriteLine("라라라라라라랆");*/

            // 변수 (Variable)
            // 메모리에 저장해둔 값

            // 키보드 입력을 한줄 받아서 input이라는 변수에 기록
            /*            string input = Console.ReadLine();
                        Console.WriteLine(input);*/

            // 실습
            // 시작하면 이름을 물어보고 이름을 세번 출력

            Console.WriteLine("문자열을 입력하세요");
            string input = Console.ReadLine();
            
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(i+1 + " : " + input);
            }
        }
    }
}

// 한줄 주석
/* 
 * 여러 줄 주석
 */

/// 자동
/// 주석
