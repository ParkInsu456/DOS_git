using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    internal class InputMgr
    {


        public int input;

        public void Select(int low, int high)
        {
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
            while (true)
            {                
                bool exception = int.TryParse(Console.ReadLine(), out input);
                if (!(low<= input && input <= high)) Console.WriteLine("잘못된 입력입니다");
                else break;                    
            }
        }

        public void Buy(int low, int high)
        {
            Console.WriteLine();
            Console.WriteLine("구매를 원하는 아이템번호를 입력해주세요.");
            Console.Write(">>");
            while (true)
            {
                bool exception = int.TryParse(Console.ReadLine(), out input);
                if (input == 999) break;
                else if (!(low <= input && input <= high)) Console.WriteLine("잘못된 입력입니다");
                else break;
            }
        }

    }
}
