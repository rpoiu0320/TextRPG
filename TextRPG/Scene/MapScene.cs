using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TextRPG.Type;

namespace TextRPG
{
    public class MapScene : Scene
    {
        public MapScene(Game game) : base(game) 
        {

        }

        public override void Render()
        {
            PrintMap();
        }

        public override void Update()
        {
            if (Data.map[Data.player_map.pos.x, Data.player_map.pos.y] ==
                Data.TileStyle.Goal)
            {
                game.GameClear();
                return;
            }

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.Key)
            {
                case ConsoleKey.UpArrow:
                    Data.player_map.Move(Direction.Up);
                    break;
                case ConsoleKey.DownArrow:
                    Data.player_map.Move(Direction.Down);
                    break;
                case ConsoleKey.LeftArrow:
                    Data.player_map.Move(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    Data.player_map.Move(Direction.Right);
                    break;
            }
            
        }

        private void PrintMap()
        {
            StringBuilder sb = new StringBuilder();
            for(int y = 0; y < Data.map.GetLength(0); y++)
            {
                for(int x = 0; x < Data.map.GetLength(1); x++)
                {
                    if (Data.map[x, y] == Data.TileStyle.Wall)
                    {
                        sb.Append('▩');
                    }
                    else if (Data.map[x, y] == Data.TileStyle.Road)
                    {
                        sb.Append(' ');
                    }
                    else if (Data.map[x, y] == Data.TileStyle.Bush)
                    {
                        sb.Append('▣');
                    }
                    else if (Data.map[x, y] == Data.TileStyle.Goal)
                    {
                        sb.Append('○');
                    }
                    else if (Data.map[x, y] == Data.TileStyle.Item)
                    {
                        sb.Append('★');
                    }

                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb.ToString());

            Console.ForegroundColor = ConsoleColor.Red;

            if (Data.map[Data.player_map.pos.x, Data.player_map.pos.y] ==
                Data.TileStyle.Bush)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }

            if (Data.map[Data.player_map.pos.x, Data.player_map.pos.y] ==
                Data.TileStyle.Item)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            Console.WriteLine(Data.player_map.icon);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
