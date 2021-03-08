using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3EX1B4.Exercise_2
{
    public class Program {

        static void Main(string[] args)
        {

        }

    }
    public class AreaCalc
    {
        public static int CalculateRectArea(Rectangle r)
        {
            return r.Height * r.Width;
        }

        public static int CalculateSquareArea(Square s)
        {
            return s.Height * s.Width;
        }
    }
}
