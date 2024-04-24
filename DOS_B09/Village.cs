using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    internal class Village
    {

       protected string name;
       protected string desc;
       protected string desc2;
       protected string[] selMenu;
        protected int low;  // 선택제한 low 이상
        protected int high; // 선택제한 low 이하

        public virtual void Print()
        { }
        
    }

    class Sparta : Village
    {
        PrintMgr printMgr = new PrintMgr();
        InputMgr inputMgr = new InputMgr();
        Shop shop = new Shop();

        public Sparta()
        {
            name = "스파르타 마을";
            desc = "스파르타 마을에 오신 여러분 환영합니다.";
            desc2 = "이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.";
            selMenu = new[] { "상태 보기", "인벤토리", "상점" };
            low = 0;    //변수화 가능
            high = 2;
            
        }

        public override void Print()
        {
            printMgr.MenuName(name);
            printMgr.MenuDesc(desc);
            printMgr.MenuDesc(desc2);
            Console.WriteLine();
            printMgr.MenuList(selMenu);
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
                    //상태 보기
                    GameManager.status.Print();
                    break;
                case 1:
                    //인벤토리
                    break;
                case 2:
                    //상점
                    shop.Print();
                    break;
                case 999:
                    // 돌아가기
                    break;
                default:
                    break;
            }
        }
    }
}
