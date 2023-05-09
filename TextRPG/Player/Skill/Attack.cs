using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Attack : Skill
    {
        public string skillName = "공격";
        public Attack(string skillName) : base(skillName)
        {
            this.skillName = skillName;
        }

        public void AttackAction(Monster monster, Player_battle player)
        {
            Console.WriteLine($"{monster.name}에게 공격!");
            Thread.Sleep(100);
            monster.TakeDamage(player.AP);
        }
    }
}
