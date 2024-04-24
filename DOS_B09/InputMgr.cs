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

        public void Select()
        {
            
            Console.WriteLine("원하시는 행동을 입력해주세요.");
            Console.Write(">>");
            while (true)
            {                
                bool exception = int.TryParse(Console.ReadLine(), out input);
                
                if (exception) break;
                else Console.WriteLine("잘못된 입력입니다");
            }
        }
    }
}
