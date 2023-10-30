using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Triangle : GraphicPrimitive
    {
        public int SideLength { get; set; }

        public Triangle(int x, int y, int sideLength) : base(x, y)
        {
            SideLength = sideLength;
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw triangle at ({X}, {Y}) with side length {SideLength}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void Scale(float factor)
        {
            SideLength = (int)(SideLength * factor);
        }
    }
}
