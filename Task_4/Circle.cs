using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Circle: GraphicPrimitive
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius) : base(x, y)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw circle at ({X}, {Y}) with radius {Radius}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void Scale(float factor)
        {
            Radius = (int)(Radius * factor);
        }
    }
}
