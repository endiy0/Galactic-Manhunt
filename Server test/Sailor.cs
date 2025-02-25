using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    //선원 클래스
    class Sailor
    {
        SailorType type; //선원 타입
        public double EatInDay; //식사량
        public bool isDisable; //행동 불능 상태: True:행동 불능, False:정상
        public Inventory inventory;
        public Sailor(SailorType T, double EatINDAY, double Maxinventory)
        {
            inventory = new Inventory(Maxinventory, 0);
            type = T;
            EatInDay = EatINDAY;
            isDisable = false;
        }
        public SailorType sailorType
        {
            get { return type; }
        }
    }
    enum SailorType
    {
        Normal,
        Advanced
    }
}
