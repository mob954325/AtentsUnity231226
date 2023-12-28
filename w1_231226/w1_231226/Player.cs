using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_231226
{
    /// <summary>
    /// C#은 반드시 하나의 상속만 받을 수 있음
    /// </summary>
    internal class Player : Character // Player 클래스가 Character 클래스를 상속 받음
    {
        public Player(string _name) : base(_name) 
        { 

        }
        /*public new void Attack()
        {
            Console.WriteLine("플레이어가 공격한다");
        }*/

        public override void Skill() // player의 skill 함수를 덮어쓴다.
        {
            base.Skill(); // player 부모클래스 Skill()을 실행하고 자신을 실행한다.
            Console.WriteLine("플레이어가 파이어 볼을 사용한다.");
        }
    }
}
