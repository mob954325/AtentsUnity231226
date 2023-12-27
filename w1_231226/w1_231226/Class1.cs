using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_231226
{
    public enum Grade
    {
        A,
        B,
        C,
        D,
        E,
        F
    }

    public enum DayofWeek
    {
        Mon, Tue, Wed, Thu, Fri, Sat, Sun
    }
    internal class Class1
    {
        static int count = 0;

        static void startGame()
        {

            Console.WriteLine("하고싶은 게임을 선택하세요 !! ");
            Console.WriteLine("홀수 짝수 : 1");
            Console.WriteLine("주사위 맞추기 : 2");
            Console.Write("입력 : ");
            string startInput = Console.ReadLine();
            int input = 0;
            int.TryParse(startInput, out input);

            switch(input)
            {
                case 1:
                    Console.WriteLine("홀수 짝수를 선택하셨습니다.");
                    even_odd();
                    break;
                case 2:
                    Console.WriteLine("주사위 맞추기를 선택하셨습니다.");
                    playRoll();
                    break;
                default:
                    Console.WriteLine("숫자를 잘못 입력했습니다.");
                    break;
            }
        }
        static int playerInput()
        {
            Console.Write("수를 입력하세요 1-6 : ");
            string inputNum = Console.ReadLine();
            int num = 0;
            int.TryParse(inputNum, out num);

            return num;
        }

        static void playRoll()
        {
            int dicePlayer = playerInput();
            bool canPlay = true;

            Random r = new Random();
            int dice = r.Next(6) + 1;

            Console.WriteLine($"주사위 값 : {dice}");

            if ((dice > 0 && dice < 4) && (dicePlayer > 0 && dicePlayer < 4))
            {
                Console.WriteLine($"Low");
                count++;
                playRoll();
            }
            else if ((dice > 3 && dice < 7) && (dicePlayer > 3 && dicePlayer < 7))
            {
                Console.WriteLine($"High");
                count++;
                playRoll();
            }
            else if (dicePlayer > 6)
            {
                Console.WriteLine($"숫자를 잘못 입력하셧습니다. \n 게임을 종료합니다.");
                Console.WriteLine($"{count}번 맞추셨습니다. !");
            }
            else
            {
                Console.WriteLine($"틀렸으므로 게임을 종료합니다.");
                Console.WriteLine($"{count}번 맞추셨습니다. !");
            }
        }

        static void even_odd()
        {
            int eoPlayer = playerInput();

            Random r = new Random();
            int enemy = r.Next(6) + 1;

            if ((enemy % 2 == 0) && (eoPlayer % 2 == 0))
            {
                Console.WriteLine($"숫자 : {enemy}");
                Console.WriteLine($"짝수");
                count++;
                even_odd();
            }
            else if((enemy % 2 == 1) && (eoPlayer % 2 == 1))
            {
                Console.WriteLine($"숫자 : {enemy}");
                Console.WriteLine($"홀수");
                count++;
                even_odd();
            }
            else if (eoPlayer > 6)
            {
                Console.WriteLine($"숫자를 잘못 입력하셧습니다. \n 게임을 종료합니다.");
                Console.WriteLine($"{count}번 맞추셨습니다. !");
            }
            else
            {
                Console.WriteLine($"숫자 : {enemy}");
                Console.WriteLine($"틀렸으므로 게임을 종료합니다.");
                Console.WriteLine($"{count}번 맞추셨습니다. !");
            }
        }

        static void Main(string[] args)
        {
            // 실습
            // 주사위 게임 만들기
            // 1. High/Low 만들기
            //  1.1 시작하면 high나 low값을 입력받음
            //  1.2 주사위를 굴려서 1-3이면 low, 4-6 high를 출력
            //  1.3 플레이어의 선택이 맞으면 성공으로 한 후 다시 시작 -> 1.1로 돌아감
            //  1.4 플레이어의 선택이 틀리면 성공횟수 표시하고 종료

            // 2. 홀짝
            // 1. High/Low 만들기
            //  1.1 시작하면 high나 low값을 입력받음
            //  1.2 주사위를 굴려서 1-3이면 low, 4-6 high를 출력
            //  1.3 플레이어의 선택이 맞으면 성공으로 한 후 다시 시작 -> 1.1로 돌아감
            //  1.4 플레이어의 선택이 틀리면 성공횟수 표시하고 종료

            startGame();

            /*Day_231226();*/

            /*inputName();*/

            /*int ixxx; // 인티저 타입 변수 i를 선언
            ixxx = 10; // i에 10을 대입한다. , 대입연산자
            bool b = ixxx == 10; // i와 10이 같다 , 비교연산자 
            // -> i가 10과 같으면 true 아니면 false
            int j;
            j = ixxx + 10; // 20 , 산술연산자

            i > j;
            i >= j;
            i < j;
            i <= j;*/

            /*            float f;
                        f = j + 10; // int형 데이터를 float형 데이터에 넣기 -> 가능
                        //i = f; // float 

                        string str1 = "Hello";
                        string str2 = ", World!";
                        string str3 = str1 + str2; // Hello, World!
                        string str5 = str1 + str2 + str3; // 최악의 경우 -> 쓸대없는 임시공간이 발생

                        string.Format("{0} {1}", str1, str2);
                        string str4 = $"{str1} {str2}";

                        bool b2 = (str1 == "Hello"); // true
                        bool b3 = (str1 == "HellO"); // false 
                        // 문자열간의 비교는 피할 수 있으면 무조건 피하는 것이 이득

                        Console.WriteLine($"{str1} {str2}");*/

            // 제어문 (코드의 흐름을 제어하는 코드)

            // 20미만 -> 미성년자
            // 20이상 -> 성인

            // 조건문(제어문 중의 하나로 특정 조건에 따라 다른 코드를 실행하는 코드)

            /*int age = 15;*/

            /*if(age < 20)
            {
                Console.WriteLine($"{age}살은 미성년입니다\n");
            }

            age = 20;
            if (age >= 20)
                Console.WriteLine($"{age}살은 성인입니다.");*/

            /*if(age < 20)
            {
                Console.WriteLine($"{age}는 미성년입니다.");
            }
            else
            {
                Console.WriteLine($"{age}는 성년입니다.");
            }*/


            /* Console.Write("몇살인가요 : ");
            string inputAge = Console.ReadLine(); // 문자열로 readline 입력받기
            int age = 18;
            // int age = int.Parse(inputAge); // int.Parse를 통해 string타입을 int 타입으로 변경
            int.TryParse(inputAge, out age); // int.TryParse -> 위와 동일하나 예외는 0을 받음

            checkAge(age);

            Console.Write("점수를 입력하세요 : ");
            string inputFloat = Console.ReadLine();
            float score = 0;
            float.TryParse(inputFloat, out score);
            checkScore(score);
            Grade grade = checkGrade(score); // gradeCheck 함수의 결과를 grade에 대입

            Console.WriteLine($"당신의 등급은 {grade}입니다");

            switch (grade) // switch
            {
                case Grade.A:
                    Console.WriteLine("A");
                    break;
                case Grade.B:
                    Console.WriteLine("B");
                    break;
                case Grade.C:
                    Console.WriteLine("C");
                    break;
                case Grade.D:
                    Console.WriteLine("D");
                    break;
                case Grade.F:
                    Console.WriteLine("F");
                    break;
                default:
                    Console.WriteLine("아무 등급도 아닙니다");
                    break;
            } */


            // 반복문(코드를 반복하는 코드)

            /* int temp2 = 0;
             temp2 = temp2 + 1; temp2++;*/

            // for문

            /*Console.Write("수를 입력하세요 : ");
            string inputNum = Console.ReadLine();
            int num = 0;
            int.TryParse(inputNum, out num);

            Gugudan(num);

            Console.Write("수를 입력하세요22 : ");
            string inputNum2 = Console.ReadLine();
            int num2 = 0;
            int.TryParse(inputNum2, out num2);
            pyramid(num2);*/

            /* // while문 ()사이의 조건이 참이면 반복하는 코드
            // while() { }

            int count = 0;

            while(count < 10)
            {
                count++;
            } */

            /* // do-while문() {}

            count = 0;
            do
            {
                count++;
            } while(count < 10);

            // foreach() { } */

            // 대입연산자
            // = : 왼쪽에 있는 변수에 오른쪽에 있는 값을 대입한다.

            // 산술 연산자 , + - * / % ++ -- += -= ...

            // 비교 연산자 == != , 리턴 타입 bool

            // 논리 연산자 || && ^ , 리턴 타입 bool



        }

        // 함수
        // 특정 기능을 수행할수 있는 코드들
        // 구성요소 : 리턴타입, 이름 , 파라미터(매개변수), 함수바디(코드)

        /// <summary>
        /// 리턴타입 : void
        /// 이름 : inputName
        /// 파라미터 : () 내용
        /// 함수바디 : 코드 블록{} 내에 있는 내용
        /// </summary>
        static void inputName()
        {
            Console.WriteLine("inputName 함수 출력 \n");
            Console.WriteLine("당신의 이름을 입력하세요");

            string input = Console.ReadLine();
            Console.WriteLine(input);
        }

        // 실습 함수 만들기
        // 위 코드 수행하는 함수 만들기
        // 함수 이름은  Day_231226
        static void Day_231226()
        {
            Day_231227(); // 드래그 , 리팩토링 함수 만들기
        }

        private static void Day_231227()
        {
            Console.WriteLine("Day_231226 함수 출력 \n");
            Console.WriteLine("Hello, World!\n"); // 출력
            Console.WriteLine("World!\n"); // 출력
            Console.WriteLine("와랄라");
            Console.WriteLine("dfasdfasd");

            // 변수 (Variable)
            // 메모리에 저장해둔 값

            // 키보드 입력을 한줄 받아서 input이라는 변수에 기록
            /*       string input = Console.ReadLine();
                     Console.WriteLine(input);*/



            // 1bit -> 0, 1을 저장
            // 1byte -> 8bit

            // string : 문자열, 글자열을 저장하기 위한 데이터 타입 -> 연속된 메모리에 저장됨
            // int(4byte , 32bit) : 정수형 데이터 타입 -> 소수점 없는 숫자를 저장함 , 2^32개를 저장함
            // float(4byte , 32bit) : 실수형 데이터 타입 -> 소숫점이 있는 숫자를 저장
            // -> 저장할 범위를 넘어서면 오버플로우가 일어남
            // bool (참, 거짓) : true(1) 또는 false(0)
        }

        static void checkAge(int age)
        {

            if (age < 8)
            {
                Console.WriteLine($"{age}살는 미취학아동입니다.");
            }
            else if (age < 14)
            {
                Console.WriteLine($"{age}살는 초등학생입니다.");
            }
            else if (age < 17)
            {
                Console.WriteLine($"{age}살는 중학생입니다.");
            }
            else if (age < 20)
            {
                Console.WriteLine($"{age}살는 고등학생입니다.");
            }
            else
            {
                Console.WriteLine($"{age}살는 성인입니다.");
            }
        } // 나이를 입력받은 함수

        static void checkScore(float score) // 점수를 입력받아서 A - F까지 출력하는 함수
        {
            /// 90이상 A
            /// 80이상 B
            /// 70이상 C
            /// 60이상 D
            /// 60미만 F

            if (score > 89)
            {
                Console.WriteLine("A");
            }
            else if (score > 79)
            {
                Console.WriteLine("B");
            }
            else if (score > 69)
            {
                Console.WriteLine("C");
            }
            else if (score > 59)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }

        static Grade checkGrade(float score) 
        {
            Grade grade = Grade.F;
            if (score > 89)
            {
                Console.WriteLine("A");
                grade = Grade.A;
            }
            else if (score > 79)
            {
                Console.WriteLine("B");
                grade = Grade.B;
            }
            else if (score > 69)
            {
                Console.WriteLine("C");
                grade = Grade.C;
            }
            else if (score > 59)
            {
                Console.WriteLine("D");
                grade = Grade.D;
            }
            else
            {
                Console.WriteLine("F");
                grade = Grade.F;
            }

            return grade;
        } // enum을 이용한 출력

        static void Gugudan(int num)
        {
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }

        static void pyramid(int num) 
        {
            for(int index = 0; index < num; index++)
            {
                for (int i = num - index; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (int i = 0; i < index * 2 + 1; i++)
                {
                    Console.Write('*');
                }
                Console.Write("\n");
            }
        } 
    }
}

// git change test

// 한줄 주석
/* 
 * 여러 줄 주석
 */

/// 자동
/// 주석
