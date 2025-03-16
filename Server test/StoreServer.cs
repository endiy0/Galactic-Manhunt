using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 상점 클래스
    class StoreServer
    {
        StoreType storeType;

        // TODO: 물건 정보, 아이템 정보

        const int MaxFood = 10000000; // 물과 음식 상점 수용 용량
        const int MaxSeed = 1000000;  // 씨앗 상점 최대 수용 용량
        
        // 1kg 기준 가격
        const double food_cost = 600;
        const double water_cost = 100;
        const double seed_cost = 400;

        const double storage_cost = 16000;

        const double sailor_cost = 2000;
        const double advanced_cost = 3000;
        const double team_Identify = 1000;

        // 스킬 가격은 아래 바로바로 구현함 - 저장소 제외

        Dictionary<Ability, double> abilities; // 상점 종류당 판매하는 능력
        Dictionary<Item, double> items;// 상점 종류당 판매하는 아이템
        Dictionary<Sailor, double> sailors;    // 인력사무소에서 판매하는 선원들

        public StoreServer(StoreType store) // 일단 상점 종류만 받기 - 수정할거면 ㄱㄱ
        {
            storeType = store;
            Random rand = new Random(Convert.ToInt16(DateTime.Now.Ticks % 10000));

            if (storeType == StoreType.Sailor_store) // 인력사무소
            {
                sailors.Add(new Sailor(SailorType.Normal, 1, 140), sailor_cost);     // 선원
                sailors.Add(new Sailor(SailorType.Advanced, 1, 200), advanced_cost); // 고급 선원
            }

            else
            {
                double multiply = 1; // 가격 변동 변수, 공용 상점은 그대로

                if (storeType == StoreType.Cops_store) // 경찰 상점
                {
                    multiply = 0.8; // 가격 0.8배, 경찰은 시세보다 싸게
                    
                    // 경찰만 있는 능력
                    abilities.Add(new Ability(AbilityType.dark_under_the_lamp), 10000); // 등잔 밑이 어둡다
                    abilities.Add(new Ability(AbilityType.galaxy_travel), 50000);       // 은하 탐방
                    abilities.Add(new Ability(AbilityType.planet_travel), 12000);       // 행성 탐방
                    abilities.Add(new Ability(AbilityType.handcuff), 2000);             // 수갑
                }

                else if (storeType == StoreType.Black_market) // 암시장
                {
                    int luck = rand.Next(20, 141); // 암시장 랜덤 능력 저하 or 능력 상승 변수

                    multiply = 1.2;   // 가격 1.2배 // 도둑은 시세보다 비싸게

                    // 도둑만 있는 능력
                    abilities.Add(new Ability(AbilityType.get_fuel), 5000);         // 겟 퓨얼
                    abilities.Add(new Ability(AbilityType.fuel_compressor), 10000); // 연료 압축기
                    abilities.Add(new Ability(AbilityType.fuel_changer), 5000);     // 연료 교환권
                    abilities.Add(new Ability(AbilityType.stun_remover), 5000);     // 스턴 제거기
                }

                // 공용 상점은 그대로 multiply = 1, 경찰은 0.8, 도둑은 1.2
                // 나머지 아이템 한 번에 처리
                items.Add(new Item(Resource.Food, MaxFood),600 * multiply);   // 음식
                items.Add(new Item(Resource.Water, MaxFood), 100 * multiply); // 물
                items.Add(new Item(Resource.Seed, MaxSeed), 400 * multiply);   // 씨앗

                abilities.Add(new Ability(AbilityType.team_identify),team_Identify *multiply);
                abilities.Add(new Ability(AbilityType.store_growth), storage_cost * multiply); // 저장량 증가
            }
        }

        public int Exchange_place(Resource Re, int count) // 판매 자원 종류, 판매 자원 kg - 소수점 사용 불가
        {

            // 반환한거는 개인 크로노 추가

            if (Re == Resource.Oxygen) // 산소
            {
                return count * 100;
            }

            if (Re == Resource.Hydrogen) // 수소
            {
                return count * 400;
            }

            if (Re == Resource.Nitrogen) // 질소
            {
                return count * 120;
            }

            if (Re == Resource.Epsilon_crystal) // 엑실론 크리스탈
            {
                return count * 1000;
            }

            return 0;
        }

        // 상점 타입 반환
        public StoreType tp
        {
            get { return storeType; }
        }
    }

    // 상점 타입
    enum StoreType
    {
        Cops_store,
        Black_market,
        Sailor_store,
        Public_store
    }
}