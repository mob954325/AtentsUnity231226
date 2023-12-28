using System;
using System.Collections.Generic;
using System.Text;

namespace w1_231226
{
    class Character
    {
        /// <summary>
        /// 접근 제한자 : private(비공개), public(공개), protected(상속만 공개)
        /// </summary>

        protected float hp;

        public float Hp // 프로퍼티(property)
        {
            get => hp;  // 읽기 : public
            private set // 쓰기 : private
            {
                hp = value;

               /*if (hp < 0)
                    hp = 0;
                else if (hp > maxHp)
                    hp = maxHp;*/

                hp = Math.Clamp(value, 0, maxHp);
            }
        }

        private bool isDead = false;
        public bool IsDead => isDead;
        protected float maxHp;
        protected float mp;
        protected float maxMp;
        protected int level;
        protected float exp;
        protected const float maxExp = 100; // 상수, 절대 변경 불가
        protected float attackPower;
        protected float defencePower;
        protected string name;
        protected string Name => name; // Name이라는 프로퍼티를 읽기 전용으로 만들고 name을 리턴한다.

        public Character() // 생성자
        {
            hp = 100.0f;
            maxHp = 100.0f;
            mp = 50.0f;
            maxMp = 50.0f;

            attackPower = 10.0f;
            defencePower = 5.0f;

            level = 1;
            exp = 0.0f;

            name = "무명";
        }

        public Character(string _name) // 생성자
        {
            hp = 10.0f;
            maxHp = 100.0f;
            mp = 50.0f;
            maxMp = 50.0f;

            attackPower = 10.0f;
            defencePower = 5.0f;

            level = 1;
            exp = 0.0f;

            name = _name;
        }

        void Defence(float damage)
        {
            Hp -= (damage - defencePower);

            if (Hp <= 0 && !IsDead)
            {
                Die();
            }
            else
            {
                Console.WriteLine($"[{name}]이 {(damage - defencePower)} 만큼의 피해를 입었습니다.");
            }
        }

        public void Attack(Character _target)
        {
            Console.WriteLine($"[{name}]이(가) 공격한다.");

            _target.Defence(attackPower);
            
            Console.WriteLine($"[{_target.name}]의 남은 체력 {_target.Hp}");
        }

        public virtual void Skill() // skill은 virtual 함수. => 스킬함수는 오버라이딩할 수 있다.
        {
            Console.WriteLine("캐릭터가 스킬을 사용한다.");
        }

        void LevelUp()
        {

        }

        void Die()
        {
            isDead = true;
            Console.WriteLine($"[{name}]이 사망했습니다.");
        }
    }
}
