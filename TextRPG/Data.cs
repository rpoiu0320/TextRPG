using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class Data
    {
        public static Player_map player_map;
        public static Player_battle player_battle;
        public static List<Monster> monsters;
        public static List<Item> items;
        public static List<Item> inventory;
        public static List<Skill> skill;

        public enum TileStyle { Wall, Road, Goal, Bush, Item }
        public static TileStyle[,] map;
        public static void Init()
        {
            player_map = new Player_map();
            player_battle = new Player_battle();
            monsters = new List<Monster>();
            items = new List<Item>();
            inventory = new List<Item>();
            skill = new List<Skill>();

            skill.Add(new SkillAttack("공격"));
            skill.Add(new SkillEscape("도망"));
        }

        public static void Release()
        {

        }

        public static void LodeLeve1()
        {
            map = new TileStyle[,]
            {
                { TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall},
                { TileStyle.Wall, TileStyle.Road, TileStyle.Road, TileStyle.Road, TileStyle.Bush, TileStyle.Bush, TileStyle.Road, TileStyle.Item, TileStyle.Road, TileStyle.Wall},
                { TileStyle.Wall, TileStyle.Road, TileStyle.Road, TileStyle.Bush, TileStyle.Bush, TileStyle.Bush, TileStyle.Road, TileStyle.Road, TileStyle.Road, TileStyle.Wall},
                { TileStyle.Wall, TileStyle.Road, TileStyle.Bush, TileStyle.Road, TileStyle.Bush, TileStyle.Bush, TileStyle.Road, TileStyle.Bush, TileStyle.Bush, TileStyle.Wall},
                { TileStyle.Wall, TileStyle.Bush, TileStyle.Road, TileStyle.Bush, TileStyle.Bush, TileStyle.Bush, TileStyle.Bush, TileStyle.Road, TileStyle.Road, TileStyle.Wall},
                { TileStyle.Wall, TileStyle.Road, TileStyle.Road, TileStyle.Road, TileStyle.Bush, TileStyle.Bush, TileStyle.Road, TileStyle.Road, TileStyle.Road, TileStyle.Wall},
                { TileStyle.Wall, TileStyle.Bush, TileStyle.Bush, TileStyle.Road, TileStyle.Bush, TileStyle.Bush, TileStyle.Road, TileStyle.Road, TileStyle.Road, TileStyle.Wall},
                { TileStyle.Item, TileStyle.Bush, TileStyle.Road, TileStyle.Road, TileStyle.Bush, TileStyle.Bush, TileStyle.Bush, TileStyle.Bush, TileStyle.Bush, TileStyle.Wall},
                { TileStyle.Wall, TileStyle.Road, TileStyle.Bush, TileStyle.Road, TileStyle.Bush, TileStyle.Road, TileStyle.Road, TileStyle.Bush, TileStyle.Goal, TileStyle.Wall},
                { TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall, TileStyle.Wall},
            };

            player_map.pos = new Type.Position(1, 1);
        }
        
    }
}
