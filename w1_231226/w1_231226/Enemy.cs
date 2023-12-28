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

        public override void Skill()
        {
            Console.WriteLine("적이 도끼를 던진다");
        }
    }
}
