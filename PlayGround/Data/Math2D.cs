using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayGround.Model;

namespace PlayGround.Data
{
    internal class Math2D
    {
        public static ClassBod MaxAreaFromOrigin(ClassBod point1,ClassBod point2)
        {
            if (point1.CalculateArea() >= point2.CalculateArea())
                return point1;
            else
                return point2;

        }
    }
}
