using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static TextRPG.Type;

namespace TextRPG
{
    public class Game
    {
        private bool running = true;

        private Scene           curScene;
        private MainMenuScene   mainMenuScene;
        private MapScene        mapScene;
        private InventoryScene  inventoryScene;
        private BattleScene     battleScene;

        public void Run()
        {
            Init();

            while (running)
            {
                Render();
                Update();
            }

            Release();
        }

        private void Init()
        {
            mainMenuScene =     new MainMenuScene(this);
            mapScene =          new MapScene(this);
            inventoryScene =    new InventoryScene(this);
            battleScene =       new BattleScene(this);

            curScene = mainMenuScene;
        }

        public void GameStart()
        {
            string startText = "목적지까지 전투를 치르며 도착하기";
            Console.WriteLine(startText);
            Thread.Sleep(3000);
            Console.Clear();
            Console.CursorVisible = false;
            curScene = mapScene;
        }

        public void GameOver()
        {
            running = false;
        }

        public void NextLevel()
        {

        }

        public void GameClear()
        {
            Console.WriteLine("게임을 클리어했습니다.\n");
            running = false;
        }

        public void BatteleStart(Monster monster)
        {
            curScene = battleScene;
        }

        public void RoadMap()
        {
            curScene = mapScene;
        }

        private void Render() 
        {
            Console.Clear();
            curScene.Render();
        }

        private void Update()
        {
            curScene.Update();
        }

        public void Release()
        {
            Console.WriteLine("엔터를 누르면 게임을 종료합니다.");
            ConsoleKeyInfo endInput = Console.ReadKey();
            switch (endInput.Key)
            {
                
            }
        }
    }
}
