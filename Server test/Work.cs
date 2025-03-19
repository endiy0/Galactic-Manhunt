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
        string name;
        public Work(WorkType workType)
        {
            type = workType;
            if (type == WorkType.shipControl)
                name = "함선 조종"; // complete

            else if (type == WorkType.farming)
                name = "농사";

            else if (type == WorkType.collection)
                name = "채집";

            else if(type == WorkType.itemUse)
                name = "아이템 사용"; // 90% complete - except 등잔밑이 어둡다

            else if(type == WorkType.itemSynthesis)
                name = "아이템 합성";

            else if(type == WorkType.store)
                name = "상점";

            else if (type == WorkType.none)
                name = "없음";
        }

        public WorkType GetWorkType()
        {
            return type;
        }

        public string GetWorkName()
        {
            return name;
        }

        // 함선 조종
        
        // 함선 다음 위치 반환
        public Vector2 ShipMoving(Planet planet)
        { 
            return planet.location;
        }

        public Vector2 ShipMoving(PlanetSystem system)
        {
            return system.Location;
            
        }

        public Vector2 ShipMoving(Galaxy galaxy)
        {
            return galaxy.Location;
        }

        // 퍼옥사이드하고 하이드라진 이용하는 행성계 간 이동
        double ReturnFuel(double fuel, Resource fuelType, Vector2 location, PlanetSystem system, int sale)
        {
            if (fuelType == Resource.epsilon)
            {
                return -1;
            }
            double distance = Math.Sqrt((location.y - system.Location.y) * (location.y - system.Location.y) 
                + (location.x - system.Location.y) * (location.x - system.Location.y));
            double fuels = fuel - distance * (fuelType == Resource.Peroxide ? 10.2 : 8) / (sale > 0 ? 4 : 20) * 4;
            if (fuels < 0)
            {
                return -1; // -1 이면 이동 못한다는 의미로 이해하고 못가게 하기
            }
            return fuels; // 아니면 이동하는거지
        }

        // 엑실론 사용하는 은하간 이동
        double ReturnFuel(double fuel, Resource fuelType, Vector2 location, Galaxy galaxy)
        {
            if (fuelType != Resource.epsilon)
            {
                return -1;
            }
            double distance = Math.Sqrt((location.y - galaxy.Location.y) * (location.y - galaxy.Location.y) 
                + (location.x - galaxy.Location.y) * (location.x - galaxy.Location.y));
            double fuels = fuel - distance * 4;
            if (fuels < 0)
            {
                return -1; // 똑같아요 위에하고
            }
            return fuels;
        }

        // 아이템 사용 == 능력 사용

        // 저장량 증가
        int UsingStorageGrowth(Ability ability)
        {
            if(ability.GetAbilityType() == AbilityType.storageGrowth)
            {
                return 4000;
            }
            return 0;
        }
        
        // 은하 탐방
        List<Vector2> UsingGalaxyMove(Ability ability)
        {
            if (ability.GetAbilityType() == AbilityType.galaxyTravel)
            {
                List<Vector2> locationList = new List<Vector2>();
                foreach (var robber in Server.robbers)
                {
                    locationList.Add(robber.galaxy.Location);
                }
                return locationList;
            }
            return null;
        }

        // 행성 탐방

       List<Vector2> UsingPlanetTravel(Ability ability)
        {
            List<Vector2> location_list = new List<Vector2>();
            if (ability.GetAbilityType() == AbilityType.planetTravel)
            {
                foreach(var robber in Server.robbers)
                {
                    location_list.Add(robber.advancedPlanetsystem.Location);
                }
                return location_list;
            }
            return location_list;
        }

        // 경찰 기본스킬 - 행성계 들어가면 도둑들 스턴        -- 얘는 그냥 움직일 때마다 사용하는거라서 매개변수 필요 x

        public void Stun_Robber(Vector2 location)
        {
            foreach(var robber in Server.robbers)
            {
                if(robber.planetSystem.Location == location)
                {
                    robber.isMoving = false;
                }
            }
        }

        // 팀 식별 - 전체 공용
        public List<Client.PlayerType> Team_Identify(PlanetSystem planetSystem)
        {
            List<Client.PlayerType> returnList= new List<Client.PlayerType>();
            foreach(var client in Server.clients)
            {
                if(planetSystem.Location == client.planetSystem.Location)
                {
                    returnList.Add(client.playerType);
                }
            }
            return returnList;
        }
        
        // 겟 퓨얼 - 도둑

        public Item GetFuel(Resource resource)
        {
            Random rand = new Random();
            Item returnItem = new Item(resource, rand.Next(20, 80));
            return returnItem;
        }

        // 연료 교환권 - 도둑

        // List에서 0번째는 본인이 요청한 연료, 1번째는 본인이 줄 연료 == 0 : 추가, 1 : 차감
        public List<Item> FuelChanged(Resource resource, double mass, Resource resource2, double mass2, string name)
        {
            List<Item> returnItem = new List<Item>();
            foreach(var robber in Server.robbers)
            {
                if (robber.Help_robber(resource, mass, name))
                {
                    returnItem.Add(new Item(resource, mass));
                    returnItem.Add(new Item(resource2, mass2));
                    robber.inventory.AddItem(new Item(resource2, mass2));
                    robber.inventory.AddItem(new Item(resource, -mass));
                    break;
                }
            }
            return returnItem;
        }

        // 수갑
        public void Handcuff(PlanetSystem planetSystem, Planet planet)
        {
            foreach (var robber in Server.robbers)
            {
                if (robber.planetSystem.Location == planetSystem.Location)
                {
                    if (robber.planet.location == planet.location)
                    {
                        //  잡힌 상태 - 감옥에 가둬놓는 형태
                        robber.galaxy = Server.prison.galaxy;
                        Server.prison.AddRobber();
                        if (Server.prison.IsFinish())
                        {
                            // TODO : 게임 끝내는 기능 추가
                        }
                    }
                }
            }
        }

        // 스턴 && 스턴 제거기
        public void Stun(Vector2 location)
        {
            foreach (var robber in Server.robbers)
            {
                if (robber.galaxy.Location == location)
                {
                    robber.isMoving = false;

                    // TODO : 게임 구현 후 2턴 만들어서 그거로 스턴 해제 하고 그러기
                }
            }
        }

        public void StunRemover(string nick)
        {
            foreach (var robber in Server.robbers)
            {
                if (robber.nickname == nick)
                {
                    robber.is_moving = true;
                }
            }
        }

        // 연료 압축기
        public int ReturnSaleFuel()
        {
            return 20;
        }
    }

    // 작업 타입
    enum WorkType
    {
        none,          // 없음
        shipControl,   // 함선 조종
        farming,       // 농사
        collection,    // 채집
        itemUse,       // 아이템 사용
        itemSynthesis, // 아이템 합성
        store          // 상점
    }
}