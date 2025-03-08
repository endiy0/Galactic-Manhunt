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
        double day1, day2, day3;        // 1,2,3 일차에 있는 씨앗 개수들

        double tmp1, tmp2, tmp3;

        public double food = 0;
        public Farm(double day)
        {

        }

        public double Water(double water)
        {
            if(day3 <= water)
            {
                water -= day3;
                food += day3;
                day3 = 0;
            }

            else if(day2 <= water)
            {
                water -= day2;
                day3 += day2;
                day2 = 0;
            }
            
            else if(day1 <= water)
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
            return water;
        }

    }
}
