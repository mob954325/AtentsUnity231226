using System;
using System.Collections.Generic;
using System.Text;

namespace w1_231226
{
    internal class testStatic
    {
        // static : 정적이라는 의미, 프로그램이 실행되기 전에 메모리에 위치가 확정되어있다.
        public static int i = 0; // 인스턴스화 하지 안항도 접근 할 수 있다.


        public void test1()
        {
            Console.WriteLine("테스트1");
        }

        public static void test2()
        {
            Console.WriteLine("테스트2");
            i = 250;
            //int a = 2; 
        }
    }
}
