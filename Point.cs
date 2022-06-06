using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level_24___Catacombs_of_Class
{
    internal class Point
    {
        public float _x;
        public float _y;

        public Point(float x, float y)
        {
            this._x = x;
            this._y = y;
        }

        public static Point PointFactory(float x, float y) => new Point(x, y);
        public static Point ZeroPointFactory() => new Point(0f, 0f);

        public Point PointChange(float x, float y)
        {
            _x = x;
            _y = y;
            return this;
        }
    }
}
