using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp1
{
    enum MonsterType
    {
        None = 0,
        Amat = 1,
        Tel = 2,
        Psk= 3
    }
    class Monster : Creature
    {
        MonsterType _type = MonsterType.None;
        protected Monster(MonsterType type) : base(CreatureType.Monster)
        {
            _type= type;
        }
    }

    class Amat : Monster
    {
        public Amat() : base(MonsterType.Amat)
        {
            SetInfo(10, 10);
            Console.WriteLine("야생의 Amat이 나타났습니다!");
        }
    }
    class Tel : Monster
    {
        public Tel() : base(MonsterType.Tel)
        {
            SetInfo(20, 12);
            Console.WriteLine("야생의 Tel이 나타났습니다!");
        }
    }
    class Psk : Monster
    {
        public Psk() : base(MonsterType.Psk)
        {
            SetInfo(15, 15);
            Console.WriteLine("야생의 Amat이 나타났습니다!");
        }
    }

}
