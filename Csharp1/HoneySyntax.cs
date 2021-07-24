// 어렵지만 알면 알수록 인생이 편해지는 C# 꿀 문법

/*using System;
using System.Reflection;

namespace CSharp1pluse
{
    class Program
    {
        class Monster
        {
            public int Id { get; set; }
        }

        static int Find()
        {
            return 0;
        }

        static Monster FindMonster(int id)
        {
            return null;
        }

        static void Main(string[] args)
        {
            Monster monster = null;
            if (monster != null)
            {
                int monsterId = monster.Id;
            }

            // (monster != null) ? monster.Id : null
            int? id = monster?.Id;

            // Nullable -> Null + able
            int? number = null;

            // number != null ? number : 0
            int b = number ?? 0;

            //number = 3;

            //int a = number;
            //int a = number.Value;

            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            // 객체 - 없/있 - Null
            //Monster monster = FindMonster(101);

        }
    }
}*/

/* // // Reflection , [Attribute] RuntimeComment
        class RunTimeComment : System.Attribute
        {
            string _message;
            public RunTimeComment(string message) { _message = message;  }
        }

        class Monster
        {
            [RunTimeComment("compiler's best")]

            public int hp;
            protected int attack;
            private float speed;

            void Attack() { }
        }
        static void Main(string[] args)
        {
            // Reflection
            Monster monster = new Monster();

            // Monster class 의 정보 얻기
            Type type = monster.GetType();
            //type.

            var fields = type.GetFields(BindingFlags.Public
                | BindingFlags.NonPublic
                | BindingFlags.Static
                | BindingFlags.Instance
                );

            foreach(FieldInfo field in fields)
            {
                string access = "protected";
                if (field.IsPublic)
                    access = "public";
                else if (field.IsPrivate)
                    access = "private";

                var attributes = field.GetCustomAttributes();

                Console.WriteLine($"{access}\t{field.FieldType.Name}\t{field.Name}");
            }
        }*/

/* /// // 결론 Func<> + Lambda
        enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        UnCommon,
        Rare
    }

    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }

    class Program
    {
        static List<Item> _items = new List<Item>();

        // 인벤토리 조회

        // delegate 따로 선언 안 해줘도 된다
        //delegate bool ItemSelector(Item item);
        static Item FindItem(Func<Item, bool> selector)
        {
            foreach(Item item in _items)
            {
                // item 이 selector 조건을 충족한다면 반환하겠다
                if (selector(item))
                    return item;
            }
            return null;
        }
        
        static void Main(string[] args)
        {
            // Item 만들기. new 하면서 동시에 초기화
            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity= Rarity.Normal });
            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity= Rarity.UnCommon });
            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });
            
            // delegate객체 = Lambda 재활용. (인자) => {반환}
            Func<Item, bool> selector = (Item item) => { return item.ItemType == ItemType.Weapon; };
            Item item = FindItem(selector);
        }
    }*/

/* // [delegate + generice -> Func< >] + Lambda
        //delegate bool ItemSelector(Item item);
        //delegate Return MyFunc<Return>();
        //delegate Return MyFunc<T, Return>(T item);
        //delegate Return MyFunc<T1, T2, Return>(T1 t1, T2 t2);
        //Func<>
        //Action<>

        //static Item FindItem(ItemSelector selector)
        //static Item FindItem(MyFunc<Item, bool> selector)
        // Lambda: (인자) => {반환} . 일회용 함수 만드는 문법
        //Item item = FindItem((Item item) => { return item.ItemType == ItemType.Weapon; });

        // delegate객체 = Lambda 재활용
        //ItemSelector selector = new ItemSelector((Item item) => { return item.ItemType == ItemType.Weapon; });
        //MyFunc<Item, bool> selector = new MyFunc<Item, bool>((Item item) => { return item.ItemType == ItemType.Weapon; });
        //MyFunc<Item, bool> selector = (Item item) => { return item.ItemType == ItemType.Weapon; };*/

/* // delegate 로 넘기는 콜백인자
            Item item = FindItem(delegate (Item item)
            {
                return item.ItemType == ItemType.Weapon;
            });*/

/* // FindItem 에 넣을 조건식. 을 Lambda 로 대체
        static bool IsWeapon(Item item)
        {
            return item.ItemType == ItemType.Weapon;
        }
*/

/*// 인벤토리 조회를 장착 부위별, 희귀도 별, 조합별로 12가지를 다 만든다??? ㄴㄴ 싫어여
        static Item FindWeapon()
        {
            foreach (Item item in _items)
            {
                if (item.ItemType == ItemType.Weapon)
                    return item;
            }
            return null;
        }
        static Item FindRareItem()
        {
            foreach (Item item in _items)
            {
                if (item.Rarity == Rarity.Rare)
                    return item;
            }
            return null;
        }*/

/* // Dictionary
            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            for(int i=0; i<10000; i++)
            {
                dict.Add(i, new List<int>(i));
            }

            List<int> list;
            bool found = dict.TryGetValue(7777, out list);

            dict.Remove(77);
            dict.Clear();
*/

/* /// // List<> ()  ///
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for(int i=0; i<5; i++)
            {
                list.Add(i);
            }
            list.Add(0);
            PrnList(list);

            list.Remove(0);
            PrnList(list);

            list.RemoveAt(3);
            PrnList(list);
        }
        static void PrnList(List<int> list)
        {
            foreach(int _ in list)
            {
                Console.Write(_+" ");
            }
            Console.WriteLine();
        }*/

/* // // 배열- 다차원, 다차원 가변  ///
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            map.Render();

            int[,] aaa1 = new int[2, 3] { { 0, 1, 2 }, { 10, 20, 30 } };
            int[,] aaa2 = new int[,] { { 0, 1, 2 }, { 10, 20, 30 } };
            int[,] aaa3 = { { 0, 1, 2 }, { 10, 20, 30 } };

            int[][] bbb1 = new int[2][];
            bbb1[0] = new int[3];
            bbb1[1] = new int[6];
        }

    }

    class Map
    {
        int[,] tiles =
        {
            {1,1,1,1,1 },
            {1,0,0,0,1 },
            {1,0,0,0,1 },
            {1,0,0,0,1 },
            {1,1,1,1,1 }
        };

        public void Render()
        {
            ConsoleColor defaultColor = ConsoleColor.White;
            // y: 세로
            for(int y=0; y<tiles.GetLength(1); y++)
            {
                // x: 가로
                for(int x=0; x<tiles.GetLength(0); x++)
                {
                    if (tiles[y, x] == 1)
                        Console.ForegroundColor = ConsoleColor.Red;
                    else
                        Console.ForegroundColor = ConsoleColor.Green;

                    Console.Write('\u25cf');
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = defaultColor;
        }
    }
*/

/* // 배열 [기초, 연습]
        static void Main(string[] args)
        {
            int[] scores = new int[5] { 10, 30, 40, 20, 50 };

            GetHighestScore(scores);
            GetAverageScore(scores);
            GetIndexOf(scores, 40);
            Sort1(scores);
            Sort2(scores);

        }

        private static int GetHighestScore(int[] scores)
        {
            int max = 0;
            foreach(int _ in scores)
            {
                if (max < _)
                    max = _;
            }
            return max;
        }

        private static double GetAverageScore(int[] scores)
        {
            if (scores.Length == 0) return 0;

            int sum = 0;
            foreach(int _ in scores)
            {
                sum += _;
            }
            
            return sum/scores.Length;
        }

        private static int GetIndexOf(int[] scores, int value)
        {
            for(int i=0; i<scores.Length; i++)
            {
                if (value == scores[i]) return i;
            }
            return -1;
        }

        private static int[] Sort1(int[] scores)
        {
            int[] indexArr = new int[scores.Length];
            int count;
            int[] scoreSort = new int[scores.Length];

            for (int i = 0; i < scores.Length; i++)
            {
                count = 0;
                for (int j = 0; j < scores.Length; j++)
                {
                    // 기준값보다 비교대상값이 작으면 count 늘림
                    // 0 2 3 1 4
                    if (scores[i] > scores[j])
                        count++;
                }
                indexArr[i] = count;
            }
            
            // 정렬한 index를 새로 만든 sort 에 넣음
            for(int i=0; i< scores.Length; i++)
            {
                scoreSort[indexArr[i]] = scores[i];
            }

            return scoreSort;
        }

        private static int[] Sort2(int[] scores)
        {
            // { '10', 30, 40, 20, 50 } - 첫번째부터 순회하며 제일 작은 걸 찾는다
            // { "10", 30, 40, 20, 50 } - 첫 번째에 있으니 냅둔다
            // 작은 거 보자마자 바꾸는 게 아니다!
            // { 10, 30, 40, '20', 50 } - 두번째부터 순회하며 제일 작은 걸 찾는다
            // { 10, "20", 40, "30", 50 } - 두번째랑 찾은 위치랑 바꾼다
            // 반복
            for(int i=0; i<scores.Length; i++)
            {
                int minIndex = i;
                for(int j=i; j<scores.Length; j++)
                {

                    if(scores[j] < scores[i])
                    {
                        minIndex = j;
                    }
                }

                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
            return scores;
        }
*/

/*// 이건 아닌거 같음. 
         * 의도: 최솟값 찾아서 [5]짜리 새로 만들어 첫 번째에 넣고, 해당하는 건 제외하고 다시 최솟값 찾으려함
        // 한계: 기본 배열에서 pop을 제공 안 하니, 너무 복잡해짐.
        private static int Min(int[] values, int[] exceptIndex)
        {
            int min= 100000;
            int minIndexInner=0;
            for(int i=0 ; i<values.Length; i++)
            {
                if(values[i] < min && ! i.exceptIndex에있는건빼고)
                {
                    min = values[i];
                    minIndexInner = i;
                }
            }

            return GetIndexOf(values, minIndexInner);
        }*/

/* // 배열 기초
            int[] scores = new int[5];

            int[] scores1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] scores2 = new int[] { 1, 2, 3, 4, 5 };
            int[] scores3 =  { 1, 2, 3, 4, 5 };

            scores[0] = 1;
            scores[1] = 2;
            scores[2] = 3;
            scores[3] = 4;
            scores[4] = 5;
            
            //scores[5] = 100;

            for (int i = 0; i < 5; i++) Console.WriteLine(scores[i]);
            for (int i = 0; i < scores.Length; i++) Console.WriteLine(scores[i]);
            foreach (int _ in scores) Console.WriteLine(_);
*/