using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 선원 클래스
    class Sailor
    {
        SailorType type; // 선원 타입
        public double EatInDay; // 식사량
        public bool isDisable; // True: 행동 불능, False: 정상
        public Inventory inventory;
        public Work work;

        public Sailor(SailorType T, double EatINDAY, double Maxinventory, Work work)
        {
            inventory = new Inventory(Maxinventory, 0);
            type = T;
            EatInDay = EatINDAY;
            isDisable = false;
            this.work = work;
        }

        public SailorType sailorType
        {
            get { return type; }
        }
    }

    // 선원 타입
    enum SailorType
    {
        Normal,
        Advanced
    }
}