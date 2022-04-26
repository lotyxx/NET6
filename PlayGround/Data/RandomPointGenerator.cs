using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayGround.Model;


namespace PlayGround.Data
{
    internal class RandomPointGenerator
    {
        private static int Counter = 0;
        public static int GetCount()
        {
            return Counter;
        }
        public static ClassBod GetRandomPoint()
        {
            Counter++;
            Random random = new Random();
            double x = random.Next(int.MinValue, int.MaxValue);
            double y = random.Next(int.MinValue, int.MaxValue);
            ClassBod result = new ClassBod(x, y);
            return result;
        }
    }
}
