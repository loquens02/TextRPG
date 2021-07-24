using System;

namespace Csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            while (true)
            {
                game.Process();
            }
            
        }
    }
}

/* //// TextRPG2 ver 플레이어 생성 ///
            Player player1 = new Mage();
            Player player2 = new Archer();
            Monster monster1 = new Psk();

            int damage = player1.GetAttack();
            monster1.OnDamaged(damage);
*/

/* ///// string ex //
            string name = "Harry Potter";

            // find
            bool found = name.Contains("Harry");
            int index = name.IndexOf('P'); //0~
            int index2 = name.IndexOf('Z'); //0~

            // trans
            name += " Junior";
            string lower = name.ToLower();
            string upper =name.ToUpper();
            string newName = name.Replace('r', 'l');

            // slice
            string[] names= name.Split(' ');
            string[] names2= name.Split(new char[] { ' ' });
            string subStr = name.Substring(6);
*/

/*/// //// 은닉, 상속, 다형성 ///////
    class Player
    {
        static public int counter = 1;

        public int id;
        public int hp;
        public int attack;

        public Player()
        {
            counter++;
            //Console.WriteLine("Player 기본생성자");
        }

        public virtual void Move()
        {
            Console.WriteLine("기본 이동");
        }
        public void Attack()
        {
            Console.WriteLine("기본 공격");
        }
    }
    class Mage : Player
    {
        public int mp;
        public override void Move()
        {
            //base.Move();
            Console.WriteLine("순간 이동!");
        }
    }
    class Archer : Player
    {
        public override void Move()
        {
            base.Move();
            Console.WriteLine("조용히 이동");
        }

    }
    class Knight : Player
    {
        protected int stunRange;

        public Knight() : base()
        {
            //Console.WriteLine("Knight 기본생성자");
        }
        public Knight(int hp) : base()
        {
            this.hp = hp;
            //Console.WriteLine("Knight +hp 생성자");
        }
        public Knight(int hp, int attack)
        {
            this.hp = hp;
            this.attack = attack;
            //Console.WriteLine("Knight +hp +attack 생성자");
        }

        public Knight Clone()
        {
            Knight knight = new Knight();
            knight.hp = hp;
            knight.attack = attack;
            return knight;
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("돌진!");
        }

        public void stun()
        {

        }

    }

    class SuperKnight : Knight
    {
        SuperKnight()
        {
            stunRange = 20;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Mage mage = new Mage();

            EnterGame(mage);
        }

        static void EnterGame(Player player)
        {
            player.Move();

            //추천하는 방식: as
            Mage mage = player as Mage;
            if (mage != null)
            {
                mage.mp = 10;
            }

            //bool isMage = player is Mage;
            //if (isMage)
            //{
            //    Mage mage = (Mage)player;
            //    mage.mp = 10;
            //}
        }
    }*/

/*/////// 깊은복사 얕은 복사
 * Knight knight = null;
 * 
 * struct Mage
    {
        public int hp;
        public int attactk;
    }
            Knight knight = new Knight();
            knight.hp = 100;
            knight.attack = 10;

            Knight knight4 = knight.Clone();
            knight4.hp = 0;

            //Knight knight3 = new Knight();
            //knight3.hp = 0;

            //Knight knight2 = knight;
            //knight2.hp= 0;



            Mage mage; // =new Mage();
            mage.hp = 50;
            mage.attactk = 15;

            Mage mage2 = mage;
            mage2.hp = 0;
*/