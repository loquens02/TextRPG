using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp1
{
    // 절차 지향. Part1- TextRPG 1
    class ProcedureOriented
    {
        /*static void Main(string[] args)
        {
            while (true)
            {
                // 직업 선택
                ClassType choice = ChooseJob();
                if (ClassType.None == choice) continue;

                // 캐릭터 생성
                Player player = new Player();
                CreatePlayer(choice, ref player);

                // 게임 진입 or 돌아가기
                EnterGame(ref player);
            }
        }



        // enum 에는 string 안 됨
        enum ClassType
        {
            None = 0,
            Knight = 1,
            Archer = 2,
            Mage = 3
        }

        struct Player
        {
            public int hp;
            public int attack;
            //public ClassType type;  // 변경점이 많아서 나중에. 이미 못 건드리겠음.

            override public string ToString()
            {
                return "체력: " + hp + "\t공격력: " + attack;
            }
        }

        static ClassType ChooseJob()
        {
            Console.WriteLine("직업을 선택하세요~");
            Console.WriteLine("[1] 기사");
            Console.WriteLine("[2] 궁수");
            Console.WriteLine("[3] 법사");

            string input = Console.ReadLine();

            ClassType choice = ClassType.None;
            switch (input)
            {
                case "1":
                    choice = ClassType.Knight;
                    break;
                case "2":
                    choice = ClassType.Archer;
                    break;
                case "3":
                    choice = ClassType.Mage;
                    break;
            }
            return choice;
        }

        static void CreatePlayer(ClassType choice, ref Player player)
        {
            // default: 문법적으로 필수라 넣었지만, 진입 불가.
            switch (choice)
            {
                case ClassType.Knight:
                    player.hp = 100;
                    player.attack = 10;
                    break;
                case ClassType.Archer:
                    player.hp = 75;
                    player.attack = 12;
                    break;
                case ClassType.Mage:
                    player.hp = 50;
                    player.attack = 15;
                    break;

                default:
                    player.hp = 0;
                    player.attack = 0;
                    break;
            }

            Console.WriteLine($"직업: {choice}\t{player.ToString()}");
        }

        static void EnterGame(ref Player player)
        {
            while (true)
            {
                Console.WriteLine("마을에 접속했습니다");
                Console.WriteLine("[1] 필드에 들어가기");
                Console.WriteLine("[2] 로비로 돌아가기");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnterField(ref player);
                        break;
                    case "2":
                        return;
                }
            }
        }
        static void EnterField(ref Player player)
        {
            Console.WriteLine("필드에 진입했습니다!");

            //랜덤 몬스터 생성
            Monster monster; // = new Player();
            CreateRandomMonster(out monster);

            Console.WriteLine("[1] 물리친다!");
            Console.WriteLine("[2] 일정확률로 도망간다");
            string choice = Console.ReadLine();

            if ("1" == choice)
            {
                // 필드에서 몬스터와 전투
                Fight(ref player, ref monster);
            }
            else if ("2" == choice)
            {
                RunAway(ref player, ref monster);
            }



        }

        // (기본 60 - 몬스터 공격력 )% 확률로 도망갈 수 있음
        static void RunAway(ref Player player, ref Monster monster)
        {
            Random random = new Random();
            int percent = random.Next(1, 101);
            percent -= monster.attack;

            if (40 < percent)
            {
                Console.WriteLine($"ㅌㅌㅌ (도망률 {percent - 40}%)");
            }
            else
            {
                Console.WriteLine($"어딜 도망가 (도망률 {percent - 40}%)");
                Fight(ref player, ref monster);
            }
        }

        static void CreateRandomMonster(out Monster monster)
        {
            Random random = new Random();
            int monsterType = random.Next(1, 4);

            switch (monsterType)
            {
                case (int)MonsterType.AMAT:
                    monster.type = MonsterType.AMAT;
                    monster.hp = 20;
                    monster.attack = 2;
                    break;
                case (int)MonsterType.PSK:
                    monster.type = MonsterType.PSK;
                    monster.hp = 40;
                    monster.attack = 4;
                    break;
                case (int)MonsterType.TEL:
                    monster.type = MonsterType.TEL;
                    monster.hp = 30;
                    monster.attack = 3;
                    break;

                default:
                    monster.type = MonsterType.None;
                    monster.hp = 0;
                    monster.attack = 0;
                    break;
            }
            Console.WriteLine("몬스터가 생성되었습니다");
            Console.WriteLine($"{monster.ToString()}");
        }

        static void Fight(ref Player player, ref Monster monster)
        {
            Console.WriteLine($"필드에서 몬스터와 전투");
            while (true)
            {
                monster.hp -= player.attack;
                Console.WriteLine(monster.ToString());
                if (0 >= monster.hp)
                {
                    Console.WriteLine("플레이어 승리!");
                    break;
                }

                player.hp -= monster.attack;
                Console.WriteLine(player.ToString());
                if (0 >= player.hp)
                {
                    Console.WriteLine("You Died");
                    break;
                }
            }
        }

        struct Monster
        {
            public int hp;
            public int attack;
            public MonsterType type;

            override public string ToString()
            {
                return "종류: " + type + "\t체력: " + hp + "\t공격력: " + attack;
            }
        }

        enum MonsterType
        {
            None = 0,
            AMAT = 1,
            PSK = 2,
            TEL = 3
        }*/
    }
}


/* /// //// Factorial  /  ///////
        // 5! = 5 * 4!
        static int Factorial(int n)
        {
            if (1 == n)
            {
                Console.Write($"{n} ");
                return 1;
            }
            Console.Write($"{n} * ");
            return Factorial(n-1) * n;
        }

        static void Main(string[] args)
        {
            Console.Write("입력: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int ret = Factorial(input);

            Console.WriteLine($"= {ret}");
        }*/

/* ////// 별 찍기- 삼각형 /////////
 * 
 * //      i   j   max
   // o       0   0   3
   // o o     1   01   3
   // o o o   2   0123   3

    Console.WriteLine("몇 줄 까지 출력하실?: ");
    int max = Convert.ToInt32(Console.ReadLine());

    for(int i=0; i<max; i++)
    {
        for(int j=0; j<=i; j++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }*/

/* ///// 구구단 //////
    for(int i=1; i<=9; i++)
    {
        for(int j=1; j<=9; j++)
        {
            Console.WriteLine($"{i} * {j} = {i*j}");
        }
    }*/

/*   //////// 오버로딩, 디폴트 매개변수 ///////////
        static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static float Add(float a, float b= .0f, float c= .0f)
    {
        return a + b + c;
    }

    static void Main(string[] args)
    {
        Console.WriteLine( Program.Add(30, 5, 100));
        Console.WriteLine( Program.Add(0.3f, 0.05f));
        Console.WriteLine( Program.Add(0.07f, c:10000f));
    }*/

/* //////////  참조 변수 ref, out -결과 여럿   /////////////
        static int Sum1(int a, int b)
        {
            return a + b;
        }
        static void numberOne(ref int number)
        {
            number++;
        }
        static void Divide1(int a, int b, out int res1, out int res2)
        {
            
            res1 = (0 != b) ? (a / b) : 0;
            res2 = (0 != b) ? (a % b) : a;
        }
        static void Main(string[] args)
        {
            int number = 0;
            int a = 20;
            int b = 0;
            
            int res1;
            int res2;
            
            //numberOne(ref number);
            
            Divide1(a, b, out res1, out res2);
            //Console.WriteLine($"합은 {Sum1(a,b)}");
            //Console.WriteLine($"합은 {number}");
            Console.WriteLine($"나눈값 {res1}, 나머지 {res2}");
        }*/

/* /////////  소수 판단  /////////
            int num = 97;
            bool isPrime = true;
            string res;

            for(int i = 2; i < num; i++)
            {
                if (0 == (num % i))
                {
                    isPrime = false;
                    break;
                }
            }

            res = isPrime ? "소수입니다" : "소수가 아닙니다";
            Console.WriteLine($"{num}은 {res}.");
*/

/* ////////// 가위바위보 ////////////
// main 바깥, class 안 쪽
            enum Choice
            {
                SCISSORS = 0,
                ROCK = 1,
                PAPER = 2
            }
// main
            Random rand = new Random();

            //const int SCISSORS = 0;
            //const int ROCK = 1;
            //const int PAPER = 2;

            int aiChoice = rand.Next(0, 3); // [0,3)
            string userRes, aiRes, res;

            Console.WriteLine("입력(0가위 1바위 2보) 바랍니다: ");
            int userChoice = Convert.ToInt32(Console.ReadLine());
            
            switch (userChoice)
            {
                case (int)Choice.SCISSORS:
                    userRes= "가위";
                    break;
                case (int)Choice.ROCK:
                    userRes= "바위";
                    break;
                case (int)Choice.PAPER:
                    userRes= "보";
                    break;
                default:
                    userRes= "다른 거 내";
                    break;
            }

            switch (aiChoice)
            {
                case (int)Choice.SCISSORS:
                    aiRes = "가위";
                    break;
                case (int)Choice.ROCK:
                    aiRes = "바위";
                    break;
                case (int)Choice.PAPER:
                    aiRes = "보";
                    break;
                default:
                    aiRes = "rand 왜이럼";
                    break;
            }

            Console.WriteLine("당신의 선택: {0}", userRes);
            Console.WriteLine("컴퓨터 선택: {0}", aiRes);


            //
            // * m c r
            // *0 0 -
            // *0 1 f
            // *0 2 t
            // *1 0 t
            // *1 1 -
            // *1 2 f
            // *2 0 f
            // *2 1 t
            //* 2 2 -


            switch (aiChoice- userChoice)
            {
                case 0:
                    res = "비겼어";
                    break;
                case 1:
                case -2:
                    res = "졌어";
                    break;
                case 2:
                case -1:
                    res = "이겼어";
                    break;
                default:
                    res = "가라 하와이";
                    break;
            }
            Console.WriteLine("내가 {0}", res);*/

/* ////////// 비트 연산 ////////////
            
            int num1 = 2;
            //Console.WriteLine(num << 1);
            //Console.WriteLine(num >> 1);

            //Console.WriteLine(num >> 2); // 0. 아래로 내려가면 없어짐

            //Console.WriteLine(0 ^ 1 ^ 1);

            int id = 123;
            int cryptoKey = 409;

            int crytoId = id ^ cryptoKey;
            //int userRes= (id ^ cryptoKey) ^ cryptoKey;
            //Console.WriteLine(crytoId);
            //Console.WriteLine(crytoId ^ cryptoKey);
            //Console.WriteLine(id ^ cryptoKey ^ cryptoKey);
            //Console.WriteLine(res);


            ////// 할당 /////////
            int val = 100;
            int res2 = val %= 3;
            
            Console.WriteLine(res2);*/

/* ////////// 진수 정수범위 형식(변환) ////////////
 *      
             * byte(1B 0~255), short(2B -3만~3만), int(4B -21억~21억), long(8B)
             * s: signed, u: unsigned
             * sbyte(1B -128~127), ushort(2B 0~6만), uint(4B 0~43억), ulong(8B)
             

            // 1B (1b 보다 연산이 빨라서)
            bool b;
            b = true;
            b = false;

            // 4B
            // 3.14 는 double
            float f1 = 3.14f;
            // float = int 는 멀쩡
            float f2 = 1;
            //Console.WriteLine("Hello World! {0} {1}", f1, f2);

            // 8B
            double d1 = 3.14;
            // double = float 는 되나봄. 되긴 되는데 쓰레기가 잔뜩
            double d2 = 3.14f;
            //Console.WriteLine("Hello World! {0} {1}", d1, d2);

            int a3 = 0x0fffffff;
            short s3 = (short)a3;



            char c1 = 'a';
            //string str1 = 'hell o world';
            string str2 = "hell o world";
            Console.WriteLine("Hello World! {0}\n{1}", c1,str2);


            byte ub= 255;
            sbyte sb = (sbyte)ub;
*/

/* ///////// 정수 형식 /////////////
 * 
            


            int hp;
            // byte 로 충분하겠지만, 기획이 바뀌어서 level 상한선이 올라갈 수 있다. 넉넉-
            short level = 100;
            // 게임 7년차가 넘어가니 생성한 아이템 수만 21억개를 넘어가더라. 넉넉-
            long id;
            // 문명5에서 시간이 갈수록 공격성이 약해지도록 설정해뒀는데
            // 간디는 byte 0 에서 1을 빼서 under flow가 발생 > 255 라는 괴악한 수치
            byte attackBias = 0;
            attackBias--;
           

            hp = 100;



            //Console.WriteLine("Hello World! {0} {1}", hp, attackBias);
         
 */