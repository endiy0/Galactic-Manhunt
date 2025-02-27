using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_test
{
    class Vector2
    {
        public double x;
        public double y;

        public Vector2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2 operator +(Vector2 vector, Vector2 vec)
        {
            return new Vector2(vec.x + vector.x, vec.y + vector.y);
        }

        public static Vector2 operator -(Vector2 vector, Vector2 vec)
        {
            return new Vector2(vector.x - vec.x, vector.y - vec.y);
        }
    }
}