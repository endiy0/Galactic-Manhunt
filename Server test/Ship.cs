using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 함선 클래스
    class Ship
    {
        public ShipType shipType;    // 함선 타입
        public Inventory inventory;  // 인벤토리
        public List<Sailor> sailors; // 선원들
        // TODO: 기본 스킬 사용 구현하기
    }

    // 함선 타입
    enum ShipType
    {
        newbie_ship,             // 초급자 전용 함선
        resource_ship,           // 자원 함선
        sailor_ship,             // 선원 함선
        galaxy_moving_ship,      // 초 은하 이동 함선
        thief_ship               // 도적 함선
    }
}