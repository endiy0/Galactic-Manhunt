using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    class Work
    {
        WorkType type;
        public Work(WorkType WORKTYPE)
        {
            type = WORKTYPE;
        }
        // TODO: Wokr클래스에 부족한 것 있으면 보완하기
    }

    // 작업 타입
    enum WorkType
    {
        Null,           // 없음
        Ship_Move,      // 함선 조종
        Farming,        // 농사
        Collecting,     // 채집
        Item_Use,       // 아이템 사용
        Item_Synthesis, // 아이템 합성
        Store           // 상점
    }
}