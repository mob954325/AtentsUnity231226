using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class Class1
    {
        static int winCount = 0;

        static void playDice()
        {
            bool selectedHigh = false;
            bool selectedLow = false;
            bool isLose = false;

            Random r = new Random();


            while(!isLose)
            {
                int dice = r.Next(6) + 1; // 0 - 6까지

                Console.WriteLine("숫자를 선택하세요 1-6");
                string startInput = Console.ReadLine();

                int input = int.Parse(startInput);

                if (input < 4)
                {
                    selectedLow = true;
                }
                else if (input < 7)
                {
                    selectedHigh = true;
                }
                else
                {
                    Console.WriteLine("숫자 범위에 벗어났습니다.");
                }

                if(dice < 4 && selectedLow)
                {
                    Console.WriteLine("LOW !!");
                    winCount++;
                    selectedLow = false;
                }
                else if (dice < 7 && selectedHigh) 
                {
                    Console.WriteLine("HIGH !!");
                    winCount++;
                    selectedHigh = false;
                }
                else
                {
                    Console.WriteLine("틀렸습니다.");
                    Console.WriteLine($"{winCount}번 승리했습니다.");
                    isLose = true;
                }
            }
        }

        static void Main()
        {
            bool isStart = false;

            while(!isStart)
            {
                Console.WriteLine("주사위 게임");
                Console.WriteLine("시작하려면 1을 입력하세요.\n");
                string startInput = Console.ReadLine();

                int input = int.Parse(startInput);

                if (input == 1)
                {
                    isStart = true;
                    playDice();
                }
            }
        } // main
    }
}
