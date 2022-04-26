using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayGround.Model
{
    internal class ClassBod
    {
        public ClassBod(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }

        public ClassBod()
        {

        }
        public double X { get; set; }
        public double Y { get; set; }

        public void Print()
        {
            Console.WriteLine($"x : {X} y: {Y}");
        }

        public double VypocetObdelnika()
        {
            double  obsah = p1.X * p2.X;
            return obsah;

        }

    }
}
