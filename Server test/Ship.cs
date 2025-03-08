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
        public Ship(ShipType shipType)
        {

            this.shipType = shipType;
            
            if (shipType == ShipType.newbie_ship)
                Name = "초급자 전용 함선";

            else if (shipType == ShipType.ShipType_ship)
                Name = "자원 함선";

            else if (shipType == ShipType.sailor_ship)
                Name = "선원 함선";

            else if (shipType == ShipType.galaxy_moving_ship)
                Name = "초 은하 이동 함선";

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
    }
        // TODO: 기본 스킬 사용 구현하기

    // 함선 타입
    enum ShipType
    {
        newbie_ship,             // 초급자 전용 함선
        ShipType_ship,           // 자원 함선
        sailor_ship,             // 선원 함선
        galaxy_moving_ship,      // 초 은하 이동 함선
        thief_ship               // 도적 함선
    }
}