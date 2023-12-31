﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Matrix4x4
    {
        public double M11 { get; }
        public double M12 { get; }
        public double M13 { get; }
        public double M14 { get; }
        public double M21 { get; }
        public double M22 { get; }
        public double M23 { get; }
        public double M24 { get; }
        public double M31 { get; }
        public double M32 { get; }
        public double M33 { get; }
        public double M34 { get; }
        public double M41 { get; }
        public double M42 { get; }
        public double M43 { get; }
        public double M44 { get; }

        public Matrix4x4(
            double m11, double m12, double m13, double m14,
            double m21, double m22, double m23, double m24,
            double m31, double m32, double m33, double m34,
            double m41, double m42, double m43, double m44)
        {
            M11 = m11;
            M12 = m12;
            M13 = m13;
            M14 = m14;
            M21 = m21;
            M22 = m22;
            M23 = m23;
            M24 = m24;
            M31 = m31;
            M32 = m32;
            M33 = m33;
            M34 = m34;
            M41 = m41;
            M42 = m42;
            M43 = m43;
            M44 = m44;
        }
    }
}
