using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    class Inventory
    {
        public List<Item> items; //아이템 저장 함수
        public Dictionary<Ability, int> abilities; //능력 저장 함수
        double itemMax; //단위: kg, 아이템 최대
        int abilityMax; //단위: 개, 능력 최대

        public Inventory(double itemmax, int abilitymax) 
        {
            items = new List<Item>();
            abilities = new Dictionary<Ability, int>();
            itemMax = itemmax;
            abilityMax = abilitymax;
        }
        public double ItemMax
        {
            get { return itemMax; }
        }
        public int AbilityMax
        { 
            get { return abilityMax; }
        }
        public List<Item> Items
        {
            get { return items; }
        }
        public Dictionary<Ability, int> Abilities
        { 
            get { return abilities; } 
        }
        public void SetItemMax(double itemMAX)
        {
            itemMax = itemMAX;
        }
        public void SetAbilityMax(int abilityMAX)
        {
            abilityMax = abilityMAX;
        }
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
        public bool RemoveItem(Item item) //if문 사용해서 빠졌는지 안빠졌는지 꼭 체크해줘야함
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
        public void Clear()
        {
            items.Clear();
        }
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
