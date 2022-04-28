//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PlayGround.Model
//{


//    internal class ClassBod
//    {
//        public ClassBod(double _x, double _y)
//        {
//            X = _x;
//            Y = _y;
//        }

//        public ClassBod()
//        {

//        }
//        public double X { get; set; }
//        public double Y { get; set; }



//        public override string ToString()
//        {
//            return $"x: {X} y: {Y}";
//        }
//        public void Print()
//        {
//            Console.WriteLine($"x : {X} y: {Y}");
//            Console.WriteLine(CalculateArea());
//        }

//        public double CalculateArea()
//        {
//            double obsah = Math.Abs(X) * Math.Abs(Y);

//            return obsah;
//        }

//        public Quadrant GetQuadrant()
//        {
//            if (X >= 0 && Y == 0)
//                return Quadrant.Origin;
//            if (X >= 0 && Y >= 0)
//                return Quadrant.Quadrant1;
//            else if (X < 0 && Y >= 0)
//                return Quadrant.Quadrant2;
//            else if (X < 0 && Y < 0)
//                return Quadrant.Quadrant3;
//            else if (X >= 0 && Y < 0)
//                return Quadrant.Quadrant4;
//            else
//                return Quadrant.Error;
//        }
        

//    }
//}
