using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 채굴 행성 클래스
    public class Planet
    {
        public Vector2 location;
        public Inventory resources;
        public PlanetType type;
        static double hydrogenMax = 8;
        static double nitrogenMax = 28;
        static double oxygenMax = 32;
        static double epsilonCrystalMax = 10;
        static double waterMax = 18;
        static double seedMax = 5;

        public Planet(PlanetType T, double xx, double yy) 
        {
            type = T;
            resources = new Inventory(1800, 0);
            location = new Vector2(xx, yy);
            Random random = new Random(Convert.ToInt16(DateTime.Now.Ticks % 10000));

            int airCount = (T == PlanetType.earth) ? random.Next(0, Item.airCount + 1) : random.Next(Item.airCount / 2, Item.airCount + 1);

            int mineralCount = (T == PlanetType.earth) ? random.Next(0, Item.mineralCount + 1) : 0;

            int organicMatterCount = (T == PlanetType.earth) ? random.Next(0, Item.organicMatterCount + 1) : 0;

            for(int i = 0; i < airCount; i++)
            {
                Resource resource = new Resource();
                resource = (Resource)random.Next(0, Item.airCount);
                if (resource == Resource.hydrogen)
                {
                    resources.AddItem(new Item(resource, hydrogenMax * random.NextDouble()));
                }
                else if (resource == Resource.nitrogen)
                {
                    resources.AddItem(new Item(resource, nitrogenMax * random.NextDouble()));
                }
                else if (resource == Resource.oxygen)
                {
                    resources.AddItem(new Item(resource, oxygenMax * random.NextDouble()));
                }
            }

            for (int i = 0; i < mineralCount; i++)
            {
                Resource resource = new Resource();
                resource = (Resource)random.Next(Item.airCount + Item.compountCount,
                                                 Item.airCount + Item.compountCount + Item.mineralCount);
                if (resource == Resource.epsilonCrystal)
                {
                    resources.AddItem(new Item(resource, epsilonCrystalMax * random.NextDouble()));
                }
                else if (resource == Resource.water)
                {
                    resources.AddItem(new Item(resource, waterMax * random.NextDouble()));
                }
            }

            for (int i = 0; i < organicMatterCount; i++)
            {
                Resource resource = new Resource();
                resource = (Resource)random.Next(Item.airCount + Item.compountCount + Item.mineralCount, 
                                                 Item.airCount + Item.compountCount + Item.mineralCount + Item.organicMatterCount);
                if (resource == Resource.seed)
                {
                    resources.AddItem(new Item(resource, seedMax * random.NextDouble()));
                }
            }
        }
    }

    // 행성 타입
    public enum PlanetType
    {
        earth,
        jupiter
    }
}