using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Group : GraphicPrimitive
    {
        private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

        public Group(int x, int y) : base(x, y) { }

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing Group at ({X}, {Y})");
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }

        public override void Move(int x, int y)
        {
            X += x;
            Y += y;
            foreach (var primitive in primitives)
            {
                primitive.Move(x, y);
            }
        }

        public void Scale(float factor)
        {
            foreach (var primitive in primitives)
            {
                if (primitive is Circle circle)
                {
                    circle.Scale(factor);
                }
                else if (primitive is Rectangle rectangle)
                {
                    rectangle.Scale(factor);
                }
                else if (primitive is Triangle triangle)
                {
                    triangle.Scale(factor);
                }
                else if (primitive is Group group)
                {
                    group.Scale(factor);
                }
            }
        }
    }
}
