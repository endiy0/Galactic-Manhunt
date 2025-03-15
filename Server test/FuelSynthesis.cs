using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// FeedBack : 합성 비율 이게 맞는건지요?

namespace Server_test
{
    internal class FuelSynthesis
    {
        // 엑실론 제외 연료 합성

        List<Item>return_list = null;
        public FuelSynthesis(Item item1, Item item2, ShipType type)
        {
            Item return_fuel;

            // 근데 여기서 문제는 이 순서로 넘겨야함

            if (item1.GetItemType() == Resource.Nitrogen && item2.GetItemType() == Resource.Hydrogen)
            {
                return_fuel = new Item(Resource.Hydrazine, item1.mass);      // 일단 결합은 질량비 1:2
            }

            /*else if (item1.GetItemType() == Resource.Oxygen && item2.GetItemType() == Resource.Hydrogen)
            {
                return_fuel = new Item(Resource.Peroxide, item1.mass);       // 여기는 1:1
            }*/
            else
            {
                return_fuel = new Item(Resource.Peroxide, item1.mass);
            }

            return_list.Add(return_fuel);
        }
        
        // 엑실론 합성시
        public FuelSynthesis(Item item, ShipType type)
        {
            Item return_fuel;
            
            if(type == ShipType.galaxy_moving_ship)
            {
                return_fuel = new Item(Resource.Epsilon, item.mass / 3);
            }
            else
            {
                return_fuel = new Item(Resource.Epsilon, item.mass / 2);
            }

            return_list.Add(return_fuel);
        }

        public List<Item> Return_Fuel()
        {
            List<Item> list = return_list;
            return_list.Clear();         // 비워주기 매번 초기화해줘야 다른 사람 쓸때 오류 없어요
            return list;
        }

        // 합성 창 닫을 때 list 비워주는거
        public void Remove()
        {
            return_list.Clear();
        }
    }
}