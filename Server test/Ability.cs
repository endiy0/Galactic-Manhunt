using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // Ability 클래스
    public class Ability
    {
        AbilityType type;
        string Name;

        public Ability(AbilityType ABILITYTYPE)
        {
            type = ABILITYTYPE;

            if (type == AbilityType.dark_under_the_lamp)
                Name = "등잔 밑이 어둡다";     

            else if (type == AbilityType.galaxy_travel)
                Name = "은하 탐방";         // work.cs 구현

            else if (type == AbilityType.planet_travel)
                Name = "행성 탐방";         // work.cs 구현

            else if (type == AbilityType.stun)
                Name = "스턴";

            else if (type == AbilityType.handcuff)
                Name = "수갑";

            else if (type == AbilityType.team_identify)
                Name = "팀 식별";          // work.cs 구현

            else if (type == AbilityType.get_fuel)
                Name = "겟 퓨얼";          // work.cs 구현

            else if (type == AbilityType.fuel_changer)
                Name = "연료 교환권";        // work.cs 구현

            else if (type == AbilityType.fuel_compressor)
                Name = "연료 압축기";        

            else if (type == AbilityType.stun_remover)
                Name = "스턴 제거기";        

            else if (type == AbilityType.store_growth)
                Name = "저장량 증가";        // work.cs 구현
        }

        public AbilityType GetAbilityType()
        {
            return type;
        }

        public string GetAbilityName()
        {
            return Name;
        }
    }

    public enum AbilityType
    {
        // 경찰
        dark_under_the_lamp,   // 등잔 밑이 어둡다
        galaxy_travel,         // 은하 탐방
        planet_travel,         // 행성 탐방
        stun,                  // 스턴
        handcuff,              // 수갑
        team_identify,         // 팀 식별

        // 도둑
        get_fuel,              // 겟 퓨얼
        fuel_changer,          // 연료 교환권
        fuel_compressor,       // 연료 압축기
        stun_remover,          // 스턴 제거기
                               
        // 공통
        store_growth           // 저장량 증가
    }
}