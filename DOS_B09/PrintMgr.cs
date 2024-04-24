using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    class PrintMgr
    {
        //public static PrintMgr instance { get; private set; }

        string fmt = "{,}";
        
        public void MenuName(string menuName)
        {
            Console.WriteLine(menuName);
        }

        public void MenuDesc(string menuDesc)
        {
            Console.WriteLine(menuDesc);
        }

        public void MenuList(string[] menuList)
        {
            int i = 0;
            foreach (var menu in menuList)
            {                
                Console.WriteLine("{0}. {1}",i++, menu);
            }
        }


    }
}
