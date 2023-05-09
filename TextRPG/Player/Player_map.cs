using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TextRPG.Type;

namespace TextRPG
{
    public class Player_map
    {
        public string icon = " ♥";
        public Position pos;

        public void Move(Direction dir)
        {
            Position prevPos = pos;

            switch (dir)
            {
                case Direction.Up:
                    pos.y--;
                    break;
                case Direction.Down:
                    pos.y++;
                    break;
                case Direction.Left:
                    pos.x--;
                    break;
                case Direction.Right:
                    pos.x++;
                    break;
            }

            if (Data.map[pos.x, pos.y] == Data.TileStyle.Wall)
            {
                pos = prevPos;
            }
        }
    }
}
