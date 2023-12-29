using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w1_231226
{
    internal class Enemy : Character
    {
        public Enemy(string _name) : base(_name)
        { 

        }

        protected override float onSkill()
        {
            Console.WriteLine("적이 도끼를 던진다");
            return attackPower * 3.0f;
        }
    }
}
