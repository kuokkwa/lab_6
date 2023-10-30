using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class MathOperations
    {
        public double X { get; set; }
        public double Y { get; set; }

        public MathOperations(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static MathOperations operator +(MathOperations a, MathOperations b)
        {
            return new MathOperations(x: a.X + b.X, y: a.Y + b.Y);
        }

        public static MathOperations operator -(MathOperations a, MathOperations b)
        {
            return new MathOperations(x: a.X - b.X, y: a.Y - b.Y);
        }

        public static MathOperations operator *(MathOperations a, MathOperations b)
        {
            return new MathOperations(x: a.X * b.X, y: a.Y * b.Y);
        }

        public static MathOperations operator /(MathOperations a, MathOperations b)
        {
            if (b.X == 0 || b.Y == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return new MathOperations(x: a.X / b.X, y: a.Y / b.Y);
        }
    }
}
