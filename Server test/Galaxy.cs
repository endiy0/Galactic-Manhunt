using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 은하 클래스
    class Galaxy
    {
        List<PlanetSystem> systems;
        Vector2 location;

        public Galaxy(double xx, double yy) // Server 아직 구현 안된 곳에서 받아올것
        {
            location = new Vector2(xx, yy); // 현 은하계 위치
            Random rand = new Random(Convert.ToInt16(DateTime.Now.Ticks % 10000));
            int size = rand.Next(3, 8); // 현재 은하계의 항성계 개수
            
            for(int i = 0; i < size; i++)
            {
                while (true)
                {
                    bool cmp = true;
                    double x = location.x + rand.Next(-3, 3) + rand.NextDouble(); // 항성계 x축 위치
                    double y = location.y + rand.Next(-3, 3) + rand.NextDouble(); // 항성계 y축 위치
                    Vector2 Location = new Vector2(x, y);
                    foreach (PlanetSystem system in systems) // 좌표 중복 체크
                    {
                        if (system.Location == Location)
                        {
                            cmp = false;
                        }
                    }
                    if (cmp)
                    {
                        break; // cmp변화하면 중복이죠 아니면 그냥 ㄱㄱ
                    }
                }
                systems.Add(new PlanetSystem(Location));
            }
        }

        public List<PlanetSystem> Systems
        {
            get
            { return systems; }
        }

        public Vector2 Location
        {
            get
            { return location; }
        }

        public void AddSystems(PlanetSystem PS)
        {
            systems.Add(PS);
        }

        public void RemoveSystems(PlanetSystem PS)
        {
            systems.Remove(PS);
        }

        public void ClearSystems()
        {
            systems.Clear();
        }
    }
}