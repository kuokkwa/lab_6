using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Route
    {
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }

        public Route(string startPoint, string endPoint)
        {
            StartPoint = startPoint;
            EndPoint = endPoint;
        }
    }
}
