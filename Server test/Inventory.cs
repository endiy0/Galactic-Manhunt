using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 인벤토리 클래스
    class Inventory
    {
        List<Item> items;                    // 아이템 저장 함수
        Dictionary<Ability, int> abilities;  // 능력 저장 함수
        double itemMax;                      // 아이템 최댓값, 단위: kg
        int abilityMax;                      // 능력 최댓값, 단위: 개

        public Inventory(double itemmax, int abilitymax) 
        {
            items = new List<Item>();
            abilities = new Dictionary<Ability, int>();
            itemMax = itemmax;
            abilityMax = abilitymax;
        }

        // 아이템 최대량 반환
        public double ItemMax
        {
            get { return itemMax; }
        }

        // 능력 최대량 반환
        public int AbilityMax
        { 
            get { return abilityMax; }
        }

        // 아이템 리스트 반환
        public List<Item> Items
        {
            get { return items; }
        }

        // 능력 리스트 반환
        public Dictionary<Ability, int> Abilities
        { 
            get { return abilities; } 
        }

        // 아이템 최대량 설정
        public void SetItemMax(double itemMAX)
        {
            itemMax = itemMAX;
        }

        // 능력 최대량 설정
        public void SetAbilityMax(int abilityMAX)
        {
            abilityMax = abilityMAX;
        }

        // 아이템 추가
        public void AddItem(Item item)
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.items[i].GetItemType() == item.GetItemType())
                {
                    this.items[i].mass += item.mass;
                    return;
                }
            }
            this.items.Add(item);
        }

        // 아이템 삭제
        public bool RemoveItem(Item item) // if문 사용해서 빠졌는지 안빠졌는지 꼭 체크해줘야함
        {
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (this.items[i].GetItemType() == item.GetItemType())
                {
                    if (this.items[i].mass - item.mass >= 0)
                    {
                        this.items[i].mass -= item.mass;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        // 아이템 초기화(전체 삭제)
        public void Clear()
        {
            items.Clear();
        }

        // 두 인벤토리 더하기
        public static Inventory operator +(Inventory inv, Item item)
        {
            for (int i = 0; i < inv.Items.Count; i++)
            {
                if (inv.items[i].GetItemType() == item.GetItemType())
                {
                    inv.items[i].mass += item.mass;
                    return inv;
                }
            }
            inv.items.Add(item);
            return inv;
        }
    }
}