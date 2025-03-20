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

        List<Item> returnList = null;
        public FuelSynthesis(Item item1, Item item2, ShipType type)
        {
            Item returnFuel;

            // 근데 여기서 문제는 이 순서로 넘겨야함

            if (item1.GetItemType() == Resource.nitrogen && item2.GetItemType() == Resource.hydrogen)
            {
                returnFuel = new Item(Resource.hydrazine, item1.mass);      // 일단 결합은 질량비 1:2
            }

            /*else if (item1.GetItemType() == Resource.Oxygen && item2.GetItemType() == Resource.Hydrogen)
            {
                returnFuel = new Item(Resource.Peroxide, item1.mass);       // 여기는 1:1
            }*/
            else
            {
                returnFuel = new Item(Resource.peroxide, item1.mass);
            }

            returnList.Add(returnFuel);
        }
        
        // 엑실론 합성시
        public FuelSynthesis(Item item, ShipType type)
        {
            Item returnFuel;
            
            if(type == ShipType.galaxyTravelingShip && item.GetItemType() == Resource.epsilonCrystal)
            {
                returnFuel = new Item(Resource.epsilon, item.mass / 3);
            }
            else
            {
                returnFuel = new Item(Resource.epsilon, item.mass / 2);
            }

            returnList.Add(returnFuel);
        }

        // 얘네 필요 없을거 같은 느낌

        public List<Item> ReturnFuel()
        {
            List<Item> list = returnList;
            returnList.Clear();         // 비워주기 매번 초기화해줘야 다른 사람 쓸때 오류 없어요
            return list;
        }

        // 합성 창 닫을 때 list 비워주는거
        public void Remove()
        {
            returnList.Clear();
        }
    }
}