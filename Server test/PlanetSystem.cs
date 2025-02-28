using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    // 행성계 클래스
    class PlanetSystem
    {
        List<Planet> planets;
        Vector2 location;
        public Store store;
        // TODO: 생성자 만들기
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