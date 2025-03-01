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

    enum WorkType
    {
        None,       // 없음
        Ship_Move,  // 함선 조종
        Farm_Work,  // 농사
        Mine_Work,  // 채집
        Item_Make,  // 아이템 사용
        Item_Use,   // 아이템 제작
        Store_Use   // 상점 이용
    }
}
