using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class SkillEscape : Skill
    {
        public string skillName = "도망가기";
        Game game = new Game();
        public SkillEscape(string skillName) : base(skillName)
        {
            this.skillName = skillName;
        }
        public void Escape()
        {
            Random random = new Random();
            Console.WriteLine("플레이어의 도망가기!");
            switch (random.Next(0, 4))
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("몬스터와의 전투에서 이탈했다.");
                    Thread.Sleep(1000);
                    game.RoadMap();
                    break;
                default:
                    Console.WriteLine("도망에 실패했다..");
                    break;
            }
        }
    }
}
