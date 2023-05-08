using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Player_battle
    {
        List<Skill> skill = new List<Skill>();
        public Player_battle()
        {
            CurHp = 30;
            MaxHp = 30;
            CurMp = 15;
            MaxMp = 15;
            Level = 1;
            CurExp = 0;
            MaxExp = 10;
            AP = 5;
            skills = new List<Skill>();
        }
        public int CurHp { get; private set; }
        public int MaxHp { get; private set; }
        public int CurMp { get; private set; }
        public int MaxMp { get; private set; }
        public int Level { get; private set; }
        public int CurExp { get; private set; }
        public int MaxExp { get; private set; }
        public int AP { get; private set; }
        public List<Skill> skills;

        public void GetItem(Item item)
        {
            Data.inventory.Add(item);
        }

        public void TakeDamage(int damage)
        {
            Console.WriteLine($"피해를 {damage}받았다!");
            CurHp -= damage;

            if (CurHp <= 0)
            {
                Console.WriteLine("플레이어는 쓰러졌다...");
                return;
            }

            if ( CurHp < 10 && CurHp > 0)
            {
                Console.WriteLine("체력이 얼마 남지 않았다!");
            }
        }
    }
}
