using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    internal class GameManager
    {
        public static InputMgr inputMgr = new InputMgr();
        public static PrintMgr printMgr = new PrintMgr();
        public static Item item = new Item();
        public static Player player = new Warrior();
        public static Inventory inventory = new Inventory();
        public static Inventory equip = new Equip();
        public static Status status = new Status();
        public static Village village = new Sparta();
        //public static Shop Shop = new Shop(); 상점은 마을마다 다를 수 있으니까 마을에서 생성
        
        
        

       

        public void Init()
        {
            item.Init();
            village.InitShop(); 
            village.Print();            
        }
    }
}
