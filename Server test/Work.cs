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