using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 아이템 클래스
    public class Item
    {
        Resource Itemtype;
        string Name;
        public double mass; // 질량, 단위: kg
        public static int ResourceCount = 10;
        public static int AirCount = 3;
        public static int CompountCount = 4;
        public static int MineralCount = 2;
        public static int OrganicMatterCount = 1;

        public Item(Resource ITEMTYPE, double MASS)
        {
            Itemtype = ITEMTYPE;
            mass = MASS;
            if (Itemtype == Resource.Hydrogen)
                Name = "수소";

            else if (Itemtype == Resource.Nitrogen)
                Name = "질소";

            else if (Itemtype == Resource.Oxygen)
                Name = "산소";

            else if (Itemtype == Resource.Peroxide)
                Name = "퍼옥사이드";

            else if (Itemtype == Resource.Hydrazine)
                Name = "하이드라진";

            else if (Itemtype == Resource.Epsilon)
                Name = "엑실론";

            else if (Itemtype == Resource.Food)
                Name = "식량";

            else if (Itemtype == Resource.Epsilon_crystal)
                Name = "엑실론 크리스탈";

            else if (Itemtype == Resource.Water)
                Name = "물";

            else if (Itemtype == Resource.Seed)
                Name = "씨앗";

            else if (Itemtype == Resource.Chrono)
                Name = "크로노";
        }

        public Resource GetItemType()
        {
            return Itemtype;
        }

        public string GetItemName()
        {
            return Name;
        }
    }

    // 자원 종류
    // 자원 추가할때마다 Item의 전역변수 Count 수정하기
    public enum Resource
    {
        Hydrogen = 1,         // 수소
        Nitrogen = 2,         // 질소
        Oxygen = 3,           // 산소
        Epsilon_crystal = 4,  // 엑실론-크리스탈

        Peroxide = 5,         // 퍼옥사이드
        Hydrazine = 6,        // 하이드라진
        Epsilon = 7 ,          // 엑실론

        Water = 8,            // 물
        Food = 9,             // 식량

        Seed = 10,             // 씨앗
                             
        Chrono = 11            // 크로노
    }
}