using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_231226
{
    /*    public enum Grade
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
        }*/

    internal class Class1
    {
        static void Main(string[] args)
        {
            // 적과 나중 한명이 죽을 때까지 싸운다.
            Player player = new Player("주인공");
            Enemy enemy = new Enemy("오크");

            while (player.IsAlive && enemy.IsAlive)
            {
                if (!player.IsAlive || !enemy.IsAlive)
                    break;

                player.Attack(enemy);

                if (enemy.IsAlive)
                {
                    enemy.Attack(player);
                }
            }

            testStatic.i = 20;
            testStatic.test2();
        }
    }
}