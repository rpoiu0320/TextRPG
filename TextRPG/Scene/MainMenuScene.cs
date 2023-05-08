using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    public class MainMenuScene : Scene
    {
        public MainMenuScene(Game game) : base(game) 
        {
            
        }
        public override void Render()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("1. 게임시작");
            sb.AppendLine("2. 게임종료\n");
            sb.AppendLine("게임을 시작하세요.");

            Console.WriteLine(sb.ToString());
        }
        public override void Update()
        {
            string input = Console.ReadLine();

            int command;
            if(!int.TryParse(input, out command))
            {
                Console.WriteLine("잘못된 입력입니다.");
                Thread.Sleep(1000);
                return;
            }

            switch(command)
            {
                case 1:
                    game.GameStart();
                    break;
                case 2:
                    game.Release();
                    break;
                default:
                    break;
            }
        }
    }
}
