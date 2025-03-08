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
            if(type == WorkType.Null)
            {

            }
            if(type == WorkType.Ship_Control)
            {

            }
            if(type == WorkType.Farming)
            {

            }
            if(type == WorkType.Collection)
            {

            }
            if(type == WorkType.Item_Use)
            {

            }
            if(type == WorkType.Item_Synthesis)
            {

            }
            if(type == WorkType.Store)
            {

            }
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