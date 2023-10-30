using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Rectangle: GraphicPrimitive
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int width, int height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Draw rectangle at ({X}, {Y}) with width {Width} and height {Height}");
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
        }

        public void Scale(float factor)
        {
            Width = (int)(Width * factor);
            Height = (int)(Height * factor);
        }
    }
}
