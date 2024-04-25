using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    internal class ShopBuy
    {
        PrintMgr printMgr = GameManager.printMgr;
        InputMgr inputMgr = GameManager.inputMgr;
        Player player = GameManager.player;        
        Item item = GameManager.item;
        public Item[] itemList; // 상품목록. 초기화는 Village클래스에서 실행함.
        public Item[] invenList = GameManager.inventory.invenList;
        public Inventory inventory = GameManager.inventory;
        public Shop shop;

        string name = "상점 - 아이템 구매";
        string desc = "필요한 아이템을 얻을 수 있는 상점입니다.";


        int low = 0;   //변수화 가능
        int high = 20;


        public void Print()
        {
            printMgr.MenuName(name);
            printMgr.MenuDesc(desc);
            Console.WriteLine();
            Console.WriteLine("[보유 골드]");
            Console.WriteLine(player.gold + " G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            // 아이템 목록 출력
            printMgr.BuyList(itemList);
            Console.WriteLine();

            Console.WriteLine();
            
            Console.WriteLine("999. 돌아가기");
            Console.WriteLine();
            
            inputMgr.Buy(low, high);
            if (inputMgr.input == 999) { SwitchScene(inputMgr.input);}
            if (itemList[inputMgr.input].isBuy == true) Console.WriteLine("이미 구매한 아이템입니다.");
            BuyItem(inputMgr.input);
            
            Console.WriteLine();
            
            Print();
        }
                     
        void BuyItem(int input)
        {
            // 재구매 막기
            if (input == 999 || itemList[input].isBuy == true)
                return;
            // 골드 체크
            if (player.gold >= itemList[input].price)
            {
                player.gold -= itemList[input].price;

                // 리스트[input]의 isBuy를 true로 바꾼다.
                itemList[input].isBuy = true;

                // 리스트[input]을 인벤토리에 Add한다
                for (int i = 0; i < invenList.Length; ++i)
                {
                    if (invenList[i] == null)
                    {
                        Item temp = new Item();
                        temp = itemList[input];
                        invenList[i] = temp;
                        break;
                    }
                }
                // isBuy가 true면 gold부분 출력을 구매완료 로 바꾼다.
                //PrintMgr에서 바꿈
                Console.WriteLine("구매를 완료했습니다.");
            }
            else
            {
                Console.WriteLine("소지금이 부족합니다.");
                inputMgr.Buy(low, high);
                BuyItem(inputMgr.input);
            }
        }

        public void SwitchScene(int input)  // 다른 클래스로 분리가능
        {
            switch (input)
            {
                case 999:
                    // 돌아가기 //원래는 상점으로 돌아가야 하는데 하는법을 모르겠음.
                    shop.Print();
                    break;
                default:
                    break;
            }
        }

    }
}
