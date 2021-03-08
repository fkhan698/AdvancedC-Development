using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3EX1B4.Exercise_2
{
    public class Shape : IHeight, IWidth, ISideLength
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int SideLength { get; set; }

        public int Area()
        {
            int area = 0;
            if (Height == 0 && Width == 0)
            {
                area = SideLength * SideLength;
                return area;
            }
            else if (SideLength == 0)
            {
                area = Height * Width;
                return area;
            }
            return area;
        }
    }
}
