using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 행성계 클래스
    public class PlanetSystem
    {
        public List<Planet> planets;
        public Vector2 location;
        public StoreServer store;
        
        public PlanetSystem(Vector2 L) // Galaxy class에서 받아올것
        {
            Random rand = new Random(Convert.ToInt16(DateTime.Now.Ticks % 10000));
            int size = rand.Next(3, 11); //  한 항성계 최대 행성
            const int MaxEarth = 4;      // 최대 지구형 행성 개수
            int EarthCount = 0;          // 지구형 행성 카운트

            location = L; // 항성계 위치

            for(int i = 0; i < size; i++) // planets List채우기
            {
                bool[,] visited = new bool[10001,10001];
                PlanetType type = (rand.Next(0, 2) == 1) ? PlanetType.Jupitor : PlanetType.Earth; // 1: 목성형, 0: 지구형
                if (type == PlanetType.Earth)      // 지구형 행성 최대 4개 검사
                {
                    if (EarthCount == MaxEarth)
                    {
                        type = PlanetType.Jupitor; // 최대 안넘게 목성형으로 교체
                    }
                    else
                    {
                        EarthCount++;
                    }
                }
                int x = rand.Next(-10000, 10000);
                int y = rand.Next(-10000, 10000);
                while (visited[x, y])
                {
                    x = rand.Next(-10000, 10000);
                    y = rand.Next(-10000, 10000);
                }
                visited[x,y] = true;
                planets.Add(new Planet(type,x,y)); // 행성 생성
            }
        }

        public List<Planet> Planets
        {
            get
            { return planets; }
        }

        public Vector2 Location
        {
            get
            { return location; }
        }

        public void AddPlanets(Planet P)
        {
            planets.Add(P);
        }

        public void RemovePlanets(Planet P)
        {
            planets.Remove(P);
        }

        public void ClearPlanets()
        {
            planets.Clear();
        }
    }
}