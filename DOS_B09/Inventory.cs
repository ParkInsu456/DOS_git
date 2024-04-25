using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    internal class Inventory
    {
        PrintMgr printMgr = GameManager.printMgr;
        InputMgr inputMgr = GameManager.inputMgr;
        Player player = GameManager.player;
        public Item[] invenList = new Item[20]; //20칸짜리 가방. 앞으로 늘리려면 다른거로 바꿔야하나?

        string name = "인벤토리";
        string desc = "보유 중인 아이템을 관리할 수 있습니다.";        
        
        //인벤토리 목록 

        int low = 0;   //변수화 가능
        int high = 1;

        void test()
        {
            
            
        }

        public void Print()
        {
            printMgr.MenuName(name);
            printMgr.MenuDesc(desc);
            Console.WriteLine();
            Console.Write("[아이템 목록]"); Console.WriteLine("  소지금 : "+player.gold);
            Console.WriteLine();
            // 아이템 목록 출력
            printMgr.ItemList(invenList);
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("1. 장착 관리"); Console.Write("0. 돌아가기");
            Console.WriteLine();
            inputMgr.Select(low, high);
            Console.WriteLine();
            SwitchScene(inputMgr.input);
        }

        public void SwitchScene(int input)  // 다른 클래스로 분리가능
        {
            switch (input)
            {
                case 0:
                    // 돌아가기
                    GameManager.village.Print();
                    break;               
                case 1:
                    // 장착 관리

                    break;
                default:
                    break;
            }
        }
    }
}
