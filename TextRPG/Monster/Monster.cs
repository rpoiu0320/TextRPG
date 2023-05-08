using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Monster
    {
        public string name;
        public int curHP;
        public int maxHP;
        public int ap;

        public void TakeDamage(int damage)
        {
            if(damage > 0)
            {
                Console.WriteLine($"{name}(은/는) {damage} 피해를 받았다!");
            }
            
            Thread.Sleep(1000);

            if(curHP <= 0)
            {
                Console.WriteLine($"{name}(은/는) 쓰러졌다!");
            }
        }

        public void Attack(Player_battle player)
        {
            Console.WriteLine($"{name}의 공격!");
            Thread.Sleep(1000);
            player.TakeDamage(ap);
        }
    }
}
