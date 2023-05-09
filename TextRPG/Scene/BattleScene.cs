using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static TextRPG.Type;

namespace TextRPG
{
    public class BattleScene : Scene
    {
        private Monster monster;

        public BattleScene(Game game) : base(game)
        {

        }
        
        public override void Render()
        {
            Console.WriteLine();
            Console.WriteLine($"{monster.name}      {monster.curHP}//{monster.maxHP}");
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine($"체력          {Data.player_battle.CurHp}{Data.player_battle.MaxHp }");
        }

        public override void Update()
        {
            Console.WriteLine("행동을 선택해주세요.");
            Console.WriteLine("1. 공격\n2.도망가기");

            ConsoleKeyInfo input = Console.ReadKey();


        }

        public void StartBattle(Monster monster)
        {
            this.monster = monster;
            
            Console.Clear();
            Console.WriteLine($"{monster.name}(이/가) 싸움을 걸어왔다!");
            Thread.Sleep(1000);
        }

        public void EndBattle()
        {

        }
    }
}
