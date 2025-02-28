using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 아이템 클래스
    class Item
    {
        Resource Itemtype;
        string Name;
        public double mass; // 질량, 단위: kg

        // TODO: Resource종류를 바꿀때마다 이름도 바꾸는 생성자 구현

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
    enum Resource
    {
        Hydrogen,         // 수소
        Nitrogen,         // 질소
        Oxygen,           // 산소
        Peroxide,         // 퍼옥사이드
        Hydrazine,        // 하이드라진
        Epsilon,          // 엑실론
        Epsilon_crystal,  // 엑실론-크리스탈
                             
        Seed,             // 씨앗
        Water,            // 물
                             
        Chrono            // 크로노
    }
}