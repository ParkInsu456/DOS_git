using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOS_B09
{
    public class Item
    {
        public Item[] arr;

        public int id;
        public string name;
        public float atk;
        public float def;
        public string desc;
        public int price;
        public bool isBuy = false;
        protected bool isOpen = true;
        

        public void Init()
        {
            arr = new Item[20]; // []안 숫자를 동적으로 하거나 변수로 할당하는법 없을까?

            arr[0] = new Item();
            arr[0].id = 0;
            arr[0].name = "가죽 갑옷";
            arr[0].atk = 0;
            arr[0].def = 5;
            arr[0].desc = "초보자들이 입는 갑옷";
            arr[0].price = 1000;

            arr[1] = new Item();
            arr[1].id = 1;
            arr[1].name = "철 갑옷";
            arr[1].atk = 0;
            arr[1].def = 10;
            arr[1].desc = "철로 만든 갑옷";
            arr[1].price = 2000;
            
            arr[2] = new Item();
            arr[2].id = 2;
            arr[2].name = "스파르타 갑옷";
            arr[2].atk = 0;
            arr[2].def = 20;
            arr[2].desc = "스파르탄이 입는 갑옷";
            arr[2].price = 4000;
            
            arr[3] = new Item();
            arr[3].id = 3;
            arr[3].name = "황동 갑옷";
            arr[3].atk = 0;
            arr[3].def = 15;
            arr[3].desc = "황동으로 만들어진 튼튼한 갑옷";
            arr[3].price = 3000;
            
            arr[4] = new Item();
            arr[4].id = 4;
            arr[4].name = "흑요석 갑옷";
            arr[4].atk = 0;
            arr[4].def = 25;
            arr[4].desc = "강력한 흑요석 갑옷";
            arr[4].price = 5000;
            
            arr[5] = new Item();
            arr[5].id = 5;
            arr[5].name = "용갑옷";
            arr[5].atk = 5;
            arr[5].def = 30;
            arr[5].desc = "강력한 용의 가죽으로 만들어진 갑옷";
            arr[5].price = 7000;
            

            arr[6] = new Item();
            arr[6].id = 6;
            arr[6].name = "나무 검";
            arr[6].atk = 5;
            arr[6].def = 0; 
            arr[6].desc = "나무로 만들어진 초보자를 위한 검";
            arr[6].price = 500;
            
            arr[7] = new Item();
            arr[7].id = 7;
            arr[7].name = "철검";
            arr[7].atk = 10;
            arr[7].def = 0; 
            arr[7].desc = "철로 만들어진 강력한 검";
            arr[7].price = 1500;
            
            arr[8] = new Item();
            arr[8].id = 8;
            arr[8].name = "마법 지팡이";
            arr[8].atk = 15;
            arr[8].def = 0; 
            arr[8].desc = "강력한 마법을 사용하는 지팡이";
            arr[8].price = 2500;
            
            arr[9] = new Item();
            arr[9].id = 9;
            arr[9].name = "스파르탄 검";
            arr[9].atk = 20;
            arr[9].def = 0; 
            arr[9].desc = "전설적인 스파르타 전사의 검";
            arr[9].price = 4000;
            
            arr[10] = new Item();
            arr[10].id = 10;
            arr[10].name = "용의 검";
            arr[10].atk = 25;
            arr[10].def = 2; 
            arr[10].desc = "용의 힘을 지닌 검";
            arr[10].price = 7000;
        }
    }

    
}
