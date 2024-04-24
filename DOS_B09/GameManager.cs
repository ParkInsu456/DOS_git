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
        public static Player player = new Warrior();
        public static Status status = new Status();
        public static Village village = new Sparta();
        

       

        public void Init()
        {

            village.Print();


            
        }
    }
}
