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

        public void Status(Player player)
        {
            string fmt = "{0,-12}{1,-2}{2, 6}";
            //string fmt2 = ;

            Console.WriteLine(fmt,"Lv.", ":", player.level);
            Console.WriteLine(player.name +"   ( "+ player.job+" )");
            Console.WriteLine(fmt, "공격력", ":", player.fATK);
            Console.WriteLine(fmt, "방어력", ":", player.fDEF);
            Console.WriteLine(fmt, "체 력", ":", player.fHP);
            Console.WriteLine(fmt, "Gold", ":", player.gold);
        }
    }
}
