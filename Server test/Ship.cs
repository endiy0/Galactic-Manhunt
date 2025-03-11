using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Server_test
{
    // 함선 클래스
    class Ship
    {
        public ShipType shipType;    // 함선 타입
        public Inventory inventory;  // 인벤토리
        public List<Sailor> sailors; // 선원들
        string Name;
        Random rand = new Random(Convert.ToInt16(DateTime.Now.Ticks % 10000));
        Array resources = Enum.GetValues(typeof(Resource));
        
        // 함선 종류별 역할 모음집
        delegate void Resource_Skill(ShipType type);
        delegate void Newbie_Skill(ShipType type);
        delegate void Sailor_Skill(ShipType type);
        delegate void Galaxy_Moving_Skill(ShipType type);
        delegate void Thief_Skill(ShipType type);


        public Ship(ShipType shipType)
        {
            this.shipType = shipType;
            
            if (shipType == ShipType.newbie_ship)
                Name = "초급자 전용 함선";

            else if (shipType == ShipType.Resource_ship)
                Name = "자원 함선";

            else if (shipType == ShipType.sailor_ship)
                Name = "선원 함선";

            else if (shipType == ShipType.galaxy_moving_ship)
                Name = "초은하 이동 함선";

            else if (shipType == ShipType.thief_ship)
                Name = "도적 함선";
        }

        public ShipType GetShipType()
        {
            return shipType;
        }

        public string GetShipName()
        {
            return Name;
        }

        // 자원 함선 매턴 자원 주는 함수
        // 매개 변수는 함선 종류 분별하기 위해 사용
        // 나중에 delegate 넣으면 필요 없을 수도
        public Item Resource_Give(ShipType type)
        {
            if (type != ShipType.Resource_ship)
            {
                return null;
            }
            Item items;
            int mass = rand.Next(1000, 3000); // 랜덤으로 자원량 줄 것
            int index = rand.Next(0, 12); // 랜덤 자원 
            Resource resource = (Resource)index;    // 여기 틀린거 같으면 다시 구현해주세요.
            items = new Item(resource, mass);
            return items;
        }

        // 자원 증가율 -> 매턴 랜덤으로
        public double Resource_Increased(ShipType type)
        {
            if (type != ShipType.Resource_ship)
            {
                return 1;   // 다른 타입이면 그냥 원래대로
            }
            double Increased = rand.Next(20, 50);
            return Increased;
        }

        // Todo : 자원 함선 이외 4가지 함선들 구현
        // FeedBack
        // 1. 자원 증가율 매번 랜덤으로 할건지, 랜덤으로 할거면 저정도 수치가 괜찮을지
        // 2. Resource_Give에서 저게 return이 잘 될지를 모르겠어요.



        // 초보자용 함선 처음에 아이템 주기

        public List<Item> Newbie_Resource(ShipType type)
        {
            // 초기에 주는 자원량 상수로 만들어 놓기 -> 불편하면 위로 빼도 되고

            const double chrono = 10000;
            const double seed = 10;
            const double food = 500;
            const double water = 500;
            const double epsilon = 500;
            const double hydrazine = 500;
            const double peroxide = 500;
            const double hydrogen = 500;
            const double nitrogen = 500;
            const double oxygen = 500;
            const double epsilon_crystal = 500;


            List<Item> items = new List<Item>();

            if (type != ShipType.newbie_ship) return items;         // 맞는 종류인지 확인

            items.Add(new Item(Resource.Chrono, chrono));
            items.Add(new Item(Resource.Water, water));
            items.Add(new Item(Resource.Epsilon, epsilon));
            items.Add(new Item(Resource.Seed, seed));
            items.Add(new Item(Resource.Hydrazine, hydrazine));
            items.Add(new Item(Resource.Hydrogen, hydrogen));
            items.Add(new Item(Resource.Nitrogen, nitrogen));
            items.Add(new Item(Resource.Peroxide, peroxide));
            items.Add(new Item(Resource.Epsilon_crystal, epsilon_crystal));
            items.Add(new Item(Resource.Oxygen, oxygen));
            items.Add(new Item(Resource.Food, food));

            return items;
        }

        // 선원 함선

        // 매턴 선원 식량 주는거 - 20턴 동안
        public List<Item> Sailor_Resource(ShipType type)
        {

            List<Item> items = new List<Item>();

            if (type != ShipType.sailor_ship) return items;     // 맞는 종류인지 확인

            items.Add(new Item(Resource.Food, 3));
            items.Add(new Item(Resource.Water, 2));
            return items;
        }

        // 처음에 선원 3명 주는 함수

        
        public List<Sailor> Sailor_Give(ShipType type)
        {
            List<Sailor>sailors = new List<Sailor>();

            for (int i = 0; i < 3; i++)
            {
                sailors.Add(new Sailor(SailorType.Normal, 1, 140));
            }

            return sailors;
        }

        // TODO : 선원 주는 함선 함수 좀만 더 ㄱㄱ
    }

    // 함선 타입
    enum ShipType
    {
        none,               // 선택되지 않음
        newbie_ship,        // 초급자 전용 함선
        Resource_ship,      // 자원 함선
        sailor_ship,        // 선원 함선
        galaxy_moving_ship, // 초은하 이동 함선
        thief_ship          // 도적 함선
    }
}