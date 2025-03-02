using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 채굴 행성 클래스
    class Planet
    {
        public Inventory resources;
        PlanetType type;
        static double HydrogenMax = 8;
        static double NitrogenMax = 28;
        static double OxygenMax = 32;
        static double EpsilonCrystalMax = 10;
        static double WaterMax = 18;
        static double SeedMax = 5;

        // TODO: Planet 생성자에 행성 타입에 따라 Resource 랜덤하게 넣어주는 알고리즘 짜기

        public Planet(PlanetType T) 
        {
            type = T;
            resources = new Inventory(1800, 0);
            Random random = new Random(Convert.ToInt16(DateTime.Now.Ticks % 10000));

            int AirCount = (T == PlanetType.Earth) ? random.Next(0, Item.AirCount + 1) : random.Next(Item.AirCount / 2, Item.AirCount + 1);

            int MineralCount = (T == PlanetType.Earth) ? random.Next(0, Item.MineralCount + 1) : 0;

            int OrganicMatterCount = (T == PlanetType.Earth) ? random.Next(0, Item.OrganicMatterCount + 1) : 0;

            for(int i = 0; i < AirCount; i++)
            {
                Resource resource = new Resource();
                resource = (Resource)random.Next(0, Item.AirCount);
                if(resource == Resource.Hydrogen)
                {
                    resources.AddItem(new Item(resource, HydrogenMax * random.NextDouble()));
                }
                else if (resource == Resource.Nitrogen)
                {
                    resources.AddItem(new Item(resource, NitrogenMax * random.NextDouble()));
                }
                else if (resource == Resource.Oxygen)
                {
                    resources.AddItem(new Item(resource, OxygenMax * random.NextDouble()));
                }
            }

            for (int i = 0; i < MineralCount; i++)
            {
                Resource resource = new Resource();
                resource = (Resource)random.Next(Item.AirCount + Item.CompountCount,
                                                 Item.AirCount + Item.CompountCount + Item.MineralCount);
                if (resource == Resource.Epsilon_crystal)
                {
                    resources.AddItem(new Item(resource, EpsilonCrystalMax * random.NextDouble()));
                }
                else if (resource == Resource.Water)
                {
                    resources.AddItem(new Item(resource, WaterMax * random.NextDouble()));
                }
            }

            for (int i = 0; i < OrganicMatterCount; i++)
            {
                Resource resource = new Resource();
                resource = (Resource)random.Next(Item.AirCount + Item.CompountCount + Item.MineralCount, 
                                                 Item.AirCount + Item.CompountCount + Item.MineralCount + Item.OrganicMatterCount);
                if (resource == Resource.Seed)
                {
                    resources.AddItem(new Item(resource, SeedMax * random.NextDouble()));
                }
            }
        }
    }

    // 행성 타입
    enum PlanetType
    {
        Earth,
        Jupitor
    }
}