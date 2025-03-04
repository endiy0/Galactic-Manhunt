using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // Ability 클래스
    class Ability
    {
        AbilityType type;
        public Ability(AbilityType ABILITYTYPE)
        {
            type = ABILITYTYPE;

        }
    }

    enum AbilityType
    {
        // 경찰
        dark_under_the_lamp,   // 등잔 밑이 어둡다
        galaxy_travel,         // 은하 탐방
        planet_travel,         // 행성 탐방
        stun,                  // 스턴
        handcuff,             // 수갑
        team_identify,       // 팀 식별

        // 도둑                  
        get_fuel,              // 겟 퓨얼
        fuel_changer,         // 연료 교환권
        fuel_compressor,       // 연료 압축기
        stun_remover,          // 스턴 제거기
                               
        // 공통                  
        store_growth          // 저장량 증가
    }
}