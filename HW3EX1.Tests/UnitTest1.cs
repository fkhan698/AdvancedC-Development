using HW3EX1B4.Exercise_2;
using HW3EX1B4.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HW3EX1.Tests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TwentyFor4X5ShapeFromRectangle()
        {
            Shape myShape = new Rectangle() { Height = 4, Width = 5 };
            Assert.AreEqual(20, myShape.Area());
        }

        [TestMethod]
        public void TwentyFor4X5ShapeFromRectangleAnd9For3X3Square()
        {
            var shapes = new List<Shape>
                             {
                                 new Rectangle {Height = 4, Width = 5},
                                 new Square {SideLength = 3}
                             };
            var areas = new List<int>();
            foreach (Shape shape in shapes)
            {
                areas.Add(shape.Area());
            }
            Assert.AreEqual(20, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }


    }
}
