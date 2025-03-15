using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server_test
{
    class Work
    {
        WorkType type;
        string Name;
        public Work(WorkType WORKTYPE)
        {
            type = WORKTYPE;
            if(type == WorkType.Ship_Control)
                Name = "함선 조종";

            else if (type == WorkType.Farming)
                Name = "농사";

            else if (type == WorkType.Collection)
                Name = "채집";

            else if(type == WorkType.Item_Use)
                Name = "아이템 사용";

            else if(type == WorkType.Item_Synthesis)
                Name = "아이템 합성";

            else if(type == WorkType.Store)
                Name = "상점";

            else if (type == WorkType.Null)
                Name = "없음";
        }

        public WorkType GetWorkType()
        {
            return type;
        }

        public string GetWorkName()
        {
            return Name;
        }

        

        // 함선 조종
        
        // 함선 다음 위치 반환

        public Vector2 Ship_Moving(Planet planet)
        { 
            return planet.location;
        }

        public Vector2 Ship_Moving(PlanetSystem system)
        {
            return system.Location;
            
        }

        public Vector2 Ship_Moving(Galaxy galaxy)
        {
            return galaxy.Location;
        }

        // 퍼옥사이드하고 하이드라진 이용하는 행성계 간 이동
        double return_fuel(double fuel, Resource fuel_type, Vector2 location, PlanetSystem system)
        {
            if (fuel_type == Resource.Epsilon) return -1;
            double distance = Math.Sqrt((location.y - system.Location.y) * (location.y - system.Location.y) + (location.x - system.Location.y) * (location.x - system.Location.y));
            double fuels = fuel - distance * (fuel_type == Resource.Peroxide ? 10.2 : 8);
            if (fuels < 0) return -1;           // -1 이면 이동 못한다는 의미로 이해하고 못가게 하기
            return fuels;               // 아니면 이동하는거지
        }

        // 엑실론 사용하는 은하간 이동
        double return_fuel(double fuel, Resource fuel_type,Vector2 location, Galaxy galaxy)
        {
            if (fuel_type != Resource.Epsilon) return -1;
            double distance = Math.Sqrt((location.y - galaxy.Location.y) * (location.y - galaxy.Location.y) + (location.x - galaxy.Location.y) * (location.x - galaxy.Location.y));
            double fuels = fuel - distance * 4;
            if (fuels < 0) return -1;           // 똑같아요 위에하고
            return fuels;
        }



        // 아이템 사용 == 능력 사용

        int Using_ability(Ability ability)
        {
            if(ability.GetAbilityType() == AbilityType.store_growth)
            {
                return 4000;
            }

            else if(ability.GetAbilityType() == AbilityType.galaxy_travel)
            {
                
            }
            return 0;
        }
        

    }

    // 작업 타입
    enum WorkType
    {
        Null,           // 없음
        Ship_Control,   // 함선 조종
        Farming,        // 농사
        Collection,     // 채집
        Item_Use,       // 아이템 사용
        Item_Synthesis, // 아이템 합성
        Store           // 상점
    }
}