using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 은하 클래스
    class Galaxy
    {
        List<PlanetSystem> systems;
        Vector2 location;

        // TODO: 생성자 만들기
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