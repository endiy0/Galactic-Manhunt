using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FeedBack : 합성 비율 이게 맞는건지요?

namespace Server_test
{
    internal class FuelSynthesis
    {
        Item return_fuel = null;
        ShipType shipType;

        // 엑실론 제외 연료 합성
        public FuelSynthesis(Item item1, Item item2, ShipType type)
        {
            shipType = type;

            // 근데 여기서 문제는 이 순서로 넘겨야함

            if (item1.GetItemType() == Resource.Nitrogen && item2.GetItemType() == Resource.Hydrogen)
            {
                return_fuel = new Item(Resource.Hydrazine, item1.mass);      // 일단 결합은 질량비 1:2
            }

            else if (item1.GetItemType() == Resource.Oxygen && item2.GetItemType() == Resource.Hydrogen)
            {
                return_fuel = new Item(Resource.Peroxide, item1.mass);       // 여기는 1:1
            }
        }
        
        // 엑실론 합성시
        public FuelSynthesis(Item item, ShipType type)
        {
            shipType = type;
        }
    }
}