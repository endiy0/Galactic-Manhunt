using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Security.Policy;
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
                Name = "함선 조종";             // complete

            else if (type == WorkType.Farming)
                Name = "농사";

            else if (type == WorkType.Collection)
                Name = "채집";

            else if(type == WorkType.Item_Use)
                Name = "아이템 사용";            // 90% complete - except 등잔밑이 어둡다

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
        double return_fuel(double fuel, Resource fuel_type, Vector2 location, PlanetSystem system, int sale)
        {
            if (fuel_type == Resource.Epsilon) return -1;
            double distance = Math.Sqrt((location.y - system.Location.y) * (location.y - system.Location.y) + (location.x - system.Location.y) * (location.x - system.Location.y));
            double fuels = fuel - distance * (fuel_type == Resource.Peroxide ? 10.2 : 8) / (sale > 0 ? 4 : 20) * 4;
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

        // 저장량 증가

        int Using_Store_Growth(Ability ability)
        {
            if(ability.GetAbilityType() == AbilityType.store_growth)
            {
                return 4000;
            }
            return 0;
        }
        
        // 은하 탐방
        List<Vector2>Using_Galaxy_Moving(Ability ability)
        {
            if (ability.GetAbilityType() == AbilityType.galaxy_travel)
            {
                List<Vector2> location_list = new List<Vector2>();
                foreach (var robber in Server.robbers)
                {
                    location_list.Add(robber.galaxy.Location);
                }
                return location_list;
            }
            return null;
        }

        // 행성 탐방

       List<Vector2>Using_Planet_Travel(Ability ability)
        {
            List<Vector2> location_list = new List<Vector2>();
            if (ability.GetAbilityType() == AbilityType.planet_travel)
            {
                
                foreach(var robber in Server.robbers)
                {
                    location_list.Add(robber.advanced_planetsystem.Location);
                }
                return location_list;
            }
            return location_list;
        }

        // 경찰 기본스킬 - 행성계 들어가면 도둑들 스턴        -- 얘는 그냥 움직일 때마다 사용하는거라서 매개변수 필요 x

        public void Stun_Robber(Vector2 Location)
        {
            foreach(var robber in Server.robbers)
            {
                if(robber.planetSystem.Location == Location)
                {
                    robber.is_moving = false;
                }
            }
        }

        // 팀 식별 - 전체 공용

        public List<Client.PlayerType> Team_Identify(PlanetSystem planetSystem)
        {
            List<Client.PlayerType> return_list= new List<Client.PlayerType>();
            foreach(var client in Server.clients)
            {
                if(planetSystem.Location == client.planetSystem.Location)
                {
                    return_list.Add(client.playerType);
                }
            }
            return return_list;
        }
        
        // 겟 퓨얼 - 도둑

        public Item Get_Fuel(Resource resource)
        {
            Random rand = new Random();
            Item return_item = new Item(resource, rand.Next(20, 80));
            return return_item;
        }

        // 연료 교환권 - 도둑

        // List에서 0번째는 본인이 요청한 연료, 1번째는 본인이 줄 연료 == 0 : 추가, 1 : 차감

        public List<Item> Fuel_Changed(Resource resource, double mass, Resource resource2, double mass2, string name)
        {
            List<Item> return_item = new List<Item>();
            foreach(var robber in Server.robbers)
            {
                if (robber.Help_robber(resource, mass, name))
                {
                    return_item.Add(new Item(resource, mass));
                    return_item.Add(new Item(resource2, mass2));
                    robber.inventory.AddItem(new Item(resource2, mass2));
                    robber.inventory.AddItem(new Item(resource, -mass));
                    break;
                }
                
            }
            return return_item;
            
        }

        // 수갑

        public void HandCuff(PlanetSystem planetSystem, Planet planet)
        {
            foreach(var robber in Server.robbers)
            {
                if(robber.planetSystem.Location == planetSystem.Location)
                {
                    if(robber.planet.location == planet.location)
                    {
                        //  잡힌 상태 - 감옥에 가둬놓는 형태
                        robber.galaxy = Server.prison.galaxy;
                        Server.prison.Add_Robber();
                        if (Server.prison.Is_Finish())
                        {
                            // TODO : 게임 끝내는 기능 추가
                        }
                    }
                }
            }
        }

        // 스턴 && 스턴 제거기

        public void Stun(Vector2 Location)
        {
            foreach(var robber in Server.robbers)
            {
                if(robber.galaxy.Location == Location)
                {
                    robber.is_moving = false;

                    // TODO : 게임 구현 후 2턴 만들어서 그거로 스턴 해제 하고 그러기
                }
            }
        }

        public void Stun_Remover(string nick)
        {
            foreach(var robber in Server.robbers)
            {
                if(robber.nickname == nick)
                {
                    robber.is_moving = true;
                }
            }
        }

        // 연료 압축기

        public int Return_Sale_Fuel()
        {
            return 20;
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