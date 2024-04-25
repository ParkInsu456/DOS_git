using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    internal class Inventory
    {
        protected PrintMgr printMgr = new PrintMgr();
        protected InputMgr inputMgr = new InputMgr();
        protected Player player = GameManager.player;
        public Item[] invenList = new Item[20]; //20칸짜리 가방. 앞으로 늘리려면 다른거로 바꿔야하나?        

        string name = "인벤토리";
        protected string desc = "보유 중인 아이템을 관리할 수 있습니다.";        
        
        //인벤토리 목록 

        int low = 0;   //변수화 가능
        int high = 1;

        void test()
        {
            
            
        }

        public virtual void Print()
        {
            printMgr.MenuName(name);
            printMgr.MenuDesc(desc);
            Console.WriteLine();
            Console.Write("[아이템 목록]"); Console.WriteLine("  소지금 : "+player.gold);
            Console.WriteLine();
            // 아이템 목록 출력
            printMgr.EquipList(invenList);
            Console.WriteLine();

            Console.WriteLine("1. 장착 관리");
            Console.WriteLine("0. 돌아가기");            
            inputMgr.Select(low, high);
            Console.WriteLine();
            SwitchScene(inputMgr.input);
        }


        // 인벤토리 정렬


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
                    GameManager.equip.Print();
                    break;
                default:
                    break;
            }
        }
    }

    class Equip : Inventory
    {
        Item[] einvenList = GameManager.inventory.invenList;

        string name = "인벤토리 - 장착 관리";

        int low = 0;   //변수화 가능
        int high = 20;



        public void Gethigh()
        {
            int highidx =0 ;
            for (int i = 0; i < einvenList.Length; ++i)
            {
                if (einvenList[i] == null)
                {
                    highidx = i-1;
                    break;
                }
            }
            high = highidx;
        }
        public override void Print()
        {
            printMgr.MenuName(name);
            printMgr.MenuDesc(base.desc);
            Console.WriteLine();            
            Console.WriteLine("[아이템 목록]");
            // 아이템 목록 출력
            printMgr.EquipList(einvenList);
            Console.WriteLine();

            Console.WriteLine();

            Console.WriteLine("999. 돌아가기");
            Console.WriteLine();
            Gethigh();
            inputMgr.Equip(low, high);
            if (inputMgr.input == 999) { SwitchScene(inputMgr.input); }
            EquipItem(inputMgr.input);

            Console.WriteLine();

            Print();
        }

        void EquipItem(int input)
        {

            if (!einvenList[input].isEquip)
            {
                einvenList[input].isEquip = true;
                //장비의 스테이터스를 스탯에 반영한다.
                // 버퍼에 값을 더하자 , 출력 수정
                player.fATKBuffer += einvenList[input].atk;
                player.fDEFBuffer += einvenList[input].def;

                // 이름 앞 출력에 [E]를 붙인다
                //PrintMgr에서 바꿈
            }
            // 장비한 번호를 재입력하면 해제한다.
            else
            {
                einvenList[input].isEquip = false;
                player.fATKBuffer -= einvenList[input].atk;
                player.fDEFBuffer -= einvenList[input].def;
            }
        }
        public void SwitchScene(int input)  // 다른 클래스로 분리가능
        {
            switch (input)
            {
                case 999:
                    // 돌아가기 
                    base.Print();
                    break;
                default:
                    break;
            }
        }
    }
}
