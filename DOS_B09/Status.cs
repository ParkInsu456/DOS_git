using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    internal class Status
    {
        PrintMgr printMgr = GameManager.printMgr;
        InputMgr inputMgr = GameManager.inputMgr;
        Player player = GameManager.player;

        string name = "상태 보기";
        string desc = "캐릭터의 정보가 표시됩니다.";
           

        int low = 0;
        int high = 0;

        public void Print()
        {
            printMgr.MenuName(name);
            printMgr.MenuDesc(desc);
            Console.WriteLine();
            printMgr.Status(player);
            Console.WriteLine();
            Console.Write("0. 돌아가기");
            Console.WriteLine();
            inputMgr.Select(low, high);
            Console.WriteLine();
            SwitchScene(inputMgr.input);
        }
        public void SwitchScene(int input)  // 다른 클래스로 분리가능
        {
            switch (input)
            {
                case 0: //돌아가기
                    GameManager.village.Print();
                    break;
               
                default:
                    break;
            }
        }
    }
}
