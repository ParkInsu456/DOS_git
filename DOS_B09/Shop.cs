﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DOS_B09
{
    internal class Shop
    {
        PrintMgr printMgr = GameManager.printMgr;
        InputMgr inputMgr = GameManager.inputMgr;
        Player player = GameManager.player;
        Item item = GameManager.item;
        public ShopBuy shopBuy;
        
        public Item[] itemList; // 상품목록. 초기화는 Village클래스에서 실행함.


        string name = "상점";
        string desc = "필요한 아이템을 얻을 수 있는 상점입니다.";
           

        int low = 0;   //변수화 가능
        int high = 1;

        
        public void Print()
        {
            printMgr.MenuName(name);
            printMgr.MenuDesc(desc);
            Console.WriteLine();
            Console.WriteLine("[보유 골드]"); 
            Console.WriteLine(player.gold + " G");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");  //스트링 xxx로 저장 및 반복사용 강의에있음. 찾아보기
            // 아이템 목록 출력
            printMgr.ItemList(itemList);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("1. 아이템 구매"); 
            Console.WriteLine("0. 돌아가기");
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
                    // 아이템 구매
                    shopBuy.Print();
                    break;
                default:
                    break;
            }
        }
    }
}
