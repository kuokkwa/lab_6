using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class GraphicsEditor
    {
        private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

        public void AddPrimitive(GraphicPrimitive primitive)
        {
            primitives.Add(primitive);
        }

        public void DrawAll()
        {
            Console.WriteLine("Drawing all primitives:");
            foreach (var primitive in primitives)
            {
                primitive.Draw();
            }
        }
    }
}
