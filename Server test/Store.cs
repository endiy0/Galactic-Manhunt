using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 상점 클래스
    class Store
    {
        StoreType storeType;

        // TODO: 물건 정보, 아이템 정보, 환전소 만들기

        const int MaxFood = 10000000;      // 물과 음식 상점 수용 용량
        const int MaxSeed = 1000000;        // 씨앗 상점 최대 수용 용량
        const int food_cost = 3000;         // 음식 값
        const int water_cost = 500;         // 물 가격
        const int seed_cost = 2000;         // 씨앗 가격

        const int sailor_cost = 2000;       // 일반 선원 가격
        const int advanced_cost = 3000;     // 고급 선원 가격

        // 스킬 가격은 아래 바로바로 구현함.

        List<(Ability, int)> abilities;     // 상점 종류당 판매하는 능력
        List<(Item,int)> items;             // 상점 종류당 판매하는 아이템
        List<(Sailor,int)> sailors;         // 인력사무소에서 판매하는 노예들

        public Store(StoreType store)           // 일단 상점 종류만 받기 - 수정할거면 ㄱㄱ
        {
            storeType = store;
            Random rand = new Random(Convert.ToInt16(DateTime.Now.Ticks % 10000));

            if (storeType == StoreType.Cops_store)    //경찰 상점
            {
                items.Add((new Item(Resource.Food,MaxFood),food_cost));         // 음식, 뒤에 가격은 5KG당 가격
                items.Add((new Item(Resource.Water, MaxFood),water_cost));      // 물, 뒤에 가격은 5KG당 가격
                items.Add((new Item(Resource.Seed, MaxSeed),seed_cost));        // 씨앗, 뒤에 가격은 5KG당 가격


                abilities.Add((new Ability(AbilityType.dark_under_the_lamp), 10000));       // 등잔 밑이 어둡다
                abilities.Add((new Ability(AbilityType.galaxy_travel), 50000));             // 은하 탐방
                abilities.Add((new Ability(AbilityType.planet_travel), 12000));             // 행성 탐방
                abilities.Add((new Ability(AbilityType.handcuffs), 2000));                  // 수갑
                abilities.Add((new Ability(AbilityType.store_growing), 16000));             // 저장량 증가



            }


            else if(storeType == StoreType.Slave_store)  // 인력사무소
            {
                sailors.Add((new Sailor(SailorType.Normal, 1, 140),sailor_cost));           // 선원
                sailors.Add((new Sailor(SailorType.Advanced, 1, 200),advanced_cost));       // 고급 선원
            }


            else if(storeType == StoreType.Black_market)  // 암시장
            {
                int luck = rand.Next(20, 141);      // 암시장 랜덤 능력 저하 or 능력 상승 변수

                items.Add((new Item(Resource.Food, MaxFood), food_cost));           // 음식, 뒤에 가격은 5KG당 가격
                items.Add((new Item(Resource.Water, MaxFood), water_cost));         // 물, 뒤에 가격은 5KG당 가격
                items.Add((new Item(Resource.Seed, MaxSeed), seed_cost));           // 씨앗, 뒤에 가격은 5KG당 가격

                abilities.Add((new Ability(AbilityType.get_fuel), 5000));               // 겟 퓨얼
                abilities.Add((new Ability(AbilityType.fuel_compressor), 10000));       // 연료 압축기  
                abilities.Add((new Ability(AbilityType.fuel_changing),5000));           // 연료 교환권
                abilities.Add((new Ability(AbilityType.stun_remover), 5000));           // 스턴 제거기
                abilities.Add((new Ability(AbilityType.store_growing), 16000));         // 저장량 증가


            }
        }
        

        
    }
    enum StoreType
    {
        Cops_store,
        Black_market,
        Slave_store,
    }
}