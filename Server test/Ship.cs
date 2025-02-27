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
        public ShipType shipType; // 함선 타입
        public Inventory inventory; // 인벤토리
        public List<Sailor> sailors; // 선원들
        // TODO: 기본 스킬 사용 구현하기
    }

    enum ShipType
    {
        // TODO: 함선 종류 추가하기
    }
}