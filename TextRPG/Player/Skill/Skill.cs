using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Skill
    {
        public string skillName;
        
        public Skill(string skillName)
        {
            this.skillName = skillName;
        }

        public void Action(string skillName)
        {
            Console.WriteLine($"플레이어의 {skillName}!");
        }
    }
}
