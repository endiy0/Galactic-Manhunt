using System;
using System.Collections.Generic;
using System.Linq;
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

        public ShipType GetshipType()
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
            double Increased = rand.NextDouble();
            return Increased * 30;        // 0 ~ 30 사이의 정수
        }

        // Todo : 자원 함선 이외 4가지 함선들 구현
        // FeedBack
        // 1. 자원 증가율 매번 랜덤으로 할건지, 랜덤으로 할거면 저정도 수치가 괜찮을지
        // 2. Resource_Give에서 저게 return이 잘 될지를 모르겠어요.
    }

    // 함선 타입
    enum ShipType
    {
        newbie_ship,        // 초급자 전용 함선
        Resource_ship,      // 자원 함선
        sailor_ship,        // 선원 함선
        galaxy_moving_ship, // 초은하 이동 함선
        thief_ship          // 도적 함선
    }
}