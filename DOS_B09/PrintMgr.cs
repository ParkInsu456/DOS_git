using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    class PrintMgr
    {
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

        public void ItemList(Item[] itemList)
        {
            //for (int i = 0; i < itemList.Length; ++i)
            //{
            //    if (!(itemList[i] == null))
            //        Console.WriteLine($"{itemList[i].name}  | 공: +{itemList[i].atk} 방: +{itemList[i].def} | {itemList[i].desc}  | {itemList[i].price} G");                
            //}

          foreach (var menu in itemList)
          {
              if (!(menu == null))
                  Console.WriteLine($"{menu.name}  | 공: +{menu.atk} 방: +{menu.def} | {menu.desc}  | {menu.price} G");
              else break;
          }
        }
        public void BuyList(Item[] itemList)
        { 
            foreach (var menu in itemList)
            {
                if (!(menu == null))
                {
                    if(menu.isBuy)
                    {
                        Console.WriteLine($"- {menu.id} {menu.name}  | 공: +{menu.atk} 방: +{menu.def} | {menu.desc}  | 구매완료");
                    }
                    else
                    Console.WriteLine($"- {menu.id} {menu.name}  | 공: +{menu.atk} 방: +{menu.def} | {menu.desc}  | {menu.price} G");
                }
                else break;
            }
        }

        public void EquipList(Item[] itemList)
        {
            int i = 0;
            foreach (var menu in itemList)
            {
                if (!(menu == null))
                {
                    if (menu.isEquip)
                    {
                        Console.WriteLine($"- {i++} [E]{menu.name}  | 공: +{menu.atk} 방: +{menu.def} | {menu.desc}");
                    }
                    else
                        Console.WriteLine($"- {i++} {menu.name}  | 공: +{menu.atk} 방: +{menu.def} | {menu.desc}");
                }
                else break;
            }

        }


        public void Status(Player player)
        {
            string fmt = "{0,-12}{1,-2}{2, 6}";
            //string fmt2 = ;

            Console.WriteLine(fmt,"Lv.", ":", player.level);
            Console.WriteLine(player.name +"   ( "+ player.job+" )");

            if(player.fATKBuffer >0) { Console.WriteLine($"공격력 : "+ (player.fATK+ player.fATKBuffer) + "  (+"+player.fATKBuffer+")"); }
            else Console.WriteLine(fmt, "공격력", ":", player.fATK);

            if (player.fDEFBuffer > 0) { Console.WriteLine($"방어력 : " + (player.fDEF+ player.fDEFBuffer) + "  (+" + player.fDEFBuffer + ")"); }
            else Console.WriteLine(fmt, "방어력", ":", player.fDEF);

            Console.WriteLine(fmt, "체 력", ":", player.fHP);
            Console.WriteLine(fmt, "Gold", ":", player.gold);
        }
    }
}
