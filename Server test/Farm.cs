using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    class Farm
    {
        public double day1, day2, day3; // 1, 2, 3일차에 있는 씨앗 개수들
        public double food = 0;
        public double water = 0;

        public Farm(double day1, double day2, double day3)
        {
            this.day1 = day1;
            this.day2 = day2;
            this.day3 = day3;
        }

        public double Water(double water)
        {
            this.water = water;
            if (day3 <= water)
            {
                water -= day3;
                food += day3;
                day3 = 0;
            }

            else if (day2 <= water)
            {
                water -= day2;
                day3 += day2;
                day2 = 0;
            }

            else if (day1 <= water)
            {
                water -= day1;
                day2 += day1;
                day1 = 0;
            }

            else
            {
                day1 -= water;
                day2 += water;
                return 0;
            }
            this.water = water;
            return water;
        }

        public double ReturnFood()
        {
            return food;
        }
    }
}
