using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public abstract class GraphicPrimitive
    {
        public int X { get; set; }
        public int Y { get; set; }

        public GraphicPrimitive(int x, int y)
        {
            X = x;
            Y = y;
        }

        public abstract void Draw();
        public abstract void Move(int x, int y);

    }
}
